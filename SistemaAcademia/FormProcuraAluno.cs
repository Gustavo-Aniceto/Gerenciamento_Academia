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
    public partial class FormProcuraAluno : Form
    {

        private SqlConnection conexao;
        //textbox do form pai
        TextBox txtMatricula;
        TextBox txtNome;

        public FormProcuraAluno()
        {
            InitializeComponent();
            conexao = new SqlConnection(Conexao.stringConexao);
            carregarGridView();
            
        }

        public FormProcuraAluno(TextBox txtPesquisaMatricula):
            this()
        {
            txtMatricula = txtPesquisaMatricula;
        }

        public FormProcuraAluno(TextBox txtPesquisaMatricula, TextBox txtPesquisaNome) :
            this(txtPesquisaMatricula)
        {
            txtNome= txtPesquisaNome;
        }




        private void carregarGridView()
        {
            try
            {
                var comando = "SELECT matricula, nome FROM tb_alunos ORDER BY nome";
                var dataAdapter = new SqlDataAdapter(comando, conexao);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewAlunos.DataSource = dataSet.Tables[0];

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }


            dataGridViewAlunos.Columns[1].Width = 300;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String pesquisa =  "nome like  '%" + txtNomeConsulta.Text + "%'";
           
            try
            {
                if (txtNomeConsulta.TextLength > 0)
                {
                    (dataGridViewAlunos.DataSource as DataTable).DefaultView.RowFilter = pesquisa;
                }
                else
                {
                    (dataGridViewAlunos.DataSource as DataTable).DefaultView.RowFilter = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNomeConsulta.Text = "";
            }
        }

        private void dataGridViewAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtMatricula.Text = dataGridViewAlunos.SelectedCells[0].Value.ToString();
                if(txtNome != null)
                {
                    txtNome.Text = dataGridViewAlunos.SelectedCells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
            
            
        }
    }
}
