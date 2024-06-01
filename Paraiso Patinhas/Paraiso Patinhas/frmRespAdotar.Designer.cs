namespace Paraiso_Patinhas
{
    partial class frmRespAdotar
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
            this.lbllParabens = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbllParabens
            // 
            this.lbllParabens.AutoSize = true;
            this.lbllParabens.BackColor = System.Drawing.Color.Transparent;
            this.lbllParabens.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllParabens.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbllParabens.Location = new System.Drawing.Point(256, 30);
            this.lbllParabens.Name = "lbllParabens";
            this.lbllParabens.Size = new System.Drawing.Size(290, 65);
            this.lbllParabens.TabIndex = 0;
            this.lbllParabens.Text = "Parabéns!";
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.BackColor = System.Drawing.Color.Transparent;
            this.lblInstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblInstrucao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInstrucao.Location = new System.Drawing.Point(97, 114);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(580, 36);
            this.lblInstrucao.TabIndex = 1;
            this.lblInstrucao.Text = "Em breve nossa equipe entrará em contato";
            // 
            // frmRespAdotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paraiso_Patinhas.Properties.Resources.Tela_de_boas_vindas__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.lbllParabens);
            this.DoubleBuffered = true;
            this.Name = "frmRespAdotar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adoção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllParabens;
        private System.Windows.Forms.Label lblInstrucao;
    }
}