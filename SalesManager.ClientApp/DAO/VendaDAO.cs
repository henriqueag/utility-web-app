using System;
using System.Data;
using System.Data.SqlClient;
using SistemaVendas.Model;

namespace SistemaVendas.DAO
{
    public class VendaDAO
    {
        public string MensagemErro { get; private set; }

        public void LancamentoDeVenda (Venda venda, ItensDaVenda itens)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd1 = Conexao.OpenConn().CreateCommand())
                    {
                        cmd1.Transaction = transaction;
                        cmd1.CommandText = "INSERT INTO vendas (idVenda,idCliente,dataLancamento,id_forma_pagamento,desconto,acrescimo,totalItens,totalDaVenda) " +
                                        "VALUES(@idVenda, @idCliente, @dataLancamento, @formaPagamento, @desconto, @acrescimo, @totalItens, @totalDaVenda)";
                        cmd1.Parameters.AddWithValue("@idVenda", venda.IdVenda);
                        cmd1.Parameters.AddWithValue("@idCliente", venda.Cliente.Id);
                        cmd1.Parameters.AddWithValue("@dataLancamento", venda.DataLancamento);
                        cmd1.Parameters.AddWithValue("@formaPagamento", venda.Pagamento.Id);
                        cmd1.Parameters.AddWithValue("@desconto", venda.Desconto);
                        cmd1.Parameters.AddWithValue("@acrescimo", venda.Acrescimo);
                        cmd1.Parameters.AddWithValue("@totalItens", venda.Total_itens);
                        cmd1.Parameters.AddWithValue("@totalDaVenda", venda.Total_geral);
                        cmd1.ExecuteNonQuery();
                        cmd1.Parameters.Clear();
                    }
                    using (SqlCommand cmd2 = Conexao.OpenConn().CreateCommand())
                    {
                        using (SqlCommand cmd3 = Conexao.OpenConn().CreateCommand())
                        {
                            cmd2.Transaction = transaction;
                            cmd3.Transaction = transaction;

                            foreach (ItensDaVenda item in itens.ListItens)
                            {
                                #region Comando insert na tabela itens_venda
                                cmd2.CommandText = "INSERT INTO itens_venda (idVenda,idProduto,quantidade,vlr_unitario) " +
                                "VALUES (@idVendaItens,@idProduto,@quantidade,@vlrUnitario)";
                                cmd2.Parameters.AddWithValue("@idVendaItens", item.IdVenda);
                                cmd2.Parameters.AddWithValue("@idProduto", item.Produto.Id);
                                cmd2.Parameters.AddWithValue("@quantidade", item.Quantidade);
                                cmd2.Parameters.AddWithValue("@vlrUnitario", item.VlrUnitario);
                                #endregion
                                #region Comando update para baixar o estoque
                                cmd3.CommandText = "UPDATE produtos SET estoque = estoque - @quantidade WHERE id = @idProduto";
                                cmd3.Parameters.AddWithValue("@quantidade", item.Quantidade);
                                cmd3.Parameters.AddWithValue("@idProduto", item.Produto.Id);
                                if (cmd2.ExecuteNonQuery() == 1 && cmd3.ExecuteNonQuery() == 1)
                                {
                                    cmd2.Parameters.Clear();
                                    cmd3.Parameters.Clear();
                                }
                                else
                                    throw new InvalidProgramException();
                                #endregion
                            }
                        }
                    }
                    transaction.Commit();
                }                
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    MensagemErro = string.Empty;
                    MensagemErro = $"Erro ao executar o método {nameof(LancamentoDeVenda)}\nErros:\n";

                    foreach (SqlError erros in ex.Errors)
                        MensagemErro += erros.ToString() + "\n";

                    throw;
                }
            }
        }

        public int ProximaIdVenda ()
        {
            try
            {
                int id = 0;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT MAX(idVenda) FROM vendas";
                    if (cmd.ExecuteScalar() == DBNull.Value)
                        return 1;
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                return id + 1;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable BuscaVendas30Dias ()
        {
            try
            {
                DataTable table = new DataTable();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM GridVendas WHERE dataLancamento >= @dataFiltro";
                    cmd.Parameters.AddWithValue("@dataFiltro", DateTime.Now - TimeSpan.FromDays(30));
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        dataAdapter.Fill(table);
                }
                return table;
            }
            catch (SqlException ex)
            {
                MensagemErro = string.Empty;
                MensagemErro = $"Erro ao executar o método {nameof(BuscaVendas30Dias)}\nErros:\n";

                foreach (SqlError erros in ex.Errors)
                    MensagemErro += erros.ToString() + "\n";

                throw;
            }
        }

        public DataTable FiltroVenda (string idCliente, DateTime inicial, DateTime final, string vendaIni, string vendaFim)
        {
            try
            {
                DataTable table = new DataTable();
                if (String.IsNullOrWhiteSpace(idCliente) && String.IsNullOrWhiteSpace(vendaIni) && String.IsNullOrWhiteSpace(vendaFim))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexao.OpenConn();
                        cmd.CommandText = "SELECT * FROM GridVendas WHERE dataLancamento >= @dataIni AND dataLancamento <= @dataFim";
                        cmd.Parameters.AddWithValue("@dataIni", inicial);
                        cmd.Parameters.AddWithValue("@dataFim", final);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                        cmd.Parameters.Clear();
                    }
                }
                else if (!String.IsNullOrWhiteSpace(idCliente) && String.IsNullOrWhiteSpace(vendaIni) && String.IsNullOrWhiteSpace(vendaFim))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexao.OpenConn();
                        cmd.CommandText = "SELECT * FROM GridVendas WHERE SUBSTRING(cliente, 1, 4) = @idcliente AND dataLancamento >= @dataIni AND dataLancamento <= @dataFim";
                        cmd.Parameters.AddWithValue("@idcliente", Convert.ToInt32(idCliente));
                        cmd.Parameters.AddWithValue("@dataIni", inicial);
                        cmd.Parameters.AddWithValue("@dataFim", final);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                        cmd.Parameters.Clear();
                    }
                }
                else if (!String.IsNullOrWhiteSpace(vendaIni) && !String.IsNullOrWhiteSpace(vendaFim))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexao.OpenConn();
                        cmd.CommandText = "SELECT * FROM GridVendas WHERE idVenda >= @vendaIni AND idVenda <= @vendaFim";
                        cmd.Parameters.AddWithValue("@vendaIni", Convert.ToInt32(vendaIni));
                        cmd.Parameters.AddWithValue("@vendaFim", Convert.ToInt32(vendaFim));
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                        cmd.Parameters.Clear();
                    }
                }
                else if (String.IsNullOrWhiteSpace(idCliente) && !String.IsNullOrWhiteSpace(vendaIni) && String.IsNullOrWhiteSpace(vendaFim))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexao.OpenConn();
                        cmd.CommandText = "SELECT * FROM GridVendas WHERE idVenda >= @vendaIni";
                        cmd.Parameters.AddWithValue("@vendaIni", vendaIni);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                        cmd.Parameters.Clear();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Conexao.OpenConn();
                        cmd.CommandText = "SELECT TOP 0 * FROM GridVendas";
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(table);
                        }
                        cmd.Parameters.Clear();
                    }
                }
                return table;
            }
            catch (SqlException ex)
            {
                MensagemErro = string.Empty;
                MensagemErro = $"Erro ao executar o método {nameof(FiltroVenda)}\nErros:\n";

                foreach (SqlError erros in ex.Errors)
                    MensagemErro += erros.ToString() + "\n";

                throw;
            }
        }

        public Venda BuscaVendaPorId (int id)
        {
            try
            {
                DataTable table = new DataTable();
                Venda venda = null;
                Clientes cliente = new Clientes();
                FormasPagamento pagamento = new FormasPagamento();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conexao.OpenConn();
                    cmd.CommandText = "SELECT * FROM vendas WHERE idVenda = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(table);
                        foreach (DataRow dr in table.Rows)
                        {
                            venda = new Venda(Convert.ToInt32(dr["idVenda"]), cliente.BuscaPorId(Convert.ToInt32(dr["idCliente"])), Convert.ToDateTime(dr["dataLancamento"]), pagamento.BuscaPorId(Convert.ToInt32(dr["id_forma_pagamento"])), Convert.ToDecimal(dr["desconto"]), Convert.ToDecimal(dr["acrescimo"]), Convert.ToDecimal(dr["totalItens"]), Convert.ToDecimal(dr["totalDaVenda"]));
                        }
                    }
                }
                return venda;
            }
            catch (SqlException ex)
            {
                MensagemErro = string.Empty;
                MensagemErro = $"Erro ao executar o método {nameof(BuscaVendaPorId)}\nErros:\n";

                foreach (SqlError erros in ex.Errors)
                    MensagemErro += erros.ToString() + "\n";

                throw;
            }
        }

        public void ExcluirLancamentoVenda (int idVenda)
        {
            ItensDaVenda itens = new ItensDaVenda();
            var tableItens = itens.BuscaItensPorIdVenda(idVenda);
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd1 = new SqlCommand())
                    {
                        cmd1.Transaction = transaction;
                        cmd1.Connection = Conexao.OpenConn();
                        foreach (DataRow row in tableItens.Rows)
                        {
                            cmd1.CommandText = "UPDATE produtos SET estoque = estoque + @quantidade WHERE id = @idProduto";
                            cmd1.Parameters.AddWithValue("@quantidade", row["quantidade"]);
                            cmd1.Parameters.AddWithValue("@idProduto", row["id"]);
                            cmd1.ExecuteNonQuery();
                            cmd1.Parameters.Clear();
                        }
                    }
                    using (SqlCommand cmd2 = new SqlCommand())
                    {
                        cmd2.Transaction = transaction;
                        cmd2.Connection = Conexao.OpenConn();
                        cmd2.CommandText = "DELETE FROM itens_venda WHERE idVenda = @idVenda";
                        cmd2.Parameters.AddWithValue("@idVenda", idVenda);
                        cmd2.ExecuteNonQuery();
                        cmd2.Parameters.Clear();
                    }
                    using (SqlCommand cmd3 = new SqlCommand())
                    {
                        cmd3.Transaction = transaction;
                        cmd3.Connection = Conexao.OpenConn();
                        cmd3.CommandText = "DELETE FROM vendas WHERE idVenda = @idVenda";
                        cmd3.Parameters.AddWithValue("@idVenda", idVenda);
                        cmd3.ExecuteNonQuery();
                        cmd3.Parameters.Clear();
                    }
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();

                    MensagemErro = string.Empty;
                    MensagemErro = $"Erro ao executar o método {nameof(ExcluirLancamentoVenda)}\nErros:\n";

                    foreach (SqlError erros in ex.Errors)
                        MensagemErro += erros.ToString() + "\n";
                }
            }
        }

        public void UpdateLancamentoVenda (Venda venda, ItensDaVenda itens)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = "DELETE FROM itens_venda WHERE idVenda = @idVenda";
                        cmd.Parameters.AddWithValue("@idVenda", venda.IdVenda);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd.Transaction = transaction;
                        cmd.CommandText = "DELETE FROM itens_venda_temp";
                        cmd.ExecuteNonQuery();

                        foreach (var item in itens.ListItens)
                        {
                            cmd.CommandText = "INSERT INTO itens_venda VALUES (@idVenda, @idProduto, @quantidade, @vlr_unitario)";
                            cmd.Parameters.AddWithValue("@idVenda", venda.IdVenda);
                            cmd.Parameters.AddWithValue("@idProduto", item.Produto.Id);
                            cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                            cmd.Parameters.AddWithValue("@vlr_unitario", item.VlrUnitario);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            cmd.CommandText = "UPDATE produtos SET estoque = estoque - @quantidade WHERE id = @idProduto";
                            cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                            cmd.Parameters.AddWithValue("@idProduto", item.Produto.Id);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }

                        cmd.CommandText = "UPDATE vendas SET idCliente = @idCliente, id_forma_pagamento = @pagamento, desconto = @desconto, acrescimo = @acrescimo" +
                            ", totalItens = @totalItens, totalDaVenda = @totalVenda WHERE idVenda = @idVenda";
                        cmd.Parameters.AddWithValue("@idCliente", venda.Cliente.Id);
                        cmd.Parameters.AddWithValue("@pagamento", venda.Pagamento.Id);
                        cmd.Parameters.AddWithValue("@desconto", venda.Desconto);
                        cmd.Parameters.AddWithValue("@acrescimo", venda.Acrescimo);
                        cmd.Parameters.AddWithValue("@totalItens", venda.Total_itens);
                        cmd.Parameters.AddWithValue("@totalVenda", venda.Total_geral);
                        cmd.Parameters.AddWithValue("@idVenda", venda.IdVenda);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MensagemErro = $"Ocorreu um erro na execução do método {nameof(VendaDAO.UpdateLancamentoVenda)}\nErros:";
                    foreach (var erro in ex.Errors)
                        MensagemErro += $"{erro} \n";
                    
                    throw;
                }
            }
        }

        public void CancelaUpdateVenda (int idVenda)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = "DELETE FROM itens_venda WHERE idVenda = @idVenda";
                        cmd.Parameters.AddWithValue("@idVenda", idVenda);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "INSERT INTO itens_venda SELECT * FROM itens_venda_temp WHERE idVenda = @idVenda";
                        cmd.Parameters.AddWithValue("@idVenda", idVenda);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        cmd.CommandText = "SELECT * FROM itens_venda_temp WHERE idVenda = @idVenda";
                        cmd.Parameters.AddWithValue("@idVenda", idVenda);

                        using (SqlDataAdapter data = new SqlDataAdapter(cmd))
                        {
                            var table = new DataTable();
                            data.Fill(table);
                            foreach (DataRow row in table.Rows)
                            {
                                cmd.CommandText = "UPDATE produtos SET estoque = estoque - @quantidade WHERE id = @idProduto";
                                cmd.Parameters.AddWithValue("@quantidade", row["quantidade"]);
                                cmd.Parameters.AddWithValue("@idProduto", row["idProduto"]);
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                        }
                        cmd.CommandText = "DELETE FROM itens_venda_temp";
                        cmd.ExecuteNonQuery();
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

