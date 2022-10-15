using AccesoDatos;

namespace ProyectoServidor.Controllers {
    public class ConsultaCliente {
        ConsultaCliente consultaCliente;


        public ConsultaCliente(view.ConsultaCliente consultaCliente1) {
            this.consultaCliente = consultaCliente;
        }

        public void verDatos(object sender, EventArgs e, DataGridView datagrid) {
            BaseDatos baseDatos = new BaseDatos();

            datagrid.Enabled = true;
            datagrid.DataSource = baseDatos.obtenerClientes();
        }
    }
}
