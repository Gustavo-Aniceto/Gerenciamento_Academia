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
    public partial class FormContaAReceber : Form
    {
        private SqlConnection conexao;


        public FormContaAReceber()
        {
            InitializeComponent();
            conexao = new SqlConnection(Conexao.stringConexao);
        }

        private void carregarGridViewPagamentos()
        {

            var comando = "SELECT a.nome AS 'Nome aluno', a.matricula AS 'Matrícula aluno', " +
                   " c.id, c.descricao as 'Descricao pagamento', " +
                   " c.valor as Valor, c.data_vencimento as Vencimento, " +
                   " p.data as 'Data pagamento'," +
                   "CASE WHEN p.data is null THEN 'Não' ELSE 'Pago' END AS Pago " +
                   " FROM tb_alunos AS a inner join tb_contas_receber as c " +
                   " on a.matricula = c.matricula_aluno left outer join " +
                   " tb_pagamentos as p on c.id = p.id_conta WHERE 1 = 1 ";
            //filtros adicionais
            bool flagMatricula = false;
            bool flagData = false;
            if(txtPesquisaMatricula.Enabled)
            {
                comando += "AND a.matricula = @matricula ";
                flagMatricula = true;
            }
            if(dateTimePickerDe.Enabled && dateTimePickerAte.Enabled)
            {
                comando += "AND c.data_vencimento between @data_inicial and @data_final ";
                flagData = true;
            }


            try
            {
                SqlCommand sqlComando = new SqlCommand(comando, conexao);
                if (flagMatricula)
                {
                    sqlComando.Parameters.AddWithValue("@matricula", txtPesquisaMatricula.Text);
                }
                if (flagData)
                {
                    sqlComando.Parameters.AddWithValue("@data_inicial", dateTimePickerDe.Value.Date);
                    sqlComando.Parameters.AddWithValue("@data_final", dateTimePickerAte.Value.Date);
                }
                var dataAdapter = new SqlDataAdapter(sqlComando);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridViewPagamentos.DataSource = dataSet.Tables[0];

                //campo codigo conta invisível
                dataGridViewPagamentos.Columns[2].Visible = false;

                if(dataGridViewPagamentos.RowCount == 0)
                {
                    labelDuploClique.Text = "Nenhum registro encontrado!";
                    labelDuploClique.ForeColor = Color.Red;
                }
                else
                {
                    labelDuploClique.Text = "Duplo clique para mais informações sobre o aluno";
                    labelDuploClique.ForeColor = Color.Black;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

            //campo nome maior
            dataGridViewPagamentos.Columns[0].Width = 200;


            DateTime agora = DateTime.Now.Date;
            //verificando por contas atrasadas
            foreach( DataGridViewRow linha in dataGridViewPagamentos.Rows)
            {
                try
                {
                    // pule a linha se ja estiver paga
                    // baseado se existe valor na data de pagamento da grid
                    if (! linha.Cells[6].Value.ToString().Equals(String.Empty))
                    {
                        //pule
                        continue;
                    }

                    //atrasadas pinte de vermelho
                    DateTime data = Convert.ToDateTime( linha.Cells[5].Value.ToString() );
                    if(agora > data)
                    {
                        linha.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


        }


       private void carregarCampos()
        {
       /*     if (dataGridViewPagamentos.SelectedCells.Count == 0)
            {
                return;
            }

            try
            {
                txtEndereco.Text = dataGridViewPagamentos.SelectedCells[8].Value.ToString();
                txtBairro.Text = dataGridViewPagamentos.SelectedCells[9].Value.ToString();
                txtCidade.Text = dataGridViewPagamentos.SelectedCells[10].Value.ToString();
                txtTelefone.Text = dataGridViewPagamentos.SelectedCells[11].Value.ToString();
                txtCelular.Text = dataGridViewPagamentos.SelectedCells[12].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void dataGridViewPagamentos_SelectionChanged(object sender, EventArgs e)
        {
            carregarCampos();
        }

        private void FormPagamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnEfetuarPagamento_Click(object sender, EventArgs e)
        {

            if (dataGridViewPagamentos.SelectedCells.Count == 0)
            {
                return;
            }

            if (dataGridViewPagamentos.SelectedCells[7].Value.ToString().Equals("Pago"))
            {
                MessageBox.Show("Conta já paga");
                return;
            }

            var confirmResult = MessageBox.Show("Confirma o recebimento de " 
                + dataGridViewPagamentos.SelectedCells[3].Value.ToString() +
               " referente ao pagamento de " + 
               dataGridViewPagamentos.SelectedCells[2].Value.ToString() +
               " do aluno " + dataGridViewPagamentos.SelectedCells[0].Value.ToString(), "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            String idPagamento =  dataGridViewPagamentos.SelectedCells[13].Value.ToString();
            String matricula = dataGridViewPagamentos.SelectedCells[1].Value.ToString();


            //pagamento
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("UPDATE tb_pagamentos SET status = 1 WHERE id = " + idPagamento, conexao);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();

            }


            // verificando situação de alunos para ativá-lo se for o caso
            try
            {
                conexao.Open();
                // possui algum pagamento pendente?
                var comando = new SqlCommand("SELECT * FROM tb_pagamentos WHERE matricula_aluno = " + matricula +
                    " and status = 0 and data_vencimento < getdate()", conexao);

                

                var leitor = comando.ExecuteReader();

                comando.Dispose();
                if (!leitor.Read())
                {
                    leitor.Close();

                    comando = new SqlCommand("UPDATE tb_alunos SET situacao = 'ativo' WHERE matricula = " + matricula, conexao);
                    comando.ExecuteNonQuery();
                   
                }
  

                carregarGridViewPagamentos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
            }
        }

       


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGridViewPagamentos();
        }

        private void radioButtonPesquisaAmbos_CheckedChanged(object sender, EventArgs e)
        {
            var botao = sender as RadioButton;
            if (!botao.Checked) return;

            btnProcurarAluno.Enabled = true;
            txtPesquisaMatricula.Enabled = true;
            dateTimePickerDe.Enabled = true;
            dateTimePickerAte.Enabled = true;

            dataGridViewPagamentos.DataSource = null;
        }

        private void radioButtonPesquisaPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            var botao = sender as RadioButton;
            if (!botao.Checked) return;

            btnProcurarAluno.Enabled = false;
            txtPesquisaMatricula.Enabled = false;
            txtPesquisaMatricula.Text = String.Empty;
            dateTimePickerDe.Enabled = true;
            dateTimePickerAte.Enabled = true;
            dataGridViewPagamentos.DataSource = null;
        }

        private void radioButtonPesquisaAluno_CheckedChanged(object sender, EventArgs e)
        {
            var botao = sender as RadioButton;
            if (!botao.Checked) return;

            txtPesquisaMatricula.Enabled = true;
            btnProcurarAluno.Enabled = true;
            dateTimePickerDe.Enabled = false;
            dateTimePickerAte.Enabled = false;
            dateTimePickerAte.ResetText();
            dateTimePickerDe.ResetText();

            dataGridViewPagamentos.DataSource = null;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //txtbox como reference para recuperar a matricula
            var janelaAlunos = new FormProcuraAluno(txtPesquisaMatricula);
            janelaAlunos.ShowDialog();

            //pesquisar só por aluno? Já pesquise
            if(radioButtonPesquisaAluno.Checked)
            {
                btnConsultar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Selecione o período e clique em consultar");
            }

            
        }

        private void dataGridViewPagamentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dataGridViewPagamentos.SelectedCells.Count == 0)
            {
                return;
            }


            int matricula = 0;
            try
            {
                matricula = Convert.ToInt32(dataGridViewPagamentos.SelectedCells[1].Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            var telaAlunos = new FormCadastroAlunos(matricula, true);
            telaAlunos.ShowDialog();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            using (var telaLancarConta = new FormLancarContaReceber())
            {
                telaLancarConta.ShowDialog();
            }
            //atualizar a table se houver filtro de pesquisa por aluno
            if(txtPesquisaMatricula.TextLength > 0)
            {
                carregarGridViewPagamentos();
            }

             
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPagamentos.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione uma conta na tabela");
                return;
            }

            

            try
            {
                conexao.Open();

                // conta já paga não pode ser excluída
                var comando = new SqlCommand("SELECT * from tb_pagamentos where id_conta = @id",
                    conexao);
                var id = dataGridViewPagamentos.SelectedCells[2].Value.ToString();
                comando.Parameters.AddWithValue("@id", id);
                var reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Conta já paga");
                    return;
                }
                reader.Close();

                //confirmação
                var descricao = dataGridViewPagamentos.SelectedCells[3].Value.ToString();
                var valor = dataGridViewPagamentos.SelectedCells[4].Value.ToString();
                var opcao = MessageBox.Show("Deseja mesmo excluir a conta " + descricao + " valor " +
                    valor + "?", "Confirmação", MessageBoxButtons.YesNo);
                if (opcao == DialogResult.No)
                {
                    return;
                }

                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM tb_contas_receber WHERE id = @id";
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                MessageBox.Show("Conta exluída");

                carregarGridViewPagamentos();

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

        private void txtPesquisaMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConsultar_Click(null, null);
            }
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            if(dataGridViewPagamentos.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione uma conta na tabela");
                return;
            }

            if (!dataGridViewPagamentos.SelectedCells[6].Value.ToString().Equals(String.Empty))
            {
                MessageBox.Show("Conta já paga");
                return;
            }

            String valorConta = dataGridViewPagamentos.SelectedCells[4].Value.ToString();

            var opcao = MessageBox.Show("Confirma o recebimento da conta selecionada? \n" +
                "No valor de:" + valorConta,"Confirmação",
                MessageBoxButtons.YesNo);
            if(opcao == DialogResult.No)
            {
                return;
            }

            var id_conta = dataGridViewPagamentos.SelectedCells[2].Value.ToString();
            var agora = DateTime.Now.Date;
            try
            {
                

                conexao.Open();
                var comando = new SqlCommand("INSERT INTO tb_pagamentos (id_conta, data) values" +
                    "(@id_conta, @data)", conexao);

                comando.Parameters.AddWithValue("@id_conta", id_conta);
                comando.Parameters.AddWithValue("@data", agora);
                comando.ExecuteNonQuery();

                MessageBox.Show("Conta paga com sucesso");
                carregarGridViewPagamentos();
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

    }
}
