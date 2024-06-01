using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paraiso_Patinhas
{
    public partial class frmDoar : Form
    {
        private ControlePet controlePet;
        public string Funcao { get; set; }

        private string caminhoAntImg;

        public frmDoar()
        {
            InitializeComponent();
            controlePet = new ControlePet();  

    }
        private void btnInsImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog adImg = new OpenFileDialog();
            adImg.InitialDirectory = "c:\\";
            adImg.Filter = "Arquivos de imagem (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            adImg.FilterIndex = 1;
            adImg.RestoreDirectory = true;

            if (adImg.ShowDialog() == DialogResult.OK)
            {
                caminhoAntImg = adImg.FileName;

                try
                {
                    pbPet.Image = System.Drawing.Image.FromFile(caminhoAntImg);
                    pbPet.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                }
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (pbPet.Image == null)
            {
                if (string.IsNullOrEmpty(cbEspecie.Text) || string.IsNullOrEmpty(cbSexo.Text) ||
                    string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(cbCor.Text) ||
                    string.IsNullOrEmpty(cbPorte.Text))
                {
                    MessageBox.Show("Preencha todos os dados");
                    return;
                }

                string especiePet = this.cbEspecie.Text;
                string nomePet = this.txtNome.Text;
                string sexoPet = this.cbSexo.Text;
                string corPet = this.cbCor.Text;
                string portePet = this.cbPorte.Text;
                string caminhoImg = "";

                controlePet.InserirPet(especiePet, nomePet, sexoPet, corPet, portePet, caminhoImg);

                MessageBox.Show("Pet adicionado com sucesso");

                this.Close();
            }
            else
            {
                if (string.IsNullOrEmpty(cbEspecie.Text) || string.IsNullOrEmpty(cbSexo.Text) ||
                    string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(cbCor.Text) ||
                    string.IsNullOrEmpty(cbPorte.Text))
                {
                    MessageBox.Show("Todos os dados devem ser preenchidos");
                    return;
                }

                string nvNomeImg = txtNome.Text.Trim();

                string pastaDestino = @"C:\TESTE IMAGENS DO PROJETO";

                if (!Directory.Exists(pastaDestino))
                {
                    Directory.CreateDirectory(pastaDestino);
                }
                string extensao = Path.GetExtension(caminhoAntImg);

                string nvCaminhoImg = Path.Combine(pastaDestino, nvNomeImg + extensao);
               
                try
                {
                    File.Copy(caminhoAntImg, nvCaminhoImg, true);
                    MessageBox.Show("Pet inserido com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a imagem: " + ex.Message);
                }

                string especiePet = this.cbEspecie.Text;
                    string nomePet = this.txtNome.Text;
                    string sexoPet = this.cbSexo.Text;
                    string corPet = this.cbCor.Text;
                    string portePet = this.cbPorte.Text;
                

                controlePet.InserirPet(especiePet, nomePet, sexoPet, corPet, portePet, nvCaminhoImg);
                this.Close();
                
            }
        }
    }
}
