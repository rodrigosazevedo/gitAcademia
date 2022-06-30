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
        public frmGerarVenda()
        {
            InitializeComponent();
            txtVenda_Data.Text = DateTime.Today.ToString("dd/MM/yyyy");
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
        }

        private void txtItem_Quantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtItem_ValorUnit.Text != "")
            {
                txtItem_ValorTotal.Text = (double.Parse(txtItem_ValorUnit.Text) * double.Parse(txtItem_Quantidade.Text)).ToString();
            }
        }

        private void frmGerarVenda_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString);
            SqlDataAdapter sdaCliente = new SqlDataAdapter("SELECT CNPJ,RazaoSocial FROM cliente", cn);

            DataTable dtCliente = new DataTable();
            sdaCliente.Fill(dtCliente);

            DataRow row = dtCliente.NewRow();
            row[0] = 0;
            row[1] = "Selecionar";
            dtCliente.Rows.InsertAt(row, 0);

            cbxVenda_Cliente.DataSource = dtCliente;
            cbxVenda_Cliente.DisplayMember = "RazaoSocial";
            cbxVenda_Cliente.ValueMember = "CNPJ";
                        
            SqlDataAdapter sdaProduto = new SqlDataAdapter("SELECT Codigo,Descricao FROM produto", cn);

            DataTable dtProduto = new DataTable();
            sdaProduto.Fill(dtProduto);

            row = dtProduto.NewRow();
            row[0] = 0;
            row[1] = "Selecionar";
            dtProduto.Rows.InsertAt(row, 0);

            cbxVenda_Cliente.DataSource = dtProduto;
            cbxVenda_Cliente.DisplayMember = "Descricao";
            cbxVenda_Cliente.ValueMember = "Codigo";



        }
    }
}
