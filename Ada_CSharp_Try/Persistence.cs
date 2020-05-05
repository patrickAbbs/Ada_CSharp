using System;
using Npgsql;

namespace Ada_CSharp_Try
{
    public class Persistence
    {
        public Persistence()
        {
            var connection_string = "Host=localhost;Username=patrickabbs;Password=password;Database=ada_csharp";

            using var connection = new NpgsqlConnection(connection_string);
            connection.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, connection);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"PostgreSQL version: {version}");
        }

    }
}
