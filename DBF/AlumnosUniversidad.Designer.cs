namespace DBF
{
    partial class AlumnosUniversidad
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
            TxtNota = new TextBox();
            TxtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnGuardar = new Button();
            SuspendLayout();
            // 
            // TxtNota
            // 
            TxtNota.Location = new Point(106, 64);
            TxtNota.Margin = new Padding(3, 4, 3, 4);
            TxtNota.Name = "TxtNota";
            TxtNota.Size = new Size(114, 27);
            TxtNota.TabIndex = 9;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(106, 17);
            TxtNombre.Margin = new Padding(3, 4, 3, 4);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(114, 27);
            TxtNombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 64);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 7;
            label2.Text = "Nota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(23, 136);
            BtnGuardar.Margin = new Padding(3, 4, 3, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(86, 31);
            BtnGuardar.TabIndex = 5;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // AlumnosUniversidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNota);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGuardar);
            Name = "AlumnosUniversidad";
            Text = "AlumnosUniversidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNota;
        private TextBox TxtNombre;
        private Label label2;
        private Label label1;
        private Button BtnGuardar;
    }
}