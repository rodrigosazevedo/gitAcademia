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
            
            // Chama o método de leitura de arquivos da classe Persistencia para popular as listas
            // utilizadas pelo programa.
            Persistencia.lerArquivoVeiculosEntrada(listaEntrada);
            Persistencia.lerArquivoVeiculosSaida(listaSaida);

            // Alimenta as duas DataGridViews com o conteúdo das listas depois de populadas e faz o 
            // tratamento das colunas.
            Alimentar_DGVs();

            this.txtDataCorrente.Text = DateTime.Today.ToString("dd/MM/yyyy");            
        }

        /// Método para alterar o valor da label que informa a data e hora para o usuário,
        /// atualizando-o a cada 1000ms.
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

            // Checa se a placa tem 7 dígitos e exibe erro caso não tenha
            if(placaInformada.Length == 7)
            {
                // Primeiro caso: 5º digito da placa informada é uma letra, o que significa que está
                // no padrão novo.
                if (char.IsLetter(txtPlaca.Text[4]))
                {
                    // Usa Regex para verificar se realmente se encaixa no padrão novo
                    Regex padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
                    if (!padraoMercosul.IsMatch(placaInformada))
                    {
                        MessageBox.Show("Placa fora do padrão", "Placa inválida!");
                        txtPlaca.Focus();
                        return;
                    }
                }
                // Segundo caso: 5º dígito não é uma letra, então a placa está no padrão antigo.
                else
                {
                    // Usa Regex para verificar se realmente se encaixa no padrão antigo
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

            // Verifica se a hora informada pelo usuário está dentro do horário de funcionamento
            // da garagem (7:00 as 20:00), utilizando as duas variáveis TimeSpan definidas acima
            if(horaInformada < horaAbertura || horaInformada > horaFechamento)
            {
                MessageBox.Show("Hora informada fora do horário de funcionamento.", "Hora inválida!");
                dtpHora.Focus();
                return;
            }

            // Se o usuário tiver marcado que é uma operação de entrada
            if (this.rbEntrada.Checked)
            {
                // Chama o método jaCadastrado para exibir erro caso a placa já esteja na lista
                // de entrada (ou seja, o carro ainda está na garagem)
                if (Veiculo.jaCadastrado(placaInformada, listaEntrada))
                {
                    MessageBox.Show("Veículo já está na garagem.", "Placa inválida!");
                    txtPlaca.Focus();
                    return;
                }

                // Cria o objeto (veículo), adiciona na lista e grava no arquivo.                
                listaEntrada.Add(new Veiculo(placaInformada, dataCorrente, horaInformada));
                MessageBox.Show("Entrada do veículo " + placaInformada + " registrada.", "Operação concluída!");

                Persistencia.gravarArquivoVeiculosEntrada(listaEntrada);

                // Altera a fonte do DataGridView para nulo e depois novamente para a lista, afim de
                // atualizá-lo. Em seguida, limpa todos os campos do formulário.
                dgvListaGaragem.DataSource = null;
                dgvListaGaragem.DataSource = listaEntrada;
                Limpar();
            }
            // Se o usuário tiver marcado que é uma operação de saída
            else if (this.rbSaida.Checked)
            {
                // Verifica se aquela placa realmente está na garagem, ou seja, se está na
                // lista de entrada. Caso não esteja, exibe erro.
                if (listaEntrada.Any(Veiculo => Veiculo.PlacaVeiculo == placaInformada))
                {
                    // Copia as informações do objeto com aquela placa na lista de entrada para
                    // a lista de saída e remove o objeto da lista de entrada.
                    listaSaida.AddRange(listaEntrada.Where(Veiculo => Veiculo.PlacaVeiculo == placaInformada));
                    listaEntrada.RemoveAll(Veiculo => Veiculo.PlacaVeiculo == placaInformada);

                    listaSaida.Last().DataSaida = dataCorrente;
                    listaSaida.Last().HoraSaida = horaInformada;

                    // Calcula a diferença entre a hora que o veículo está saindo e a hora que ele
                    // entrou na garagem em minutos (arredondados)
                    int tempoPermanencia = (int)Math.Round(horaInformada.Subtract((listaSaida.Last().HoraEntrada)).TotalMinutes);
                    listaSaida.Last().TempoPermanencia = tempoPermanencia;

                    // Calcula qual é o valor à ser cobrado, dividindo o tempo de permanência por 60
                    // e multiplicando pelo valor da hora, mas adicionando 5 já que o arredondamento
                    // acontece para baixo e a pessoa pode ficar menos de uma hora.
                    listaSaida.Last().ValorCobrado = 5.00 + ((tempoPermanencia / 60) * 5.00);

                    MessageBox.Show("Registrada a saída do veículo " + placaInformada + "\nTempo de Permanência: " +
                                    listaSaida.Last().TempoPermanencia + " min Valor cobrado: R$ " + listaSaida.Last().ValorCobrado + ",00");

                    // Atualiza os arquivos novamente a partir das listas e usa á mesma lógica usada
                    // anteriormente para atualizar os DataGridViews
                    Persistencia.gravarArquivoVeiculosEntrada(listaEntrada);
                    Persistencia.gravarArquivoVeiculosSaida(listaSaida);
                    dgvListaGaragem.DataSource = null;
                    dgvListaGaragem.DataSource = listaEntrada;
                    dgvListaSaida.DataSource = null;
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

        /// Método para limpar os campos do formulário
        public void Limpar()
        {
            this.txtPlaca.Clear();
            this.dtpHora.ResetText();
            this.rbEntrada.Checked = false;
            this.rbSaida.Checked = false;
        }

        /// Método que seleciona a fonte dos dados para os DataGridViews (que serão as listas)
        /// e seleciona somente algumas colunas para serem exibidas nele. Só precisa ser rodado
        /// uma vez, ao abrir o programa.
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

        /// Método que coloca o valor de uma placa selecionada no DataGridView para a textbox
        /// da placa, para que o usuário não precise digitar.
        private void dgvListaGaragem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtPlaca.Text = dgvListaGaragem.CurrentCell.Value.ToString();
        }
    }
}
