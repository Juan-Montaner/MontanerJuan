namespace ado_multiplestablas
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
            BtnEliminarPasaje = new Button();
            BtnModificarPasaje = new Button();
            BtnAgregarPasajes = new Button();
            DGVPasajes = new DataGridView();
            DGVPasajeros = new DataGridView();
            DgvAvion = new DataGridView();
            BtnEliminarPasajeros = new Button();
            BtnModificarPasajeros = new Button();
            BtnAgregarPasajero = new Button();
            BtnEliminarAvion = new Button();
            BtnModificarAvion = new Button();
            btnAgregarAvion = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVPasajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVPasajeros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvAvion).BeginInit();
            SuspendLayout();
            // 
            // BtnEliminarPasaje
            // 
            BtnEliminarPasaje.Location = new Point(235, 11);
            BtnEliminarPasaje.Margin = new Padding(3, 2, 3, 2);
            BtnEliminarPasaje.Name = "BtnEliminarPasaje";
            BtnEliminarPasaje.Size = new Size(88, 40);
            BtnEliminarPasaje.TabIndex = 9;
            BtnEliminarPasaje.Text = "Eliminar Pasajes";
            BtnEliminarPasaje.UseVisualStyleBackColor = true;
            // 
            // BtnModificarPasaje
            // 
            BtnModificarPasaje.Location = new Point(123, 11);
            BtnModificarPasaje.Margin = new Padding(3, 2, 3, 2);
            BtnModificarPasaje.Name = "BtnModificarPasaje";
            BtnModificarPasaje.Size = new Size(88, 40);
            BtnModificarPasaje.TabIndex = 8;
            BtnModificarPasaje.Text = "Modificar Pasajes";
            BtnModificarPasaje.UseVisualStyleBackColor = true;
            BtnModificarPasaje.Click += BtnModificarPasaje_Click;
            // 
            // BtnAgregarPasajes
            // 
            BtnAgregarPasajes.Location = new Point(20, 11);
            BtnAgregarPasajes.Margin = new Padding(3, 2, 3, 2);
            BtnAgregarPasajes.Name = "BtnAgregarPasajes";
            BtnAgregarPasajes.Size = new Size(88, 40);
            BtnAgregarPasajes.TabIndex = 7;
            BtnAgregarPasajes.Text = "Agregar Pasajes";
            BtnAgregarPasajes.UseVisualStyleBackColor = true;
            BtnAgregarPasajes.Click += BtnAgregar_Click;
            // 
            // DGVPasajes
            // 
            DGVPasajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPasajes.Location = new Point(21, 84);
            DGVPasajes.Margin = new Padding(3, 2, 3, 2);
            DGVPasajes.Name = "DGVPasajes";
            DGVPasajes.RowHeadersWidth = 51;
            DGVPasajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVPasajes.Size = new Size(302, 506);
            DGVPasajes.TabIndex = 6;
            // 
            // DGVPasajeros
            // 
            DGVPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPasajeros.Location = new Point(543, 84);
            DGVPasajeros.Margin = new Padding(3, 2, 3, 2);
            DGVPasajeros.Name = "DGVPasajeros";
            DGVPasajeros.RowHeadersWidth = 51;
            DGVPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVPasajeros.Size = new Size(302, 506);
            DGVPasajeros.TabIndex = 12;
            // 
            // DgvAvion
            // 
            DgvAvion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAvion.Location = new Point(1072, 84);
            DgvAvion.Margin = new Padding(3, 2, 3, 2);
            DgvAvion.Name = "DgvAvion";
            DgvAvion.RowHeadersWidth = 51;
            DgvAvion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvAvion.Size = new Size(302, 506);
            DgvAvion.TabIndex = 13;
            // 
            // BtnEliminarPasajeros
            // 
            BtnEliminarPasajeros.Location = new Point(763, 11);
            BtnEliminarPasajeros.Margin = new Padding(3, 2, 3, 2);
            BtnEliminarPasajeros.Name = "BtnEliminarPasajeros";
            BtnEliminarPasajeros.Size = new Size(88, 40);
            BtnEliminarPasajeros.TabIndex = 16;
            BtnEliminarPasajeros.Text = "Eliminar Pasajero";
            BtnEliminarPasajeros.UseVisualStyleBackColor = true;
            // 
            // BtnModificarPasajeros
            // 
            BtnModificarPasajeros.Location = new Point(651, 11);
            BtnModificarPasajeros.Margin = new Padding(3, 2, 3, 2);
            BtnModificarPasajeros.Name = "BtnModificarPasajeros";
            BtnModificarPasajeros.Size = new Size(88, 40);
            BtnModificarPasajeros.TabIndex = 15;
            BtnModificarPasajeros.Text = "Modificar Pasajero";
            BtnModificarPasajeros.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarPasajero
            // 
            BtnAgregarPasajero.Location = new Point(548, 11);
            BtnAgregarPasajero.Margin = new Padding(3, 2, 3, 2);
            BtnAgregarPasajero.Name = "BtnAgregarPasajero";
            BtnAgregarPasajero.Size = new Size(88, 40);
            BtnAgregarPasajero.TabIndex = 14;
            BtnAgregarPasajero.Text = "Agregar Pasajero";
            BtnAgregarPasajero.UseVisualStyleBackColor = true;
            BtnAgregarPasajero.Click += BtnAgregarPasajero_Click;
            // 
            // BtnEliminarAvion
            // 
            BtnEliminarAvion.Location = new Point(1288, 11);
            BtnEliminarAvion.Margin = new Padding(3, 2, 3, 2);
            BtnEliminarAvion.Name = "BtnEliminarAvion";
            BtnEliminarAvion.Size = new Size(88, 40);
            BtnEliminarAvion.TabIndex = 19;
            BtnEliminarAvion.Text = "Eliminar Avion";
            BtnEliminarAvion.UseVisualStyleBackColor = true;
            // 
            // BtnModificarAvion
            // 
            BtnModificarAvion.Location = new Point(1176, 11);
            BtnModificarAvion.Margin = new Padding(3, 2, 3, 2);
            BtnModificarAvion.Name = "BtnModificarAvion";
            BtnModificarAvion.Size = new Size(88, 40);
            BtnModificarAvion.TabIndex = 18;
            BtnModificarAvion.Text = "Modificar Avion";
            BtnModificarAvion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAvion
            // 
            btnAgregarAvion.Location = new Point(1073, 11);
            btnAgregarAvion.Margin = new Padding(3, 2, 3, 2);
            btnAgregarAvion.Name = "btnAgregarAvion";
            btnAgregarAvion.Size = new Size(88, 40);
            btnAgregarAvion.TabIndex = 17;
            btnAgregarAvion.Text = "Agregar Avion";
            btnAgregarAvion.UseVisualStyleBackColor = true;
            btnAgregarAvion.Click += btnAgregarAvion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 678);
            Controls.Add(BtnEliminarAvion);
            Controls.Add(BtnModificarAvion);
            Controls.Add(btnAgregarAvion);
            Controls.Add(BtnEliminarPasajeros);
            Controls.Add(BtnModificarPasajeros);
            Controls.Add(BtnAgregarPasajero);
            Controls.Add(DgvAvion);
            Controls.Add(DGVPasajeros);
            Controls.Add(BtnEliminarPasaje);
            Controls.Add(BtnModificarPasaje);
            Controls.Add(BtnAgregarPasajes);
            Controls.Add(DGVPasajes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGVPasajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVPasajeros).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvAvion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnEliminarPasaje;
        private Button BtnModificarPasaje;
        private Button BtnAgregarPasajes;
        private DataGridView DGVPasajes;
        private DataGridView DGVPasajeros;
        private DataGridView DgvAvion;
        private Button BtnEliminarPasajeros;
        private Button BtnModificarPasajeros;
        private Button BtnAgregarPasajero;
        private Button BtnEliminarAvion;
        private Button BtnModificarAvion;
        private Button btnAgregarAvion;
    }
}
