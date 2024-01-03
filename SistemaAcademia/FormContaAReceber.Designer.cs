namespace SistemaAcademia
{
    partial class FormContaAReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContaAReceber));
            this.dataGridViewPagamentos = new System.Windows.Forms.DataGridView();
            this.txtPesquisaMatricula = new System.Windows.Forms.TextBox();
            this.groupBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.radioButtonPesquisaAmbos = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisaAluno = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisaPeriodo = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDe = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAte = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcurarAluno = new System.Windows.Forms.Button();
            this.labelDuploClique = new System.Windows.Forms.Label();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagamentos)).BeginInit();
            this.groupBoxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPagamentos
            // 
            this.dataGridViewPagamentos.AllowUserToAddRows = false;
            this.dataGridViewPagamentos.AllowUserToDeleteRows = false;
            this.dataGridViewPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagamentos.Location = new System.Drawing.Point(12, 157);
            this.dataGridViewPagamentos.MultiSelect = false;
            this.dataGridViewPagamentos.Name = "dataGridViewPagamentos";
            this.dataGridViewPagamentos.ReadOnly = true;
            this.dataGridViewPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPagamentos.Size = new System.Drawing.Size(822, 297);
            this.dataGridViewPagamentos.TabIndex = 0;
            this.dataGridViewPagamentos.SelectionChanged += new System.EventHandler(this.dataGridViewPagamentos_SelectionChanged);
            this.dataGridViewPagamentos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPagamentos_MouseDoubleClick);
            // 
            // txtPesquisaMatricula
            // 
            this.txtPesquisaMatricula.Location = new System.Drawing.Point(12, 76);
            this.txtPesquisaMatricula.Name = "txtPesquisaMatricula";
            this.txtPesquisaMatricula.Size = new System.Drawing.Size(190, 20);
            this.txtPesquisaMatricula.TabIndex = 26;
            this.txtPesquisaMatricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaMatricula_KeyDown);
            // 
            // groupBoxPesquisa
            // 
            this.groupBoxPesquisa.Controls.Add(this.radioButtonPesquisaAmbos);
            this.groupBoxPesquisa.Controls.Add(this.radioButtonPesquisaAluno);
            this.groupBoxPesquisa.Controls.Add(this.radioButtonPesquisaPeriodo);
            this.groupBoxPesquisa.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPesquisa.Name = "groupBoxPesquisa";
            this.groupBoxPesquisa.Size = new System.Drawing.Size(206, 32);
            this.groupBoxPesquisa.TabIndex = 27;
            this.groupBoxPesquisa.TabStop = false;
            this.groupBoxPesquisa.Text = "Consultar por:";
            // 
            // radioButtonPesquisaAmbos
            // 
            this.radioButtonPesquisaAmbos.AutoSize = true;
            this.radioButtonPesquisaAmbos.Location = new System.Drawing.Point(133, 12);
            this.radioButtonPesquisaAmbos.Name = "radioButtonPesquisaAmbos";
            this.radioButtonPesquisaAmbos.Size = new System.Drawing.Size(57, 17);
            this.radioButtonPesquisaAmbos.TabIndex = 30;
            this.radioButtonPesquisaAmbos.TabStop = true;
            this.radioButtonPesquisaAmbos.Text = "Ambos";
            this.radioButtonPesquisaAmbos.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaAmbos.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaAmbos_CheckedChanged);
            // 
            // radioButtonPesquisaAluno
            // 
            this.radioButtonPesquisaAluno.AutoSize = true;
            this.radioButtonPesquisaAluno.Checked = true;
            this.radioButtonPesquisaAluno.Location = new System.Drawing.Point(6, 12);
            this.radioButtonPesquisaAluno.Name = "radioButtonPesquisaAluno";
            this.radioButtonPesquisaAluno.Size = new System.Drawing.Size(52, 17);
            this.radioButtonPesquisaAluno.TabIndex = 29;
            this.radioButtonPesquisaAluno.TabStop = true;
            this.radioButtonPesquisaAluno.Tag = "matricula";
            this.radioButtonPesquisaAluno.Text = "Aluno";
            this.radioButtonPesquisaAluno.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaAluno.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaAluno_CheckedChanged);
            // 
            // radioButtonPesquisaPeriodo
            // 
            this.radioButtonPesquisaPeriodo.AutoSize = true;
            this.radioButtonPesquisaPeriodo.Location = new System.Drawing.Point(64, 12);
            this.radioButtonPesquisaPeriodo.Name = "radioButtonPesquisaPeriodo";
            this.radioButtonPesquisaPeriodo.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPesquisaPeriodo.TabIndex = 0;
            this.radioButtonPesquisaPeriodo.Tag = "nome";
            this.radioButtonPesquisaPeriodo.Text = "Período";
            this.radioButtonPesquisaPeriodo.UseVisualStyleBackColor = true;
            this.radioButtonPesquisaPeriodo.CheckedChanged += new System.EventHandler(this.radioButtonPesquisaPeriodo_CheckedChanged);
            // 
            // dateTimePickerDe
            // 
            this.dateTimePickerDe.Enabled = false;
            this.dateTimePickerDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDe.Location = new System.Drawing.Point(38, 112);
            this.dateTimePickerDe.Name = "dateTimePickerDe";
            this.dateTimePickerDe.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerDe.TabIndex = 28;
            this.dateTimePickerDe.Value = new System.DateTime(2018, 6, 7, 18, 38, 58, 0);
            // 
            // dateTimePickerAte
            // 
            this.dateTimePickerAte.Enabled = false;
            this.dateTimePickerAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAte.Location = new System.Drawing.Point(180, 112);
            this.dateTimePickerAte.Name = "dateTimePickerAte";
            this.dateTimePickerAte.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerAte.TabIndex = 29;
            this.dateTimePickerAte.Value = new System.DateTime(2018, 6, 7, 18, 40, 37, 0);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(261, 73);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 31;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Matrícula:";
            // 
            // btnProcurarAluno
            // 
            this.btnProcurarAluno.Image = global::SistemaAcademia.Properties.Resources.search;
            this.btnProcurarAluno.Location = new System.Drawing.Point(208, 73);
            this.btnProcurarAluno.Name = "btnProcurarAluno";
            this.btnProcurarAluno.Size = new System.Drawing.Size(47, 23);
            this.btnProcurarAluno.TabIndex = 35;
            this.btnProcurarAluno.UseVisualStyleBackColor = true;
            this.btnProcurarAluno.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // labelDuploClique
            // 
            this.labelDuploClique.AutoSize = true;
            this.labelDuploClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuploClique.Location = new System.Drawing.Point(12, 466);
            this.labelDuploClique.Name = "labelDuploClique";
            this.labelDuploClique.Size = new System.Drawing.Size(324, 17);
            this.labelDuploClique.TabIndex = 36;
            this.labelDuploClique.Text = "Duplo clique para mais informações sobre o aluno";
            // 
            // btnLancar
            // 
            this.btnLancar.Image = global::SistemaAcademia.Properties.Resources.Save_icon__1_;
            this.btnLancar.Location = new System.Drawing.Point(15, 502);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(75, 23);
            this.btnLancar.TabIndex = 37;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Image = global::SistemaAcademia.Properties.Resources.dollar_icon__1_;
            this.btnReceber.Location = new System.Drawing.Point(281, 502);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(75, 23);
            this.btnReceber.TabIndex = 40;
            this.btnReceber.Text = "Receber";
            this.btnReceber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::SistemaAcademia.Properties.Resources.Editing_Delete_icon;
            this.btnExcluir.Location = new System.Drawing.Point(99, 502);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 24);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormContaAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 561);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.labelDuploClique);
            this.Controls.Add(this.btnProcurarAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dateTimePickerAte);
            this.Controls.Add(this.dateTimePickerDe);
            this.Controls.Add(this.groupBoxPesquisa);
            this.Controls.Add(this.txtPesquisaMatricula);
            this.Controls.Add(this.dataGridViewPagamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContaAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.FormPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagamentos)).EndInit();
            this.groupBoxPesquisa.ResumeLayout(false);
            this.groupBoxPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPagamentos;
        private System.Windows.Forms.TextBox txtPesquisaMatricula;
        private System.Windows.Forms.GroupBox groupBoxPesquisa;
        private System.Windows.Forms.RadioButton radioButtonPesquisaPeriodo;
        private System.Windows.Forms.RadioButton radioButtonPesquisaAluno;
        private System.Windows.Forms.DateTimePicker dateTimePickerDe;
        private System.Windows.Forms.DateTimePicker dateTimePickerAte;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonPesquisaAmbos;
        private System.Windows.Forms.Button btnProcurarAluno;
        private System.Windows.Forms.Label labelDuploClique;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Button btnExcluir;
    }
}