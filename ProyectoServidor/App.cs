namespace ProyectoServidor
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            //estado de cada cliente (conexion y desconexion)
            clientStatus = new ClientStatus(changeClientStatus);

            //lista de clientes conectados
            modifyStatus = new ModifyClientsList(updateClientsList);

            //cantidad de clientes conectados
            modifyCount = new ModifyCount(changeClientsCount);

            cantUsuarios.Text += conteoClientes.ToString();

        }


        ConexionTCP tcp = new();

        public ModifyClientsList modifyStatus;
        public ClientStatus clientStatus;
        public ModifyCount modifyCount;

        public delegate void ModifyClientsList(string txt, bool added);
        public delegate void ClientStatus(string txt);
        public delegate void ModifyCount(string txt, bool added);
        public int conteoClientes = 0;

        public void updateClientsList(string txt, bool added)
        { //modificarListbox

            if (added)
            {
                listConnectedUsers.Items.Add(txt);
            }
            else
            {
                listConnectedUsers.Items.Remove(txt);
            }
        }
        public void changeClientStatus(string txt)
        {//EscribirEntxtBox
            listRegistroConexiones.Items.Add(txt);
        }
        public void changeClientsCount(string txt, bool added)
        { //modificarListbox

            if (added)
            {
                conteoClientes += 1;
            }
            else
            {
                if (conteoClientes > 0)
                {
                    conteoClientes -= 1;
                }
            }
            cantUsuarios.Text = $"Usuarios conectados: {conteoClientes}";
        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {

            try
            {
                tcp.initServer();
                #region dise�o
                txtEstadoServidor.Text = "Conectado";
                txtEstadoServidor.ForeColor = Color.Green;
                btnIniciarServidor.Enabled = false;
                btnDetenerServidor.Enabled = true;

                #endregion

            }
            catch (Exception)
            {
                return;
            }

        }

        private void btnDetenerServidor_Click(object sender, EventArgs e)
        {
            tcp.detenerServidor();

            #region dise�o
            txtEstadoServidor.Text = "Desconectado";
            txtEstadoServidor.ForeColor = Color.Red;
            btnIniciarServidor.Enabled = true;
            btnDetenerServidor.Enabled = false;
            #endregion
        }
        public void modifyUsersLists(string EntityId, string clientId, string action, bool added)
        {

            listConnectedUsers.Invoke(clientStatus, new object[] { $"Usuario #({clientId}) se ha {action}!" });
            listRegistroConexiones.Invoke(modifyStatus, new object[] { EntityId, added });
            cantUsuarios.Invoke(modifyCount, new object[] { EntityId, added });                                                                                                      //en una codificaci�n particular
        }

        #region dise�o

        private void esconderElementos()
        {
            foreach (var forms in Controls.OfType<UserControl>())
            {
                forms.Hide();
            }
            panelInicio.Visible = false;
        }
        private void btnRegistroSucursal_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuRegistro.Visible = false;
            registroSucursal1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;

        }

        private void btnMenuConsulta_Click(object sender, EventArgs e)
        {

            if (panelMenuConsulta.Visible)
            {
                panelMenuConsulta.Visible = false;
            }
            else
            {
                panelMenuConsulta.Visible = true;
            }
            panelMenuRegistro.Visible = false;
        }
        private void btnRegistroVehiculo_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuRegistro.Visible = false;

            registroVehiculo1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {

            esconderElementos();
            panelMenuRegistro.Visible = false;

            registroCliente1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;

        }
        private void btnRegistroVehiculoS_Click(object sender, EventArgs e)
        {

            registroVehiculoSucursal1.Controls.Clear();
            registroVehiculoSucursal1.InitializeComponent();
            esconderElementos();
            panelMenuRegistro.Visible = false;
            registroVehiculoSucursal1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnRegistroCobertura_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuRegistro.Visible = false;

            registroCobertura1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;

        }
        private void btnRegistroTipoV_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuRegistro.Visible = false;

            registroTipov1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuConsulta.Visible = false;
            consultaSucursal1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuConsulta.Visible = false;
            consultaCliente1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnConsultaVehiculo_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuConsulta.Visible = false;
            consultaVehiculo1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnConsultaVehiculoS_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuConsulta.Visible = false;
            consultaVehiculoSucursal1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnConsultaTipoV_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuConsulta.Visible = false;
            consultaTipoVehiculo1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnConsultaCobertura_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelMenuConsulta.Visible = false;
            consultaCobertura1.Visible = true;
            btnInicio.Visible = true;
            cantUsuarios.Visible = true;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            esconderElementos();
            panelInicio.Visible = true;
            btnInicio.Visible = false;
            cantUsuarios.Visible = false;
        }
        private void btnMenuRegistro_Click(object sender, EventArgs e)
        {
            if (panelMenuRegistro.Visible)
            {
                panelMenuRegistro.Visible = false;
            }
            else
            {
                panelMenuRegistro.Visible = true;
            }
            panelMenuConsulta.Visible = false;
        }
        #endregion 
    }
}