using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_multiplestablas
{
    public partial class FrmDatos : Form
    {
        private int? id;

        public FrmDatos(int? id = null)
        {
            InitializeComponent();

            this.id = id;

            if (id != null)
                CargarDatos();
        }

        private void CargarDatos()
        {
            RepositorioPasajes pasajes = new RepositorioPasajes();
            Pasaje pasajero = pasajes.ObtenerPasajePorId(id);

            

        }
    }
}
