namespace SistemaAcademia
{
    partial class FormProcuraAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcuraAluno));
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.AllowUserToAddRows = false;
            this.dataGridViewAlunos.AllowUserToDeleteRows = false;
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.ReadOnly = true;
            this.dataGridViewAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlunos.ShowEditingIcon = false;
            this.dataGridViewAlunos.Size = new System.Drawing.Size(399, 310);
            this.dataGridViewAlunos.TabIndex = 0;
            this.dataGridViewAlunos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAlunos_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Selecione o aluno com duplo clique.";
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(15, 28);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(236, 20);
            this.txtNomeConsulta.TabIndex = 2;
            this.txtNomeConsulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o nome do aluno para consultar";
            // 
            // FormProcuraAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProcuraAluno";
            this.Text = "FormProcuraAluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Label label2;
    }
}