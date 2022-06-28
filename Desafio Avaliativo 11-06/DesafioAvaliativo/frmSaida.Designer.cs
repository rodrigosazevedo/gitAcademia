namespace DesafioAvaliativo
{
    partial class frmSaida
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
            this.lblPlacaSaida = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.TextBox();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmarSaida = new System.Windows.Forms.Button();
            this.btnLimparSaida = new System.Windows.Forms.Button();
            this.cbxPlacaSaida = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPlacaSaida
            // 
            this.lblPlacaSaida.AutoSize = true;
            this.lblPlacaSaida.Location = new System.Drawing.Point(12, 21);
            this.lblPlacaSaida.Name = "lblPlacaSaida";
            this.lblPlacaSaida.Size = new System.Drawing.Size(92, 13);
            this.lblPlacaSaida.TabIndex = 15;
            this.lblPlacaSaida.Text = "Placa do Veículo:";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(119, 21);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(33, 13);
            this.lblDataSaida.TabIndex = 17;
            this.lblDataSaida.Text = "Data:";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDataSaida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataSaida.Enabled = false;
            this.txtDataSaida.Location = new System.Drawing.Point(122, 37);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(63, 20);
            this.txtDataSaida.TabIndex = 18;
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(209, 21);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(33, 13);
            this.lblHoraSaida.TabIndex = 19;
            this.lblHoraSaida.Text = "Hora:";
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.CustomFormat = "HH:mm";
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSaida.Location = new System.Drawing.Point(212, 37);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.ShowUpDown = true;
            this.dtpHoraSaida.Size = new System.Drawing.Size(52, 20);
            this.dtpHoraSaida.TabIndex = 20;
            // 
            // btnConfirmarSaida
            // 
            this.btnConfirmarSaida.Location = new System.Drawing.Point(77, 85);
            this.btnConfirmarSaida.Name = "btnConfirmarSaida";
            this.btnConfirmarSaida.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarSaida.TabIndex = 21;
            this.btnConfirmarSaida.Text = "Confirmar";
            this.btnConfirmarSaida.UseVisualStyleBackColor = true;
            this.btnConfirmarSaida.Click += new System.EventHandler(this.btnConfirmarSaida_Click);
            // 
            // btnLimparSaida
            // 
            this.btnLimparSaida.Location = new System.Drawing.Point(158, 85);
            this.btnLimparSaida.Name = "btnLimparSaida";
            this.btnLimparSaida.Size = new System.Drawing.Size(75, 23);
            this.btnLimparSaida.TabIndex = 22;
            this.btnLimparSaida.Text = "Limpar";
            this.btnLimparSaida.UseVisualStyleBackColor = true;
            this.btnLimparSaida.Click += new System.EventHandler(this.btnLimparSaida_Click);
            // 
            // cbxPlacaSaida
            // 
            this.cbxPlacaSaida.FormattingEnabled = true;
            this.cbxPlacaSaida.Location = new System.Drawing.Point(15, 37);
            this.cbxPlacaSaida.Name = "cbxPlacaSaida";
            this.cbxPlacaSaida.Size = new System.Drawing.Size(89, 21);
            this.cbxPlacaSaida.TabIndex = 23;
            // 
            // frmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 131);
            this.Controls.Add(this.cbxPlacaSaida);
            this.Controls.Add(this.btnLimparSaida);
            this.Controls.Add(this.btnConfirmarSaida);
            this.Controls.Add(this.dtpHoraSaida);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblPlacaSaida);
            this.Name = "frmSaida";
            this.Text = "Registrar Saida de Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlacaSaida;
        private System.Windows.Forms.Label lblDataSaida;
        public System.Windows.Forms.TextBox txtDataSaida;
        private System.Windows.Forms.Label lblHoraSaida;
        public System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.Button btnConfirmarSaida;
        private System.Windows.Forms.Button btnLimparSaida;
        public System.Windows.Forms.ComboBox cbxPlacaSaida;
    }
}