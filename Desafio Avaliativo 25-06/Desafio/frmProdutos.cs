using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            txtProduto_Codigo.Clear();
            txtProduto_Descricao.Clear();
            txtProduto_Unidade.Clear();
            txtProduto_RazaoSocial.Clear();
            txtProduto_CNPJ.Clear();    
            txtProduto_Custo.Clear();   
        }

        private void btnConfirmarProduto_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(txt => String.IsNullOrWhiteSpace(txt.Text)) ||
               this.Controls.OfType<MaskedTextBox>().Any(mtxt => String.IsNullOrWhiteSpace(mtxt.Text)))
            {
                MessageBox.Show("Por favor preencher todas as informações do produto.");
                return;
            }

            string codigo = txtProduto_Codigo.Text;
            string descricao = txtProduto_Descricao.Text;
            string unidade = txtProduto_Unidade.Text;
            string razaosocial = txtProduto_RazaoSocial.Text;
            int cnpj = int.Parse(txtProduto_CNPJ.Text);
            double custo = double.Parse(txtProduto_Custo.Text);

            Produto produto = new Produto(codigo,descricao,unidade,razaosocial,cnpj,custo);
            produto.SalvarDados();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void txtProduto_Unidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
