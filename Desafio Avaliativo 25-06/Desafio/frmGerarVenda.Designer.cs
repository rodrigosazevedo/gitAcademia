namespace Desafio
{
    partial class frmGerarVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCadastroProduto = new System.Windows.Forms.GroupBox();
            this.lblVenda_Cliente = new System.Windows.Forms.Label();
            this.cbxVenda_Cliente = new System.Windows.Forms.ComboBox();
            this.lblVenda_CNPJ = new System.Windows.Forms.Label();
            this.txtVenda_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtVenda_NF = new System.Windows.Forms.TextBox();
            this.lblVenda_NF = new System.Windows.Forms.Label();
            this.lblVenda_Data = new System.Windows.Forms.Label();
            this.txtVenda_Data = new System.Windows.Forms.TextBox();
            this.lblVenda_ValorTotal = new System.Windows.Forms.Label();
            this.txtVenda_ValorTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmarVenda = new System.Windows.Forms.Button();
            this.btnLimparVenda = new System.Windows.Forms.Button();
            this.cbxItem_Produto = new System.Windows.Forms.ComboBox();
            this.txtItem_Codigo = new System.Windows.Forms.TextBox();
            this.lblItem_Produto = new System.Windows.Forms.Label();
            this.lblItem_Codigo = new System.Windows.Forms.Label();
            this.txtItem_ValorUnit = new System.Windows.Forms.TextBox();
            this.lblItem_ValorUnit = new System.Windows.Forms.Label();
            this.txtItem_Quantidade = new System.Windows.Forms.TextBox();
            this.lblItem_Quantidade = new System.Windows.Forms.Label();
            this.txtItem_ValorTotal = new System.Windows.Forms.TextBox();
            this.lblItem_ValorTotal = new System.Windows.Forms.Label();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.grpCadastroProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCadastroProduto
            // 
            this.grpCadastroProduto.Controls.Add(this.btnLimparVenda);
            this.grpCadastroProduto.Controls.Add(this.btnConfirmarVenda);
            this.grpCadastroProduto.Controls.Add(this.txtVenda_ValorTotal);
            this.grpCadastroProduto.Controls.Add(this.lblVenda_ValorTotal);
            this.grpCadastroProduto.Controls.Add(this.txtVenda_Data);
            this.grpCadastroProduto.Controls.Add(this.lblVenda_Data);
            this.grpCadastroProduto.Controls.Add(this.lblVenda_NF);
            this.grpCadastroProduto.Controls.Add(this.txtVenda_NF);
            this.grpCadastroProduto.Controls.Add(this.txtVenda_CNPJ);
            this.grpCadastroProduto.Controls.Add(this.lblVenda_CNPJ);
            this.grpCadastroProduto.Controls.Add(this.cbxVenda_Cliente);
            this.grpCadastroProduto.Controls.Add(this.lblVenda_Cliente);
            this.grpCadastroProduto.Location = new System.Drawing.Point(11, 15);
            this.grpCadastroProduto.Name = "grpCadastroProduto";
            this.grpCadastroProduto.Size = new System.Drawing.Size(475, 111);
            this.grpCadastroProduto.TabIndex = 27;
            this.grpCadastroProduto.TabStop = false;
            this.grpCadastroProduto.Text = "VENDA ";
            // 
            // lblVenda_Cliente
            // 
            this.lblVenda_Cliente.AutoSize = true;
            this.lblVenda_Cliente.Location = new System.Drawing.Point(18, 21);
            this.lblVenda_Cliente.Name = "lblVenda_Cliente";
            this.lblVenda_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lblVenda_Cliente.TabIndex = 1;
            this.lblVenda_Cliente.Text = "Cliente";
            // 
            // cbxVenda_Cliente
            // 
            this.cbxVenda_Cliente.FormattingEnabled = true;
            this.cbxVenda_Cliente.Location = new System.Drawing.Point(21, 37);
            this.cbxVenda_Cliente.Name = "cbxVenda_Cliente";
            this.cbxVenda_Cliente.Size = new System.Drawing.Size(209, 21);
            this.cbxVenda_Cliente.TabIndex = 0;
            // 
            // lblVenda_CNPJ
            // 
            this.lblVenda_CNPJ.AutoSize = true;
            this.lblVenda_CNPJ.Location = new System.Drawing.Point(236, 21);
            this.lblVenda_CNPJ.Name = "lblVenda_CNPJ";
            this.lblVenda_CNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblVenda_CNPJ.TabIndex = 24;
            this.lblVenda_CNPJ.Text = "CNPJ";
            // 
            // txtVenda_CNPJ
            // 
            this.txtVenda_CNPJ.Location = new System.Drawing.Point(239, 37);
            this.txtVenda_CNPJ.Mask = "00.000.000/0000-00";
            this.txtVenda_CNPJ.Name = "txtVenda_CNPJ";
            this.txtVenda_CNPJ.Size = new System.Drawing.Size(112, 20);
            this.txtVenda_CNPJ.TabIndex = 1;
            this.txtVenda_CNPJ.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 85);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.TabStop = false;
            // 
            // txtVenda_NF
            // 
            this.txtVenda_NF.Location = new System.Drawing.Point(21, 83);
            this.txtVenda_NF.Name = "txtVenda_NF";
            this.txtVenda_NF.Size = new System.Drawing.Size(100, 20);
            this.txtVenda_NF.TabIndex = 1;
            this.txtVenda_NF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_NF_KeyPress);
            // 
            // lblVenda_NF
            // 
            this.lblVenda_NF.AutoSize = true;
            this.lblVenda_NF.Location = new System.Drawing.Point(18, 67);
            this.lblVenda_NF.Name = "lblVenda_NF";
            this.lblVenda_NF.Size = new System.Drawing.Size(61, 13);
            this.lblVenda_NF.TabIndex = 27;
            this.lblVenda_NF.Text = "Número NF";
            // 
            // lblVenda_Data
            // 
            this.lblVenda_Data.AutoSize = true;
            this.lblVenda_Data.Location = new System.Drawing.Point(354, 21);
            this.lblVenda_Data.Name = "lblVenda_Data";
            this.lblVenda_Data.Size = new System.Drawing.Size(30, 13);
            this.lblVenda_Data.TabIndex = 28;
            this.lblVenda_Data.Text = "Data";
            // 
            // txtVenda_Data
            // 
            this.txtVenda_Data.Enabled = false;
            this.txtVenda_Data.Location = new System.Drawing.Point(357, 38);
            this.txtVenda_Data.Name = "txtVenda_Data";
            this.txtVenda_Data.Size = new System.Drawing.Size(75, 20);
            this.txtVenda_Data.TabIndex = 29;
            this.txtVenda_Data.TabStop = false;
            // 
            // lblVenda_ValorTotal
            // 
            this.lblVenda_ValorTotal.AutoSize = true;
            this.lblVenda_ValorTotal.Location = new System.Drawing.Point(127, 67);
            this.lblVenda_ValorTotal.Name = "lblVenda_ValorTotal";
            this.lblVenda_ValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblVenda_ValorTotal.TabIndex = 30;
            this.lblVenda_ValorTotal.Text = "Valor Total";
            // 
            // txtVenda_ValorTotal
            // 
            this.txtVenda_ValorTotal.Enabled = false;
            this.txtVenda_ValorTotal.Location = new System.Drawing.Point(130, 83);
            this.txtVenda_ValorTotal.Name = "txtVenda_ValorTotal";
            this.txtVenda_ValorTotal.Size = new System.Drawing.Size(55, 20);
            this.txtVenda_ValorTotal.TabIndex = 2;
            this.txtVenda_ValorTotal.TabStop = false;
            // 
            // btnConfirmarVenda
            // 
            this.btnConfirmarVenda.Location = new System.Drawing.Point(280, 78);
            this.btnConfirmarVenda.Name = "btnConfirmarVenda";
            this.btnConfirmarVenda.Size = new System.Drawing.Size(104, 28);
            this.btnConfirmarVenda.TabIndex = 7;
            this.btnConfirmarVenda.Text = "FECHAR VENDA";
            this.btnConfirmarVenda.UseVisualStyleBackColor = true;
            // 
            // btnLimparVenda
            // 
            this.btnLimparVenda.Location = new System.Drawing.Point(390, 78);
            this.btnLimparVenda.Name = "btnLimparVenda";
            this.btnLimparVenda.Size = new System.Drawing.Size(79, 28);
            this.btnLimparVenda.TabIndex = 8;
            this.btnLimparVenda.Text = "LIMPAR";
            this.btnLimparVenda.UseVisualStyleBackColor = true;
            // 
            // cbxItem_Produto
            // 
            this.cbxItem_Produto.FormattingEnabled = true;
            this.cbxItem_Produto.Location = new System.Drawing.Point(32, 157);
            this.cbxItem_Produto.Name = "cbxItem_Produto";
            this.cbxItem_Produto.Size = new System.Drawing.Size(209, 21);
            this.cbxItem_Produto.TabIndex = 3;
            // 
            // txtItem_Codigo
            // 
            this.txtItem_Codigo.Enabled = false;
            this.txtItem_Codigo.Location = new System.Drawing.Point(250, 158);
            this.txtItem_Codigo.Name = "txtItem_Codigo";
            this.txtItem_Codigo.Size = new System.Drawing.Size(115, 20);
            this.txtItem_Codigo.TabIndex = 32;
            this.txtItem_Codigo.TabStop = false;
            // 
            // lblItem_Produto
            // 
            this.lblItem_Produto.AutoSize = true;
            this.lblItem_Produto.Location = new System.Drawing.Point(29, 141);
            this.lblItem_Produto.Name = "lblItem_Produto";
            this.lblItem_Produto.Size = new System.Drawing.Size(44, 13);
            this.lblItem_Produto.TabIndex = 33;
            this.lblItem_Produto.Text = "Produto";
            // 
            // lblItem_Codigo
            // 
            this.lblItem_Codigo.AutoSize = true;
            this.lblItem_Codigo.Location = new System.Drawing.Point(247, 142);
            this.lblItem_Codigo.Name = "lblItem_Codigo";
            this.lblItem_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lblItem_Codigo.TabIndex = 34;
            this.lblItem_Codigo.Text = "Código";
            // 
            // txtItem_ValorUnit
            // 
            this.txtItem_ValorUnit.Location = new System.Drawing.Point(32, 207);
            this.txtItem_ValorUnit.Name = "txtItem_ValorUnit";
            this.txtItem_ValorUnit.Size = new System.Drawing.Size(67, 20);
            this.txtItem_ValorUnit.TabIndex = 4;
            this.txtItem_ValorUnit.TextChanged += new System.EventHandler(this.txtItem_ValorUnit_TextChanged);
            this.txtItem_ValorUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_ValorUnit_KeyPress);
            // 
            // lblItem_ValorUnit
            // 
            this.lblItem_ValorUnit.AutoSize = true;
            this.lblItem_ValorUnit.Location = new System.Drawing.Point(29, 191);
            this.lblItem_ValorUnit.Name = "lblItem_ValorUnit";
            this.lblItem_ValorUnit.Size = new System.Drawing.Size(70, 13);
            this.lblItem_ValorUnit.TabIndex = 36;
            this.lblItem_ValorUnit.Text = "Valor Unitário";
            // 
            // txtItem_Quantidade
            // 
            this.txtItem_Quantidade.Location = new System.Drawing.Point(105, 207);
            this.txtItem_Quantidade.Name = "txtItem_Quantidade";
            this.txtItem_Quantidade.Size = new System.Drawing.Size(67, 20);
            this.txtItem_Quantidade.TabIndex = 5;
            this.txtItem_Quantidade.TextChanged += new System.EventHandler(this.txtItem_Quantidade_TextChanged);
            this.txtItem_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_Quantidade_KeyPress);
            // 
            // lblItem_Quantidade
            // 
            this.lblItem_Quantidade.AutoSize = true;
            this.lblItem_Quantidade.Location = new System.Drawing.Point(105, 191);
            this.lblItem_Quantidade.Name = "lblItem_Quantidade";
            this.lblItem_Quantidade.Size = new System.Drawing.Size(62, 13);
            this.lblItem_Quantidade.TabIndex = 38;
            this.lblItem_Quantidade.Text = "Quantidade";
            // 
            // txtItem_ValorTotal
            // 
            this.txtItem_ValorTotal.Enabled = false;
            this.txtItem_ValorTotal.Location = new System.Drawing.Point(178, 207);
            this.txtItem_ValorTotal.Name = "txtItem_ValorTotal";
            this.txtItem_ValorTotal.Size = new System.Drawing.Size(67, 20);
            this.txtItem_ValorTotal.TabIndex = 39;
            this.txtItem_ValorTotal.TabStop = false;
            // 
            // lblItem_ValorTotal
            // 
            this.lblItem_ValorTotal.AutoSize = true;
            this.lblItem_ValorTotal.Location = new System.Drawing.Point(175, 191);
            this.lblItem_ValorTotal.Name = "lblItem_ValorTotal";
            this.lblItem_ValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblItem_ValorTotal.TabIndex = 40;
            this.lblItem_ValorTotal.Text = "Valor Total";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(268, 199);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(79, 28);
            this.btnAdicionarItem.TabIndex = 6;
            this.btnAdicionarItem.Text = "ADICIONAR";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // frmGerarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 320);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.lblItem_ValorTotal);
            this.Controls.Add(this.txtItem_ValorTotal);
            this.Controls.Add(this.lblItem_Quantidade);
            this.Controls.Add(this.txtItem_Quantidade);
            this.Controls.Add(this.lblItem_ValorUnit);
            this.Controls.Add(this.txtItem_ValorUnit);
            this.Controls.Add(this.lblItem_Codigo);
            this.Controls.Add(this.lblItem_Produto);
            this.Controls.Add(this.txtItem_Codigo);
            this.Controls.Add(this.cbxItem_Produto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpCadastroProduto);
            this.Name = "frmGerarVenda";
            this.Text = "Gerar Venda";
            this.Load += new System.EventHandler(this.frmGerarVenda_Load);
            this.grpCadastroProduto.ResumeLayout(false);
            this.grpCadastroProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastroProduto;
        private System.Windows.Forms.Label lblVenda_Cliente;
        private System.Windows.Forms.Label lblVenda_CNPJ;
        private System.Windows.Forms.ComboBox cbxVenda_Cliente;
        private System.Windows.Forms.TextBox txtVenda_ValorTotal;
        private System.Windows.Forms.Label lblVenda_ValorTotal;
        private System.Windows.Forms.TextBox txtVenda_Data;
        private System.Windows.Forms.Label lblVenda_Data;
        private System.Windows.Forms.Label lblVenda_NF;
        private System.Windows.Forms.TextBox txtVenda_NF;
        private System.Windows.Forms.MaskedTextBox txtVenda_CNPJ;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmarVenda;
        private System.Windows.Forms.Button btnLimparVenda;
        private System.Windows.Forms.ComboBox cbxItem_Produto;
        private System.Windows.Forms.TextBox txtItem_Codigo;
        private System.Windows.Forms.Label lblItem_Produto;
        private System.Windows.Forms.Label lblItem_Codigo;
        private System.Windows.Forms.TextBox txtItem_ValorUnit;
        private System.Windows.Forms.Label lblItem_ValorUnit;
        private System.Windows.Forms.TextBox txtItem_Quantidade;
        private System.Windows.Forms.Label lblItem_Quantidade;
        private System.Windows.Forms.TextBox txtItem_ValorTotal;
        private System.Windows.Forms.Label lblItem_ValorTotal;
        private System.Windows.Forms.Button btnAdicionarItem;
    }
}