namespace ControleDeFrota
{
    partial class ControleDeFrota
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
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnCaminhoes = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCaminhao = new System.Windows.Forms.Label();
            this.txtCaminhao = new System.Windows.Forms.TextBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.txtCarros = new System.Windows.Forms.TextBox();
            this.txtEixos = new System.Windows.Forms.TextBox();
            this.lblEixos = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarros
            // 
            this.btnCarros.Location = new System.Drawing.Point(225, 23);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(75, 48);
            this.btnCarros.TabIndex = 0;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnCaminhoes
            // 
            this.btnCaminhoes.Location = new System.Drawing.Point(329, 23);
            this.btnCaminhoes.Name = "btnCaminhoes";
            this.btnCaminhoes.Size = new System.Drawing.Size(75, 48);
            this.btnCaminhoes.TabIndex = 0;
            this.btnCaminhoes.Text = "Caminhões";
            this.btnCaminhoes.UseVisualStyleBackColor = true;
            this.btnCaminhoes.Click += new System.EventHandler(this.btnCaminhoes_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(435, 23);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 48);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCaminhao);
            this.groupBox1.Controls.Add(this.txtCaminhao);
            this.groupBox1.Controls.Add(this.lblCarro);
            this.groupBox1.Controls.Add(this.txtCarros);
            this.groupBox1.Controls.Add(this.txtEixos);
            this.groupBox1.Controls.Add(this.lblEixos);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.lblKM);
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblCaminhao
            // 
            this.lblCaminhao.AutoSize = true;
            this.lblCaminhao.Location = new System.Drawing.Point(420, 147);
            this.lblCaminhao.Name = "lblCaminhao";
            this.lblCaminhao.Size = new System.Drawing.Size(57, 13);
            this.lblCaminhao.TabIndex = 9;
            this.lblCaminhao.Text = "Caminhão:";
            // 
            // txtCaminhao
            // 
            this.txtCaminhao.Location = new System.Drawing.Point(423, 163);
            this.txtCaminhao.Multiline = true;
            this.txtCaminhao.Name = "txtCaminhao";
            this.txtCaminhao.Size = new System.Drawing.Size(321, 159);
            this.txtCaminhao.TabIndex = 8;
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.Location = new System.Drawing.Point(30, 147);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(35, 13);
            this.lblCarro.TabIndex = 7;
            this.lblCarro.Text = "Carro:";
            // 
            // txtCarros
            // 
            this.txtCarros.Location = new System.Drawing.Point(33, 163);
            this.txtCarros.Multiline = true;
            this.txtCarros.Name = "txtCarros";
            this.txtCarros.Size = new System.Drawing.Size(307, 159);
            this.txtCarros.TabIndex = 6;
            this.txtCarros.TextChanged += new System.EventHandler(this.txtCarros_TextChanged);
            // 
            // txtEixos
            // 
            this.txtEixos.Location = new System.Drawing.Point(338, 105);
            this.txtEixos.Name = "txtEixos";
            this.txtEixos.Size = new System.Drawing.Size(160, 20);
            this.txtEixos.TabIndex = 5;
            this.txtEixos.Visible = false;
            this.txtEixos.TextChanged += new System.EventHandler(this.txtEixos_TextChanged);
            // 
            // lblEixos
            // 
            this.lblEixos.AutoSize = true;
            this.lblEixos.Location = new System.Drawing.Point(297, 112);
            this.lblEixos.Name = "lblEixos";
            this.lblEixos.Size = new System.Drawing.Size(35, 13);
            this.lblEixos.TabIndex = 4;
            this.lblEixos.Text = "Eixos:";
            this.lblEixos.Visible = false;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(174, 105);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 3;
            this.txtKm.TextChanged += new System.EventHandler(this.txtKm_TextChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(174, 72);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(324, 20);
            this.txtPlaca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(174, 40);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(324, 20);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(142, 112);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(26, 13);
            this.lblKM.TabIndex = 2;
            this.lblKM.Text = "KM:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(131, 79);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(123, 47);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Click += new System.EventHandler(this.label1_Click);
            // 
            // ControleDeFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaminhoes);
            this.Controls.Add(this.btnCarros);
            this.Name = "ControleDeFrota";
            this.Text = "Controle de Frota";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnCaminhoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtEixos;
        private System.Windows.Forms.Label lblEixos;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCarro;
        private System.Windows.Forms.TextBox txtCarros;
        private System.Windows.Forms.Label lblCaminhao;
        private System.Windows.Forms.TextBox txtCaminhao;
    }
}

