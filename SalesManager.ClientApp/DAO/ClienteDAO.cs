using SistemaVendas.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVendas.DAO
{
    public class ClienteDAO
    {
        public string MensagemErro { get; private set; }

        public Clientes BuscaPorId (int id)
        {
            try
            {
                Clientes cliente = null;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM cliente WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cliente = new Clientes(Convert.ToInt32(reader["id"].ToString()), reader["nome"].ToString(), reader["cpf"].ToString(), Convert.ToDateTime(reader["data_nasc"].ToString()), reader["telefone"].ToString(), reader["email"].ToString());
                            }
                        }
                    }
                    cmd.Parameters.Clear();
                    return cliente;
                }
            }
            catch (SqlException ex)
            {
                MensagemErro = string.Empty;
                MensagemErro = $"Ocorreu um erro na execução do método {nameof(BuscaPorId)}\nErros:\n";
                foreach (SqlError erro in ex.Errors)
                    MensagemErro += erro.ToString() + "\n";

                throw;
            }
        }

        public DataTable SelectAll ()
        {
            try
            {
                DataTable tabela = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM cliente";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabela);
                    }
                }
                return tabela;
            }
            catch (SqlException ex)
            {
                MensagemErro = string.Empty;
                MensagemErro = $"Ocorreu um erro na execução do método {nameof(SelectAll)}\nErros:\n";
                foreach (SqlError erro in ex.Errors)
                    MensagemErro += erro.ToString() + "\n";

                throw;
            }
        }

        public DataTable FiltroCliente (string busca)
        {
            try
            {
                DataTable tabela = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = $"SELECT * FROM cliente WHERE CONVERT(varchar, id) = @id OR nome LIKE '%{busca.ToUpper()}%'";
                    cmd.Parameters.AddWithValue("@id", busca);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabela);
                    }
                    cmd.Parameters.Clear();
                }
                return tabela;
            }
            catch (SqlException ex)
            {
                MensagemErro = string.Empty;
                MensagemErro = $"Ocorreu um erro na execução do método {nameof(FiltroCliente)}\nErros:\n";
                foreach (SqlError erro in ex.Errors)
                    MensagemErro += erro.ToString() + "\n";

                throw;
            }
        }
    }
}
