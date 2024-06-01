namespace Paraiso_Patinhas
{
    partial class frmAdotar
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
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPorte = new System.Windows.Forms.ComboBox();
            this.pbPet = new System.Windows.Forms.PictureBox();
            this.btnAdotar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPets
            // 
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPets.Location = new System.Drawing.Point(21, 355);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.RowHeadersWidth = 51;
            this.dgvPets.RowTemplate.Height = 24;
            this.dgvPets.Size = new System.Drawing.Size(740, 186);
            this.dgvPets.TabIndex = 0;
            this.dgvPets.SelectionChanged += new System.EventHandler(this.dgvPets_SelectionChanged);
            // 
            // cbEspecie
            // 
            this.cbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Items.AddRange(new object[] {
            "",
            "Cão",
            "Gato"});
            this.cbEspecie.Location = new System.Drawing.Point(21, 138);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(191, 24);
            this.cbEspecie.TabIndex = 1;
            this.cbEspecie.SelectedIndexChanged += new System.EventHandler(this.cbEspecie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione a Espécie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(16, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "",
            "Macho",
            "Fêmea"});
            this.cbSexo.Location = new System.Drawing.Point(21, 196);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(191, 24);
            this.cbSexo.TabIndex = 3;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(16, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione a Cor:";
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
            this.cbCor.Location = new System.Drawing.Point(21, 254);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(191, 24);
            this.cbCor.TabIndex = 5;
            this.cbCor.SelectedIndexChanged += new System.EventHandler(this.cbCor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(16, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione o Porte:";
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
            this.cbPorte.Location = new System.Drawing.Point(21, 312);
            this.cbPorte.Name = "cbPorte";
            this.cbPorte.Size = new System.Drawing.Size(191, 24);
            this.cbPorte.TabIndex = 7;
            this.cbPorte.SelectedIndexChanged += new System.EventHandler(this.cbPorte_SelectedIndexChanged);
            // 
            // pbPet
            // 
            this.pbPet.Location = new System.Drawing.Point(461, 110);
            this.pbPet.Name = "pbPet";
            this.pbPet.Size = new System.Drawing.Size(300, 226);
            this.pbPet.TabIndex = 9;
            this.pbPet.TabStop = false;
            this.pbPet.Click += new System.EventHandler(this.pbPet_Click);
            // 
            // btnAdotar
            // 
            this.btnAdotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdotar.Location = new System.Drawing.Point(240, 120);
            this.btnAdotar.Name = "btnAdotar";
            this.btnAdotar.Size = new System.Drawing.Size(190, 52);
            this.btnAdotar.TabIndex = 10;
            this.btnAdotar.Text = "Adotar";
            this.btnAdotar.UseVisualStyleBackColor = true;
            this.btnAdotar.Click += new System.EventHandler(this.btnAdotar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(16, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selecione um pet na lista para iniciar a adoção:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(343, 19);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(44, 16);
            this.lbl6.TabIndex = 12;
            this.lbl6.Text = "label6";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(240, 120);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(190, 52);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmAdotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paraiso_Patinhas.Properties.Resources.Tela_de_boas_vindas__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdotar);
            this.Controls.Add(this.pbPet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.dgvPets);
            this.DoubleBuffered = true;
            this.Name = "frmAdotar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adote";
            this.Load += new System.EventHandler(this.frmAdotar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPorte;
        private System.Windows.Forms.PictureBox pbPet;
        private System.Windows.Forms.Button btnAdotar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btnExcluir;
    }
}