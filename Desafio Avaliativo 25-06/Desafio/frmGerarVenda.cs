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
        // Lista utilizada para aramzenar todos os itens daquela venda e exibí-los no DGV
        List<ItemVenda> itensVenda = new List<ItemVenda>();

        public frmGerarVenda()
        {
            InitializeComponent();
            Popular_ComboBoxes();

            this.txtVenda_Data.Text = DateTime.Today.ToString("dd/MM/yyyy");
            this.dgvItensVenda.DataSource = itensVenda;
            this.txtVenda_ValorTotal.Text = 0.ToString();
        }

        private void txtVenda_NF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Só permite números no campo NumeroNF
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void txtItem_ValorUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Não permite letras no campo ValorUnit
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void txtItem_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Não permite letras no campo Quantidade
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void txtItem_ValorUnit_TextChanged(object sender, EventArgs e)
        {
            // Quando o campo ValorUnit é alterado, checa a quantidade para calcular e alterar o campo ValorTotal
            if (txtItem_Quantidade.Text != "")
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
            // Quando o campo Quantidade é alterado, checa o valor para calcular e alterar o campo ValorTotal
            if (txtItem_ValorUnit.Text != "")
            {
                txtItem_ValorTotal.Text = (double.Parse(txtItem_ValorUnit.Text) * double.Parse(txtItem_Quantidade.Text)).ToString();
            }
            else
            {
                txtItem_ValorTotal.Clear();
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            // Valida se algum campo está vazio
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

            string descricaoProduto = cbxItem_Produto.Text;
            string codigoProduto = txtItem_Codigo.Text;
            double valorUnit = double.Parse(txtItem_ValorUnit.Text);
            double quantidade = double.Parse(txtItem_Quantidade.Text);
            double valorTotal = double.Parse(txtItem_ValorTotal.Text);

            // Cria um objeto tipo ItemVenda e adiciona à lista, e em seguida atribui essa lista como
            // data source do DGV, para atualizá-lo.
            ItemVenda item = new ItemVenda(codigoProduto, descricaoProduto, valorUnit, quantidade, valorTotal);
            itensVenda.Add(item);

            dgvItensVenda.DataSource = null;
            dgvItensVenda.DataSource = itensVenda;

            txtVenda_ValorTotal.Text = (double.Parse(txtVenda_ValorTotal.Text) + valorTotal).ToString();

            btnConfirmarVenda.Enabled = true;
            MessageBox.Show("Item adicionado com sucesso.", "Novo item");
        }
        

        /// Ao alterar o Cliente selecionado na ComboBox, pega o CNPJ associado a ele e coloca na textbox
        private void cbxVenda_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVenda_CNPJ.Text = cbxVenda_Cliente.SelectedValue.ToString();

            txtVenda_NF.Enabled = true;
            cbxItem_Produto.Enabled = true;
        }

        /// Ao alterar o Produto selecionado na ComboBox, pega o código associado a ele e coloca na textbox
        private void cbxItem_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtItem_Codigo.Text = cbxItem_Produto.SelectedValue.ToString();

            txtItem_ValorUnit.Enabled = true;
            txtItem_ValorUnit.Clear();
            txtItem_Quantidade.Enabled = true;
            txtItem_Quantidade.Clear();
            txtItem_ValorTotal.Clear();

            btnAdicionarItem.Enabled = true;            
        }

        private void btnLimparVenda_Click(object sender, EventArgs e)
        {
            // Limpa todos os campos do formulário, reseta os campos e chama o método Popular_ComoboBoxes()
            // para popular as comboboxes de Cliente e Produto.
            this.Controls.Clear();
            this.InitializeComponent();
            itensVenda.Clear();            
            dgvItensVenda.DataSource = itensVenda;
            Popular_ComboBoxes();
            txtVenda_ValorTotal.Text = 0.ToString();
        }

        private void btnConfirmarVenda_Click(object sender, EventArgs e)
        {
            // Caso nenhum item tenha sido adicionado à lista da erro
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

            string razaoCliente = cbxVenda_Cliente.Text;
            long cnpjCliente = long.Parse(txtVenda_CNPJ.Text);
            int numeroNF = int.Parse(txtVenda_NF.Text);
            double valorTotal = double.Parse(txtVenda_ValorTotal.Text);
            DateTime dataVenda = DateTime.Parse(txtVenda_Data.Text);

            // Atribui o valor do numeroNF à propriedade de todos os itens daquela venda.
            foreach (ItemVenda itemVenda in itensVenda)
            {
                itemVenda.NumeroNF = numeroNF;
            }

            // Cria o objeto tipo Venda com as variáveis
            Venda venda = new Venda(numeroNF, cnpjCliente, razaoCliente, valorTotal, dataVenda);

            // Chama os métodos do objeto venda e da classe ItemVenda para salvar a venda no banco de 
            // dados e em seguida todos os itens associados à ela.
            venda.SalvarDados();
            ItemVenda.SalvarDados(itensVenda);

            MessageBox.Show("Venda registrada com sucesso!");

            this.Controls.Clear();
            this.InitializeComponent();
            itensVenda.Clear();
            dgvItensVenda.DataSource = itensVenda;
            Popular_ComboBoxes();
            txtVenda_ValorTotal.Text = 0.ToString();
        }

        /// Método para popular as comboboxes com as colunas correspondentes no banco de dados
        public void Popular_ComboBoxes()
        {
            string conexao = ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString;
            SqlConnection cn = new SqlConnection(conexao);
            SqlDataAdapter sdaCliente = new SqlDataAdapter("SELECT CNPJ,RazaoSocial FROM cliente", cn);

            DataTable dtCliente = new DataTable();
            sdaCliente.Fill(dtCliente);

            DataRow rowCliente = dtCliente.NewRow();
            rowCliente[1] = "Selecione...";
            dtCliente.Rows.InsertAt(rowCliente, 0);

            cbxVenda_Cliente.DataSource = dtCliente;
            cbxVenda_Cliente.DisplayMember = "RazaoSocial";
            cbxVenda_Cliente.ValueMember = "CNPJ";

            SqlDataAdapter sdaProduto = new SqlDataAdapter("SELECT Codigo,Descricao FROM produto", cn);

            DataTable dtProduto = new DataTable();
            sdaProduto.Fill(dtProduto);

            DataRow rowProduto = dtProduto.NewRow();
            rowProduto[1] = "Selecione...";
            dtProduto.Rows.InsertAt(rowProduto, 0);

            cbxItem_Produto.DataSource = dtProduto;
            cbxItem_Produto.DisplayMember = "Descricao";
            cbxItem_Produto.ValueMember = "Codigo";

            txtVenda_CNPJ.Clear();
            txtItem_Codigo.Clear();
        }
    }
}
