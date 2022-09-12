using CapaEntidades;

namespace ProyectoCliente {
    public partial class AppCliente : Form {
        Cliente cliente = new();
        public AppCliente() {
            InitializeComponent();
        }
        public int cantClientes;
        private void btnIniciarConexion_Click(object sender, EventArgs e) {

            if (!tIdCliente.Text.Equals(string.Empty)) {

                 Cliente cliente;

                try {
                    cliente = ConexionTCP.obtenerCliente(tIdCliente.Text);

                    if (cliente != null) {
                        nombreCliente.Text = "bienvenido " + cliente.Nombre;

                        panelInicioSesion.Visible = false;
                        panelMenu.Visible = true;
                        btnDesconectar.Visible = true;
                        idCliente.Text = tIdCliente.Text;
                    } else {
                        MessageBox.Show("El cliente no está registrado", "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception) {
                    MessageBox.Show("Es posible que el servidor no esté inicializado", "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Por favor introduzca su identificación", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }


        #region diseño

            private void btnRealizarReserva_Click(object sender, EventArgs e) {           
                realizarReserva1.Visible = true;         
            }

            private void AppCliente_FormClosed(object sender, FormClosedEventArgs e) {
                ConexionTCP.desconectar(tIdCliente.Text);
            }

            private void btnDesconectar_Click(object sender, EventArgs e) {

                if (ConexionTCP.desconectar(tIdCliente.Text)) {
                    this.Controls.Clear();
                    this.InitializeComponent();
                }
            }
            private void realizarReserva1_Load(object sender, EventArgs e) {

            }
        #endregion
    }
}