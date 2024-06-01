using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Paraiso_Patinhas
{

    public partial class frmAdotar : Form
    {
        public string Funcao { get; set; }

        private ControlePet controlePet;
        
        public frmAdotar()
        {
            
            InitializeComponent();

            controlePet = new ControlePet();

            
            
            Carregar();

        }
        
        private void frmAdotar_Load(object sender, EventArgs e)
        {
            if (Funcao == "u")
            {
                btnAdotar.Visible = true;
                btnExcluir.Visible = false;  
            }
            else if (Funcao == "a")
            {
                btnAdotar.Visible = false;
                btnExcluir.Visible = true;
            }

        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar();

        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar();
        }

        private void cbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar();
        }

        private void cbPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar();
        }

        private void pbPet_Click(object sender, EventArgs e)
        {

        }

        private void btnAdotar_Click(object sender, EventArgs e)
        {
            string idPet = dgvPets.Rows[dgvPets.CurrentRow.Index].Cells[0].Value.ToString();
            string nomePet = dgvPets.Rows[dgvPets.CurrentRow.Index].Cells[2].Value.ToString();

            var resp = MessageBox.Show("Deseja adotar " + nomePet + "?",
                "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                controlePet.ExcluirPet(idPet);
                frmRespAdotar respAdotar = new frmRespAdotar();
                respAdotar.Show();
                this.Close();
            }
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string idPet = dgvPets.Rows[dgvPets.CurrentRow.Index].Cells[0].Value.ToString();
            string nomePet = dgvPets.Rows[dgvPets.CurrentRow.Index].Cells[2].Value.ToString();

            var resp = MessageBox.Show("Deseja excluir " + nomePet + "?",
                "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                controlePet.ExcluirPet(idPet);
                Carregar();
            }

        }

        private void Carregar()
        {
            string especiePet = this.cbEspecie.Text;
            string sexoPet = this.cbSexo.Text;
            string corPet = this.cbCor.Text;
            string portePet = this.cbPorte.Text;


            DataTable data = controlePet.ListarPet(especiePet, sexoPet, corPet, portePet);
            dgvPets.DataSource = data;

            if (dgvPets.Columns["id"] != null)
            {
                dgvPets.Columns["id"].Visible = false;
                dgvPets.Columns["caminho_img"].Visible = false;
            }

        }
       
        private void dgvPets_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}