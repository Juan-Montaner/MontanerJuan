using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBF.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DBF
{
    public partial class AlumnosUniversidad : Form
    {
        private int? _alumnoId;
        public AlumnosUniversidad(int? id = null)
        {
            InitializeComponent();

            this._alumnoId = id;
            if (id != null)
                CargarDatos(id.Value);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(_alumnoId != null)
            {
                ModificarAlumno();
            }
            else
            {
                AgregarAlumno();
            }
        }


        private void CargarDatos(int id)
        {
            using var db = new AppDbContext();
            var Alumno = db.Alumnos.AsNoTracking().FirstOrDefault(p => p.id == id);
            if (Alumno == null) return;

            TxtNombre.Text = Alumno.nombre;
            TxtNota.Text = Alumno.nota.ToString();

        }

        private void AgregarAlumno()
        {
            try
            {
                using var db = new AppDbContext();

                var Alumnos = new Alumno
                {
                    nombre = TxtNombre.Text,
                    nota = int.Parse(TxtNota.Text)
                };


                db.Alumnos.Add(Alumnos);
                db.SaveChanges();

                MessageBox.Show("Alumno agregado correctamente.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato en los datos ingresados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el alumno: " + ex.Message);
            }
            this.Close();
        }

        private void ModificarAlumno()
        {
            try
            {
                using var db = new AppDbContext();
                var alumno = db.Alumnos.Find(_alumnoId);
                if (alumno != null)
                {
                    alumno.nombre = TxtNombre.Text;
                    alumno.nota = int.Parse(TxtNota.Text);
                    db.SaveChanges();
                    MessageBox.Show("Alumno modificado correctamente.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato en los datos ingresados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el alumno: " + ex.Message);
            }
            this.Close();
        }
    }
}
