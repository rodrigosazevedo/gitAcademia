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
    public partial class frmSaida : Form
    {
        frmGaragem formularioPrincipal = (frmGaragem)Application.OpenForms["frmGaragem"];
        public frmSaida()
        {
            InitializeComponent();
            this.txtDataSaida.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnLimparSaida_Click(object sender, EventArgs e)
        {
            txtDataSaida.Clear();
            dtpHoraSaida.ResetText();
        }

        private void btnConfirmarSaida_Click(object sender, EventArgs e)
        {
            if (cbxPlacaSaida.SelectedItem == null)
            {
                MessageBox.Show("Escolha uma placa!", "Erro");
                cbxPlacaSaida.Focus();
                return;
            }

            String placaInformada = cbxPlacaSaida.SelectedItem.ToString();
            DateTime dataCorrente = DateTime.Parse(txtDataSaida.Text);
            TimeSpan horaInformada = dtpHoraSaida.Value.TimeOfDay;

            if (formularioPrincipal.ValidaDados(placaInformada, dataCorrente, horaInformada))
            {
                formularioPrincipal.OperacaoSaida(placaInformada, dataCorrente, horaInformada);
            }
            else
            {
                return;
            }

        }
    }
}
