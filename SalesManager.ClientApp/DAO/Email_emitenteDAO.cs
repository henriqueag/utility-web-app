using SistemaVendas.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVendas.DAO
{
    public class Email_emitenteDAO
    {
        public void InsertEmail (Email_emitente emitente)
        {
            using (SqlTransaction transaction = Conexao.OpenConn().BeginTransaction())
            {
                try
                {
                    using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = "DELETE FROM email_emitente";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "INSERT INTO email_emitente VALUES (@smtp, @email, @senha, @porta, @ssl)";
                        cmd.Parameters.AddWithValue("@smtp", emitente.ServidorSMTP);
                        cmd.Parameters.AddWithValue("@email", emitente.Email);
                        cmd.Parameters.AddWithValue("@senha", emitente.SenhaEmail);
                        cmd.Parameters.AddWithValue("@porta", emitente.Porta);
                        cmd.Parameters.AddWithValue("@ssl", emitente.EnableSSL.ToString());
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

        public Email_emitente SelectEmail ()
        {
            try
            {
                Email_emitente emitente = null;
                using (SqlCommand cmd = Conexao.OpenConn().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM email_emitente";
                    using (SqlDataAdapter data = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        data.Fill(table);
                        if (table.Rows.Count > 0)
                            emitente = new Email_emitente(table.Rows[0].ItemArray[0].ToString(), table.Rows[0].ItemArray[1].ToString(), table.Rows[0].ItemArray[2].ToString(), Convert.ToInt32(table.Rows[0].ItemArray[3]), Convert.ToBoolean(table.Rows[0].ItemArray[4]));
                    }
                }
                return emitente;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
