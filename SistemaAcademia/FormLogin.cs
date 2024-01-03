using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class FormLogin : Form
    {
        private SqlConnection conexao;


        public FormLogin()
        {
            InitializeComponent();
            conexao = new SqlConnection(Conexao.stringConexao);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                var comando = new SqlCommand ("SELECT nome, id, senha FROM tb_usuarios WHERE usuario = @usuario",
                    conexao);
                comando.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));

                var leitor = comando.ExecuteReader();

                if(leitor.Read())
                {
                    String nome = leitor.GetString(0);
                    int codigoUsuario = leitor.GetInt32(1);
                    String senha = leitor.GetString(2);

                    if (senha.Equals(txtSenha.Text))
                    {
                        using (var formTelaPrincipal = new FormTelaPrincipal(nome, codigoUsuario))
                        {
                            this.Visible = false;
                            formTelaPrincipal.ShowDialog();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(this, new EventArgs());
            }
        }
    }
}
