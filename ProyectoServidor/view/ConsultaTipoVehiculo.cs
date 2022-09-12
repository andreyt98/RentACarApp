using AccesoDatos;

namespace ProyectoServidor.view {
    public partial class ConsultaTipoVehiculo : UserControl {
        public ConsultaTipoVehiculo() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
            BaseDatos dataBase = new();
            tipoVehiculoDataGrid.DataSource = dataBase.obtenerTipoVehiculo();
        }
    }
}
