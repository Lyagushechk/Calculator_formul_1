using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Calculator_foormul
{
    public class NpgsqlConnection
    {
        public string ConnectionString { get; set; }

        public NpgsqlConnection(string connectionString)
        {
            ConnectionString = "Host=localhost;Port=5432;Database=PostgreSQL;Username=postgresql;Password=12345111;";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        }
    }
}
