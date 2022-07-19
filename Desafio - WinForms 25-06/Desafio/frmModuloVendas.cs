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

    public partial class frmModuloVendas : Form
    {
        public frmModuloVendas()
        {
            InitializeComponent();
        }

        private void btnGerarVenda_Click(object sender, EventArgs e)
        {
            frmGerarVenda frmGerarVenda = new frmGerarVenda();
            frmGerarVenda.ShowDialog();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.ShowDialog();  
        }

    }
}
