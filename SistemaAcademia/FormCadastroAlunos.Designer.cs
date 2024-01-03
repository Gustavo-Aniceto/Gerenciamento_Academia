namespace SistemaAcademia
{
    partial class FormCadastroAlunos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAlunos));
            this.tabMatricula = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnAtivarMatricula = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnTrancarMatricula = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEditarMatricula = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvarMatricula = new System.Windows.Forms.Button();
            this.comboBoxVencimento = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TabDados = new System.Windows.Forms.TabPage();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxUF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabMatricula.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabDados.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMatricula
            // 
            this.tabMatricula.BackColor = System.Drawing.Color.Gainsboro;
            this.tabMatricula.Controls.Add(this.panel2);
            this.tabMatricula.Location = new System.Drawing.Point(4, 22);
            this.tabMatricula.Name = "tabMatricula";
            this.tabMatricula.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatricula.Size = new System.Drawing.Size(952, 233);
            this.tabMatricula.TabIndex = 1;
            this.tabMatricula.Text = "Matrícula";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.dateTimePickerDataMatricula);
            this.panel2.Controls.Add(this.btnAtivarMatricula);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.btnTrancarMatricula);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.btnEditarMatricula);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.btnSalvarMatricula);
            this.panel2.Controls.Add(this.comboBoxVencimento);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 221);
            this.panel2.TabIndex = 29;
            // 
            // dateTimePickerDataMatricula
            // 
            this.dateTimePickerDataMatricula.Enabled = false;
            this.dateTimePickerDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataMatricula.Location = new System.Drawing.Point(13, 28);
            this.dateTimePickerDataMatricula.Name = "dateTimePickerDataMatricula";
            this.dateTimePickerDataMatricula.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataMatricula.TabIndex = 8;
            // 
            // btnAtivarMatricula
            // 
            this.btnAtivarMatricula.Image = global::SistemaAcademia.Properties.Resources.apply_icon;
            this.btnAtivarMatricula.Location = new System.Drawing.Point(139, 172);
            this.btnAtivarMatricula.Name = "btnAtivarMatricula";
            this.btnAtivarMatricula.Size = new System.Drawing.Size(120, 23);
            this.btnAtivarMatricula.TabIndex = 28;
            this.btnAtivarMatricula.Text = "Ativar Matrícula";
            this.btnAtivarMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtivarMatricula.UseVisualStyleBackColor = true;
            this.btnAtivarMatricula.Visible = false;
            this.btnAtivarMatricula.Click += new System.EventHandler(this.btnAtivarMatricula_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(13, 82);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // btnTrancarMatricula
            // 
            this.btnTrancarMatricula.Image = global::SistemaAcademia.Properties.Resources.Actions_dialog_cancel_icon;
            this.btnTrancarMatricula.Location = new System.Drawing.Point(13, 172);
            this.btnTrancarMatricula.Name = "btnTrancarMatricula";
            this.btnTrancarMatricula.Size = new System.Drawing.Size(120, 23);
            this.btnTrancarMatricula.TabIndex = 27;
            this.btnTrancarMatricula.Text = "Trancar Matrícula";
            this.btnTrancarMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrancarMatricula.UseVisualStyleBackColor = true;
            this.btnTrancarMatricula.Visible = false;
            this.btnTrancarMatricula.Click += new System.EventHandler(this.btnTrancarMatricula_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Data de Início";
            // 
            // btnEditarMatricula
            // 
            this.btnEditarMatricula.Image = global::SistemaAcademia.Properties.Resources.Pencil_icon__1_;
            this.btnEditarMatricula.Location = new System.Drawing.Point(139, 143);
            this.btnEditarMatricula.Name = "btnEditarMatricula";
            this.btnEditarMatricula.Size = new System.Drawing.Size(120, 23);
            this.btnEditarMatricula.TabIndex = 26;
            this.btnEditarMatricula.Text = "Editar Matrícula";
            this.btnEditarMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarMatricula.UseVisualStyleBackColor = true;
            this.btnEditarMatricula.Click += new System.EventHandler(this.btnEditarMatricula_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(128, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Dia de Vencimento";
            // 
            // btnSalvarMatricula
            // 
            this.btnSalvarMatricula.Enabled = false;
            this.btnSalvarMatricula.Image = global::SistemaAcademia.Properties.Resources.Save_icon__1_;
            this.btnSalvarMatricula.Location = new System.Drawing.Point(13, 143);
            this.btnSalvarMatricula.Name = "btnSalvarMatricula";
            this.btnSalvarMatricula.Size = new System.Drawing.Size(120, 23);
            this.btnSalvarMatricula.TabIndex = 18;
            this.btnSalvarMatricula.Text = "Salvar Matrícula";
            this.btnSalvarMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarMatricula.UseVisualStyleBackColor = true;
            this.btnSalvarMatricula.Click += new System.EventHandler(this.btnSalvarMatricula_Click);
            // 
            // comboBoxVencimento
            // 
            this.comboBoxVencimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVencimento.Enabled = false;
            this.comboBoxVencimento.FormattingEnabled = true;
            this.comboBoxVencimento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.comboBoxVencimento.Location = new System.Drawing.Point(131, 28);
            this.comboBoxVencimento.Name = "comboBoxVencimento";
            this.comboBoxVencimento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVencimento.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Valor:";
            // 
            // TabDados
            // 
            this.TabDados.BackColor = System.Drawing.Color.Gainsboro;
            this.TabDados.Controls.Add(this.dateTimePickerNascimento);
            this.TabDados.Controls.Add(this.comboBoxEstadoCivil);
            this.TabDados.Controls.Add(this.txtCep);
            this.TabDados.Controls.Add(this.txtObjetivo);
            this.TabDados.Controls.Add(this.txtProfissao);
            this.TabDados.Controls.Add(this.txtCidade);
            this.TabDados.Controls.Add(this.txtEmail);
            this.TabDados.Controls.Add(this.txtBairro);
            this.TabDados.Controls.Add(this.txtEndereco);
            this.TabDados.Controls.Add(this.txtNome);
            this.TabDados.Controls.Add(this.txtMatricula);
            this.TabDados.Controls.Add(this.groupBoxSexo);
            this.TabDados.Controls.Add(this.label11);
            this.TabDados.Controls.Add(this.label12);
            this.TabDados.Controls.Add(this.label15);
            this.TabDados.Controls.Add(this.comboBoxUF);
            this.TabDados.Controls.Add(this.label10);
            this.TabDados.Controls.Add(this.label9);
            this.TabDados.Controls.Add(this.label4);
            this.TabDados.Controls.Add(this.txtCelular);
            this.TabDados.Controls.Add(this.label8);
            this.TabDados.Controls.Add(this.label17);
            this.TabDados.Controls.Add(this.label16);
            this.TabDados.Controls.Add(this.label14);
            this.TabDados.Controls.Add(this.label13);
            this.TabDados.Controls.Add(this.txtTelefone);
            this.TabDados.Controls.Add(this.label7);
            this.TabDados.Controls.Add(this.txtRG);
            this.TabDados.Controls.Add(this.txtCPF);
            this.TabDados.Controls.Add(this.label6);
            this.TabDados.Controls.Add(this.label5);
            this.TabDados.Controls.Add(this.label3);
            this.TabDados.Controls.Add(this.label2);
            this.TabDados.Controls.Add(this.label1);
            this.TabDados.Location = new System.Drawing.Point(4, 22);
            this.TabDados.Name = "TabDados";
            this.TabDados.Padding = new System.Windows.Forms.Padding(3);
            this.TabDados.Size = new System.Drawing.Size(952, 233);
            this.TabDados.TabIndex = 0;
            this.TabDados.Text = "Dados Cadastrais";
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(421, 112);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerNascimento.TabIndex = 9;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)",
            "Amasiado(a)",
            "Divorciado(a)"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(636, 42);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(92, 21);
            this.comboBoxEstadoCivil.TabIndex = 13;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(421, 12);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObjetivo.Location = new System.Drawing.Point(636, 116);
            this.txtObjetivo.MaxLength = 30;
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(282, 20);
            this.txtObjetivo.TabIndex = 15;
            // 
            // txtProfissao
            // 
            this.txtProfissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProfissao.Location = new System.Drawing.Point(636, 79);
            this.txtProfissao.MaxLength = 30;
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(227, 20);
            this.txtProfissao.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(77, 152);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(198, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(636, 9);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(77, 116);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(198, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(77, 82);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(230, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(77, 45);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(77, 12);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(35, 20);
            this.txtMatricula.TabIndex = 0;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxSexo.Controls.Add(this.radioButtonFeminino);
            this.groupBoxSexo.Controls.Add(this.radioButtonMasculino);
            this.groupBoxSexo.Location = new System.Drawing.Point(580, 148);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(168, 54);
            this.groupBoxSexo.TabIndex = 16;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(81, 19);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 34;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Tag = "F";
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(6, 19);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 17;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Tag = "M";
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "*Estado civil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "*Objetivo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Cidade";
            // 
            // comboBoxUF
            // 
            this.comboBoxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUF.FormattingEnabled = true;
            this.comboBoxUF.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxUF.Location = new System.Drawing.Point(77, 190);
            this.comboBoxUF.Name = "comboBoxUF";
            this.comboBoxUF.Size = new System.Drawing.Size(80, 21);
            this.comboBoxUF.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Profissão:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "*Data de nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(421, 182);
            this.txtCelular.Mask = "(99) #0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(87, 20);
            this.txtCelular.TabIndex = 11;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "E-mail:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(378, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "CEP:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "UF:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 25;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(421, 148);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(82, 20);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefone:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(421, 78);
            this.txtRG.Mask = "00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(74, 20);
            this.txtRG.TabIndex = 8;
            this.txtRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(421, 38);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(84, 20);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "*RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "*CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabDados);
            this.tabControl1.Controls.Add(this.tabMatricula);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 259);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txtDebito);
            this.panel1.Controls.Add(this.txtSituacao);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(16, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 113);
            this.panel1.TabIndex = 4;
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(18, 76);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.ReadOnly = true;
            this.txtDebito.Size = new System.Drawing.Size(100, 20);
            this.txtDebito.TabIndex = 3;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(18, 26);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(100, 20);
            this.txtSituacao.TabIndex = 2;
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Débito";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Situação do aluno";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SistemaAcademia.Properties.Resources.Log_Out_icon;
            this.btnSair.Location = new System.Drawing.Point(603, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SistemaAcademia.Properties.Resources.back_icon__1_;
            this.btnCancelar.Location = new System.Drawing.Point(513, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SistemaAcademia.Properties.Resources.Save_icon__1_;
            this.btnSalvar.Location = new System.Drawing.Point(422, 277);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastroAlunos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.tabMatricula.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabDados.ResumeLayout(false);
            this.TabDados.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabPage tabMatricula;
        private System.Windows.Forms.Button btnSalvarMatricula;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataMatricula;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TabPage TabDados;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxUF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBoxVencimento;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAtivarMatricula;
        private System.Windows.Forms.Button btnTrancarMatricula;
        private System.Windows.Forms.Button btnEditarMatricula;
    }
}

