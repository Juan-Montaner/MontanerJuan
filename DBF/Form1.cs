using DBF.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace DBF
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext AlumnoDB = new();
 
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            using var Db = new AppDbContext();
            var datos = await Db.Alumnos
                .AsNoTracking()
                .OrderBy(p => p.id)
                .ToListAsync();

            DgvAlumnosUniversidad.DataSource = datos;
        }

        #region HELPER
        public void Refrescar()
        {
            using (var db = new AppDbContext())
            {
                var alumnos = db.Alumnos.ToList();
                DgvAlumnosUniversidad.DataSource = alumnos;
            }
        }
        #endregion

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AlumnosUniversidad alumnos = new AlumnosUniversidad();
            alumnos.ShowDialog();
            Refrescar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvAlumnosUniversidad.CurrentRow != null)
            {
                int id = (int)DgvAlumnosUniversidad.CurrentRow.Cells["id"].Value;
                var alumno = new RepositorioAlumnos().listar().FirstOrDefault(a => a.id == id);
                if (alumno != null)
                {
                    AlumnosUniversidad alumnos = new AlumnosUniversidad(id);
                    alumnos.ShowDialog();
                    Refrescar();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAlumnosUniversidad.CurrentRow != null)
            {
                int id = (int)DgvAlumnosUniversidad.CurrentRow.Cells["Id"].Value;
                var persona = AlumnoDB.Alumnos.Find(id);
                if (persona != null)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de eliminar a " + persona.nombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        AlumnoDB.Alumnos.Remove(persona);
                        AlumnoDB.SaveChanges();
                        Refrescar();
                    }
                }
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
