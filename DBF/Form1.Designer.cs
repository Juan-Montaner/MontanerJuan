namespace DBF
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
            BtnSalir = new Button();
            BtnRefrescar = new Button();
            BtnEliminar = new Button();
            BtnModificar = new Button();
            BtnAgregar = new Button();
            DgvAlumnosUniversidad = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvAlumnosUniversidad).BeginInit();
            SuspendLayout();
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(133, 525);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(86, 31);
            BtnSalir.TabIndex = 11;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnRefrescar
            // 
            BtnRefrescar.Location = new Point(198, 461);
            BtnRefrescar.Margin = new Padding(3, 4, 3, 4);
            BtnRefrescar.Name = "BtnRefrescar";
            BtnRefrescar.Size = new Size(86, 31);
            BtnRefrescar.TabIndex = 10;
            BtnRefrescar.Text = "Refrescar";
            BtnRefrescar.UseVisualStyleBackColor = true;
            BtnRefrescar.Click += BtnRefrescar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(198, 405);
            BtnEliminar.Margin = new Padding(3, 4, 3, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(86, 31);
            BtnEliminar.TabIndex = 9;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(72, 461);
            BtnModificar.Margin = new Padding(3, 4, 3, 4);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(86, 31);
            BtnModificar.TabIndex = 8;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(72, 405);
            BtnAgregar.Margin = new Padding(3, 4, 3, 4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(86, 31);
            BtnAgregar.TabIndex = 7;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // DgvAlumnosUniversidad
            // 
            DgvAlumnosUniversidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAlumnosUniversidad.Location = new Point(12, 13);
            DgvAlumnosUniversidad.Margin = new Padding(3, 4, 3, 4);
            DgvAlumnosUniversidad.Name = "DgvAlumnosUniversidad";
            DgvAlumnosUniversidad.RowHeadersWidth = 51;
            DgvAlumnosUniversidad.Size = new Size(497, 363);
            DgvAlumnosUniversidad.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 642);
            Controls.Add(BtnSalir);
            Controls.Add(BtnRefrescar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnModificar);
            Controls.Add(BtnAgregar);
            Controls.Add(DgvAlumnosUniversidad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)DgvAlumnosUniversidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSalir;
        private Button BtnRefrescar;
        private Button BtnEliminar;
        private Button BtnModificar;
        private Button BtnAgregar;
        private DataGridView DgvAlumnosUniversidad;
    }
}
