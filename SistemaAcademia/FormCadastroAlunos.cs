using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class FormCadastroAlunos : Form
    {
        private SqlConnection conexao;

        private int matricula;

        public FormCadastroAlunos()
        {
            InitializeComponent();
            conexao = new SqlConnection(Conexao.stringConexao);
        }

        public FormCadastroAlunos(int argMatricula) :
            this()
        {
            matricula = argMatricula;
            txtMatricula.Text = matricula.ToString();
            carregarCampos();
        }

        public FormCadastroAlunos(int argMatricula, bool consulta) :
            this(argMatricula)
        {
            // só consulta
            btnSalvar.Enabled = !consulta;
            HabilitarComponentes(!consulta);
            btnAtivarMatricula.Enabled = !consulta;
            btnTrancarMatricula.Enabled = !consulta;
            btnEditarMatricula.Enabled = !consulta;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            // verifica se existe matricula para diferenciar entre cadastro e alteração
            if (txtMatricula.Text.Equals(""))
            {
                SalvarDados();
            }
            else
            {
                AlterarDados();
            }

            carregarCampos();
        }

        private void SalvarDados()
        {

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO tb_alunos (nome, endereco, celular," +
               "cpf, rg, sexo, email, nascimento, profissao, estado_civil, objetivo, telefone, bairro," +
               "cidade, uf, cep) output inserted.matricula " +
               "VALUES(@nome, @endereco, @celular, @cpf, @rg, @sexo, @email, @nascimento," +
               "@profissao, @estado_civil, @objetivo, @telefone, @bairro, @cidade, @uf, @cep)",conexao);
                comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                comando.Parameters.Add(new SqlParameter("@endereco", txtEndereco.Text));
                comando.Parameters.Add(new SqlParameter("@celular", txtCelular.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", txtCPF.Text));
                comando.Parameters.Add(new SqlParameter("@rg", txtRG.Text));
                comando.Parameters.Add(new SqlParameter("@sexo", getSexo()));
                comando.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                comando.Parameters.Add(new SqlParameter("@nascimento", dateTimePickerNascimento.Text));
                comando.Parameters.Add(new SqlParameter("@profissao", txtProfissao.Text));
                comando.Parameters.Add(new SqlParameter("@estado_civil", comboBoxEstadoCivil.SelectedItem));
                comando.Parameters.Add(new SqlParameter("@objetivo", txtObjetivo.Text));
                comando.Parameters.Add(new SqlParameter("@telefone", txtTelefone.Text));
                comando.Parameters.Add(new SqlParameter("@bairro", txtBairro.Text));
                comando.Parameters.Add(new SqlParameter("@cidade", txtCidade.Text));
                comando.Parameters.Add(new SqlParameter("@uf", comboBoxUF.SelectedText));
                comando.Parameters.Add(new SqlParameter("@cep", txtCep.Text));
                
                SqlDataReader leitor = comando.ExecuteReader();

                
                if (leitor.Read())
                {
                    txtMatricula.Text = leitor.GetInt32(0).ToString();
                    matricula = leitor.GetInt32(0);
                    MessageBox.Show("Aluno cadastrado com sucesso");
                }

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

        private void AlterarDados()
        {
            if (txtMatricula.Text.Equals(""))
            {
                MessageBox.Show("Erro ao alterar aluno, matrícula não encontrada");
                return;
            }

            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand("UPDATE tb_alunos set nome = @nome, endereco = @endereco," +
                    " celular = @celular, cpf = @cpf, rg = @rg, sexo = @sexo, email = @email, " +
                    "nascimento = @nascimento, profissao = @profissao, estado_civil = @estado_civil, " +
                    "objetivo = @objetivo, telefone = @telefone, bairro = @bairro, cidade = @cidade, " +
                    "uf = @uf, cep = @cep" +
                    "  WHERE matricula = @matricula", conexao);


                comando.Parameters.Add(new SqlParameter("@matricula", txtMatricula.Text));
                comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                comando.Parameters.Add(new SqlParameter("@endereco", txtEndereco.Text));
                comando.Parameters.Add(new SqlParameter("@celular", txtCelular.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", txtCPF.Text));
                comando.Parameters.Add(new SqlParameter("@rg", txtRG.Text));
                comando.Parameters.Add(new SqlParameter("@sexo", getSexo()));
                comando.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                comando.Parameters.Add(new SqlParameter("@nascimento", dateTimePickerNascimento.Text));
                comando.Parameters.Add(new SqlParameter("@profissao", txtProfissao.Text));
                comando.Parameters.Add(new SqlParameter("@estado_civil", comboBoxEstadoCivil.SelectedItem));
                comando.Parameters.Add(new SqlParameter("@objetivo", txtObjetivo.Text));
                comando.Parameters.Add(new SqlParameter("@telefone", txtTelefone.Text));
                comando.Parameters.Add(new SqlParameter("@bairro", txtBairro.Text));
                comando.Parameters.Add(new SqlParameter("@cidade", txtCidade.Text));
                comando.Parameters.Add(new SqlParameter("@uf", comboBoxUF.SelectedText));
                comando.Parameters.Add(new SqlParameter("@cep", txtCep.Text));

                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso");
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

        private void carregarCampos()
        {
            try
            {
                conexao.Open();

                var comando = new SqlCommand(" SELECT a.id_treino, a.nome, a.endereco, a.telefone, " +
                     "a.cpf, a.rg, a.sexo, a.email, a.nascimento, a.profissao, a.estado_civil, " +
                     "a.objetivo, a.celular, a.bairro, a.cidade, a.uf, a.cep, " +
                     "case when m.ativo = 1 then 'Ativo' else " +
                    "'Inativo' end as situacao, m.data_matricula, m.valor, m.dia_vencimento " +
                     "FROM tb_alunos as a left outer join tb_matriculas as m " +
                     "on a.matricula = m.matricula where a.matricula = @matricula",
                    conexao);
                comando.Parameters.Add(new SqlParameter("@matricula", matricula));

                SqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    txtNome.Text = leitor.GetString(1);
                    txtEndereco.Text = leitor.GetString(2);
                    txtTelefone.Text = leitor.GetString(3);
                    txtCPF.Text = leitor.GetString(4);
                    txtRG.Text = leitor.GetString(5);
                    setSexo(leitor.GetString(6));
                    txtEmail.Text = leitor.GetString(7);
                    dateTimePickerNascimento.Text = leitor.GetDateTime(8).Date.ToShortDateString();
                    txtProfissao.Text = leitor.GetString(9);
                    comboBoxEstadoCivil.SelectedItem = leitor.GetString(10);
                    txtObjetivo.Text = leitor.GetString(11);
                    txtCelular.Text = leitor.GetString(12);
                    txtBairro.Text = leitor.GetString(13);
                    txtCidade.Text = leitor.GetString(14);
                    comboBoxUF.SelectedItem = leitor.GetString(15);
                    txtCep.Text = leitor.GetString(16);

                    //setando cor no campo de texto situacao
                    String situacao = leitor.GetString(17);
                    txtSituacao.Text = situacao;
                    if (situacao.Equals("Ativo"))
                    {
                        txtSituacao.BackColor = Color.PaleTurquoise;
                        txtSituacao.ForeColor = Color.Navy;
                    }
                    else
                    {
                        txtSituacao.BackColor = Color.LightGray;
                        txtSituacao.ForeColor = Color.DarkSlateGray;
                    }
                    // verifica se existe matrícula cadastrada no banco
                    //para não gerar exceções por valores nulos
                    if (!leitor.IsDBNull(18))
                    {
                        dateTimePickerDataMatricula.Value = leitor.GetDateTime(18).Date;
                        txtValor.Text = leitor.GetDecimal(19).ToString();
                        comboBoxVencimento.SelectedItem = leitor.GetInt32(20).ToString();

                        //aluno ativo pode trancar, aluno inativo pode reativar
                        // mas deve exister matrícula previamente cadastrada
                        bool alunoAtivo = txtSituacao.Text.Equals("Ativo");
                        btnTrancarMatricula.Visible = alunoAtivo;
                        btnAtivarMatricula.Visible = !alunoAtivo;
                    }
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado");
                }

                //verificando possíveis débitos do aluno
                leitor.Close();
                comando.Parameters.Clear();
                comando.CommandText = "SELECT sum(c.valor) FROM tb_contas_receber as c WHERE id " +
                    "NOT IN(SELECT id_conta FROM tb_pagamentos)  AND matricula_aluno = @matricula " +
                    "and CONVERT(date, getdate()) > c.data_vencimento " +
                    "group by matricula_aluno " ;
                comando.Parameters.AddWithValue("@matricula", matricula);
                leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    txtDebito.Text =  leitor.GetDecimal(0).ToString();
                    txtDebito.BackColor = Color.OrangeRed;
                }
                else
                {
                    txtDebito.Text = "0.00";
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

        private void HabilitarComponentes(bool status)
        {
            txtNome.ReadOnly = !status;
            txtEndereco.ReadOnly = !status;
            txtCelular.ReadOnly = !status;
            txtCPF.ReadOnly = !status;
            txtRG.ReadOnly = !status;
            txtEmail.ReadOnly = !status;
            txtProfissao.ReadOnly = !status;
            txtObjetivo.ReadOnly = !status;
            txtTelefone.ReadOnly = !status;
            txtBairro.ReadOnly = !status;
            txtCidade.ReadOnly = !status;
            comboBoxUF.Enabled = status;
            txtCep.ReadOnly = !status;
            txtValor.ReadOnly = !status;

            radioButtonFeminino.Enabled = status;
            radioButtonMasculino.Enabled = status;
            dateTimePickerNascimento.Enabled = status;
            comboBoxEstadoCivil.Enabled = status;
        }

        private bool ValidarCampos()
        {
            txtValor.Text = txtValor.Text.Replace(',', '.');

            if (txtNome.Text.Length < 1)
            {
                MessageBox.Show("O nome deve ser preenchido!");
                txtNome.Select();
                return false;
            }
            if (!radioButtonFeminino.Checked && !radioButtonMasculino.Checked)
            {
                MessageBox.Show("O sexo deve ser selecionado!");
                return false;
            }
            if ( comboBoxEstadoCivil.SelectedItem == null)
            {
                MessageBox.Show("O estado civil deve ser selecionado!");
                comboBoxEstadoCivil.Select();
                return false;
            }
            if (txtObjetivo.Text.Length < 1)
            {
                MessageBox.Show("O objetivo deve ser informado!");
                txtObjetivo.Select();
                return false;
            }
            if (txtRG.Text.Length < 1)
            {
                MessageBox.Show("O RG deve ser informado!");
                txtRG.Select();
                return false;
            }
            if (txtCPF.Text.Length < 1)
            {
                MessageBox.Show("O CPF deve ser informado!");
                txtCPF.Select();
                return false;
            }

            return true;
        }

        private String getSexo()
        {
            if (radioButtonFeminino.Checked)
            {
                return "F";
            }
            else if (radioButtonMasculino.Checked)
            {
                return "M";
            }
            else
            {
                return null;
            }
        }

        private void setSexo(String argument)
        {
            if (argument.Equals("M"))
            {
                radioButtonMasculino.Checked = true;
            }
            else if (argument.Equals("F"))
            {
                radioButtonFeminino.Checked = true;
            }
        }

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            if (txtMatricula.TextLength == 0)
            {
                MessageBox.Show("Cadastre o aluno primeiro");
                tabControl1.SelectedIndex = 0;
                return;
            }

            if (!validarDadosMatricula())
            {
                return;
            }

            //verificando se o aluno já possui matrícula para
            // alterar ou salvar
            bool flagSalvar = false;
            try
            {
                conexao.Open();
                var comando = new SqlCommand("Select * from tb_matriculas WHERE matricula" +
                    " = @matricula",conexao);
                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                SqlDataReader leitor = comando.ExecuteReader();

                // Já há matricula
                if (leitor.Read())
                {
                    //alterar
                    flagSalvar = false;
                }
                else // não há matricula
                {
                    //salvar
                    flagSalvar = true;
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

            //flag utilizada para fechar a conexao antes de iniciar outro
            //comando SQL
            bool sucesso = false;
            if (flagSalvar)
            {
                sucesso = salvarMatricula();
            }
            else
            {
                sucesso = alterarMatricula();
            }
            if (sucesso)
            {
                MessageBox.Show("Dados salvos com sucesso");
                carregarCampos();
                habilitarComponentesMatricula(false);
            }



        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cancelar novo cadastro ou alteração?
            if(txtMatricula.TextLength == 0)
            {
                limparCampos();
            }
            else
            {
                carregarCampos();
            }
        }
            

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCampos()
        {
            txtMatricula.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtEmail.Text = "";
            dateTimePickerNascimento.ResetText();
            txtProfissao.Text = "";
            comboBoxEstadoCivil.SelectedItem = "";
            txtObjetivo.Text = "";
            txtCelular.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCep.Text = "";
        }

        private Decimal calcularMensalidadeProporcional()
        {
            int diaMatricula = 0; 
            int diaVencimento = 0;
            Decimal primeiraMensalidadeProporcional = 0;
            if (!comboBoxVencimento.SelectedItem.ToString().Equals(String.Empty))
            {
                try
                {
                    diaVencimento = Convert.ToInt32( comboBoxVencimento.SelectedItem.ToString());
                    diaMatricula = dateTimePickerDataMatricula.Value.Date.Day;
                    primeiraMensalidadeProporcional = Convert.ToDecimal(txtValor.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            

            //dias iguais sem diferença
            if (diaMatricula == diaVencimento)
            {
                return 0;
            }

            

            //valor será maior pois o periodo corresponde a mais de um mês
            if (diaMatricula < diaVencimento)
            {
                int dif = diaVencimento - diaMatricula;
                primeiraMensalidadeProporcional = primeiraMensalidadeProporcional +
                    (primeiraMensalidadeProporcional / 30 * dif);
            }
            else if(diaVencimento < diaMatricula) // valor será menor
            {
                int dif = diaMatricula - diaVencimento;
                primeiraMensalidadeProporcional = primeiraMensalidadeProporcional -
                    (primeiraMensalidadeProporcional / 30 * dif);
            }
            return primeiraMensalidadeProporcional;
        }

        private bool validarDadosMatricula()
        {
            if (comboBoxVencimento.SelectedItem == null)
            {
                MessageBox.Show("Selecione um dia para o vencimento");
                return false;
            }

            Decimal valor = 0;
            try
            {
                valor = Convert.ToDecimal(txtValor.Text);
                if(valor < 0)
                {
                    MessageBox.Show("Valor de matrícula inferior a 0! \nSelecione um valor para pagamento.");
                    txtValor.Focus();
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Valor de matrícula inválido! \nSelecione um valor para pagamento.");
                txtValor.Focus();
                return false;
            }

            return true;
        }

        private void btnEditarMatricula_Click(object sender, EventArgs e)
        {
            if (txtMatricula.TextLength == 0)
            {
                MessageBox.Show("Cadastre o aluno primeiro");
                tabControl1.SelectedIndex = 0;
                return;
            }

            habilitarComponentesMatricula(true);

        }

        private void habilitarComponentesMatricula(bool valor)
        {
            //componentes habilitados
            dateTimePickerDataMatricula.Enabled = valor;
            comboBoxVencimento.Enabled = valor;
            txtValor.ReadOnly = !valor;
            btnSalvarMatricula.Enabled = valor;

            //botões de edição desabilitados e vice versa
            btnEditarMatricula.Enabled = !valor;
            btnTrancarMatricula.Enabled = !valor;
            btnAtivarMatricula.Enabled = !valor;
        }


        private bool salvarMatricula()
        {
            bool flagRetorno = true;
            try
            {
                conexao.Open();

                //adicionando matricula
                var comando = new SqlCommand("INSERT INTO tb_matriculas (matricula, data_matricula," +
                    "valor, ativo, dia_vencimento) values (@matricula, @data_matricula, @valor, @ativo," +
                    "@dia_vencimento)",conexao);

                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                comando.Parameters.AddWithValue("@data_matricula", dateTimePickerDataMatricula.Value.Date);
                // valor proporcional só para o pagamento
                comando.Parameters.AddWithValue("@valor", txtValor.Text);
                comando.Parameters.AddWithValue("@ativo", 0);         
                comando.Parameters.AddWithValue("@dia_vencimento", comboBoxVencimento.SelectedItem.ToString());
                comando.ExecuteNonQuery();

               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                flagRetorno = false;

            }
            finally
            {
                conexao.Close();

            }
            return flagRetorno;
        }

        private bool alterarMatricula()
        {
            bool flagRetorno = true;
            try
            {
                conexao.Open();
                //adicionando matricula
                var comando = new SqlCommand("UPDATE tb_matriculas SET " +
                    " data_matricula = @data_matricula, valor = @valor, " +
                    "dia_vencimento = @dia_vencimento WHERE matricula = @matricula", conexao);
                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                comando.Parameters.AddWithValue("@data_matricula", dateTimePickerDataMatricula.
                    Value.Date);
                comando.Parameters.AddWithValue("@valor", txtValor.Text.Replace(",",".") );
                comando.Parameters.AddWithValue("@dia_vencimento", comboBoxVencimento.SelectedItem.ToString());
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flagRetorno = false;
            }
            finally
            {
                conexao.Close();
            }
            return flagRetorno;
        }

        private void btnTrancarMatricula_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Realmente deseja trancar a matrícula?\n" +
                "Para ativar novamente deverá haver pagamento!","Confirmação",
                MessageBoxButtons.YesNo);
            if(option == DialogResult.No)
            {
                return;
            }

            try
            {
                conexao.Open();
                var comando = new SqlCommand("UPDATE tb_matriculas SET ativo = 0 " +
                    "WHERE matricula = @matricula",conexao);
                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            carregarCampos();
        }

        private void btnAtivarMatricula_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Realmente deseja ativar a matrícula?", "Confirmação",
               MessageBoxButtons.YesNo);
            if (option == DialogResult.No)
            {
                return;
            }

            // valor bruto
            String valor = txtValor.Text;

            Decimal primeiraMensalidadeProporcional = calcularMensalidadeProporcional();
            // se a mensalidade é proporcional
            if (primeiraMensalidadeProporcional != 0)
            {
                var confirm = MessageBox.Show("Deseja incluir a primeira mensalidade" +
                    " proporcional? [" + primeiraMensalidadeProporcional.ToString("0.##") + "]? ",
                    "Confirmação", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {   //valor proporcional
                    valor = primeiraMensalidadeProporcional.ToString("0.##");
                }
            }
            //substituir vírgula por ponto para o banco
            valor = valor.Replace(",", ".");

            //confirmar recebimento
            var confirmResult = MessageBox.Show("Confirma o recebimento de " + valor +
               " referente à matrícula: " + txtMatricula.Text + " ? ", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            //criando uma transação, pois ou todos os comando sql devem ser executados
            // ou nenhum, isto garante a atomicidade do banco de dados
            //ativando a matrícula
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("Ativacao_matricula");
            try
            {
                var comando = new SqlCommand("UPDATE tb_matriculas SET ativo = 1" +
                    " WHERE matricula = @matricula", conexao);
                comando.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                comando.Transaction = transaction; //atribuindo transação
                comando.ExecuteNonQuery();

                //adicionando conta a receber para pagá-la
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO tb_contas_receber (data_vencimento," +
                    " valor, matricula_aluno, descricao)  output inserted.id VALUES (@data_vencimento, " +
                    "@valor, @matricula_aluno, @descricao)";
                comando.Parameters.Add(new SqlParameter("@data_vencimento",
                    DateTime.Now.Date));
                comando.Parameters.Add(new SqlParameter("@valor", valor));
                comando.Parameters.Add(new SqlParameter("@matricula_aluno", txtMatricula.Text));
                comando.Parameters.Add(new SqlParameter("@descricao", "matricula"));
                //recuperando id da conta adicionada para efetuar pagamento
                SqlDataReader leitor = comando.ExecuteReader();
                String id_conta = String.Empty;
                if (leitor.Read())
                {
                    id_conta = leitor.GetInt32(0).ToString();
                }
                leitor.Close();

                // adicionando pagamento da matrícula
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO tb_pagamentos (id_conta, data) " +
                    "output inserted.id VALUES (@id_conta, @data)";
                comando.Parameters.Add(new SqlParameter("@id_conta", id_conta));
                comando.Parameters.Add(new SqlParameter("@data", DateTime.Now.Date));
                comando.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Matrícula ativada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ativar a matrícula");
                MessageBox.Show(ex.Message);

                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {

                    MessageBox.Show(ex2.Message);
                }
            }
            finally
            {
                conexao.Close();
                transaction.Dispose();
            }
            carregarCampos();
        }

    }
}
