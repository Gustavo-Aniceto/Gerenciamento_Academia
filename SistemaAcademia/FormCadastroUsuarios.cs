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
    public partial class FormCadastroUsuarios : Form
    {
        private SqlConnection conexao;

        // constantes para definir quais botões ficam habilitados no método SetStatusBotões
        private const int Alterando = 1;
        private const int Selecionando = 0;

        String idSelecionado;

        public FormCadastroUsuarios()
        {
            InitializeComponent();
            conexao = new SqlConnection(Conexao.stringConexao);
            carregarGridView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool exito;

            if (!ValidarCampos())
            {
                return;
            }

            // com base no id verifica se é uma alteração ou inserção
            if (idSelecionado.Equals(""))
            {
                exito = SalvarDados();
            }
            else
            {
                exito = AlterarDados();
            }

            if (exito)
            {
                // atualizado gridView
                SetStatusBotoes(Selecionando);
                HabilitarComponentes(false);
                carregarGridView();
            }
        }

        private bool SalvarDados()
        {

            bool flag = false;

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO tb_usuarios (usuario, senha,nome) " +
               "VALUES(@usuario, @senha, @nome) ", conexao);

                comando.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));
                comando.Parameters.Add(new SqlParameter("@senha", txtSenha.Text));
                comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));

                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso");
                flag = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
            }

            return flag;
        }

        private bool AlterarDados()
        {
            if (idSelecionado.Equals(""))
            {
                return false;
            }
            bool flag = false;

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("UPDATE tb_usuarios set usuario = @usuario, senha = @senha," +
                    "nome = @nome WHERE id = @id", conexao);

                comando.Parameters.Add(new SqlParameter("@id", idSelecionado));
                comando.Parameters.Add(new SqlParameter("@usuario", txtUsuario.Text));
                comando.Parameters.Add(new SqlParameter("@senha", txtSenha.Text));
                comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));

                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso");
                flag = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return flag;
        }

        private void carregarGridView()
        {
            try
            {
                var comando = "SELECT id, usuario, senha, nome FROM tb_usuarios ORDER BY usuario";
                var dataAdapter = new SqlDataAdapter(comando, conexao);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewUsuarios.DataSource = dataSet.Tables[0];

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
            // deixando toda as colunas invisíveis
            for (int i = 0; i < dataGridViewUsuarios.Columns.Count; i++)
            {
                dataGridViewUsuarios.Columns[i].Visible = false;
            }

            //Alguns campos visíveis
            dataGridViewUsuarios.Columns[1].Visible = true;
            dataGridViewUsuarios.Columns[3].Visible = true;
            dataGridViewUsuarios.Columns[3].Width = 200;

            // selecionando a primeira linha
            dataGridViewUsuarios.Rows[0].Selected = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // verifica se o usuário estava em modo edição ao tentar selecionar a table, para não perder seus dados
            // por acidente
            if (btnSalvar.Enabled)
            {
                MessageBox.Show("Cancele o cadastro ou edição para selecionar a tabela");
                return;
            }

            carregarCampos();
            HabilitarComponentes(false);
            SetStatusBotoes(Selecionando);
        }

        private void carregarCampos()
        {
            // evitando indexes fora de limites
            if (dataGridViewUsuarios.SelectedCells.Count == 0)
            {
                return;
            }
            try
            {
                txtUsuario.Text = dataGridViewUsuarios.SelectedCells[1].Value.ToString();
                txtSenha.Text = dataGridViewUsuarios.SelectedCells[2].Value.ToString();
                txtNome.Text = dataGridViewUsuarios.SelectedCells[3].Value.ToString();
                idSelecionado = dataGridViewUsuarios.SelectedCells[0].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String usuario = txtNome.Text;

            var confirmResult = MessageBox.Show("Deseja mesmo excluir o usuário " + usuario,
                "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            try
            {
                conexao.Open();

                var comando = new SqlCommand("Delete from tb_usuarios WHERE id = " +
                    "@id", conexao);
                comando.Parameters.Add(new SqlParameter("@id", idSelecionado));
                comando.ExecuteNonQuery();

                carregarGridView();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos(sender);
            HabilitarComponentes(true);
            SetStatusBotoes(Alterando);
            txtUsuario.Focus();
            idSelecionado = "";
        }

        private void LimparCampos(object sender)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtNome.Text = String.Empty;
        }

        private void HabilitarComponentes(bool status)
        {
            txtUsuario.ReadOnly = !status;
            txtSenha.ReadOnly = !status;
            txtNome.ReadOnly = !status;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarComponentes(true);
            SetStatusBotoes(Alterando);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(sender);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (idSelecionado.Equals(""))
            {
                LimparCampos(sender);
            }
            else
            {
                carregarCampos();
            }
            HabilitarComponentes(false);
            SetStatusBotoes(Selecionando);
        }

        private void SetStatusBotoes(int status)
        {
            // Defini quais botões serão habilitados ou desabilitados de acordo com a ação
            bool alterar = false;

            if (status == Alterando)
            {
                alterar = true;
            }
            else if (status == Selecionando)
            {
                alterar = false;
            }

            btnNovo.Enabled = !alterar;
            btnSalvar.Enabled = alterar;
            btnEditar.Enabled = !alterar;
            btnCancelar.Enabled = alterar;
            btnExcluir.Enabled = !alterar;
            btnLimpar.Enabled = alterar;
        }

        private bool ValidarCampos()
        {
            if (txtSenha.TextLength < 5)
            {
                MessageBox.Show("Senha deve conter pelo menos 5 caracteres");
                txtSenha.Focus();
                return false;
            }
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo usuário");
                txtUsuario.Focus();
                return false;
            }
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo nome");
                txtNome.Focus();
                return false;
            }
            return true;
        }
    }
}
