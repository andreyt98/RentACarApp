using AccesoDatos;

namespace ProyectoServidor.view {
    public partial class ConsultaCobertura : UserControl {
        public ConsultaCobertura() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
            BaseDatos baseDatos = new BaseDatos();

            coberturaDataGrid.Enabled = true;
            coberturaDataGrid.DataSource = baseDatos.obtenerCobertura();
        }
    }
}
