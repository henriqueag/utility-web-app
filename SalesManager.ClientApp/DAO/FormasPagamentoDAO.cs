using SistemaVendas.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVendas.DAO
{
    public class FormasPagamentoDAO
    {
        public FormasPagamento SelecionaFormaPagamento (string descricao)
        {
            try
            {
                FormasPagamento pagamento = null;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM pag_formas WHERE descricao = @descricao";
                    cmd.Parameters.AddWithValue("@descricao", descricao.ToUpper());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                pagamento = new FormasPagamento(Convert.ToInt32(reader["id"].ToString()), reader["descricao"].ToString(), Convert.ToBoolean(reader["permitir_desconto"].ToString()));
                            }
                        }
                    }
                }
                return pagamento;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (FormatException)
            {
                throw;
            }
        }

        public DataTable SelectAll ()
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM pag_formas";
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(table);
                    }
                }
                return table;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public FormasPagamento BuscaPorId (int id)
        {
            try
            {
                FormasPagamento formasPagamento = null;

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM pag_formas WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())                            
                                formasPagamento = new FormasPagamento(Convert.ToInt32(reader["id"]), Convert.ToString(reader["descricao"]), Convert.ToBoolean(reader["permitir_desconto"]));
                        }
                    }
                }
                return formasPagamento;
            }
            catch (SqlException)
            {
                throw;
            }
           
        }
    }
}
