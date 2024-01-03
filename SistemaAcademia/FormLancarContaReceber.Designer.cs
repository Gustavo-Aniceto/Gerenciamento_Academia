namespace SistemaAcademia
{
    partial class FormLancarContaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLancarContaReceber));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.comboBoxServico = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVencimento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do aluno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vencimento:";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SistemaAcademia.Properties.Resources.Log_Out_icon;
            this.btnSair.Location = new System.Drawing.Point(513, 138);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.Image = global::SistemaAcademia.Properties.Resources.Save_icon__1_;
            this.btnLancar.Location = new System.Drawing.Point(432, 138);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(75, 23);
            this.btnLancar.TabIndex = 7;
            this.btnLancar.Text = "&Lançar";
            this.btnLancar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(74, 16);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 8;
            this.txtMatricula.Leave += new System.EventHandler(this.txtMatricula_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(326, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 9;
            // 
            // comboBoxServico
            // 
            this.comboBoxServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServico.FormattingEnabled = true;
            this.comboBoxServico.Items.AddRange(new object[] {
            "Mensalidade",
            "Avaliação física",
            "Taxa de matrícula",
            "Venda de produtos",
            "Outros"});
            this.comboBoxServico.Location = new System.Drawing.Point(74, 51);
            this.comboBoxServico.Name = "comboBoxServico";
            this.comboBoxServico.Size = new System.Drawing.Size(125, 21);
            this.comboBoxServico.TabIndex = 10;
            this.comboBoxServico.SelectedIndexChanged += new System.EventHandler(this.comboBoxServico_SelectedIndexChanged);
            // 
            // dateTimePickerVencimento
            // 
            this.dateTimePickerVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVencimento.Location = new System.Drawing.Point(326, 48);
            this.dateTimePickerVencimento.Name = "dateTimePickerVencimento";
            this.dateTimePickerVencimento.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerVencimento.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnProcurar);
            this.panel1.Controls.Add(this.txtMatricula);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerVencimento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxServico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 109);
            this.panel1.TabIndex = 13;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = global::SistemaAcademia.Properties.Resources.search;
            this.btnProcurar.Location = new System.Drawing.Point(180, 14);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(38, 23);
            this.btnProcurar.TabIndex = 14;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Location = new System.Drawing.Point(463, 51);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 12;
            // 
            // FormLancarContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLancarContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta a Receber - lançamento de conta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox comboBoxServico;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtValor;
    }
}