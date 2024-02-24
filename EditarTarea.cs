using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace gestion_de_tareas
{
    public partial class EditarTarea : Form
    {
        private Tarea TareaEdit { get; set; }
        public EditarTarea(Tarea tarea)
        {
            InitializeComponent();
            if (tarea != null)
            {
                TareaEdit = tarea;
                NomTaChk.Text = tarea.nombre_tarea;
                DescrTaChk.Text = tarea.descripcion_tarea;
                estadoTaChk.Text = tarea.estado;
                if (tarea.fecha != null)
                {
                    fechaVDT.Value = (DateTime)tarea.fecha;
                }
                if (tarea.fecha_fin != null)
                {
                    fechaFinVDT.Value = (DateTime)tarea.fecha_fin;
                }
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (TareaEdit != null)
            {
                TareaEdit.nombre_tarea = NomTaChk.Text;
                TareaEdit.descripcion_tarea = DescrTaChk.Text;
                TareaEdit.estado = estadoTaChk.Text;
                TareaEdit.fecha = fechaVDT.Value;
                TareaEdit.fecha_fin = fechaFinVDT.Value;
                int rowAffected = TareaEdit.UpdateModel();
                MessageBox.Show($"La tarea ha sido actualizada. tareas afectadas {rowAffected}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                Tarea tarea = new Tarea();
                tarea.nombre_tarea = NomTaChk.Text;
                tarea.descripcion_tarea = DescrTaChk.Text;
                tarea.estado = estadoTaChk.Text;
                tarea.fecha = fechaVDT.Value;
                int rowAffected = tarea.UpdateModel();
                MessageBox.Show($"La tarea ha sido actualizada. tareas afectadas {rowAffected}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
