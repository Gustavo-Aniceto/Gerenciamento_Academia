using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class FormTelaPrincipal : Form
    {
        private String nomeUsuario;
        private int codigoUsuario;


        public FormTelaPrincipal(String nome, int codigo ) :
            this()
        {
            nomeUsuario = nome;
            codigoUsuario = codigo;
            labelUsuario.Text = nomeUsuario;

        }

        public FormTelaPrincipal()
        {
            InitializeComponent();
            timer1_Tick(null, null);
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formAluno = new FormCadastroAlunosPesquisa())
            {
                formAluno.ShowDialog();
            }
                
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formUsuario = new FormCadastroUsuarios())
            {
                formUsuario.ShowDialog();
            }
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPagamento = new FormContaAReceber();
            formPagamento.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            labelDate.Text = agora.ToShortDateString();
            labelTime.Text = agora.ToShortTimeString();
        }

        private void pagamentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (var telaContasAReceber = new FormContaAReceber())
            {
                telaContasAReceber.ShowDialog();
            }
        }

        private void relatórioFaturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var telaFaturamento = new FormRelatorioFinanceiro())
            {
                telaFaturamento.ShowDialog();
            }
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var telaLogin = new FormLogin())
            {
                telaLogin.ShowDialog();
            }
        }
    }

    
}
