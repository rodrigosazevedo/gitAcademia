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
    public partial class frmGerarVenda : Form
    {
        List<ItemVenda> itensVenda = new List<ItemVenda>();

        public frmGerarVenda()
        {
            InitializeComponent();

            this.txtVenda_Data.Text = DateTime.Today.ToString("dd/MM/yyyy");
            this.dgvItensVenda.DataSource = itensVenda;
        }

        private void txtVenda_NF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtItem_ValorUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtItem_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtItem_ValorUnit_TextChanged(object sender, EventArgs e)
        {
            if(txtItem_Quantidade.Text != "")
            {
                txtItem_ValorTotal.Text = (double.Parse(txtItem_ValorUnit.Text) * double.Parse(txtItem_Quantidade.Text)).ToString();
            }
            else
            {
                txtItem_ValorTotal.Clear();
            }
        }

        private void txtItem_Quantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtItem_ValorUnit.Text != "")
            {
                txtItem_ValorTotal.Text = (double.Parse(txtItem_ValorUnit.Text) * double.Parse(txtItem_Quantidade.Text)).ToString();
            }
            else
            {
                txtItem_ValorTotal.Clear();
            }
        }

        private void frmGerarVenda_Load(object sender, EventArgs e)
        {
            string conexao = ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(conexao);
            SqlDataAdapter sdaCliente = new SqlDataAdapter("SELECT CNPJ,RazaoSocial FROM cliente", cn);

            DataTable dtCliente = new DataTable();
            sdaCliente.Fill(dtCliente);

            cbxVenda_Cliente.DataSource = dtCliente;
            cbxVenda_Cliente.DisplayMember = "RazaoSocial";
            cbxVenda_Cliente.ValueMember = "CNPJ";
                        
            SqlDataAdapter sdaProduto = new SqlDataAdapter("SELECT Codigo,Descricao FROM produto", cn);

            DataTable dtProduto = new DataTable();
            sdaProduto.Fill(dtProduto);

            cbxItem_Produto.DataSource = dtProduto;
            cbxItem_Produto.DisplayMember = "Descricao";
            cbxItem_Produto.ValueMember = "Codigo";
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (txtItem_ValorTotal.Text == "")
            {
                MessageBox.Show("Os campos de preço e quantidade não podem estar vazios!","Erro: Campos Vazios");
                return;
            }
            else if (double.Parse(txtItem_Quantidade.Text) == 0)
            {
                MessageBox.Show("A quantidade vendida não pode ser 0!", "Erro: Quantidade Zerada");
                return;
            }

            string descricaoProduto = cbxItem_Produto.DisplayMember;
            string codigoProduto = txtItem_Codigo.Text;
            double valorUnit = double.Parse(txtItem_ValorUnit.Text);
            double quantidade = double.Parse(txtItem_Quantidade.Text);
            double valorTotal = double.Parse(txtItem_ValorTotal.Text);

            ItemVenda item = new ItemVenda(codigoProduto, descricaoProduto, valorUnit, quantidade, valorTotal);
            itensVenda.Add(item);

            dgvItensVenda.DataSource = null;
            dgvItensVenda.DataSource = itensVenda;

            btnConfirmarVenda.Enabled = true;
            MessageBox.Show("Item adicionado com sucesso.", "Novo item");
        }

        private void cbxVenda_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVenda_CNPJ.Text = cbxVenda_Cliente.ValueMember;

            txtVenda_NF.Enabled = true;
            cbxItem_Produto.Enabled = true;
        }

        private void cbxItem_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItem_Codigo.Text = cbxItem_Produto.ValueMember;

            txtItem_ValorUnit.Enabled = true;
            txtItem_ValorUnit.Clear();
            txtItem_Quantidade.Enabled = true;
            txtItem_Quantidade.Clear();
            txtItem_ValorTotal.Clear();

            btnAdicionarItem.Enabled = true;            
        }

        private void btnLimparVenda_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.InitializeComponent();
            //cbxVenda_Cliente.ResetText();
            //txtVenda_CNPJ.Clear();
            //txtVenda_NF.Clear();
            //txtVenda_ValorTotal.Clear();
            //cbxItem_Produto.ResetText();
            //txtItem_Codigo.Clear();
            //txtItem_ValorUnit.Clear();
            //txtItem_Quantidade.Clear();
            //txtItem_ValorTotal.Clear();

            //txtVenda_NF.Enabled = false;
            //cbxItem_Produto.Enabled = false;
            //txtItem_ValorUnit.Enabled = false;
            //txtItem_Quantidade.Enabled = false;

            //itensVenda.Clear();
            //dgvItensVenda.DataSource = null;
            //dgvItensVenda.DataSource = itensVenda;

            //btnAdicionarItem.Enabled = false;
            //btnConfirmarVenda.Enabled = false;

        }

        private void btnConfirmarVenda_Click(object sender, EventArgs e)
        {
            if (!itensVenda.Any())
            {
                MessageBox.Show("Adicione pelo menos um produto na venda!", "Erro: Sem itens");
                return;
            }
            else if (txtVenda_NF.Text == "")
            {
                MessageBox.Show("Digite o número da nota fiscal", "Erro: Sem NF");
                return;
            }

            string razaoCliente = cbxVenda_Cliente.DisplayMember;
            int cnpjCliente = int.Parse(txtVenda_CNPJ.Text);
            int numeroNF = int.Parse(txtVenda_NF.Text);
            double valorTotal = double.Parse(txtVenda_ValorTotal.Text);
            DateTime dataVenda = DateTime.Parse(txtVenda_Data.Text);

            foreach (ItemVenda itemVenda in itensVenda)
            {
                itemVenda.NumeroNF = numeroNF;
            }

            Venda venda = new Venda(numeroNF, cnpjCliente, razaoCliente, valorTotal, dataVenda);

            venda.SalvarDados();
            ItemVenda.SalvarDados(itensVenda);

            MessageBox.Show("Venda registrada com sucesso!");
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
