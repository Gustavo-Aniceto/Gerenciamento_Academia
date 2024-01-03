using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademia
    {
        class Conexao
        {
            // Adicione o caminho do banco de dados
            public static String stringConexao = "Data Source=SeuServidor;Initial Catalog=SeuBancoDeDados;Integrated Security=True;";

            // Método para abrir uma conexão
            public static SqlConnection AbrirConexao()
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(stringConexao);
                    conexao.Open();
                    return conexao;
                }
                catch (Exception ex)
                {
                    // Lide com exceções aqui ou apenas jogue-as para o chamador
                    throw new Exception("Erro ao abrir a conexão com o banco de dados: " + ex.Message);
                }
            }

            // Método para fechar uma conexão
            public static void FecharConexao(SqlConnection conexao)
            {
                try
                {
                    if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Lide com exceções aqui ou apenas jogue-as para o chamador
                    throw new Exception("Erro ao fechar a conexão com o banco: " + ex.Message);
                }
            }
        }
    }

