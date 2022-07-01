using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;


namespace Desafio
{
    internal class ItemVenda
    {
        string codigoProduto;
        string descricaoProduto;
        int numeroNF;
        double valorUnit;
        double quantidade;
        double valorTotal;

        public ItemVenda(string codigoProduto, string descricaoProduto, double valorUnit, double quantidade, double valorTotal)
        {
            this.CodigoProduto = codigoProduto;
            this.DescricaoProduto = descricaoProduto;
            this.ValorUnit = valorUnit;
            this.Quantidade = quantidade;
            this.ValorTotal = valorTotal;
        }
        public string CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public string DescricaoProduto { get => descricaoProduto; set => descricaoProduto = value; }
        public int NumeroNF { get => numeroNF; set => numeroNF = value; }
        public double ValorUnit { get => valorUnit; set => valorUnit = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        /// Salva todos os dados de uma lista de objetos itensVenda no banco de dados.
        public static void SalvarDados(List<ItemVenda> itensVenda)
        {
            foreach (ItemVenda itemVenda in itensVenda)
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString);

                cn.Open();

                SqlTransaction tran = cn.BeginTransaction();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.Transaction = tran;

                cmd.CommandText = "INSERT into item_venda values (@Produto_Codigo,@Produto_Descricao,@NumeroNF,@ValorUnit,@Quantidade,@ValorTotal)";
                cmd.Parameters.Add("@Produto_Codigo", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@Produto_Descricao", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@NumeroNF", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@ValorUnit", System.Data.SqlDbType.Decimal);
                cmd.Parameters.Add("@Quantidade", System.Data.SqlDbType.Decimal);
                cmd.Parameters.Add("@ValorTotal", System.Data.SqlDbType.Decimal);
                cmd.Parameters[0].Value = itemVenda.codigoProduto;
                cmd.Parameters[1].Value = itemVenda.descricaoProduto;
                cmd.Parameters[2].Value = itemVenda.numeroNF;
                cmd.Parameters[3].Value = itemVenda.valorUnit;
                cmd.Parameters[4].Value = itemVenda.quantidade;
                cmd.Parameters[5].Value = itemVenda.valorTotal;

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
}
