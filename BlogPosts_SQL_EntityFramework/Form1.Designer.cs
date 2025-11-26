namespace BlogPosts_SQL_EntityFramework
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
            DgvTabla = new DataGridView();
            btnRefrescar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvTabla).BeginInit();
            SuspendLayout();
            // 
            // DgvTabla
            // 
            DgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTabla.Location = new Point(12, 57);
            DgvTabla.Name = "DgvTabla";
            DgvTabla.RowHeadersWidth = 51;
            DgvTabla.Size = new Size(631, 329);
            DgvTabla.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            btnRefrescar.ImeMode = ImeMode.NoControl;
            btnRefrescar.Location = new Point(238, 444);
            btnRefrescar.Margin = new Padding(2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(90, 27);
            btnRefrescar.TabIndex = 26;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnSalir
            // 
            btnSalir.ImeMode = ImeMode.NoControl;
            btnSalir.Location = new Point(170, 490);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 27);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(94, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 24;
            label1.Text = "GESTIÓNAR TABLA SQL";
            // 
            // btnAgregar
            // 
            btnAgregar.ImeMode = ImeMode.NoControl;
            btnAgregar.Location = new Point(102, 402);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 27);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ImeMode = ImeMode.NoControl;
            btnEliminar.Location = new Point(238, 402);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 27);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.ImeMode = ImeMode.NoControl;
            btnModificar.Location = new Point(102, 444);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 27);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 536);
            Controls.Add(btnRefrescar);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(DgvTabla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvTabla;
        private Button btnRefrescar;
        private Button btnSalir;
        private Label label1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}
