using DBF.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF
{
    public class RepositorioAlumnos
    {
        private AppDbContext _appDbContext;

        public RepositorioAlumnos()
        {
            _appDbContext = new AppDbContext();
        }
        public List<Alumno> listar()
        {
            return _appDbContext.Alumnos.ToList();
        }

        public void Agregar(Alumno alumno)
        {
            try
            {
                _appDbContext.Alumnos.Add(alumno);
                _appDbContext.SaveChanges();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error en la base de datos" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("se encontro un error de formato" + ex);
            }


        }

        public void Eliminar(int id)
        {
            try
            {
                var alumno = _appDbContext.Alumnos.Find(id);

                if (alumno != null)
                {
                    _appDbContext.Alumnos.Remove(alumno);
                    _appDbContext.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error en la base de datos" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("se encontro un error de formato" + ex);
            }


        }

        public void Modificar(Alumno alumno)
        {
            try
            {
                var AlumnosEncontrado = _appDbContext.Alumnos.FirstOrDefault(x => x.id == alumno.id);
                if (AlumnosEncontrado != null)
                {
                    _appDbContext.Alumnos.Update(AlumnosEncontrado);
                    _appDbContext.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error en la base de datos" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("se encontro un error de formato" + ex);
            }


        }

    }
}
