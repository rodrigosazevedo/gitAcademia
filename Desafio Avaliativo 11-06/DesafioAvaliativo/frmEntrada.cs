using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioAvaliativo
{
    public partial class frmEntrada : Form
    {

        frmGaragem formularioPrincipal = (frmGaragem)Application.OpenForms["frmGaragem"];

        public frmEntrada()
        {
            InitializeComponent();
            this.txtDataEntrada.Text = DateTime.Today.ToString("dd/MM/yyyy");

        }

        private void btnLimparEntrada_Click(object sender, EventArgs e)
        {
            this.txtPlacaEntrada.Clear();
            this.dtpHoraEntrada.ResetText();
        }

        private void btnConfirmarEntrada_Click(object sender, EventArgs e)
        {
            if (txtPlacaEntrada.Text == "" || txtPlacaEntrada.Text == null)
            {
                MessageBox.Show("Digite a placa do veículo!", "Erro");
                txtPlacaEntrada.Focus();
                return;
            }

            String placaInformada = (txtPlacaEntrada.Text).Replace("-", "");
            DateTime dataCorrente = DateTime.Parse(txtDataEntrada.Text);
            TimeSpan horaInformada = dtpHoraEntrada.Value.TimeOfDay;

            if (formularioPrincipal.ValidaDados(placaInformada, dataCorrente, horaInformada))
            {
                formularioPrincipal.OperacaoEntrada(placaInformada, dataCorrente, horaInformada);
            }
            else
            {
                return;
            }

        }
    }
}
