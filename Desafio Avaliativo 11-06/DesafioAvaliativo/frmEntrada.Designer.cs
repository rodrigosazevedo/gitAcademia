namespace DesafioAvaliativo
{
    partial class frmEntrada
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
            this.lblPlacaEntrada = new System.Windows.Forms.Label();
            this.txtPlacaEntrada = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmarEntrada = new System.Windows.Forms.Button();
            this.btnLimparEntrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlacaEntrada
            // 
            this.lblPlacaEntrada.AutoSize = true;
            this.lblPlacaEntrada.Location = new System.Drawing.Point(12, 21);
            this.lblPlacaEntrada.Name = "lblPlacaEntrada";
            this.lblPlacaEntrada.Size = new System.Drawing.Size(92, 13);
            this.lblPlacaEntrada.TabIndex = 15;
            this.lblPlacaEntrada.Text = "Placa do Veículo:";
            // 
            // txtPlacaEntrada
            // 
            this.txtPlacaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlacaEntrada.Location = new System.Drawing.Point(15, 37);
            this.txtPlacaEntrada.MaxLength = 9;
            this.txtPlacaEntrada.Name = "txtPlacaEntrada";
            this.txtPlacaEntrada.Size = new System.Drawing.Size(89, 20);
            this.txtPlacaEntrada.TabIndex = 16;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(119, 21);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(33, 13);
            this.lblDataEntrada.TabIndex = 17;
            this.lblDataEntrada.Text = "Data:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataEntrada.Enabled = false;
            this.txtDataEntrada.Location = new System.Drawing.Point(122, 37);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(63, 20);
            this.txtDataEntrada.TabIndex = 18;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(209, 21);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(33, 13);
            this.lblHoraEntrada.TabIndex = 19;
            this.lblHoraEntrada.Text = "Hora:";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CustomFormat = "HH:mm";
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(212, 37);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(52, 20);
            this.dtpHoraEntrada.TabIndex = 20;
            // 
            // btnConfirmarEntrada
            // 
            this.btnConfirmarEntrada.Location = new System.Drawing.Point(77, 85);
            this.btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            this.btnConfirmarEntrada.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarEntrada.TabIndex = 21;
            this.btnConfirmarEntrada.Text = "Confirmar";
            this.btnConfirmarEntrada.UseVisualStyleBackColor = true;
            this.btnConfirmarEntrada.Click += new System.EventHandler(this.btnConfirmarEntrada_Click);
            // 
            // btnLimparEntrada
            // 
            this.btnLimparEntrada.Location = new System.Drawing.Point(158, 85);
            this.btnLimparEntrada.Name = "btnLimparEntrada";
            this.btnLimparEntrada.Size = new System.Drawing.Size(75, 23);
            this.btnLimparEntrada.TabIndex = 22;
            this.btnLimparEntrada.Text = "Limpar";
            this.btnLimparEntrada.UseVisualStyleBackColor = true;
            this.btnLimparEntrada.Click += new System.EventHandler(this.btnLimparEntrada_Click);
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 131);
            this.Controls.Add(this.btnLimparEntrada);
            this.Controls.Add(this.btnConfirmarEntrada);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.txtPlacaEntrada);
            this.Controls.Add(this.lblPlacaEntrada);
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Entrada de Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlacaEntrada;
        public System.Windows.Forms.TextBox txtPlacaEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        public System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.Label lblHoraEntrada;
        public System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Button btnConfirmarEntrada;
        private System.Windows.Forms.Button btnLimparEntrada;
    }
}