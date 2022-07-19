namespace DesafioAvaliativo
{
    partial class frmGaragem
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
            this.components = new System.ComponentModel.Container();
            this.dgvListaGaragem = new System.Windows.Forms.DataGridView();
            this.dgvListaSaida = new System.Windows.Forms.DataGridView();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.lblListaGaragem = new System.Windows.Forms.Label();
            this.lblListaSaida = new System.Windows.Forms.Label();
            this.Timer1000ms = new System.Windows.Forms.Timer(this.components);
            this.txtDataCorrente = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGaragem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSaida)).BeginInit();
            this.gbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaGaragem
            // 
            this.dgvListaGaragem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListaGaragem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaGaragem.Location = new System.Drawing.Point(1, 162);
            this.dgvListaGaragem.Name = "dgvListaGaragem";
            this.dgvListaGaragem.Size = new System.Drawing.Size(345, 188);
            this.dgvListaGaragem.TabIndex = 0;
            this.dgvListaGaragem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaGaragem_CellDoubleClick);
            // 
            // dgvListaSaida
            // 
            this.dgvListaSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListaSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSaida.Location = new System.Drawing.Point(349, 162);
            this.dgvListaSaida.Name = "dgvListaSaida";
            this.dgvListaSaida.Size = new System.Drawing.Size(345, 188);
            this.dgvListaSaida.TabIndex = 1;
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(-2, -1);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(0, 13);
            this.lblDataHora.TabIndex = 2;
            // 
            // lblListaGaragem
            // 
            this.lblListaGaragem.AutoSize = true;
            this.lblListaGaragem.Location = new System.Drawing.Point(104, 146);
            this.lblListaGaragem.Name = "lblListaGaragem";
            this.lblListaGaragem.Size = new System.Drawing.Size(147, 13);
            this.lblListaGaragem.TabIndex = 5;
            this.lblListaGaragem.Text = "Lista de veículos na garagem";
            // 
            // lblListaSaida
            // 
            this.lblListaSaida.AutoSize = true;
            this.lblListaSaida.Location = new System.Drawing.Point(447, 146);
            this.lblListaSaida.Name = "lblListaSaida";
            this.lblListaSaida.Size = new System.Drawing.Size(145, 13);
            this.lblListaSaida.TabIndex = 6;
            this.lblListaSaida.Text = "Registro de saída de veículo";
            // 
            // Timer1000ms
            // 
            this.Timer1000ms.Enabled = true;
            this.Timer1000ms.Interval = 1000;
            this.Timer1000ms.Tick += new System.EventHandler(this.Timer1000ms_Tick);
            // 
            // txtDataCorrente
            // 
            this.txtDataCorrente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDataCorrente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataCorrente.Enabled = false;
            this.txtDataCorrente.Location = new System.Drawing.Point(276, 50);
            this.txtDataCorrente.Name = "txtDataCorrente";
            this.txtDataCorrente.Size = new System.Drawing.Size(88, 20);
            this.txtDataCorrente.TabIndex = 8;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(385, 50);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(75, 20);
            this.dtpHora.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(385, 98);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(466, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.rbSaida);
            this.gbOpcoes.Controls.Add(this.rbEntrada);
            this.gbOpcoes.Location = new System.Drawing.Point(150, 82);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(225, 44);
            this.gbOpcoes.TabIndex = 12;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Selecionar Operação";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(107, 19);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(54, 17);
            this.rbSaida.TabIndex = 18;
            this.rbSaida.TabStop = true;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(39, 19);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 17;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Location = new System.Drawing.Point(150, 50);
            this.txtPlaca.MaxLength = 9;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(101, 20);
            this.txtPlaca.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Placa do Veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hora:";
            // 
            // frmGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.txtDataCorrente);
            this.Controls.Add(this.lblListaSaida);
            this.Controls.Add(this.lblListaGaragem);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.dgvListaSaida);
            this.Controls.Add(this.dgvListaGaragem);
            this.Name = "frmGaragem";
            this.Text = "Gestão da Garagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGaragem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSaida)).EndInit();
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblListaGaragem;
        private System.Windows.Forms.Label lblListaSaida;
        private System.Windows.Forms.Timer Timer1000ms;
        public System.Windows.Forms.DataGridView dgvListaGaragem;
        public System.Windows.Forms.DataGridView dgvListaSaida;
        public System.Windows.Forms.TextBox txtDataCorrente;
        public System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbOpcoes;
        public System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.RadioButton rbEntrada;
    }
}

