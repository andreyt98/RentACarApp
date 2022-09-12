using AccesoDatos;

namespace ProyectoServidor.view {
    public partial class ConsultaSucursal : UserControl {
        public ConsultaSucursal() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
            BaseDatos dataBase = new();

            sucursalDataGrid.DataSource = dataBase.obtenerSucursal();
        }
    }
}
