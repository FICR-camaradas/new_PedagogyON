
namespace PedagogyOn_2021
{
    partial class FormBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusca));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colProfissao,
            this.colTelefone,
            this.colCidade,
            this.ColEstado});
            this.dataGridView1.Location = new System.Drawing.Point(33, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colProfissao
            // 
            this.colProfissao.HeaderText = "Profissão";
            this.colProfissao.Name = "colProfissao";
            this.colProfissao.ReadOnly = true;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            // 
            // colCidade
            // 
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(69)))), ((int)(((byte)(91)))));
            this.buttonPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPesquisa.Location = new System.Drawing.Point(433, 20);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(92, 23);
            this.buttonPesquisa.TabIndex = 1;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = false;
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(97, 23);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(330, 20);
            this.textBoxBusca.TabIndex = 2;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVoltar.Location = new System.Drawing.Point(12, 12);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(42, 35);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "<";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(146, 448);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(193)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(604, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormBusca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de profissionais";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
    }
}

