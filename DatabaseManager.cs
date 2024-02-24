using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_tareas
{
    internal class DatabaseManager
    {
        private String Connection = "Host=127.0.0.1;Port=5432;Username=postgres;Password=qwerty;Database=postgres";
        

        public DatabaseManager() { }
        public NpgsqlConnection Connect() {
            var conn = new NpgsqlConnection(this.Connection);
            conn.Open();
            return conn;
        }
    }
}
