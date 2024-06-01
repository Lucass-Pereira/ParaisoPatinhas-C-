
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paraiso_Patinhas
{
    public class ControlePet

    {
     
        readonly string strConexao = @"Data Source=DESKTOP-GTF77OL\SQLEXPRESS;Initial Catalog=dbo;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public const string strINSERTPET = "INSERT INTO pet_patinhas (especie, nome, sexo, cor, porte, caminho_img) " +
             "VALUES( @Especie, @Nome, @Sexo, @Cor, @Porte, @Caminho_img); ";


        private const string strDELETEPET = "DELETE FROM pet_patinhas WHERE id = @Id";


        public const string strCARREGARPET = "SELECT * FROM pet_patinhas; ";

        public const string strSELECTIMG = "SELECT * FROM pet_patinhas WHERE id = @Id";


        public void InserirPet(string especiePet, string nomePet, string sexoPet, string corPet, string portePet, string caminhoNvImg)
        {
            using (SqlConnection inConn = new SqlConnection(strConexao))
            {
                using (SqlCommand inCmd = new SqlCommand(strINSERTPET, inConn))
                {
                    inCmd.Parameters.AddWithValue("@Especie", especiePet);
                    inCmd.Parameters.AddWithValue("@Nome", nomePet);
                    inCmd.Parameters.AddWithValue("@Sexo", sexoPet); 
                    inCmd.Parameters.AddWithValue("@Cor", corPet);
                    inCmd.Parameters.AddWithValue("@Porte", portePet);
                    inCmd.Parameters.AddWithValue("@Caminho_Img", caminhoNvImg);

                    inConn.Open();
                    inCmd.ExecuteNonQuery();
                    inConn.Close();
                }
            }
        }

        public void ExcluirPet(string idPet)
        {
            using (SqlConnection deConn = new SqlConnection(strConexao))
            {
                using (SqlCommand deCmd = new SqlCommand(strDELETEPET, deConn))
                {
                    deCmd.Parameters.AddWithValue("@Id", idPet);

                    deConn.Open();
                    deCmd.ExecuteNonQuery();
                    deConn.Close();
                }
            }
        }
 
        public DataTable ListarPet(string especiePet, string sexoPet, string corPet, string portePet)
        { 
            using (SqlConnection quConn = new SqlConnection(strConexao))
            {
                quConn.Open();

                string strQUERYPET = "SELECT id, especie, nome, sexo, cor, porte, caminho_img FROM pet_patinhas WHERE 1=1";

                if (!string.IsNullOrEmpty(especiePet)) strQUERYPET += " AND especie = @especie";
                if (!string.IsNullOrEmpty(sexoPet)) strQUERYPET += " AND sexo = @sexo";
                if (!string.IsNullOrEmpty(corPet)) strQUERYPET += " AND cor = @cor";
                if (!string.IsNullOrEmpty(portePet)) strQUERYPET += " AND porte = @porte";

                using (SqlCommand quCmd = new SqlCommand(strQUERYPET, quConn))
                {
                    if (!string.IsNullOrEmpty(especiePet)) quCmd.Parameters.AddWithValue("@especie", especiePet);
                    if (!string.IsNullOrEmpty(sexoPet)) quCmd.Parameters.AddWithValue("@sexo", sexoPet);
                    if (!string.IsNullOrEmpty(corPet)) quCmd.Parameters.AddWithValue("@cor", corPet);
                    if (!string.IsNullOrEmpty(portePet)) quCmd.Parameters.AddWithValue("@porte", portePet);

                    SqlDataAdapter da = new SqlDataAdapter(quCmd);
                    DataTable dtRet = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(quCmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    quConn.Close();
                    return dataTable;
                }
            }
            
        }

    }

    
}
