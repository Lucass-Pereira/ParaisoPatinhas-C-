namespace Paraiso_Patinhas
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblCadastro = new System.Windows.Forms.ToolStripLabel();
            this.btnAdotar = new System.Windows.Forms.ToolStripButton();
            this.lblSair = new System.Windows.Forms.ToolStripLabel();
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnDoar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCadastro,
            this.btnAdotar,
            this.btnDoar,
            this.lblSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblCadastro
            // 
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(117, 24);
            this.lblCadastro.Text = "Meu Cadastro    ";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            // 
            // btnAdotar
            // 
            this.btnAdotar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdotar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdotar.Image")));
            this.btnAdotar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdotar.Name = "btnAdotar";
            this.btnAdotar.Size = new System.Drawing.Size(120, 24);
            this.btnAdotar.Text = "Quero Adotar    ";
            this.btnAdotar.Click += new System.EventHandler(this.btnAdotar_Click);
            // 
            // lblSair
            // 
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(54, 24);
            this.lblSair.Text = "   Sair  ";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.Transparent;
            this.lblBoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBoasVindas.Location = new System.Drawing.Point(12, 52);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(108, 25);
            this.lblBoasVindas.TabIndex = 1;
            this.lblBoasVindas.Text = "Bem Vindo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(117, 52);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "label1";
            // 
            // btnDoar
            // 
            this.btnDoar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDoar.Image = ((System.Drawing.Image)(resources.GetObject("btnDoar.Image")));
            this.btnDoar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoar.Name = "btnDoar";
            this.btnDoar.Size = new System.Drawing.Size(99, 24);
            this.btnDoar.Text = "Quero Doar  ";
            this.btnDoar.Click += new System.EventHandler(this.btnDoar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paraiso_Patinhas.Properties.Resources.Tela_de_boas_vindas__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblCadastro;
        private System.Windows.Forms.ToolStripLabel lblSair;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripButton btnAdotar;
        private System.Windows.Forms.ToolStripButton btnDoar;
    }
}