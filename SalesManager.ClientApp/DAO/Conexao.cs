using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVendas.DAO
{
    public class Conexao
    {
        public static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["Default"].ConnectionString; } }
        private readonly static SqlConnection conn = new SqlConnection(ConnectionString);
        
        public static SqlConnection OpenConn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException)
                {
                    throw;
                }
            }
            return conn;
        }

        public static void CloseConn()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public static void BackupBancoDados()
        {
            using (SqlCommand cmd = OpenConn().CreateCommand())
            {
                cmd.CommandText = @"BACKUP DATABASE [projeto_csharp] TO  DISK = N'C:\Estudos\SistemaVendas\Backup\projeto_csharp.bak' " +
                    "WITH NOFORMAT, NOINIT,  NAME = N'projeto_csharp-Completo Banco de Dados Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
