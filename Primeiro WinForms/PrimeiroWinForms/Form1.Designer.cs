namespace PrimeiroWinForms
{
    partial class Form1
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.listSexo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 215);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(111, 62);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 62);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(149, 20);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(348, 20);
            this.tbNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(89, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(89, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(149, 46);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(348, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(89, 105);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 6;
            this.lblRua.Text = "Rua:";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(149, 98);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(138, 20);
            this.tbRua.TabIndex = 7;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(149, 76);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(138, 20);
            this.tbCidade.TabIndex = 8;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(89, 83);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(311, 83);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro:";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(354, 76);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(138, 20);
            this.tbBairro.TabIndex = 11;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(89, 131);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(40, 13);
            this.lblComplemento.TabIndex = 12;
            this.lblComplemento.Text = "Comp.:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(149, 124);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(199, 20);
            this.tbComplemento.TabIndex = 13;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(311, 105);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Número:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(359, 98);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(66, 20);
            this.tbNumero.TabIndex = 15;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(89, 157);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo:";
            // 
            // listSexo
            // 
            this.listSexo.FormattingEnabled = true;
            this.listSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.listSexo.Location = new System.Drawing.Point(149, 153);
            this.listSexo.Name = "listSexo";
            this.listSexo.Size = new System.Drawing.Size(87, 30);
            this.listSexo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 289);
            this.Controls.Add(this.listSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ListBox listSexo;
    }
}

