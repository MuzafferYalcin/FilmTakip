using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ConnectionString
    {
        public static SqlConnection connection = new SqlConnection(@"Server=DESKTOP-8JBJMG8\SQLEXPRESS;Database=FilmArsivDb;Integrated Security=true; TrustServerCertificate=True");
    }
}
