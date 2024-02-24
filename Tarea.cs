using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_de_tareas
{
    public class Tarea
    {
        public int id { get; set; }
        public string? nombre_tarea { get; set; }
        public string? descripcion_tarea { get; set; }
        public string? estado { get; set; }
        public DateTime? fecha { get; set; }
        public DateTime? fecha_fin {  get; set; }   

        public Tarea() { }
        public Tarea(int id, string nombre_tarea, string descripcion_tarea, string estado, DateTime? fecha, DateTime? fecha_fin)
        {
            this.id = id;
            this.nombre_tarea = nombre_tarea;
            this.descripcion_tarea = descripcion_tarea;
            this.estado = estado;
            this.fecha = fecha;
            this.fecha_fin = fecha_fin;
        }
        public int save_model()
        {
            DatabaseManager dbmanager = new DatabaseManager();
            NpgsqlConnection conn = dbmanager.Connect();
            String insert = $"insert into tarea(tarea, descripcion) values(@nombre, @descripcion);";
            using (var cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", this.nombre_tarea);
                cmd.Parameters.AddWithValue("@descripcion", this.descripcion_tarea);
                int result = cmd.ExecuteNonQuery();

                return result;
            }

        }
        public int UpdateModel()
        {
            DatabaseManager dbmanager = new DatabaseManager();
            NpgsqlConnection conn = dbmanager.Connect();
            String insert = $"update tarea SET tarea = @nombre, descripcion = @descripcion, estado=@estado, fecha=@fecha, fecha_fin=@fecha_fin WHERE id=@id";
            using (var cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", this.nombre_tarea);
                cmd.Parameters.AddWithValue("@descripcion", this.descripcion_tarea);
                cmd.Parameters.AddWithValue("@estado", this.estado);
                cmd.Parameters.AddWithValue("@fecha", this.fecha);
                cmd.Parameters.AddWithValue("@fecha_fin", this.fecha_fin);
                cmd.Parameters.AddWithValue("@id", this.id);
                int rowAffected = cmd.ExecuteNonQuery();
                return rowAffected;
            }
            return 0;
        }
        public bool create_table()
        {
            DatabaseManager dbmanager = new DatabaseManager();
            NpgsqlConnection conn = dbmanager.Connect();
            String query = "CREATE TABLE IF NOT EXISTS tarea(id SERIAL PRIMARY KEY, tarea VARCHAR(150) NOT NULL, descripcion VARCHAR(200), estado VARCHAR(20), fecha Datetime);";
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    Console.WriteLine(reader.GetString(0));
            conn.Close();

            return true;
        }

        public List<Tarea> get_tareas(String query)
        {
            DatabaseManager dbmanager = new DatabaseManager();
            NpgsqlConnection conn = dbmanager.Connect();

            List<Tarea> tareas = new List<Tarea>();
            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    DateTime? fech = null;
                    DateTime? fechFin = null;
                    string? estado = null;

                    if (!reader.IsDBNull(4))
                    {
                        fech = reader.GetDateTime(4);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        estado = reader.GetString(3);
                    }
                    if (!reader.IsDBNull(5))
                    {
                        fechFin = reader.GetDateTime(5);
                    }
                    Tarea tarea = new Tarea(
                        id = reader.GetInt32(0),
                        nombre_tarea = reader.GetString(1),
                        descripcion_tarea = reader.GetString(2),
                        estado = estado,
                        fecha = fech,
                        fecha_fin = fechFin
                        );
                    tareas.Add(tarea);
                }
            conn.Close();
            return tareas;
        }

        public List<Tarea> get_pendiente()
        {
            // 
            String query = "SELECT * FROM  public.tarea WHERE estado='Pendiente';";

            List<Tarea> tareas = get_tareas(query);
            return tareas;

        }
        public List<Tarea> get_inprogress()
        {
            String query = "SELECT * FROM  public.tarea WHERE estado='En progreso';";

            List<Tarea> tareas = get_tareas(query);
            return tareas;
        }
        public List<Tarea> get_estancada()
        {
            String query = "SELECT * FROM  public.tarea WHERE estado='Estancada';";

            List<Tarea> tareas = get_tareas(query);
            return tareas;

        }
        public List<Tarea> get_revision()
        {
            String query = "SELECT * FROM  public.tarea WHERE estado='Revision';";

            List<Tarea> tareas = get_tareas(query);
            return tareas;
        }
        public List<Tarea> get_finalizada()
        {
            //Finalizada
            String query = "SELECT * FROM  public.tarea WHERE estado='Finalizada';";

            List<Tarea> tareas = get_tareas(query);
            return tareas;
        }
        public List<Tarea> get_all()
        {
            String query = "SELECT * FROM  public.tarea;";

            List<Tarea> tareas = get_tareas(query);
            return tareas;
        }
    } 
}
