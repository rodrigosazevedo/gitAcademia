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
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGaragem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSaida)).BeginInit();
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
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(172, 47);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(157, 66);
            this.btnEntrada.TabIndex = 17;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(369, 47);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(157, 66);
            this.btnSaida.TabIndex = 18;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // frmGaragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 351);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblListaSaida);
            this.Controls.Add(this.lblListaGaragem);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.dgvListaSaida);
            this.Controls.Add(this.dgvListaGaragem);
            this.Name = "frmGaragem";
            this.Text = "Gestão da Garagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaGaragem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSaida)).EndInit();
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
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
    }
}

