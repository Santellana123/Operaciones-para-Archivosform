namespace Operaciones_para_Archivosform
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
            btnAbrir = new Button();
            btnCrear = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            listViewArchivo = new ListView();
            textEscribir = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(41, 63);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(41, 102);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(41, 224);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(41, 141);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(41, 183);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // listViewArchivo
            // 
            listViewArchivo.Location = new Point(169, 141);
            listViewArchivo.Name = "listViewArchivo";
            listViewArchivo.Size = new Size(511, 210);
            listViewArchivo.TabIndex = 5;
            listViewArchivo.UseCompatibleStateImageBehavior = false;
            // 
            // textEscribir
            // 
            textEscribir.Location = new Point(169, 63);
            textEscribir.Name = "textEscribir";
            textEscribir.Size = new Size(437, 23);
            textEscribir.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(612, 63);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(textEscribir);
            Controls.Add(listViewArchivo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCrear);
            Controls.Add(btnAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private Button btnCrear;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListView listViewArchivo;
        private TextBox textEscribir;
        private Button btnAgregar;
    }
}
