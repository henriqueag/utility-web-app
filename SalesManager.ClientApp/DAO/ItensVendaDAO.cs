using System.Data;
using System.Data.SqlClient;

namespace SistemaVendas.DAO
{
    public class ItensVendaDAO
    {
        public string MensagemErro { get; private set; }

        public DataTable BuscaItensPorIdVenda (int idVenda)
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT itens_venda.idVenda, produtos.id, produtos.nome_produto AS descricao, itens_venda.quantidade, itens_venda.vlr_unitario" +
                        " FROM itens_venda" +
                        " INNER JOIN produtos ON itens_venda.idProduto = produtos.id" +
                        " WHERE itens_venda.idVenda = @idVenda";
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(table);
                    }
                    cmd.Parameters.Clear();
                }
                return table;
            }
            catch (SqlException ex)
            {
                MensagemErro = $"Ocorreu um erro na execução do método {nameof(BuscaItensPorIdVenda)}\nErros:\n";
                foreach (SqlError erro in ex.Errors)
                    MensagemErro += erro.ToString() + "\n";

                throw;
            }
        }

        public void VoltarEstoqueProdutos (int idVenda)
        {
            var tableItens = BuscaItensPorIdVenda(idVenda);
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd1 = new SqlCommand())
                    {
                        cmd1.Transaction = transaction;
                        cmd1.Connection = Conexao.OpenConn();
                        cmd1.CommandText = "INSERT INTO itens_venda_temp SELECT * FROM itens_venda WHERE idVenda = @idVenda";
                        cmd1.Parameters.AddWithValue("@idVenda", idVenda);
                        cmd1.ExecuteNonQuery();
                        cmd1.Parameters.Clear();

                        foreach (DataRow row in tableItens.Rows)
                        {
                            cmd1.CommandText = "UPDATE produtos SET estoque = estoque + @quantidade WHERE id = @idProduto";
                            cmd1.Parameters.AddWithValue("@quantidade", row["quantidade"]);
                            cmd1.Parameters.AddWithValue("@idProduto", row["id"]);
                            cmd1.ExecuteNonQuery();
                            cmd1.Parameters.Clear();
                        }
                    }
                    transaction.Commit();
                }
                catch (SqlException)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
