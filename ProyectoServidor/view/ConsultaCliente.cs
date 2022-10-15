using AccesoDatos;
namespace ProyectoServidor.view {
    public partial class ConsultaCliente : UserControl {
        public ConsultaCliente() {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e) {
<<<<<<< HEAD
=======
       // Controllers.ConsultaCliente cc = new(this);
>>>>>>> 7d8c0238e664b1a824bcbdc48eabad2d00b5edb8
            BaseDatos baseDatos = new BaseDatos();

            clienteDataGrid.Enabled = true;
            clienteDataGrid.DataSource = baseDatos.obtenerClientes();
<<<<<<< HEAD
=======
          //  cc.verDatos(sender, e, clienteDataGrid);
>>>>>>> 7d8c0238e664b1a824bcbdc48eabad2d00b5edb8
        }
    }
}