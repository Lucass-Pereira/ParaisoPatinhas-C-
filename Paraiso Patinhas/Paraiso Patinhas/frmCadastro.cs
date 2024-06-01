using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Paraiso_Patinhas
{
    public partial class frmCadastro : Form
    {
        private ControleBD controleBD;
        public string Funcao { get; set; }
        public string User { get; set; }


        public frmCadastro()
        {
            InitializeComponent();

            controleBD = new ControleBD();

        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (Funcao == "cadastrar")
            {
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                txtPesquisa.Visible = false;
                lblPesquisa.Visible = false;
            }
            if (Funcao == "exibir")
            {
                txtUsuario.Enabled = false;
                txtNome.Enabled = false;
                txtEmail.Enabled = false;
                btnIncluir.Visible = false;
                txtPesquisa.Visible = false;
                lblPesquisa.Visible = false;
                CarregarDados(User);
            }
            if (Funcao == "adm")
            {
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtEmail.Enabled = false;
                txtNome.Enabled = false;
                txtTelefone.Enabled = false;
                txtEndereco.Enabled = false;
                btnIncluir.Visible = false;
                btnExcluir.Enabled = false;
                btnAlterar.Visible = false; 
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)

        {
            ControleBD inConn = new ControleBD();

            inConn.Usuario = this.txtUsuario.Text;
            inConn.Senha = this.txtSenha.Text;
            inConn.Email = this.txtEmail.Text;
            inConn.Nome = this.txtNome.Text;
            inConn.Telefone = this.txtTelefone.Text;
            inConn.Endereco = this.txtEndereco.Text;

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Os campos marcados com '*' não podem estar vazios. Por favor, preencha os campos.");
                return;
            }

            if (inConn.VerifIns())
            {
                inConn.Inserir();
                MessageBox.Show("Usuário criado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("O usuario ou email já está em uso. Por favor, use valores diferentes.");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ControleBD atConn = new ControleBD();

            atConn.Usuario = this.txtUsuario.Text;
            atConn.Senha = this.txtSenha.Text;
            atConn.Email = this.txtEmail.Text;
            atConn.Nome = this.txtNome.Text;
            atConn.Telefone = this.txtTelefone.Text;
            atConn.Endereco = this.txtEndereco.Text;

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Os campos marcados com '*' não podem estar vazios. Por favor, preencha os campos.");
                return;
            }
            else
            {
                atConn.Atualizar();
                MessageBox.Show("Dados atualizados com sucesso!");

                string tpusu = "u";
                string usu = txtUsuario.Text;

                frmMenu menu = new frmMenu
                {
                    UsuAdm = tpusu,
                    UsuLog = usu
                };
                menu.Show();
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            var resp = MessageBox.Show("Deseja excluir o registro " + this.txtUsuario.Text + "?",
                "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes && Funcao == "adm")
            {
                string delUsuario = txtUsuario.Text;
                ControleBD de = new ControleBD();
                de.Excluir(delUsuario);
                txtUsuario.Clear();

                string usu = "a";

                frmMenu menu = new frmMenu
                {
                    UsuAdm = usu
                };
                this.Close();
            }
            else if (resp == DialogResult.Yes && Funcao != "adm")
            {
                string delUsuario = txtUsuario.Text;
                ControleBD de = new ControleBD();
                de.Excluir(delUsuario);
                txtUsuario.Clear();

                string usu = "fechar";

                frmMenu menu = new frmMenu
                {
                    UsuAdm = usu
                };
                menu.Show();
                this.Close();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string exUsuario = this.txtPesquisa.Text;
            if (txtPesquisa.Text != "" && txtPesquisa.Text!= "admin")
            {

                DadosUsuario usuario = controleBD.CarregarDados(exUsuario);
                if (usuario != null)
                {
                    txtUsuario.Text = usuario.Usuario;
                    txtSenha.Text = usuario.Senha;
                    txtEmail.Text = usuario.Email;
                    txtNome.Text = usuario.Nome;
                    txtTelefone.Text = usuario.Telefone;
                    txtEndereco.Text = usuario.Endereco;
                    btnExcluir.Enabled = true;
                }
            }
           
        }

        private void CarregarDados(string nomeUsuario)
        {
            DadosUsuario usuario = controleBD.CarregarDados(nomeUsuario);
            if (usuario != null)
            {
                txtUsuario.Text = usuario.Usuario;
                txtSenha.Text = usuario.Senha;
                txtEmail.Text = usuario.Email;
                txtNome.Text = usuario.Nome;
                txtTelefone.Text = usuario.Telefone;
                txtEndereco.Text = usuario.Endereco;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }
    }
}
