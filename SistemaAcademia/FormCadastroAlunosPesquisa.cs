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
    


    public partial class FormCadastroAlunosPesquisa : Form
    {

        private SqlConnection conexao;

        public FormCadastroAlunosPesquisa()
        {
            InitializeComponent();
            conexao = new SqlConnection(Conexao.stringConexao);
            comboBoxListar.SelectedIndex = 0;
            carregarGridViewAlunos();
            contaAtivosInativos();
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (var telaCadastroAlunos = new FormCadastroAlunos())
            {
                telaCadastroAlunos.ShowDialog();
                carregarGridViewAlunos();
                contaAtivosInativos();
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (dataGridViewAlunos.SelectedCells == null)
            {
                MessageBox.Show("Selecione um aluno");
                return;
            }

            int matricula = 0;

            try
            {
                matricula = Convert.ToInt32(dataGridViewAlunos.SelectedCells[0].Value.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            using (var telaCadastroAlunos = new FormCadastroAlunos(matricula))
            {
                telaCadastroAlunos.ShowDialog();
                carregarGridViewAlunos();
                contaAtivosInativos();
            }
                
        }


    

    private void carregarGridViewAlunos()
    {

        var filtro = "";
        if (comboBoxListar.SelectedIndex == 1)
        {
            filtro = "AND m.ativo = 1 ";
        }
        else if(comboBoxListar.SelectedIndex == 2)
        {
            filtro = "AND m.ativo = 0 or m.ativo is null ";
        }

        try
        {
            


            var comando = "SELECT a.matricula, a.nome," +
                    " case when m.ativo = 1 then 'Sim' else 'Não' END as Ativo"  +
                    " FROM tb_alunos as a left outer join tb_matriculas as m on m.matricula = a.matricula" +
                    " WHERE 1=1 " + filtro +
                    "ORDER BY nome";
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


            dataGridViewAlunos.Columns[1].Width = 290;
            dataGridViewAlunos.Columns[2].Width = 50;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            // classificando dados dataGridViewAlunos

            String pesquisa = "";
            if (radioButtonPesquisaNome.Checked)
            {
                pesquisa = "nome like  '%" + txtFiltrar.Text + "%'";
            }
            else if (radioButtonPesquisaMatricula.Checked)
            {
                pesquisa = "matricula =  '" + txtFiltrar.Text + "'";
            }
            try
            {
                if (txtFiltrar.TextLength > 0)
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
                txtFiltrar.Text = "";
            }
        }

        private void comboBoxListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarGridViewAlunos();
        }

        private void contaAtivosInativos()
        {
            try
            {
                conexao.Open();

                var comando = new SqlCommand("SELECT count(matricula) " +
                    "from tb_matriculas WHERE ativo = 1", conexao);
                
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    labelAtivos.Text = leitor.GetInt32(0).ToString();
                }
                leitor.Close();

                //quantidade de anulos inativos
                comando.CommandText = "SELECT COUNT(a.matricula) FROM tb_alunos AS a LEFT OUTER JOIN" +
                    " tb_matriculas AS m ON a.matricula = m.matricula WHERE m.ativo = 0 or m.ativo IS NULL";      
                leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    labelInativos.Text = leitor.GetInt32(0).ToString();
                }
                leitor.Close();
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

        private void dataGridViewAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAlterar_Click(null, null);
        }
    }


}
