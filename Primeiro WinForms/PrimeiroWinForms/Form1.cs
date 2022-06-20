using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no botão OK");
            MessageBox.Show("Nome: " + tbNome.Text + "\nE-mail: " + tbEmail.Text +
                            "\nCidade: " + tbCidade.Text + "\nBairro: " + tbBairro.Text +
                            "\nRua: " + tbRua.Text + "\nNúmero: " + tbNumero.Text +
                            "\nComplemento: " + tbComplemento.Text + "\nSexo:" + listSexo.SelectedItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão CANCELAR");
        }
    }
}
