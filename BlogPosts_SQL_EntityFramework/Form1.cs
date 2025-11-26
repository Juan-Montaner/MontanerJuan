using BlogPosts_SQL_EntityFramework.Data;
using BlogPosts_SQL_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BlogPosts_SQL_EntityFramework
{
    public partial class Form1 : Form
    {
        private readonly CrudWindowsFormContext personaDB = new();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using var db = new CrudWindowsFormContext();   // tu contexto
            var datos = await db.Personas                  // tu DbSet generado
                .AsNoTracking()
                .OrderBy(p => p.Nombre)
                .ToListAsync();

            DgvTabla.DataSource = datos;
        }

        #region HELPER
        public void Refrescar()
        {
            using (var db = new CrudWindowsFormContext())
            {
                var personas = db.Personas.ToList();
                DgvTabla.DataSource = personas;
            }
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FRmDatos frmPersonas = new FRmDatos();
            frmPersonas.ShowDialog();
            Refrescar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DgvTabla.CurrentRow != null)
            {
                int id = (int)DgvTabla.CurrentRow.Cells["Id"].Value;
                var persona = personaDB.Personas.Find(id);
                if (persona != null)
                {
                    FRmDatos frmPersona = new FRmDatos(id);
                    frmPersona.ShowDialog();
                    Refrescar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvTabla.CurrentRow != null)
            {
                int id = (int)DgvTabla.CurrentRow.Cells["Id"].Value;
                var persona = personaDB.Personas.Find(id);
                if (persona != null)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar a " + persona.Nombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        personaDB.Personas.Remove(persona);
                        personaDB.SaveChanges();
                        Refrescar();
                    }
                }
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
