using System;
using System.Data;
using System.Data.SqlClient;
using SistemaVendas.Model;

namespace SistemaVendas.DAO
{
    public class ProdutoDAO
    {
        public string MensagemErro { get; private set; }

        public int BuscaProximoId ()
        {
            try
            {
                int proximoId;
                using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                {
                    cmd.CommandText = "SELECT MAX(id) FROM produtos";
                    if (cmd.ExecuteScalar() == DBNull.Value)
                        return 1;
                    proximoId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                }
                return proximoId;
            }
            catch (SqlException ex)
            {
                MensagemErro = ex.Message;
                throw;
            }
        }

        public void InsertProduto (Produtos produto)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = "INSERT INTO produtos VALUES(@id, @descricao, @estoque, @vlr, @ativo)";
                        cmd.Parameters.AddWithValue("@id", produto.Id);
                        cmd.Parameters.AddWithValue("@descricao", produto.NomeProduto);
                        cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                        cmd.Parameters.AddWithValue("@vlr", produto.Preco);
                        cmd.Parameters.AddWithValue("@ativo", produto.Ativo.ToString());
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MensagemErro = ex.Message;
                    throw;
                }
            }
        }

        public void DeleteProduto (int idProduto)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = "DELETE FROM produtos WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", idProduto);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    transaction.Commit();

                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MensagemErro = ex.Message;
                    throw;
                }
            }
        }

        public void UpdateProduto (Produtos produto)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = "UPDATE produtos SET nome_produto = @descricao, preco = @preco, ativo = @ativo WHERE id = @id";
                        cmd.Parameters.AddWithValue("@descricao", produto.NomeProduto);
                        cmd.Parameters.AddWithValue("@preco", produto.Preco);
                        cmd.Parameters.AddWithValue("@ativo", produto.Ativo);
                        cmd.Parameters.AddWithValue("@id", produto.Id);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MensagemErro = ex.Message;
                    throw;
                }
            }
        }

        public void UpdateEstoque (int idProduto, decimal quantidade, string tipoMovi)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                    {
                        if (tipoMovi.Equals("Entrada"))
                        {
                            cmd.Transaction = transaction;
                            cmd.CommandText = "UPDATE produtos SET estoque = estoque + @quantidade WHERE id = @idProduto";
                            cmd.Parameters.AddWithValue("@quantidade", quantidade);
                            cmd.Parameters.AddWithValue("@idProduto", idProduto);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        else
                        {
                            cmd.Transaction = transaction;
                            cmd.CommandText = "UPDATE produtos SET estoque = estoque - @quantidade WHERE id = @idProduto";
                            cmd.Parameters.AddWithValue("@quantidade", quantidade);
                            cmd.Parameters.AddWithValue("@idProduto", idProduto);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                    }
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MensagemErro = ex.Message;
                    throw;
                }
            }
        }

        public Produtos BuscaPorId (int id)
        {
            try
            {
                Produtos produto = null;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM produtos WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                produto = new Produtos(
                                    Convert.ToInt32(reader["id"].ToString()),
                                    reader["nome_produto"].ToString(),
                                    Convert.ToDecimal(reader["estoque"].ToString()),
                                    Convert.ToDecimal(reader["preco"].ToString())
                                    );
                            }
                        }
                    }
                    return produto;
                }
            }
            catch (SqlException ex)
            {
                MensagemErro = $"Ocorreu um erro na execução do método {nameof(BuscaPorId)}.\nErros:\n";
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
                    cmd.CommandText = "SELECT * FROM produtos";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabela);
                    }
                }
                return tabela;
            }
            catch (SqlException ex)
            {
                MensagemErro = $"Ocorreu um erro na execução do método {nameof(SelectAll)}.\nErros:\n";
                foreach (SqlError erro in ex.Errors)
                    MensagemErro += erro.ToString() + "\n";
                throw;
            }
        }

        public DataTable FiltroProduto (string busca)
        {
            try
            {
                DataTable tabela = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = $"SELECT * FROM produtos WHERE CONVERT(varchar, id) = @busca OR nome_produto LIKE '%{busca.ToUpper()}%'";
                    cmd.Parameters.AddWithValue("@busca", busca.ToUpper());
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabela);
                    }
                }
                return tabela;
            }
            catch (SqlException ex)
            {
                MensagemErro = $"Ocorreu um erro na execução do método {nameof(FiltroProduto)}.\nErros:\n";
                foreach (SqlError erro in ex.Errors)
                    MensagemErro += erro.ToString() + "\n";
                throw;
            }
        }
    }
}
