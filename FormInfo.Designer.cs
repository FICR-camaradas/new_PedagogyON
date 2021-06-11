
namespace PedagogyOn_2021
{
    partial class FormInfo
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
            this.buttonSobreNos = new System.Windows.Forms.Button();
            this.buttonPed = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSobreNos
            // 
            this.buttonSobreNos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            this.buttonSobreNos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSobreNos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSobreNos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSobreNos.Location = new System.Drawing.Point(369, 12);
            this.buttonSobreNos.Name = "buttonSobreNos";
            this.buttonSobreNos.Size = new System.Drawing.Size(93, 26);
            this.buttonSobreNos.TabIndex = 0;
            this.buttonSobreNos.Text = "Sobre nós";
            this.buttonSobreNos.UseVisualStyleBackColor = false;
            // 
            // buttonPed
            // 
            this.buttonPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            this.buttonPed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPed.Location = new System.Drawing.Point(238, 12);
            this.buttonPed.Name = "buttonPed";
            this.buttonPed.Size = new System.Drawing.Size(125, 26);
            this.buttonPed.TabIndex = 1;
            this.buttonPed.Text = "PedagogyON";
            this.buttonPed.UseVisualStyleBackColor = false;
            this.buttonPed.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVoltar.Location = new System.Drawing.Point(12, 12);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(42, 41);
            this.buttonVoltar.TabIndex = 2;
            this.buttonVoltar.Text = "<";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(193)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonPed);
            this.Controls.Add(this.buttonSobreNos);
            this.Name = "FormInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSobreNos;
        private System.Windows.Forms.Button buttonPed;
        private System.Windows.Forms.Button buttonVoltar;
    }
}

