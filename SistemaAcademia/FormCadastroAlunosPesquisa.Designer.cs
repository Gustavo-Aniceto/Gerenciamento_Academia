namespace SistemaAcademia
{
    partial class FormCadastroAlunosPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAlunosPesquisa));
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.radioButtonPesquisaMatricula = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisaNome = new System.Windows.Forms.RadioButton();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAtivos = new System.Windows.Forms.Label();
            this.labelInativos = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBoxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.radioButtonPesquisaMatricula);
            this.groupBoxPesquisa.Controls.Add(this.radioButtonPesquisaNome);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(496, 12);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(82, 67);
            this.groupBoxPesquisa.TabIndex = 40;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Pesquisar por:";
            // 
            // radioButtonPesquisaMatricula
            // 
            this.radioButtonPesquisaMatricula.AutoSize = true;
            this.radioButtonPesquisaMatricula.Location = new System.Drawing.Point(6, 12);
            this.radioButtonPesquisaMatricula.Name = "radioButtonPesquisaMatricula";
            this.radioButtonPesquisaMatricula.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPesquisaMatricula.TabIndex = 29;
            this.radioButtonPesquisaMatricula.Tag = "matricula";
            this.radioButtonPesquisaMatricula.Text = "Matrícula";
            this.radioButtonPesquisaMatricula.UseVisualStyleBackColor = true;
            // 
            // radioButtonPesquisaNome
            // 
            this.radioButtonPesquisaNome.AutoSize = true;
            this.radioButtonPesquisaNome.Checked = true;
            this.radioButtonPesquisaNome.Location = new System.Drawing.Point(6, 35);
            this.radioButtonPesquisaNome.Name = "radioButtonPesquisaNome";
            this.radioButtonPesquisaNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPesquisaNome.TabIndex = 0;
            this.radioButtonPesquisaNome.TabStop = true;
            this.radioButtonPesquisaNome.Tag = "nome";
            this.radioButtonPesquisaNome.Text = "Nome\r\n";
            this.radioButtonPesquisaNome.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(493, 109);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(144, 20);
            this.txtFiltrar.TabIndex = 0;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::SistemaAcademia.Properties.Resources.Pencil_icon__1_;
            this.btnAlterar.Location = new System.Drawing.Point(102, 415);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.AllowUserToAddRows = false;
            this.dataGridViewAlunos.AllowUserToDeleteRows = false;
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAlunos.MultiSelect = false;
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.ReadOnly = true;
            this.dataGridViewAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlunos.Size = new System.Drawing.Size(478, 382);
            this.dataGridViewAlunos.TabIndex = 41;
            this.dataGridViewAlunos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAlunos_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Pesquisar:";
            // 
            // comboBoxListar
            // 
            this.comboBoxListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListar.FormattingEnabled = true;
            this.comboBoxListar.Items.AddRange(new object[] {
            "Todos os alunos",
            "Alunos ativos",
            "Alunos inativos"});
            this.comboBoxListar.Location = new System.Drawing.Point(493, 159);
            this.comboBoxListar.Name = "comboBoxListar";
            this.comboBoxListar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListar.TabIndex = 1;
            this.comboBoxListar.SelectedIndexChanged += new System.EventHandler(this.comboBoxListar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Listar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Informações:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ativos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Inativos:";
            // 
            // labelAtivos
            // 
            this.labelAtivos.AutoSize = true;
            this.labelAtivos.Location = new System.Drawing.Point(565, 216);
            this.labelAtivos.Name = "labelAtivos";
            this.labelAtivos.Size = new System.Drawing.Size(13, 13);
            this.labelAtivos.TabIndex = 48;
            this.labelAtivos.Text = "0";
            // 
            // labelInativos
            // 
            this.labelInativos.AutoSize = true;
            this.labelInativos.Location = new System.Drawing.Point(565, 244);
            this.labelInativos.Name = "labelInativos";
            this.labelInativos.Size = new System.Drawing.Size(13, 13);
            this.labelInativos.TabIndex = 49;
            this.labelInativos.Text = "0";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::SistemaAcademia.Properties.Resources.new_file_icon;
            this.btnNovo.Location = new System.Drawing.Point(12, 415);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 33;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FormCadastroAlunosPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.labelInativos);
            this.Controls.Add(this.labelAtivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dataGridViewAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroAlunosPesquisa";
            this.Text = "Cadastro de Alunos";
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.RadioButton radioButtonPesquisaMatricula;
        private System.Windows.Forms.RadioButton radioButtonPesquisaNome;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dataGridViewAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAtivos;
        private System.Windows.Forms.Label labelInativos;
    }
}