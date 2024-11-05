using System.Data.SqlClient;

namespace ProjetoELP4 {
    internal class Banco {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vinic\Faculdade\elp4\ProjetoELP4\BD_2024-2_ELP4.mdf;Integrated Security=True";

        public static SqlConnection Abrir() {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            return conn;
        }
    }
}
