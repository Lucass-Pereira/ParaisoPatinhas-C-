using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paraiso_Patinhas
{
    public partial class frmMenu : Form
    {
        public string UsuLog { get; set; }
        public string UsuAdm { get; set; }
    
    
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(UsuAdm == "fechar")
            {
                this.Close();
            }

            if (UsuAdm == "u")
            {   
                lblCadastro.Text = "Meu Cadastro   ";
                lblBoasVindas.Text = "Bem-Vindo " + UsuLog;
                lblUsuario.Visible = false;
                lblUsuario.Text = UsuLog;  
            }
            else if(UsuAdm == "a") {
                lblCadastro.Text = "Usuarios  ";
                lblBoasVindas.Text = "Administrador ";
                lblUsuario.Visible = false;
                btnAdotar.Text = "Gestão de Pets ";
                btnDoar.Visible = false;
            } 
            else
            {
                lblCadastro.Text = "Cadastrar    ";
                btnAdotar.Enabled = false;
                lblBoasVindas.Text = "Bem-vindo";
                lblUsuario.Visible = false;
            }
    }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            if (lblCadastro .Text == "Cadastrar    ")
            {
               

                string func = "cadastrar";

                frmCadastro exCadastro = new frmCadastro
                {
                    Funcao = func
                };
                exCadastro.Show();
                this.Close();
            }

            else if (lblCadastro.Text == "Meu Cadastro   ")
            {
                string func = "exibir";
                string user = lblUsuario.Text;

                frmCadastro exCadastro = new frmCadastro
                {
                    Funcao = func,
                    User = user
                };
                exCadastro.Show();
                this.Close();

            }

            else if (lblCadastro.Text == "Usuarios  ")
            {
                string func = "adm";

                frmCadastro exCadastro = new frmCadastro
                {
                    Funcao = func,
                };
                exCadastro.Show();
            }
        }
        
        private void btnAdotar_Click(object sender, EventArgs e)
        {
            if(btnAdotar.Text == "Gestão de Pets ")
            {
                    string func = "a";
                    frmAdotar exAdocao = new frmAdotar
                    {
                        Funcao = func
                    };
                    exAdocao.Show();
            }
            else
            {
                string func = "u";
                frmAdotar exAdocao = new frmAdotar
                {
                    Funcao = func
                    };
                exAdocao.Show();
            }
        }
        
        private void btnDoar_Click(object sender, EventArgs e)
        {
            if (btnDoar.Text == "Quero Doar  ")
            {
                string func = "doacao";
                frmDoar exDoacao = new frmDoar
                {
                    Funcao = func

                };
                exDoacao.Show();
            }
            else
            {
                string func = "gestao";
                frmDoar exDoacao = new frmDoar
                {
                    Funcao = func

                };
                exDoacao.Show();
            }
        }

        private void btnPet_Click(object sender, EventArgs e)
        {

        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
