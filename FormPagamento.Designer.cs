
namespace PedagogyOn_2021
{
    partial class frmPagamento
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
            this.btnCartaoCredito = new System.Windows.Forms.Button();
            this.btnBoleto = new System.Windows.Forms.Button();
            this.btnTransferência = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCartaoCredito
            // 
            this.btnCartaoCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnCartaoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCartaoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaoCredito.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCartaoCredito.Location = new System.Drawing.Point(75, 239);
            this.btnCartaoCredito.Name = "btnCartaoCredito";
            this.btnCartaoCredito.Size = new System.Drawing.Size(300, 60);
            this.btnCartaoCredito.TabIndex = 0;
            this.btnCartaoCredito.Text = "CARTÃO DE CRÉDITO";
            this.btnCartaoCredito.UseVisualStyleBackColor = false;
            this.btnCartaoCredito.Click += new System.EventHandler(this.btnCartaoCredito_Click);
            // 
            // btnBoleto
            // 
            this.btnBoleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBoleto.Location = new System.Drawing.Point(400, 239);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(300, 60);
            this.btnBoleto.TabIndex = 0;
            this.btnBoleto.Text = "BOLETO BANCÁRIO";
            this.btnBoleto.UseVisualStyleBackColor = false;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            // 
            // btnTransferência
            // 
            this.btnTransferência.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnTransferência.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransferência.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferência.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTransferência.Location = new System.Drawing.Point(75, 339);
            this.btnTransferência.Name = "btnTransferência";
            this.btnTransferência.Size = new System.Drawing.Size(300, 60);
            this.btnTransferência.TabIndex = 0;
            this.btnTransferência.Text = "TRANSFERÊNCIA";
            this.btnTransferência.UseVisualStyleBackColor = false;
            this.btnTransferência.Click += new System.EventHandler(this.btnTransferência_Click);
            // 
            // btnPix
            // 
            this.btnPix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.btnPix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPix.Location = new System.Drawing.Point(400, 339);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(300, 60);
            this.btnPix.TabIndex = 0;
            this.btnPix.Text = "PIX";
            this.btnPix.UseVisualStyleBackColor = false;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a forma de pagamento";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(193)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnBoleto);
            this.Controls.Add(this.btnTransferência);
            this.Controls.Add(this.btnCartaoCredito);
            this.Name = "frmPagamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCartaoCredito;
        private System.Windows.Forms.Button btnBoleto;
        private System.Windows.Forms.Button btnTransferência;
        private System.Windows.Forms.Button btnPix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}

