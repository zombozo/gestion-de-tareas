namespace gestion_de_tareas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tarea_tb = new TextBox();
            descripcion = new Label();
            descripcion_tb = new TextBox();
            guardar = new Button();
            grid_tareas = new DataGridView();
            pendiente = new Button();
            enProgreso = new Button();
            estancada = new Button();
            revision = new Button();
            finalizada = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grid_tareas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 25);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Tarea";
            label1.Click += label1_Click;
            // 
            // tarea_tb
            // 
            tarea_tb.Location = new Point(158, 43);
            tarea_tb.Name = "tarea_tb";
            tarea_tb.Size = new Size(215, 23);
            tarea_tb.TabIndex = 2;
            // 
            // descripcion
            // 
            descripcion.AutoSize = true;
            descripcion.Location = new Point(379, 25);
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(69, 15);
            descripcion.TabIndex = 3;
            descripcion.Text = "Descripción";
            // 
            // descripcion_tb
            // 
            descripcion_tb.Location = new Point(379, 43);
            descripcion_tb.Name = "descripcion_tb";
            descripcion_tb.Size = new Size(427, 23);
            descripcion_tb.TabIndex = 4;
            // 
            // guardar
            // 
            guardar.Location = new Point(821, 43);
            guardar.Name = "guardar";
            guardar.Size = new Size(75, 23);
            guardar.TabIndex = 7;
            guardar.Text = "Crear";
            guardar.UseVisualStyleBackColor = false;
            guardar.Click += guardar_Click;
            // 
            // grid_tareas
            // 
            grid_tareas.AllowUserToOrderColumns = true;
            grid_tareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_tareas.Location = new Point(158, 99);
            grid_tareas.Name = "grid_tareas";
            grid_tareas.RowTemplate.Height = 25;
            grid_tareas.Size = new Size(738, 360);
            grid_tareas.TabIndex = 8;
            // 
            // pendiente
            // 
            pendiente.Location = new Point(39, 99);
            pendiente.Name = "pendiente";
            pendiente.Size = new Size(96, 23);
            pendiente.TabIndex = 9;
            pendiente.Text = "pendiente";
            pendiente.UseVisualStyleBackColor = true;
            pendiente.Click += pendiente_Click;
            // 
            // enProgreso
            // 
            enProgreso.Location = new Point(39, 144);
            enProgreso.Name = "enProgreso";
            enProgreso.Size = new Size(96, 23);
            enProgreso.TabIndex = 10;
            enProgreso.Text = "En progreso";
            enProgreso.UseVisualStyleBackColor = true;
            enProgreso.Click += enProgreso_Click;
            // 
            // estancada
            // 
            estancada.Location = new Point(39, 187);
            estancada.Name = "estancada";
            estancada.Size = new Size(96, 23);
            estancada.TabIndex = 11;
            estancada.Text = "estancada";
            estancada.UseVisualStyleBackColor = true;
            estancada.Click += estancada_Click;
            // 
            // revision
            // 
            revision.Location = new Point(39, 229);
            revision.Name = "revision";
            revision.Size = new Size(96, 23);
            revision.TabIndex = 12;
            revision.Text = "Revisión";
            revision.UseVisualStyleBackColor = true;
            revision.Click += revision_Click;
            // 
            // finalizada
            // 
            finalizada.Location = new Point(39, 272);
            finalizada.Name = "finalizada";
            finalizada.Size = new Size(96, 23);
            finalizada.TabIndex = 13;
            finalizada.Text = "Finalizada";
            finalizada.UseVisualStyleBackColor = true;
            finalizada.Click += finalizada_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 46);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 14;
            label2.Text = "Filtros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 572);
            Controls.Add(label2);
            Controls.Add(finalizada);
            Controls.Add(revision);
            Controls.Add(estancada);
            Controls.Add(enProgreso);
            Controls.Add(pendiente);
            Controls.Add(grid_tareas);
            Controls.Add(guardar);
            Controls.Add(descripcion_tb);
            Controls.Add(descripcion);
            Controls.Add(tarea_tb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grid_tareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tarea_tb;
        private Label descripcion;
        private TextBox descripcion_tb;
        private Button guardar;
        public DataGridView grid_tareas;
        private Button pendiente;
        private Button enProgreso;
        private Button estancada;
        private Button revision;
        private Button finalizada;
        private Label label2;
    }
}