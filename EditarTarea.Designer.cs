namespace gestion_de_tareas
{
    partial class EditarTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NomTaChk = new TextBox();
            DescrTaChk = new TextBox();
            fechaVDT = new DateTimePicker();
            Actualizar = new Button();
            labelNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            estadoTaChk = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            fechaFinVDT = new DateTimePicker();
            SuspendLayout();
            // 
            // NomTaChk
            // 
            NomTaChk.Location = new Point(60, 49);
            NomTaChk.Name = "NomTaChk";
            NomTaChk.Size = new Size(202, 23);
            NomTaChk.TabIndex = 0;
            // 
            // DescrTaChk
            // 
            DescrTaChk.Location = new Point(60, 114);
            DescrTaChk.Name = "DescrTaChk";
            DescrTaChk.Size = new Size(202, 23);
            DescrTaChk.TabIndex = 1;
            // 
            // fechaVDT
            // 
            fechaVDT.Location = new Point(60, 227);
            fechaVDT.Name = "fechaVDT";
            fechaVDT.ShowCheckBox = true;
            fechaVDT.Size = new Size(202, 23);
            fechaVDT.TabIndex = 3;
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(60, 401);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(202, 23);
            Actualizar.TabIndex = 4;
            Actualizar.Text = "Guardar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(57, 22);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(108, 15);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Nombre de la tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 87);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 7;
            label2.Text = "Descripción de la tarea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 154);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Estado";
            // 
            // estadoTaChk
            // 
            estadoTaChk.FormattingEnabled = true;
            estadoTaChk.Items.AddRange(new object[] { "Pendiente", "En progreso", "Estancada", "Revision", "Finalizada" });
            estadoTaChk.Location = new Point(60, 172);
            estadoTaChk.Name = "estadoTaChk";
            estadoTaChk.Size = new Size(202, 23);
            estadoTaChk.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 209);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Fecha inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 269);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Fecha fin";
            // 
            // fechaFinVDT
            // 
            fechaFinVDT.Location = new Point(57, 287);
            fechaFinVDT.Name = "fechaFinVDT";
            fechaFinVDT.ShowCheckBox = true;
            fechaFinVDT.Size = new Size(205, 23);
            fechaFinVDT.TabIndex = 12;
            // 
            // EditarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(fechaFinVDT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(estadoTaChk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelNombre);
            Controls.Add(Actualizar);
            Controls.Add(fechaVDT);
            Controls.Add(DescrTaChk);
            Controls.Add(NomTaChk);
            Name = "EditarTarea";
            Text = "EditarTarea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NomTaChk;
        private TextBox DescrTaChk;
        private DateTimePicker fechaVDT;
        private Button Actualizar;
        private Label labelNombre;
        private Label label2;
        private Label label3;
        private ComboBox estadoTaChk;
        private Label label4;
        private Label label5;
        private DateTimePicker fechaFinVDT;
    }
}