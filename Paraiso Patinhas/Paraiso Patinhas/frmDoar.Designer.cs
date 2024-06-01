namespace Paraiso_Patinhas
{
    partial class frmDoar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnInsImg = new System.Windows.Forms.Button();
            this.pbPet = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira as informações sobre o pet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(14, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espécie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(38, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(52, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(38, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Porte:";
            // 
            // cbEspecie
            // 
            this.cbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Items.AddRange(new object[] {
            "",
            "Cão",
            "Gato"});
            this.cbEspecie.Location = new System.Drawing.Point(108, 195);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(191, 24);
            this.cbEspecie.TabIndex = 2;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "",
            "Macho",
            "Fêmea"});
            this.cbSexo.Location = new System.Drawing.Point(108, 245);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(191, 24);
            this.cbSexo.TabIndex = 3;
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "",
            "Preto",
            "Cinza",
            "Caramelo",
            "Branco"});
            this.cbCor.Location = new System.Drawing.Point(108, 300);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(191, 24);
            this.cbCor.TabIndex = 4;
            // 
            // cbPorte
            // 
            this.cbPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorte.FormattingEnabled = true;
            this.cbPorte.Items.AddRange(new object[] {
            "",
            "Pequeno",
            "Médio",
            "Grande"});
            this.cbPorte.Location = new System.Drawing.Point(108, 355);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(191, 24);
            this.cbPorte.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 140);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(191, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(43, 428);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(256, 79);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Doar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnInsImg
            // 
            this.btnInsImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsImg.Location = new System.Drawing.Point(452, 428);
            this.btnInsImg.Name = "btnInsImg";
            this.btnInsImg.Size = new System.Drawing.Size(300, 79);
            this.btnInsImg.TabIndex = 7;
            this.btnInsImg.Text = "Inserir Imagem";
            this.btnInsImg.UseVisualStyleBackColor = true;
            this.btnInsImg.Click += new System.EventHandler(this.btnInsImg_Click);
            // 
            // pbPet
            // 
            this.pbPet.Location = new System.Drawing.Point(452, 140);
            this.pbPet.Name = "pbPet";
            this.pbPet.Size = new System.Drawing.Size(300, 226);
            this.pbPet.TabIndex = 10;
            this.pbPet.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(357, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "*As imagens devem estar, preferencialmente, no formato 800x600\r\n";
            // 
            // frmDoar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paraiso_Patinhas.Properties.Resources.Tela_de_boas_vindas__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbPet);
            this.Controls.Add(this.btnInsImg);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbPorte);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmDoar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doação";
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.ComboBox cbPorte;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnInsImg;
        private System.Windows.Forms.PictureBox pbPet;
        private System.Windows.Forms.Label label7;
    }
}