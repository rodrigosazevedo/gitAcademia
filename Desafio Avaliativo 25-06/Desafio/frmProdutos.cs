using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Desafio
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
            Atualizar_DGV();
        }

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            // Limpa todos os campos do formulário e reseta os campos 

            txtProduto_Codigo.Clear();
            txtProduto_Descricao.Clear();
            txtProduto_Unidade.Clear();
            txtProduto_RazaoSocial.Clear();
            txtProduto_CNPJ.Clear();    
            txtProduto_Custo.Clear();   
        }

        private void btnConfirmarProduto_Click(object sender, EventArgs e)
        {
            // Roda o método Validar_Campos para verificar se todos os campos estão preenchidos corretamente.
            if (Validar_Campos() == false) return;

            string codigo = txtProduto_Codigo.Text;
            string descricao = txtProduto_Descricao.Text;
            string unidade = txtProduto_Unidade.Text;
            string razaosocial = txtProduto_RazaoSocial.Text;
            long cnpj = long.Parse(txtProduto_CNPJ.Text);
            double custo = double.Parse(txtProduto_Custo.Text);

            // Cria o objeto Produto com as informações do formulário e roda o método SalvarDados() para 
            // dar insert no banco de dados. Após isso, roda o método de atualizar os dados do DGV e limpa
            // os controles
            Produto produto = new Produto(codigo,descricao,unidade,razaosocial,cnpj,custo);
            produto.SalvarDados();
            Atualizar_DGV();
            this.Controls.Clear();
            this.InitializeComponent();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void txtProduto_Unidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Só permite letras no campo Unidade
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        /// Método que faz um select de todos os registros na tabela produto do banco de dados e passa
        /// eles para o DataGridView do formulário.
        public void Atualizar_DGV()
        {
            string conexao = ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(conexao);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM produto", cn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvProdutos.DataSource = dt;
        }

        /// Método para validar se todos os campos do formulário estão de acordo com o esperado
        public bool Validar_Campos()
        {
            // Verifica se algum dos campos está vazio, e mostra erro se tiver.
            if (txtProduto_Codigo.Text == "" || txtProduto_Descricao.Text == "" || txtProduto_Unidade.Text == "")
            {
                MessageBox.Show("Por favor preencher todas as informações do produto.");
                return false;
            }

            // Verifica se o CNPJ informado tem menos de 14 dígitos e retorna erro se sim
            if (txtProduto_CNPJ.Text.Trim().Length < 14)
            {
                MessageBox.Show("CPNJ inválido!", "Erro: CNPJ");
                return false;
            }

            return true;
        }
    }
}
