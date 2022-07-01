namespace Desafio
{
    partial class frmClientes
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
            this.lblCliente_RazaoSocial = new System.Windows.Forms.Label();
            this.txtCliente_RazaoSocial = new System.Windows.Forms.TextBox();
            this.lblCliente_CNPJ = new System.Windows.Forms.Label();
            this.txtCliente_Email = new System.Windows.Forms.TextBox();
            this.lblCliente_Email = new System.Windows.Forms.Label();
            this.txtCliente_Endereco = new System.Windows.Forms.TextBox();
            this.lblCliente_Endereco = new System.Windows.Forms.Label();
            this.txtCliente_Bairro = new System.Windows.Forms.TextBox();
            this.lblCliente_Bairro = new System.Windows.Forms.Label();
            this.lblCliente_Cidade = new System.Windows.Forms.Label();
            this.lblCliente_CEP = new System.Windows.Forms.Label();
            this.lblCliente_UF = new System.Windows.Forms.Label();
            this.cbxCliente_UF = new System.Windows.Forms.ComboBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblCliente_Telefone = new System.Windows.Forms.Label();
            this.grpCadastroCliente = new System.Windows.Forms.GroupBox();
            this.txtCliente_Cidade = new System.Windows.Forms.TextBox();
            this.txtCliente_CEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCliente_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCliente_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmarCliente = new System.Windows.Forms.Button();
            this.btnLimparCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grpCadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente_RazaoSocial
            // 
            this.lblCliente_RazaoSocial.AutoSize = true;
            this.lblCliente_RazaoSocial.Location = new System.Drawing.Point(18, 21);
            this.lblCliente_RazaoSocial.Name = "lblCliente_RazaoSocial";
            this.lblCliente_RazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblCliente_RazaoSocial.TabIndex = 1;
            this.lblCliente_RazaoSocial.Text = "Razão Social";
            // 
            // txtCliente_RazaoSocial
            // 
            this.txtCliente_RazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente_RazaoSocial.Location = new System.Drawing.Point(21, 37);
            this.txtCliente_RazaoSocial.MaxLength = 50;
            this.txtCliente_RazaoSocial.Name = "txtCliente_RazaoSocial";
            this.txtCliente_RazaoSocial.Size = new System.Drawing.Size(171, 20);
            this.txtCliente_RazaoSocial.TabIndex = 0;
            // 
            // lblCliente_CNPJ
            // 
            this.lblCliente_CNPJ.AutoSize = true;
            this.lblCliente_CNPJ.Location = new System.Drawing.Point(195, 21);
            this.lblCliente_CNPJ.Name = "lblCliente_CNPJ";
            this.lblCliente_CNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCliente_CNPJ.TabIndex = 5;
            this.lblCliente_CNPJ.Text = "CNPJ";
            // 
            // txtCliente_Email
            // 
            this.txtCliente_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCliente_Email.Location = new System.Drawing.Point(21, 87);
            this.txtCliente_Email.MaxLength = 50;
            this.txtCliente_Email.Name = "txtCliente_Email";
            this.txtCliente_Email.Size = new System.Drawing.Size(212, 20);
            this.txtCliente_Email.TabIndex = 2;
            // 
            // lblCliente_Email
            // 
            this.lblCliente_Email.AutoSize = true;
            this.lblCliente_Email.Location = new System.Drawing.Point(18, 71);
            this.lblCliente_Email.Name = "lblCliente_Email";
            this.lblCliente_Email.Size = new System.Drawing.Size(35, 13);
            this.lblCliente_Email.TabIndex = 7;
            this.lblCliente_Email.Text = "E-mail";
            // 
            // txtCliente_Endereco
            // 
            this.txtCliente_Endereco.Location = new System.Drawing.Point(21, 137);
            this.txtCliente_Endereco.MaxLength = 50;
            this.txtCliente_Endereco.Name = "txtCliente_Endereco";
            this.txtCliente_Endereco.Size = new System.Drawing.Size(212, 20);
            this.txtCliente_Endereco.TabIndex = 4;
            // 
            // lblCliente_Endereco
            // 
            this.lblCliente_Endereco.AutoSize = true;
            this.lblCliente_Endereco.Location = new System.Drawing.Point(18, 121);
            this.lblCliente_Endereco.Name = "lblCliente_Endereco";
            this.lblCliente_Endereco.Size = new System.Drawing.Size(53, 13);
            this.lblCliente_Endereco.TabIndex = 11;
            this.lblCliente_Endereco.Text = "Endereço";
            // 
            // txtCliente_Bairro
            // 
            this.txtCliente_Bairro.Location = new System.Drawing.Point(239, 137);
            this.txtCliente_Bairro.MaxLength = 50;
            this.txtCliente_Bairro.Name = "txtCliente_Bairro";
            this.txtCliente_Bairro.Size = new System.Drawing.Size(113, 20);
            this.txtCliente_Bairro.TabIndex = 5;
            this.txtCliente_Bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_Bairro_KeyPress);
            // 
            // lblCliente_Bairro
            // 
            this.lblCliente_Bairro.AutoSize = true;
            this.lblCliente_Bairro.Location = new System.Drawing.Point(236, 121);
            this.lblCliente_Bairro.Name = "lblCliente_Bairro";
            this.lblCliente_Bairro.Size = new System.Drawing.Size(34, 13);
            this.lblCliente_Bairro.TabIndex = 13;
            this.lblCliente_Bairro.Text = "Bairro";
            // 
            // lblCliente_Cidade
            // 
            this.lblCliente_Cidade.AutoSize = true;
            this.lblCliente_Cidade.Location = new System.Drawing.Point(124, 171);
            this.lblCliente_Cidade.Name = "lblCliente_Cidade";
            this.lblCliente_Cidade.Size = new System.Drawing.Size(40, 13);
            this.lblCliente_Cidade.TabIndex = 15;
            this.lblCliente_Cidade.Text = "Cidade";
            // 
            // lblCliente_CEP
            // 
            this.lblCliente_CEP.AutoSize = true;
            this.lblCliente_CEP.Location = new System.Drawing.Point(18, 171);
            this.lblCliente_CEP.Name = "lblCliente_CEP";
            this.lblCliente_CEP.Size = new System.Drawing.Size(28, 13);
            this.lblCliente_CEP.TabIndex = 17;
            this.lblCliente_CEP.Text = "CEP";
            // 
            // lblCliente_UF
            // 
            this.lblCliente_UF.AutoSize = true;
            this.lblCliente_UF.Location = new System.Drawing.Point(243, 171);
            this.lblCliente_UF.Name = "lblCliente_UF";
            this.lblCliente_UF.Size = new System.Drawing.Size(21, 13);
            this.lblCliente_UF.TabIndex = 19;
            this.lblCliente_UF.Text = "UF";
            // 
            // cbxCliente_UF
            // 
            this.cbxCliente_UF.FormattingEnabled = true;
            this.cbxCliente_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbxCliente_UF.Location = new System.Drawing.Point(246, 186);
            this.cbxCliente_UF.MaxDropDownItems = 5;
            this.cbxCliente_UF.Name = "cbxCliente_UF";
            this.cbxCliente_UF.Size = new System.Drawing.Size(39, 21);
            this.cbxCliente_UF.TabIndex = 8;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(410, 15);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(267, 277);
            this.dgvClientes.TabIndex = 21;
            this.dgvClientes.TabStop = false;
            // 
            // lblCliente_Telefone
            // 
            this.lblCliente_Telefone.AutoSize = true;
            this.lblCliente_Telefone.Location = new System.Drawing.Point(236, 71);
            this.lblCliente_Telefone.Name = "lblCliente_Telefone";
            this.lblCliente_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lblCliente_Telefone.TabIndex = 22;
            this.lblCliente_Telefone.Text = "Telefone";
            // 
            // grpCadastroCliente
            // 
            this.grpCadastroCliente.Controls.Add(this.txtCliente_Cidade);
            this.grpCadastroCliente.Controls.Add(this.txtCliente_CEP);
            this.grpCadastroCliente.Controls.Add(this.txtCliente_Telefone);
            this.grpCadastroCliente.Controls.Add(this.txtCliente_CNPJ);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_Telefone);
            this.grpCadastroCliente.Controls.Add(this.cbxCliente_UF);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_UF);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_CEP);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_Cidade);
            this.grpCadastroCliente.Controls.Add(this.txtCliente_Bairro);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_Bairro);
            this.grpCadastroCliente.Controls.Add(this.txtCliente_Endereco);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_Endereco);
            this.grpCadastroCliente.Controls.Add(this.txtCliente_Email);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_Email);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_CNPJ);
            this.grpCadastroCliente.Controls.Add(this.txtCliente_RazaoSocial);
            this.grpCadastroCliente.Controls.Add(this.lblCliente_RazaoSocial);
            this.grpCadastroCliente.Location = new System.Drawing.Point(11, 15);
            this.grpCadastroCliente.Name = "grpCadastroCliente";
            this.grpCadastroCliente.Size = new System.Drawing.Size(393, 228);
            this.grpCadastroCliente.TabIndex = 24;
            this.grpCadastroCliente.TabStop = false;
            this.grpCadastroCliente.Text = "CADASTRO DE CLIENTE";
            // 
            // txtCliente_Cidade
            // 
            this.txtCliente_Cidade.Location = new System.Drawing.Point(127, 187);
            this.txtCliente_Cidade.MaxLength = 50;
            this.txtCliente_Cidade.Name = "txtCliente_Cidade";
            this.txtCliente_Cidade.Size = new System.Drawing.Size(113, 20);
            this.txtCliente_Cidade.TabIndex = 23;
            this.txtCliente_Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_Cidade_KeyPress);
            // 
            // txtCliente_CEP
            // 
            this.txtCliente_CEP.Location = new System.Drawing.Point(21, 187);
            this.txtCliente_CEP.Mask = "00000-000";
            this.txtCliente_CEP.Name = "txtCliente_CEP";
            this.txtCliente_CEP.Size = new System.Drawing.Size(100, 20);
            this.txtCliente_CEP.TabIndex = 6;
            this.txtCliente_CEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCliente_Telefone
            // 
            this.txtCliente_Telefone.Location = new System.Drawing.Point(239, 87);
            this.txtCliente_Telefone.Mask = "(00)90000-0000";
            this.txtCliente_Telefone.Name = "txtCliente_Telefone";
            this.txtCliente_Telefone.Size = new System.Drawing.Size(112, 20);
            this.txtCliente_Telefone.TabIndex = 3;
            this.txtCliente_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCliente_Telefone.TextChanged += new System.EventHandler(this.txtCliente_Telefone_TextChanged);
            // 
            // txtCliente_CNPJ
            // 
            this.txtCliente_CNPJ.Location = new System.Drawing.Point(198, 37);
            this.txtCliente_CNPJ.Mask = "00.000.000/0000-00";
            this.txtCliente_CNPJ.Name = "txtCliente_CNPJ";
            this.txtCliente_CNPJ.Size = new System.Drawing.Size(112, 20);
            this.txtCliente_CNPJ.TabIndex = 1;
            this.txtCliente_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnConfirmarCliente
            // 
            this.btnConfirmarCliente.Location = new System.Drawing.Point(96, 255);
            this.btnConfirmarCliente.Name = "btnConfirmarCliente";
            this.btnConfirmarCliente.Size = new System.Drawing.Size(95, 37);
            this.btnConfirmarCliente.TabIndex = 9;
            this.btnConfirmarCliente.Text = "CONFIRMAR";
            this.btnConfirmarCliente.UseVisualStyleBackColor = true;
            this.btnConfirmarCliente.Click += new System.EventHandler(this.btnConfirmarCliente_Click);
            // 
            // btnLimparCliente
            // 
            this.btnLimparCliente.Location = new System.Drawing.Point(201, 255);
            this.btnLimparCliente.Name = "btnLimparCliente";
            this.btnLimparCliente.Size = new System.Drawing.Size(95, 37);
            this.btnLimparCliente.TabIndex = 10;
            this.btnLimparCliente.Text = "LIMPAR";
            this.btnLimparCliente.UseVisualStyleBackColor = true;
            this.btnLimparCliente.Click += new System.EventHandler(this.btnLimparCliente_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 298);
            this.Controls.Add(this.btnLimparCliente);
            this.Controls.Add(this.btnConfirmarCliente);
            this.Controls.Add(this.grpCadastroCliente);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmClientes";
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grpCadastroCliente.ResumeLayout(false);
            this.grpCadastroCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCliente_RazaoSocial;
        private System.Windows.Forms.TextBox txtCliente_RazaoSocial;
        private System.Windows.Forms.Label lblCliente_CNPJ;
        private System.Windows.Forms.TextBox txtCliente_Email;
        private System.Windows.Forms.Label lblCliente_Email;
        private System.Windows.Forms.TextBox txtCliente_Endereco;
        private System.Windows.Forms.Label lblCliente_Endereco;
        private System.Windows.Forms.TextBox txtCliente_Bairro;
        private System.Windows.Forms.Label lblCliente_Bairro;
        private System.Windows.Forms.Label lblCliente_Cidade;
        private System.Windows.Forms.Label lblCliente_CEP;
        private System.Windows.Forms.Label lblCliente_UF;
        private System.Windows.Forms.ComboBox cbxCliente_UF;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblCliente_Telefone;
        private System.Windows.Forms.GroupBox grpCadastroCliente;
        private System.Windows.Forms.Button btnConfirmarCliente;
        private System.Windows.Forms.Button btnLimparCliente;
        private System.Windows.Forms.MaskedTextBox txtCliente_CEP;
        private System.Windows.Forms.MaskedTextBox txtCliente_Telefone;
        private System.Windows.Forms.MaskedTextBox txtCliente_CNPJ;
        private System.Windows.Forms.TextBox txtCliente_Cidade;
    }
}