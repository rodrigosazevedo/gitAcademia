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
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Desafio
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            Atualizar_DGV();
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        { 
            // Limpa todos os campos do formulário, reseta os campos e coloca o foco no campo de Razão Social.

            txtCliente_RazaoSocial.Clear();
            txtCliente_CNPJ.Clear();
            txtCliente_Email.Clear();
            txtCliente_Telefone.Clear();
            txtCliente_Endereco.Clear();
            txtCliente_Bairro.Clear();
            txtCliente_CEP.Clear();
            txtCliente_Cidade.Clear();
            cbxCliente_UF.ResetText();

            txtCliente_RazaoSocial.Focus();
        }

        private void btnConfirmarCliente_Click(object sender, EventArgs e)
        {

            // Roda o método Validar_Campos para verificar se todos os campos estão preenchidos corretamente.
            if (Validar_Campos() == false) return;

            string razaosocial = txtCliente_RazaoSocial.Text;
            long cnpj = long.Parse(txtCliente_CNPJ.Text);
            string email = txtCliente_Email.Text;
            long telefone = long.Parse(txtCliente_Telefone.Text);
            string endereco = txtCliente_Endereco.Text;
            string bairro = txtCliente_Bairro.Text;
            int cep = int.Parse(txtCliente_CEP.Text);
            string cidade = txtCliente_Cidade.Text;
            string uf = cbxCliente_UF.SelectedItem.ToString();

            // Cria o objeto Cliente com as informações do formulário e roda o método SalvarDados() para 
            // dar insert no banco de dados. Após isso, roda o método de atualizar os dados do DGV e limpa
            // os controles
            Cliente cliente = new Cliente(razaosocial, cnpj, email, telefone, endereco, bairro, cep, cidade, uf);
            cliente.SalvarDados();
            Atualizar_DGV();
            this.Controls.Clear();
            this.InitializeComponent();

            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void txtCliente_Telefone_TextChanged(object sender, EventArgs e)
        {
            // Altera a máscara do campo Telefone se o 3ª dígito for um 9 (depois do DDD)
            if(txtCliente_Telefone.Text.Length >= 3)
            {
                if ("9".Equals(txtCliente_Telefone.Text.Substring(2, 1)))
                {
                    txtCliente_Telefone.Mask = "(99)99999-9999";
                }
                else
                {
                    txtCliente_Telefone.Mask = "(99)9999-9999";
                }
            }
        }

        private void txtCliente_Bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Não permite números no campo Bairro
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtCliente_Cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Não permite números no campo Cidade
            e.Handled = char.IsDigit(e.KeyChar);
        }

        /// Método que faz um select de todos os registros na tabela cliente do banco de dados e passa
        /// eles para o DataGridView do formulário.
        public void Atualizar_DGV()
        {
            string conexao = ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(conexao);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM cliente", cn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvClientes.DataSource = dt;
        }

        /// Método para validar se todos os campos do formulário estão de acordo com o esperado
        public bool Validar_Campos()
        {
            // Verifica se algum dos campos está vazio, e mostra erro se tiver.
            if (txtCliente_RazaoSocial.Text == "" || txtCliente_CNPJ.Text == "" || txtCliente_Email.Text == "" ||
                txtCliente_Telefone.Text == "" || txtCliente_Endereco.Text == "" || txtCliente_Bairro.Text == "" ||
                txtCliente_CEP.Text == "" || txtCliente_Cidade.Text == "" || cbxCliente_UF.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor preencher todas as informações do cliente.");
                return false;
            }

            // Tenta passar o e-mail informado para um objeto tipo MailAddress, o que verifica se é válido
            try
            {
                MailAddress Teste_Email = new MailAddress(txtCliente_Email.Text);
            }
            catch
            {
                MessageBox.Show("E-mail inválido!");
                txtCliente_Email.Focus();
                return false;
            }

            // Verifica se o CNPJ informado tem menos de 14 dígitos e retorna erro se sim
            if (txtCliente_CNPJ.Text.Trim().Length < 14)
            {
                MessageBox.Show("CPNJ inválido!", "Erro: CNPJ");
                return false;
            }

            // Verifica se o Telefone informado tem menos de 10 dígitos e retorna erro se sim.
            if (txtCliente_Telefone.Text.Trim().Length < 10)
            {
                MessageBox.Show("Telefone inválido!", "Erro: Telefone");
                return false;
            }

            // Verifica se o CEP informado tem menos de 8 dígitos e retorna erro se sim.
            if (txtCliente_CEP.Text.Trim().Length < 8)
            {
                MessageBox.Show("CEP inválido!", "Erro: CEP");
                return false;
            }

            return true;
        }
    }
}
