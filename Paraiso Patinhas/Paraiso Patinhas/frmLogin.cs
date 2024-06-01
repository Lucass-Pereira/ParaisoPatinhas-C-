using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paraiso_Patinhas
{
    public partial class frmLogin : Form
    {
        private ControleBD controleBD;
        public frmLogin()
        {
            InitializeComponent();
            controleBD = new ControleBD();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text; 
            ControleBD enConn = new ControleBD(); 
            enConn.Usuario = this.txtUsuario.Text;
            enConn.Senha = this.txtSenha.Text;

            bool admin = controleBD.VerifAdm(user);
            if (admin == true && enConn.Entrar())   
            {
                    string usu = txtUsuario.Text;
                    string adm = "a";

                    frmMenu menu = new frmMenu
                    {
                        UsuLog = usu,
                        UsuAdm = adm
                    };
                    menu.Show();

                    this.txtUsuario.Clear();
                    this.txtSenha.Clear();
                }
            else if(admin == false && enConn.Entrar())
            {
                string usu = txtUsuario.Text;
                string adm = "u";

                    frmMenu menu = new frmMenu
                    {
                        UsuLog = usu,
                        UsuAdm = adm
                    };
                    menu.Show();

                    this.txtUsuario.Clear();
                    this.txtSenha.Clear();              
            } 
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
                this.txtUsuario.Clear();
                this.txtSenha.Clear();

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string func = "cadastrar";

            frmCadastro exCadastro = new frmCadastro
            {
                Funcao = func
            };
            exCadastro.Show();
        }

        private void btnEntrarSL_Click(object sender, EventArgs e)
            {
                this.txtUsuario.Clear();
                this.txtSenha.Clear();

                string usu = "";

                frmMenu menu = new frmMenu
                {
                    UsuAdm = usu
                };
                menu.Show();
            }
        }
}
