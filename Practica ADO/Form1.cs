namespace ado_multiplestablas
{
    public partial class Form1 : Form
    {
        RepositorioPasajes pasaje = new RepositorioPasajes();
        RepositorioPasajes Pasajeros = new RepositorioPasajes();
        RepositorioPasajes Aviones = new RepositorioPasajes();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmDatos formDatos = new FrmDatos();
            formDatos.ShowDialog();

            RefrescarPasajes();
        }   
        
        private void BtnModificarPasaje_Click(object sender, EventArgs e)
        {
            int? Id = GetIdPasajes();

            if (Id != null)
            {
                FrmDatos formPasajes = new FrmDatos(Id);
                formPasajes.ShowDialog();
                RefrescarPasajes();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void BtnAgregarPasajero_Click(object sender, EventArgs e)
        {
            //formulario pasajeros

            RefrescarPasajeros();
        }

        private void btnAgregarAvion_Click(object sender, EventArgs e)
        {
            //formulario Avion


            RefrescarAvion();
        }

        #region REFRESCAR
        public void RefrescarPasajes()
        {

            DGVPasajes.DataSource = pasaje.ListarPasajes();
        }

        public void RefrescarPasajeros()
        {

            DGVPasajeros.DataSource = Pasajeros.ListarPasajeros();
        }

        public void RefrescarAvion()
        {

            DgvAvion.DataSource = Aviones.ListarAviones();
        }

        private int? GetIdPasajes()
        {
            try
            {
                return int.Parse(DGVPasajes.Rows[DGVPasajes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }
        private int? GetIdPasajeros()
        {
            try
            {
                return int.Parse(DGVPasajeros.Rows[DGVPasajeros.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }
        private int? GetIdAvion()
        {
            try
            {
                return int.Parse(DgvAvion.Rows[DgvAvion.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }
        #endregion


     
    }
}
