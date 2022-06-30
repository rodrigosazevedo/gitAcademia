using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioAvaliativo
{
    public partial class frmGaragem : Form
    {
        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listaSaida = new List<Veiculo>();
        public frmGaragem()
        {
            InitializeComponent();
            
            Persistencia.lerArquivoVeiculosEntrada(listaEntrada);
            Persistencia.lerArquivoVeiculosSaida(listaSaida);

            Alimentar_DGVs();

            this.txtDataCorrente.Text = DateTime.Today.ToString("dd/MM/yyyy");            
        }

        private void Timer1000ms_Tick(object sender, EventArgs e)
        {
            this.lblDataHora.Text = DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM") +
            " de " + DateTime.Now.ToString("yyyy") + ", " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String placaInformada = (txtPlaca.Text).Replace("-","");
            DateTime dataCorrente = DateTime.Parse(txtDataCorrente.Text);
            TimeSpan horaInformada = dtpHora.Value.TimeOfDay;            

            if(placaInformada.Length == 7)
            {
                if (char.IsLetter(txtPlaca.Text[4]))
                {
                    Regex padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
                    if (!padraoMercosul.IsMatch(placaInformada))
                    {
                        MessageBox.Show("Placa fora do padrão", "Placa inválida!");
                        txtPlaca.Focus();
                        return;
                    }
                }
                else
                {
                    Regex padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");
                    if (!padraoNormal.IsMatch(placaInformada))
                    {
                        MessageBox.Show("Placa fora do padrão", "Placa inválida!");
                        txtPlaca.Focus();
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Placa deve ter 7 dígitos.","Placa inválida!");
                txtPlaca.Focus();
                return;
            }

            TimeSpan horaAbertura = new TimeSpan(7, 0, 0);
            TimeSpan horaFechamento = new TimeSpan(20, 0, 0);

            if(horaInformada < horaAbertura || horaInformada > horaFechamento)
            {
                MessageBox.Show("Hora informada fora do horário de funcionamento.", "Hora inválida!");
                dtpHora.Focus();
                return;
            }

            if (this.rbEntrada.Checked)
            {
                if (Veiculo.jaCadastrado(placaInformada, listaEntrada))
                {
                    MessageBox.Show("Veículo já está na garagem.", "Placa inválida!");
                    txtPlaca.Focus();
                    return;
                }

                listaEntrada.Add(new Veiculo(placaInformada, dataCorrente, horaInformada));
                MessageBox.Show("Entrada do veículo " + placaInformada + " registrada.", "Operação concluída!");

                Persistencia.gravarArquivoVeiculosEntrada(listaEntrada);
                dgvListaGaragem.DataSource = listaEntrada;
                Limpar();
            }
            else if (this.rbSaida.Checked)
            {
                if (listaEntrada.Any(Veiculo => Veiculo.PlacaVeiculo == placaInformada))
                {
                    listaSaida.AddRange(listaEntrada.Where(Veiculo => Veiculo.PlacaVeiculo == placaInformada));
                    listaEntrada.RemoveAll(Veiculo => Veiculo.PlacaVeiculo == placaInformada);

                    listaSaida.Last().DataSaida = dataCorrente;
                    listaSaida.Last().HoraSaida = horaInformada;
                    listaSaida.Last().TempoPermanencia = horaInformada.Subtract((listaSaida.Last().HoraEntrada)).Minutes;
                    listaSaida.Last().ValorCobrado = 5.00 + ((horaInformada.Subtract((listaSaida.Last().HoraEntrada)).Minutes / 60) * 5.00);

                    MessageBox.Show("Registrada a saída do veículo " + placaInformada + "\nTempo de Permanência: " +
                                    listaSaida.Last().TempoPermanencia + " min Valor cobrado: R$ " + listaSaida.Last().ValorCobrado + ",00");

                    Persistencia.gravarArquivoVeiculosEntrada(listaEntrada);
                    Persistencia.gravarArquivoVeiculosSaida(listaSaida);
                    dgvListaGaragem.DataSource = listaEntrada;
                    dgvListaSaida.DataSource = listaSaida;
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Veículo informado não está na garagem.", "Erro na operação!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Informe se é uma entrada ou saída.", "Sem operação!");
                return;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            this.txtPlaca.Clear();
            this.dtpHora.ResetText();
            this.rbEntrada.Checked = false;
            this.rbSaida.Checked = false;
        }
        public void Alimentar_DGVs()
        {
            this.dgvListaGaragem.DataSource = listaEntrada;
            this.dgvListaGaragem.AutoGenerateColumns = false;
            this.dgvListaGaragem.Columns.RemoveAt(6);
            this.dgvListaGaragem.Columns.RemoveAt(5);
            this.dgvListaGaragem.Columns.RemoveAt(4);
            this.dgvListaGaragem.Columns.RemoveAt(3);
            this.dgvListaGaragem.Columns[0].HeaderText = "Placa";
            this.dgvListaGaragem.Columns[1].HeaderText = "Data_Entrada";
            this.dgvListaGaragem.Columns[2].HeaderText = "Hora_Entrada";

            this.dgvListaSaida.DataSource = listaSaida;
            this.dgvListaSaida.AutoGenerateColumns = false;
            this.dgvListaSaida.Columns.RemoveAt(6);
            this.dgvListaSaida.Columns.RemoveAt(5);
            this.dgvListaSaida.Columns.RemoveAt(2);
            this.dgvListaSaida.Columns.RemoveAt(1);
            this.dgvListaSaida.Columns[0].HeaderText = "Placa";
            this.dgvListaSaida.Columns[1].HeaderText = "Tempo_Permanência";
            this.dgvListaSaida.Columns[2].HeaderText = "Valor_Cobrado";
        }

        private void dgvListaGaragem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtPlaca.Text = dgvListaGaragem.CurrentCell.Value.ToString();
        }
    }
}
