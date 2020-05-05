using System;
using Ada_CSharp_Try.Classes;
using Npgsql;

namespace Ada_CSharp_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Dimension_Space Word_Space = new Dimension_Space("word", .4, .34, .03, 5.0, .8);

            var connection_string = "Host=localhost;Username=patrickabbs;Password=password;Database=ada_csharp";

            using var connection = new NpgsqlConnection(connection_string);
            connection.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, connection);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"PostgreSQL version: {version}");

            Console.WriteLine(Word_Space.Space_Name);
            Console.WriteLine("Hello World!");
        }
    }
}
