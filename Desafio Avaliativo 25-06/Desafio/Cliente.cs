using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Desafio
{
    internal class Cliente
    {
        string razaosocial;
        private int cnpj;
        private string email;
        private int telefone;
        private string endereco;
        private string bairro;
        private int cep;
        private string cidade;
        private string uf;

        public Cliente(string razaosocial, int cnpj, string email, int telefone, string endereco,
                       string bairro, int cep, string cidade, string uf)
        {
            this.razaosocial = razaosocial;
            this.cnpj = cnpj;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
        }

        public string Razaosocial { get => razaosocial; set => razaosocial = value; }
        public int Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public int Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }

        public void SalvarDados()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjetosAcademiaConnectionString"].ConnectionString);

            cn.Open();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandText = "INSERT into cliente values (@RazaoSocial,@CNPJ,@Email,@Telefone,@Endereco,@Bairro,@CEP,@Cidade,@UF)";
            cmd.Parameters.Add("@RazaoSocial", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@CNPJ", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Email", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Telefone", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Endereco", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@Bairro", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@CEP", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@Cidade", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@UF", System.Data.SqlDbType.VarChar);
            cmd.Parameters[0].Value = this.razaosocial;
            cmd.Parameters[1].Value = this.cnpj;
            cmd.Parameters[2].Value = this.email;
            cmd.Parameters[3].Value = this.telefone;
            cmd.Parameters[4].Value = this.endereco;
            cmd.Parameters[5].Value = this.bairro;
            cmd.Parameters[6].Value = this.cep;
            cmd.Parameters[7].Value = this.cidade;
            cmd.Parameters[8].Value = this.uf;

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
