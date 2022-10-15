using AccesoDatos;
namespace ProyectoServidor.view {
    public partial class ConsultaCliente : UserControl {
        public ConsultaCliente() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
       // Controllers.ConsultaCliente cc = new(this);
            BaseDatos baseDatos = new BaseDatos();

            clienteDataGrid.Enabled = true;
            clienteDataGrid.DataSource = baseDatos.obtenerClientes();
          //  cc.verDatos(sender, e, clienteDataGrid);
        }
    }
}