using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Desafio
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            txtCliente_RazaoSocial.Clear();
            txtCliente_CNPJ.Clear();
            txtCliente_Email.Clear();
            txtCliente_Telefone.Clear();
            txtCliente_Endereco.Clear();
            txtCliente_Bairro.Clear();
            txtCliente_CEP.Clear();
            txtCliente_Cidade.Clear();
            cbxCliente_UF.ResetText();
        }

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(txt => String.IsNullOrWhiteSpace(txt.Text)) ||
               this.Controls.OfType<MaskedTextBox>().Any(mtxt => String.IsNullOrWhiteSpace(mtxt.Text)) ||
               cbxCliente_UF.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor preencher todas as informações do cliente.");
                return;
            }

            string razaosocial = txtCliente_RazaoSocial.Text;
            int cnpj = int.Parse(txtCliente_CNPJ.Text);
            string email = txtCliente_Email.Text;
            int telefone = int.Parse(txtCliente_Telefone.Text);
            string endereco = txtCliente_Endereco.Text;
            string bairro = txtCliente_Bairro.Text;
            int cep = int.Parse(txtCliente_CEP.Text);
            string cidade = txtCliente_Cidade.Text;
            string uf = cbxCliente_UF.SelectedItem.ToString();


            Cliente cliente = new Cliente(razaosocial, cnpj, email, telefone, endereco, bairro, cep, cidade, uf);
            cliente.SalvarDados();

            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void txtCliente_Telefone_TextChanged(object sender, EventArgs e)
        {
            if ("9".Equals(txtCliente_Telefone.Text.Substring(4, 1)))
            {
                txtCliente_Telefone.Mask = "(99)99999-9999";
            }
            else
            {
                txtCliente_Telefone.Mask = "(99)9999-9999";
            }
        }

        private void txtCliente_Bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtCliente_Cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtCliente_Email_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                var email = new MailAddress(txtCliente_Email.Text);
            }
            catch
            {
                MessageBox.Show("E-mail inválido!");
                txtCliente_Email.Focus();
            }
        }
    }
}
