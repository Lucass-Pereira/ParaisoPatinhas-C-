using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paraiso_Patinhas
{
    public class ControleBD
    
    {   public string Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Adm { get; set; }


        readonly string strConexao = @"Data Source=DESKTOP-GTF77OL\SQLEXPRESS;Initial Catalog=dbo;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public const string strENTRARUSU = "SELECT COUNT(1) FROM usu_patinhas WHERE usuario = @Usuario AND senha = @Senha";
        
        public const string strVERIFADM = "SELECT adm FROM usu_patinhas WHERE usuario = @Usuario";

        public const string strINSERTUSU = "INSERT INTO usu_patinhas (usuario, senha, email, nome, telefone, endereco) " +
             "VALUES( @Usuario, @Senha, @Email, @Nome, @Telefone, @Endereco); ";
        
        public const string strVERIFINS = "SELECT COUNT(*) FROM usu_patinhas WHERE usuario = @Usuario OR email = @Email";

        public const string strSELECTUSU = "SELECT * FROM usu_patinhas; ";

        public const string strCARREGARUSU = "SELECT * FROM usu_patinhas WHERE usuario = @Usuario; ";

        private const string strDELETEUSU = "DELETE FROM usu_patinhas WHERE usuario = @Usuario";

        public const string strUPDATEUSU = "UPDATE usu_patinhas SET senha = @Senha, email = @Email, " +
            "telefone = @Telefone, endereco = @Endereco WHERE usuario = @Usuario ";


        public const string strSELECTPET = "SELECT * FROM pet_patinhas; ";


        public bool Entrar()
        {
            using (SqlConnection enConn = new SqlConnection(strConexao))
            {
                using (SqlCommand enCmd = new SqlCommand(strENTRARUSU, enConn))
                {
                    enCmd.Parameters.AddWithValue("@Usuario", Usuario);
                    enCmd.Parameters.AddWithValue("@Senha", Senha);

                    enConn.Open();
                    int count = (int)enCmd.ExecuteScalar();
                    enConn.Close();
                    return count == 1; 
                }               
            }
        }

        public bool VerifAdm(string user)
        {
            bool admin = false;

            using (SqlConnection enConn = new SqlConnection(strConexao))
            {
                SqlCommand enCmd = new SqlCommand(strVERIFADM, enConn);
                enCmd.Parameters.AddWithValue("@Usuario", user);

                try
                {
                    enConn.Open();
                    SqlDataReader ler = enCmd.ExecuteReader();

                    if (ler.Read())
                    {
                        string valorAdm = ler["adm"].ToString();
                        if (valorAdm == "S")
                        {
                            admin = true;
                        }
                    }
                    
                    ler.Close();
                }

                finally
                {
                    enConn.Close();
       
                }
                return admin;
            }
        }

            public void Inserir()
        {
            using (SqlConnection inConn = new SqlConnection(strConexao))
            {
                using (SqlCommand inCmd = new SqlCommand(strINSERTUSU , inConn))
                {
                    inCmd.Parameters.AddWithValue("@Usuario", Usuario);
                    inCmd.Parameters.AddWithValue("@Senha", Senha);
                    inCmd.Parameters.AddWithValue("@Email", Email);
                    inCmd.Parameters.AddWithValue("@Nome", Nome);
                    inCmd.Parameters.AddWithValue("@Telefone", Telefone);
                    inCmd.Parameters.AddWithValue("@Endereco", Endereco);

                    inConn.Open();
                    inCmd.ExecuteNonQuery();
                    inConn.Close();
                }
            }
        }

        public bool VerifIns()
        {
            using (SqlConnection inConn = new SqlConnection(strConexao))
            {
                
                using (SqlCommand viCmd = new SqlCommand(strVERIFINS, inConn))
                {
                    inConn.Open();
                    viCmd.Parameters.AddWithValue("@Usuario", Usuario);
                    viCmd.Parameters.AddWithValue("@Email", Email);
                    int count = (int)viCmd.ExecuteScalar();
                    inConn.Close();
                    return count == 0;
                    
                }
            }
        }

        public DadosUsuario CarregarDados(string nomeUsuario)
        {
            using (SqlConnection exConn = new SqlConnection(strConexao))
            {
                using (SqlCommand exCmd = new SqlCommand(strCARREGARUSU, exConn))
                {
                    exCmd.Parameters.AddWithValue("@Usuario", nomeUsuario);

                    try
                    {
                        exConn.Open();
                        SqlDataReader ler = exCmd.ExecuteReader();

                        if (ler.Read())
                        {
                            return new DadosUsuario
                            {
                                Usuario = ler["Usuario"].ToString(),
                                Senha = ler["Senha"].ToString(),
                                Email = ler["Email"].ToString(),
                                Nome = ler["Nome"].ToString(),
                                Telefone = ler["Telefone"].ToString(),
                                Endereco = ler["Endereco"].ToString()
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao obter dados do usuário: " + ex.Message);
                    }
                    finally {
                        exConn.Close();
                    }
                }
            }
        }

        public void Atualizar()
        {
            using (SqlConnection atConn = new SqlConnection(strConexao))
            {
                using (SqlCommand atCmd = new SqlCommand(strUPDATEUSU, atConn))
                {
                    atCmd.Parameters.AddWithValue("@Usuario", Usuario);
                    atCmd.Parameters.AddWithValue("@Senha", Senha);
                    atCmd.Parameters.AddWithValue("@Email", Email);
                    atCmd.Parameters.AddWithValue("@Nome", Nome);
                    atCmd.Parameters.AddWithValue("@Telefone", Telefone);
                    atCmd.Parameters.AddWithValue("@Endereco", Endereco);
                    atConn.Open();
                    atCmd.ExecuteNonQuery();
                    atConn.Close();
                }
            }
        }


        public void Excluir(string delUsuario)
        {
                using (SqlConnection deConn = new SqlConnection(strConexao))
            {
                using (SqlCommand deCmd = new SqlCommand(strDELETEUSU, deConn))
                {
                    deCmd.Parameters.AddWithValue("@Usuario", delUsuario);

                    deConn.Open();
                    deCmd.ExecuteNonQuery();
                    deConn.Close();
                }
            }
        }



        public DataTable Listar()
        {
            DataTable dtRet = new DataTable();
            using (SqlConnection oConnection = new SqlConnection(strConexao))
            {
                using (SqlCommand oCommand = new SqlCommand(strSELECTPET, oConnection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(oCommand);

                    oConnection.Open();
                    da.Fill(dtRet);
                    oConnection.Close();
                }
            }
            return dtRet;
        }


    }
}