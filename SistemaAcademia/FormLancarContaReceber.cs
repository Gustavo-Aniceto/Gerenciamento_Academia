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
    public partial class FormLancarContaReceber : Form
    {
        public FormLancarContaReceber()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            using (var telaProcurarAluno = new FormProcuraAluno(txtMatricula, txtNome))
            {
                telaProcurarAluno.ShowDialog();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }

            String valorConta = txtValor.Text.Replace(",", ".");

            var conexao = new SqlConnection(Conexao.stringConexao);
            try
            {
                conexao.Open();
                var comando = new SqlCommand("INSERT INTO tb_contas_receber (data_vencimento," +
                    "valor, matricula_aluno, descricao) values (@data_vencimento," +
                    "@valor, @matricula_aluno, @descricao)", conexao);

                comando.Parameters.AddWithValue("@data_vencimento", dateTimePickerVencimento.Value.Date);
                comando.Parameters.AddWithValue("@valor", valorConta);
                comando.Parameters.AddWithValue("@matricula_aluno", txtMatricula.Text);
                comando.Parameters.AddWithValue("@descricao", comboBoxServico.SelectedText);
                comando.ExecuteNonQuery();
                MessageBox.Show("Conta lançada");
                this.Close();
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

        private bool validarCampos()
        {
            if(txtNome.TextLength == 0)
            {
                MessageBox.Show("Digite uma matrícula válida");
                txtMatricula.Focus();
                return false;
            }


            var matricula = txtMatricula.Text;
            
            try
            {
                Convert.ToUInt32(matricula);
            }
            catch (Exception)
            {
                MessageBox.Show("Valor inválido de matrícula");
                txtMatricula.Focus();
                return false;
            }

            if(txtMatricula.TextLength == 0)
            {
                MessageBox.Show("Preencha a matrícula do aluno");
                txtMatricula.Focus();
                return false;
            }

            if (comboBoxServico.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma descrição");
                return false;
            }

            try
            {
                var valor = Convert.ToDecimal(txtValor.Text);
                if (valor < 0)
                {
                    MessageBox.Show("Valor inferior a 0");
                    txtValor.Focus();
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Valor inválido");
                txtValor.Focus();
                return false;
            }

            if (dateTimePickerVencimento.Value.Date < DateTime.Today)
            {

                 var confirm = MessageBox.Show("A data de vencimento é realmente menor que a " +
                     "data atual?", "Confirma?",
                    MessageBoxButtons.YesNo);

                if(confirm == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        private void txtMatricula_Leave(object sender, EventArgs e)
        {
            var conexao = new SqlConnection(Conexao.stringConexao);

            try
            {
                conexao.Open();

                var comando = new SqlCommand("SELECT nome FROM tb_alunos WHERE " +
                    "matricula = @matricula", conexao);
                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtNome.Text = reader.GetString(0);
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado");
                    txtNome.Text = String.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Matrícula inválida\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServico.SelectedIndex == 0 && txtMatricula.TextLength > 0)
            {
                using(var conexao = new SqlConnection(Conexao.stringConexao))
                {
                    try
                    {
                        conexao.Open();
                        var comando = new SqlCommand("SELECT valor FROM tb_matriculas WHERE " +
                            "matricula = @matricula");
                        comando.Connection = conexao;
                        comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                        SqlDataReader leitor = comando.ExecuteReader();
                        if (leitor.Read())
                        {
                            txtValor.Text = leitor.GetDecimal(0).ToString();
                        }
                        leitor.Close();
                        comando.Dispose();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                    }
                }
            }
        }
    }
}
