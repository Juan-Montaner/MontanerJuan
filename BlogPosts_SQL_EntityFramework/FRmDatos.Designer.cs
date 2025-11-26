namespace BlogPosts_SQL_EntityFramework
{
    partial class FRmDatos
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
            lblNombre = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            txtnombre = new TextBox();
            txtNumTelefono = new TextBox();
            txtMail = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ImeMode = ImeMode.NoControl;
            lblNombre.Location = new Point(42, 37);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(42, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 31;
            label2.Text = "NumTelefono";
            // 
            // btnGuardar
            // 
            btnGuardar.ImeMode = ImeMode.NoControl;
            btnGuardar.Location = new Point(145, 193);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 27);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(145, 34);
            txtnombre.Margin = new Padding(2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(270, 27);
            txtnombre.TabIndex = 32;
            // 
            // txtNumTelefono
            // 
            txtNumTelefono.Location = new Point(145, 78);
            txtNumTelefono.Margin = new Padding(2);
            txtNumTelefono.Name = "txtNumTelefono";
            txtNumTelefono.Size = new Size(270, 27);
            txtNumTelefono.TabIndex = 34;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(145, 124);
            txtMail.Margin = new Padding(2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(270, 27);
            txtMail.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(42, 127);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 36;
            label1.Text = "Mail";
            // 
            // FRmDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(txtNumTelefono);
            Controls.Add(lblNombre);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(txtnombre);
            Name = "FRmDatos";
            Text = "FRmDatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDatosPersona;
        private Label lblNombre;
        private Label label2;
        private Button btnGuardar;
        private TextBox txtnombre;
        private TextBox txtNumTelefono;
        private TextBox txtMail;
        private Label label1;
    }
}