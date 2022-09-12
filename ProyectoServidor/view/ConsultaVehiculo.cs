using AccesoDatos;

namespace ProyectoServidor.view {
    public partial class ConsultaVehiculo : UserControl {
        public ConsultaVehiculo() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
            BaseDatos dataBase = new();
            vehiculoDataGrid.DataSource = dataBase.obtenerVehiculo(true);
        }
    }
}
