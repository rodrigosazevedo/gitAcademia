using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Desafio
{
    internal class Venda
    {
        int numeroNF;
        int cnpjCliente;
        string razaoCliente;
        double valorTotal;
        DateTime dataVenda;

        public Venda(int numeroNF, int cnpjCliente, string razaoCliente, double valorTotal, DateTime dataVenda)
        {
            this.NumeroNF = numeroNF;
            this.CnpjCliente = cnpjCliente;
            this.RazaoCliente = razaoCliente;
            this.ValorTotal = valorTotal;
            this.DataVenda = dataVenda;
        }

        public int NumeroNF { get => numeroNF; set => numeroNF = value; }
        public int CnpjCliente { get => cnpjCliente; set => cnpjCliente = value; }
        public string RazaoCliente { get => razaoCliente; set => razaoCliente = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public DateTime DataVenda { get => DataVenda; set => DataVenda = value; }

        public void SalvarDados()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString);

            cn.Open();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandText = "INSERT into venda values (@NumeroNF,@Cliente_CNPJ,@Cliente_RazaoSocial,@ValorTotal,@DataVenda)";
            cmd.Parameters.Add("@NumeroNF", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Cliente_CNPJ", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Cliente_RazaoSocial", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@ValorTotal", System.Data.SqlDbType.Decimal);
            cmd.Parameters.Add("@DataVenda", System.Data.SqlDbType.Date);
            cmd.Parameters[0].Value = this.NumeroNF;
            cmd.Parameters[1].Value = this.CnpjCliente;
            cmd.Parameters[2].Value = this.RazaoCliente;
            cmd.Parameters[3].Value = this.ValorTotal;
            cmd.Parameters[4].Value = this.DataVenda;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
