namespace Desafio
{
    partial class frmModuloVendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarVenda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarVenda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERAÇÕES";
            // 
            // btnGerarVenda
            // 
            this.btnGerarVenda.Location = new System.Drawing.Point(6, 19);
            this.btnGerarVenda.Name = "btnGerarVenda";
            this.btnGerarVenda.Size = new System.Drawing.Size(92, 33);
            this.btnGerarVenda.TabIndex = 1;
            this.btnGerarVenda.Text = "Gerar Venda";
            this.btnGerarVenda.UseVisualStyleBackColor = true;
            this.btnGerarVenda.Click += new System.EventHandler(this.btnGerarVenda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCadastrarProdutos);
            this.groupBox2.Controls.Add(this.btnCadastrarCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CADASTRO";
            // 
            // btnCadastrarProdutos
            // 
            this.btnCadastrarProdutos.Location = new System.Drawing.Point(104, 19);
            this.btnCadastrarProdutos.Name = "btnCadastrarProdutos";
            this.btnCadastrarProdutos.Size = new System.Drawing.Size(92, 33);
            this.btnCadastrarProdutos.TabIndex = 2;
            this.btnCadastrarProdutos.Text = "PRODUTOS";
            this.btnCadastrarProdutos.UseVisualStyleBackColor = true;
            this.btnCadastrarProdutos.Click += new System.EventHandler(this.btnCadastrarProdutos_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(6, 19);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(92, 33);
            this.btnCadastrarCliente.TabIndex = 1;
            this.btnCadastrarCliente.Text = "CLIENTES";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // frmModuloVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 166);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModuloVendas";
            this.Text = "Módulo de Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerarVenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCadastrarProdutos;
        private System.Windows.Forms.Button btnCadastrarCliente;
    }
}

