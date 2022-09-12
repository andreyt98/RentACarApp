using AccesoDatos;
namespace ProyectoServidor.view {
    public partial class ConsultaVehiculoSucursal : UserControl {
        public ConsultaVehiculoSucursal() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
            BaseDatos dataBase = new();
            vehiculoSucursalDataGrid.DataSource = dataBase.obtenerVehiculoSucursal();
                
        }
    }
}
