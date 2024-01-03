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
    public partial class FormRelatorioFinanceiro : Form
    {
        public FormRelatorioFinanceiro()
        {
            InitializeComponent();
            CarregarGraficoFaturamentoUltimos13Meses();
        }

        private void CarregarGraficoFaturamentoUltimos13Meses()
        {
            String[] meses = {"JAN", "FEV", "MAR", "ABR", "MAI", "JUN",
                "JUL", "AGO", "SET", "OUT", "NOV", "DEZ" };

            var conexao = new SqlConnection(Conexao.stringConexao);
            try
            {
                conexao.Open();
                var comando = new SqlCommand("SELECT month(p.data) as mes, year(p.data) as ano, " + 
                    " sum(c.valor) as faturamento " + 
                    " FROM tb_contas_receber as c " + 
                    " inner join tb_pagamentos as p " + 
                    " on c.id = p.id_conta  where p.data between " + 
                    " dateadd(" + 
                         " day, " + 
                         " - day(getdate()) + 1," + 
                         " dateadd(" + 
                               " year, " + 
                               " - 1, " + 
                               " convert(date, getdate()) " + 
                          " ) " + 
                    " ) " + 
                    " and getdate() " + 
                    " group by month(p.data), year(p.data)");

                comando.Connection = conexao;
                SqlDataReader leitor = comando.ExecuteReader();

                while(leitor.Read())
                {
                    graficoFinanceiro.Series["Faturamento"].Points.AddXY(
                        meses[leitor.GetInt32(0)-1] +"/"+ leitor.GetInt32(1).ToString(), leitor.GetDecimal(2) );
                }
                graficoFinanceiro.ChartAreas["ChartArea1"].AxisX.Interval = 1;
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
