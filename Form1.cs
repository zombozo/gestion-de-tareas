using Npgsql;

namespace gestion_de_tareas
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
            Tarea tarea = new Tarea();
            this.Text = "Control de tareas";
            tareas = tarea.get_all();
            grid_tareas.AutoGenerateColumns = true;
            grid_tareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_tareas.DataSource = tareas;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grid_tareas.Columns.Add(btn);
            btn.HeaderText = "Edit";
            btn.Text = "Edit";
            btn.Name = "Edit";
            btn.UseColumnTextForButtonValue = true;

            grid_tareas.CellClick += Grid_tareas_CellClick;
        }

        private void Grid_tareas_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid_tareas.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = grid_tareas.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                editar_tarea(id);
            }
        }
        private void editar_tarea(int id)
        {
            foreach (Tarea tarea in tareas)
            {
                if (tarea.id == id)
                {
                    EditarTarea editarTarea = new EditarTarea(tarea);

                    DialogResult result = editarTarea.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        get_all_tareas();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        get_all_tareas();
                    }

                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Tarea Newtarea = new Tarea();
            Newtarea.nombre_tarea = tarea_tb.Text;
            Newtarea.descripcion_tarea = descripcion_tb.Text;
            guardar_tarea(Newtarea);

            tarea_tb.Text = "";
            descripcion_tb.Text = "";

        }

        private void get_all_tareas()
        {
            Tarea tarea = new Tarea();
            List<Tarea> tareas = tarea.get_all();
            Actualizar_datagridview(tareas);
        }
        private void guardar_tarea(Tarea tarea)
        {
            tarea.create_table();
            tarea.save_model();


            
        }

        public void Actualizar_datagridview(List<Tarea> tareas)
        {
            grid_tareas.DataSource = null;
            grid_tareas.AutoGenerateColumns = true;
            grid_tareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_tareas.DataSource = tareas;
        }

        private void pendiente_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();
            List<Tarea> tareas = tarea.get_pendiente();
            Actualizar_datagridview(tareas);
        }

        private void enProgreso_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();
            List<Tarea> tareas = tarea.get_inprogress();
            Actualizar_datagridview(tareas);
        }

        private void estancada_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();
            List<Tarea> tareas = tarea.get_estancada();
            Actualizar_datagridview(tareas);
        }

        private void revision_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();
            List<Tarea> tareas = tarea.get_revision();
            Actualizar_datagridview(tareas);
        }

        private void finalizada_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();
            List<Tarea> tareas = tarea.get_finalizada();
            Actualizar_datagridview(tareas);
        }
    }
}