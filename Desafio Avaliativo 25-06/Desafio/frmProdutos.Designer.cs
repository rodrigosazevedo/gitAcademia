namespace Desafio
{
    partial class frmProdutos
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
            this.txtProduto_Custo = new System.Windows.Forms.MaskedTextBox();
            this.txtProduto_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtProduto_Unidade = new System.Windows.Forms.TextBox();
            this.lblProduto_Unidade = new System.Windows.Forms.Label();
            this.lblProduto_Custo = new System.Windows.Forms.Label();
            this.lblProduto_CNPJ = new System.Windows.Forms.Label();
            this.txtProduto_RazaoSocial = new System.Windows.Forms.TextBox();
            this.lblProduto_RazaoSocial = new System.Windows.Forms.Label();
            this.txtProduto_Descricao = new System.Windows.Forms.TextBox();
            this.lblProduto_Descricao = new System.Windows.Forms.Label();
            this.txtProduto_Codigo = new System.Windows.Forms.TextBox();
            this.lblProduto_Codigo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnLimparProduto = new System.Windows.Forms.Button();
            this.btnConfirmarProduto = new System.Windows.Forms.Button();
            this.grpCadastroProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCadastroProduto
            // 
            this.grpCadastroProduto.Controls.Add(this.txtProduto_Custo);
            this.grpCadastroProduto.Controls.Add(this.txtProduto_CNPJ);
            this.grpCadastroProduto.Controls.Add(this.txtProduto_Unidade);
            this.grpCadastroProduto.Controls.Add(this.lblProduto_Unidade);
            this.grpCadastroProduto.Controls.Add(this.lblProduto_Custo);
            this.grpCadastroProduto.Controls.Add(this.lblProduto_CNPJ);
            this.grpCadastroProduto.Controls.Add(this.txtProduto_RazaoSocial);
            this.grpCadastroProduto.Controls.Add(this.lblProduto_RazaoSocial);
            this.grpCadastroProduto.Controls.Add(this.txtProduto_Descricao);
            this.grpCadastroProduto.Controls.Add(this.lblProduto_Descricao);
            this.grpCadastroProduto.Controls.Add(this.txtProduto_Codigo);
            this.grpCadastroProduto.Controls.Add(this.lblProduto_Codigo);
            this.grpCadastroProduto.Location = new System.Drawing.Point(11, 15);
            this.grpCadastroProduto.Name = "grpCadastroProduto";
            this.grpCadastroProduto.Size = new System.Drawing.Size(393, 240);
            this.grpCadastroProduto.TabIndex = 26;
            this.grpCadastroProduto.TabStop = false;
            this.grpCadastroProduto.Text = "CADASTRO DE PRODUTO";
            // 
            // txtProduto_Custo
            // 
            this.txtProduto_Custo.Location = new System.Drawing.Point(21, 187);
            this.txtProduto_Custo.Mask = "00,00";
            this.txtProduto_Custo.Name = "txtProduto_Custo";
            this.txtProduto_Custo.Size = new System.Drawing.Size(63, 20);
            this.txtProduto_Custo.TabIndex = 5;
            // 
            // txtProduto_CNPJ
            // 
            this.txtProduto_CNPJ.Location = new System.Drawing.Point(236, 137);
            this.txtProduto_CNPJ.Mask = "00.000.000/0000-00";
            this.txtProduto_CNPJ.Name = "txtProduto_CNPJ";
            this.txtProduto_CNPJ.Size = new System.Drawing.Size(121, 20);
            this.txtProduto_CNPJ.TabIndex = 4;
            // 
            // txtProduto_Unidade
            // 
            this.txtProduto_Unidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto_Unidade.Location = new System.Drawing.Point(276, 87);
            this.txtProduto_Unidade.MaxLength = 2;
            this.txtProduto_Unidade.Name = "txtProduto_Unidade";
            this.txtProduto_Unidade.Size = new System.Drawing.Size(44, 20);
            this.txtProduto_Unidade.TabIndex = 2;
            this.txtProduto_Unidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_Unidade_KeyPress);
            // 
            // lblProduto_Unidade
            // 
            this.lblProduto_Unidade.AutoSize = true;
            this.lblProduto_Unidade.Location = new System.Drawing.Point(273, 71);
            this.lblProduto_Unidade.Name = "lblProduto_Unidade";
            this.lblProduto_Unidade.Size = new System.Drawing.Size(47, 13);
            this.lblProduto_Unidade.TabIndex = 22;
            this.lblProduto_Unidade.Text = "Unidade";
            // 
            // lblProduto_Custo
            // 
            this.lblProduto_Custo.AutoSize = true;
            this.lblProduto_Custo.Location = new System.Drawing.Point(18, 171);
            this.lblProduto_Custo.Name = "lblProduto_Custo";
            this.lblProduto_Custo.Size = new System.Drawing.Size(34, 13);
            this.lblProduto_Custo.TabIndex = 17;
            this.lblProduto_Custo.Text = "Custo";
            // 
            // lblProduto_CNPJ
            // 
            this.lblProduto_CNPJ.AutoSize = true;
            this.lblProduto_CNPJ.Location = new System.Drawing.Point(233, 121);
            this.lblProduto_CNPJ.Name = "lblProduto_CNPJ";
            this.lblProduto_CNPJ.Size = new System.Drawing.Size(97, 13);
            this.lblProduto_CNPJ.TabIndex = 13;
            this.lblProduto_CNPJ.Text = "CNPJ - Fornecedor";
            // 
            // txtProduto_RazaoSocial
            // 
            this.txtProduto_RazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto_RazaoSocial.Location = new System.Drawing.Point(21, 137);
            this.txtProduto_RazaoSocial.Name = "txtProduto_RazaoSocial";
            this.txtProduto_RazaoSocial.Size = new System.Drawing.Size(209, 20);
            this.txtProduto_RazaoSocial.TabIndex = 3;
            // 
            // lblProduto_RazaoSocial
            // 
            this.lblProduto_RazaoSocial.AutoSize = true;
            this.lblProduto_RazaoSocial.Location = new System.Drawing.Point(18, 121);
            this.lblProduto_RazaoSocial.Name = "lblProduto_RazaoSocial";
            this.lblProduto_RazaoSocial.Size = new System.Drawing.Size(133, 13);
            this.lblProduto_RazaoSocial.TabIndex = 11;
            this.lblProduto_RazaoSocial.Text = "Razão Social - Fornecedor";
            // 
            // txtProduto_Descricao
            // 
            this.txtProduto_Descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto_Descricao.Location = new System.Drawing.Point(21, 87);
            this.txtProduto_Descricao.Name = "txtProduto_Descricao";
            this.txtProduto_Descricao.Size = new System.Drawing.Size(249, 20);
            this.txtProduto_Descricao.TabIndex = 1;
            // 
            // lblProduto_Descricao
            // 
            this.lblProduto_Descricao.AutoSize = true;
            this.lblProduto_Descricao.Location = new System.Drawing.Point(18, 71);
            this.lblProduto_Descricao.Name = "lblProduto_Descricao";
            this.lblProduto_Descricao.Size = new System.Drawing.Size(95, 13);
            this.lblProduto_Descricao.TabIndex = 7;
            this.lblProduto_Descricao.Text = "Descrição Produto";
            // 
            // txtProduto_Codigo
            // 
            this.txtProduto_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto_Codigo.Location = new System.Drawing.Point(21, 37);
            this.txtProduto_Codigo.Name = "txtProduto_Codigo";
            this.txtProduto_Codigo.Size = new System.Drawing.Size(125, 20);
            this.txtProduto_Codigo.TabIndex = 0;
            // 
            // lblProduto_Codigo
            // 
            this.lblProduto_Codigo.AutoSize = true;
            this.lblProduto_Codigo.Location = new System.Drawing.Point(18, 21);
            this.lblProduto_Codigo.Name = "lblProduto_Codigo";
            this.lblProduto_Codigo.Size = new System.Drawing.Size(80, 13);
            this.lblProduto_Codigo.TabIndex = 1;
            this.lblProduto_Codigo.Text = "Codigo Produto";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(410, 15);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(267, 283);
            this.dgvProdutos.TabIndex = 25;
            this.dgvProdutos.TabStop = false;
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.Location = new System.Drawing.Point(201, 261);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(95, 37);
            this.btnLimparProduto.TabIndex = 7;
            this.btnLimparProduto.Text = "LIMPAR";
            this.btnLimparProduto.UseVisualStyleBackColor = true;
            this.btnLimparProduto.Click += new System.EventHandler(this.btnLimparProduto_Click);
            // 
            // btnConfirmarProduto
            // 
            this.btnConfirmarProduto.Location = new System.Drawing.Point(96, 261);
            this.btnConfirmarProduto.Name = "btnConfirmarProduto";
            this.btnConfirmarProduto.Size = new System.Drawing.Size(95, 37);
            this.btnConfirmarProduto.TabIndex = 6;
            this.btnConfirmarProduto.Text = "CONFIRMAR";
            this.btnConfirmarProduto.UseVisualStyleBackColor = true;
            this.btnConfirmarProduto.Click += new System.EventHandler(this.btnConfirmarProduto_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 304);
            this.Controls.Add(this.btnLimparProduto);
            this.Controls.Add(this.btnConfirmarProduto);
            this.Controls.Add(this.grpCadastroProduto);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "frmProdutos";
            this.Text = "Cadastro de Produtos";
            this.grpCadastroProduto.ResumeLayout(false);
            this.grpCadastroProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastroProduto;
        private System.Windows.Forms.TextBox txtProduto_Unidade;
        private System.Windows.Forms.Label lblProduto_Unidade;
        private System.Windows.Forms.Label lblProduto_Custo;
        private System.Windows.Forms.Label lblProduto_CNPJ;
        private System.Windows.Forms.TextBox txtProduto_RazaoSocial;
        private System.Windows.Forms.Label lblProduto_RazaoSocial;
        private System.Windows.Forms.TextBox txtProduto_Descricao;
        private System.Windows.Forms.Label lblProduto_Descricao;
        private System.Windows.Forms.TextBox txtProduto_Codigo;
        private System.Windows.Forms.Label lblProduto_Codigo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnLimparProduto;
        private System.Windows.Forms.Button btnConfirmarProduto;
        private System.Windows.Forms.MaskedTextBox txtProduto_Custo;
        private System.Windows.Forms.MaskedTextBox txtProduto_CNPJ;
    }
}