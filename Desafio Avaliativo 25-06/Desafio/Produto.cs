using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Desafio
{
    internal class Produto
    {
        string codigo;
        string descricao;
        string unidade;
        string razaosocial;
        long cnpj;
        double custo;

        public Produto(string codigo, string descricao, string unidade, string razaosocial, long cnpj, double custo)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.unidade = unidade;
            this.razaosocial = razaosocial;
            this.cnpj = cnpj;
            this.custo = custo;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string Razaosocial { get => razaosocial; set => razaosocial = value; }
        public long Cnpj { get => cnpj; set => cnpj = value; }
        public double Custo { get => custo; set => custo = value; }

        /// Salva todos os dados daquele objeto Produto no banco de dados
        public void SalvarDados()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString);

            cn.Open();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandText = "INSERT into produto values (@Codigo,@Descricao,@Unidade,@RazaoSocial,@CNPJ,@Custo)";
            cmd.Parameters.Add("@Codigo", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Descricao", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Unidade", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@RazaoSocial", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@CNPJ", System.Data.SqlDbType.BigInt);
            cmd.Parameters.Add("@Custo", System.Data.SqlDbType.Decimal);
            cmd.Parameters[0].Value = this.codigo;
            cmd.Parameters[1].Value = this.descricao;
            cmd.Parameters[2].Value = this.unidade;
            cmd.Parameters[3].Value = this.razaosocial;
            cmd.Parameters[4].Value = this.cnpj;
            cmd.Parameters[5].Value = this.custo;

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
