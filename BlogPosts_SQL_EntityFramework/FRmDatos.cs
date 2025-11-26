using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BlogPosts_SQL_EntityFramework.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogPosts_SQL_EntityFramework
{
    public partial class FRmDatos : Form
    {
        private int? id;
        public FRmDatos(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargarDatos(id.Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                ModificarPersonas();
            }
            else
            {
                AgregarPersonas();
            }
        }

        private void AgregarPersonas()
        {
            try
            {
                using var db = new CrudWindowsFormContext();

                int? tel = string.IsNullOrWhiteSpace(txtNumTelefono.Text) ? null : int.Parse(txtNumTelefono.Text);

                var persona = new Models.Persona
                {
                    Nombre = txtnombre.Text,
                    NumTelefono = tel,
                    Mail = txtMail.Text
                };

                db.Personas.Add(persona);
                db.SaveChanges();

                MessageBox.Show("Persona agregada correctamente ");
            }
            catch (FormatException)
            {
                MessageBox.Show("El número de teléfono no tiene un formato válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
            }
            this.Close();
        }

        private void ModificarPersonas()
        {
            try
            {
                using var db = new CrudWindowsFormContext();
                var persona = db.Personas.Find(id);

                if (persona == null) return;

                int? tel = string.IsNullOrWhiteSpace(txtNumTelefono.Text) ? null : int.Parse(txtNumTelefono.Text);

                persona.Nombre = txtnombre.Text;
                persona.NumTelefono = tel;
                persona.Mail = txtMail.Text;

                db.SaveChanges();

                MessageBox.Show("Persona modificada correctamente ");
            }
            catch (FormatException)
            {
                MessageBox.Show("El número de teléfono no tiene un formato válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar: " + ex.Message);
            }
            this.Close();
        }

        private void CargarDatos(int id)
        {
            using var db = new CrudWindowsFormContext();
            var persona = db.Personas.AsNoTracking().FirstOrDefault(p => p.Id == id);
            if (persona == null) return;

            txtnombre.Text = persona.Nombre;
            txtNumTelefono.Text = persona.NumTelefono?.ToString() ?? string.Empty; // si es string, quitá el ToString()
            txtMail.Text = persona.Mail ?? string.Empty;

        }
    }
}
