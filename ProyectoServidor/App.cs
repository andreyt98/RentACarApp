using AccesoDatos;
using CapaEntidades;
using Newtonsoft.Json;
using Serializar;
using System.Net;
using System.Net.Sockets;

namespace ProyectoServidor {
    public partial class App : Form {
        public App() {
            InitializeComponent();

            //estado de cada cliente (conexion y desconexion)
            clientStatus = new ClientStatus(changeClientStatus);

            //lista de clientes conectados
            modifyStatus = new ModifyClientsList(updateClientsList);

            //cantidad de clientes conectados
            modifyCount = new ModifyCount(changeClientsCount);

            cantUsuarios.Text += conteoClientes.ToString();
        }


        public ModifyClientsList modifyStatus;
        public ClientStatus clientStatus;
        public ModifyCount modifyCount;

        public delegate void ModifyClientsList(string txt, bool added);
        public delegate void ClientStatus(string txt);
        public delegate void ModifyCount(string txt, bool added);
        public TcpListener tcpListener;
        public Thread connectWithClient;
        private bool isServerActive = false;
        public int conteoClientes = 0;

        public void updateClientsList(string txt, bool added) { //modificarListbox

            if (added) {
                listConnectedUsers.Items.Add(txt);
            } else {
                listConnectedUsers.Items.Remove(txt);
            }
        }
        public void changeClientStatus(string txt) {//EscribirEntxtBox
                listRegistroConexiones.Items.Add(txt);
        }
        public void changeClientsCount(string txt, bool added) { //modificarListbox

            if (added) {
                conteoClientes += 1;
            } else {
                if (conteoClientes > 0) {
                    conteoClientes -= 1;
                }
            }
            cantUsuarios.Text = $"Usuarios conectados: {conteoClientes}";
        }

        private void btnIniciarServidor_Click(object sender, EventArgs e) {

            try {
                initServer();
                #region diseño
                txtEstadoServidor.Text = "Conectado";
                txtEstadoServidor.ForeColor = Color.Green;
                btnIniciarServidor.Enabled = false;
                btnDetenerServidor.Enabled = true;

                #endregion

            } catch (Exception) {
                return;
            }

        }


        public void initServer() {

            //instanciamos la clase ipadress y especificamos la dirrecion ip con la que se va a comunicar
            IPAddress localIp = IPAddress.Parse("127.0.0.1");
            //inicializa la escucha de las conexiones que vengan de la ip especificada comunicandose en el puerto especificado
            tcpListener = new TcpListener(localIp, 14100);

            //creamos un hilo y especificamos el metodo que se ejecutara en ese hilo
            connectWithClient = new Thread(new ThreadStart(reponseToClientRequest));

            //iniciamos el thread listenClientRequest
            isServerActive = true;
            connectWithClient.Start();
        }


        public void reponseToClientRequest() {
            tcpListener.Start(); //incializa escucha de conexiones entrantes

            try {
                while (isServerActive) {

                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    //creamos un hilo y especificamos el metodo que se ejecutara en ese hilo
                    Thread serializeDataThread = new Thread(new ParameterizedThreadStart(serializeMessage));

                    serializeDataThread.Start(tcpClient);
                }
            } catch (Exception) {
                return;
            }
        }



        public void serializeMessage(object client) {
            TcpClient tcpClient = (TcpClient)client;

            StreamReader streamReader = new StreamReader(tcpClient.GetStream());
            StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());

            while (isServerActive) {

                try {
                    var dataFromStream = streamReader.ReadLine();

                    ClsSerializar<object> package = JsonConvert.DeserializeObject<ClsSerializar<object>>(dataFromStream);
                    methodToUse(package.Method, dataFromStream, ref streamWriter);

                } catch (Exception ex) {
                    break;
                }

            }
        }


        public void methodToUse(string method, string inputStream, ref StreamWriter streamWriterServer) {
            switch (method) {

                case "connect":
                    ClsSerializar<string> getClient = JsonConvert.DeserializeObject<ClsSerializar<string>>(inputStream);
                    connect(getClient.Entity, ref streamWriterServer);
                    break;


                case "disconnect":
                    ClsSerializar<string> disconnectionMessage = JsonConvert.DeserializeObject<ClsSerializar<string>>(inputStream);
                    disconnect(disconnectionMessage.Entity);
                    break;

                case "SucursalesParaCliente":
                    ClsSerializar<string> getSucursal = JsonConvert.DeserializeObject<ClsSerializar<string>>(inputStream);
                    SucursalesParaCliente(ref streamWriterServer);
                    break;


                case "VehiculosParaCliente":
                    ClsSerializar<string> getVehiculos = JsonConvert.DeserializeObject<ClsSerializar<string>>(inputStream);
                    VehiculosParaCliente(int.Parse(getVehiculos.Entity), ref streamWriterServer);
                    break;


                case "CoberturasParaCliente":
                    ClsSerializar<string> getCoberturas = JsonConvert.DeserializeObject<ClsSerializar<string>>(inputStream);
                    CoberturasParaCliente(getCoberturas.Entity, ref streamWriterServer);
                    break;

                default: break;
            }
        }


        public bool connect(string id, ref StreamWriter streamWriterServer) {

            Cliente cliente = new Cliente();
            BaseDatos baseDatos = new();

            cliente = baseDatos.obtenerCliente(id);

            streamWriterServer.WriteLine(JsonConvert.SerializeObject(cliente));
            streamWriterServer.Flush();


            if (cliente != null && !listConnectedUsers.Items.Contains(cliente.Id) && !listRegistroConexiones.Items.Contains(cliente.Id)) {

                listConnectedUsers.Invoke(clientStatus, new object[] { $"Usuario #({cliente.Id}) se ha conectado!" });
                listRegistroConexiones.Invoke(modifyStatus, new object[] { id, true });
                cantUsuarios.Invoke(modifyCount, new object[] { id, true });
                return true;
            }

            return false;
        }

        public void SucursalesParaCliente(ref StreamWriter servidorStreamWriter) {
            BaseDatos baseDatos = new BaseDatos();

            List<Sucursal> listaSucursales = new List<Sucursal>();

            listaSucursales = baseDatos.obtenerSucursal(false);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaSucursales));
            servidorStreamWriter.Flush();
        }

        private void VehiculosParaCliente(int seleccionIdSucursal, ref StreamWriter servidorStreamWriter) {
            BaseDatos baseDatos = new BaseDatos();

            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            VehiculoSucursal vehiculoSucursal = new VehiculoSucursal();

            if (baseDatos.obtenerVehiculo(true).Count > 0) {

                //verificamos que ya se hayan vinculado sucursales a vehiculos
                if (baseDatos.obtenerVehiculoSucursal().Count > 0) {

                    //y mostramos en el datagridview los que no se hayan vinculado a la sucursal seleccionada

                    listaVehiculos = baseDatos.obtenerVehiculo(false, baseDatos.vehiculosAsociados((int)seleccionIdSucursal));

                    if (baseDatos.obtenerVehiculo(false, baseDatos.vehiculosAsociados((int)seleccionIdSucursal)).Count <= 0) {
                        MessageBox.Show("ya vinculó con esta sucursal todos los vehiculos disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    //si no se ha hecho ninguna vinculacion, se muestran todos los vehiculos existentes
                    listaVehiculos = baseDatos.obtenerVehiculo(true);
                }
            }

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaVehiculos));
            servidorStreamWriter.Flush();
        }

        private void CoberturasParaCliente(string id, ref StreamWriter servidorStreamWriter) {
            BaseDatos baseDatos = new BaseDatos();

            Cobertura coberturas = new Cobertura();
            List<Cobertura> listaCoberturas = new List<Cobertura>();

            listaCoberturas = baseDatos.obtenerCobertura(id, false);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaCoberturas));
            servidorStreamWriter.Flush();
        }  
        
        public void disconnect(string id) {
            listConnectedUsers.Invoke(clientStatus, new object[] { $"Usuario #({id}) se ha desconectado!" });
            listRegistroConexiones.Invoke(modifyStatus, new object[] { id, false });
            cantUsuarios.Invoke(modifyCount, new object[] { id, false });
        }
        public void detenerServidor() {

            tcpListener.Stop();
            isServerActive = false;
        }
        private void btnDetenerServidor_Click(object sender, EventArgs e) {
            detenerServidor();

            #region diseño
                txtEstadoServidor.Text = "Desconectado";
                txtEstadoServidor.ForeColor = Color.Red;
                btnIniciarServidor.Enabled = true;
                btnDetenerServidor.Enabled = false;
            #endregion
        }
                                                                                                               //en una codificación particular

        #region diseño

        private void esconderElementos() {
                foreach (var forms in Controls.OfType<UserControl>()) {
                    forms.Hide();
                }
                panelInicio.Visible = false;
            }
            private void btnRegistroSucursal_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuRegistro.Visible = false;
                registroSucursal1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            
            }

            private void btnMenuConsulta_Click(object sender, EventArgs e) {

                if (panelMenuConsulta.Visible) {
                    panelMenuConsulta.Visible = false;
                } else {
                    panelMenuConsulta.Visible = true;
                }
                panelMenuRegistro.Visible = false;
            }
        private void btnRegistroVehiculo_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuRegistro.Visible = false;

                registroVehiculo1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnRegistroCliente_Click(object sender, EventArgs e) {

                esconderElementos();
                panelMenuRegistro.Visible = false;

                registroCliente1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;

            }
            private void btnRegistroVehiculoS_Click(object sender, EventArgs e) {

                registroVehiculoSucursal1.Controls.Clear();
                registroVehiculoSucursal1.InitializeComponent();
                esconderElementos();
                panelMenuRegistro.Visible = false;
                registroVehiculoSucursal1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnRegistroCobertura_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuRegistro.Visible = false;

                registroCobertura1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;

            }
            private void btnRegistroTipoV_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuRegistro.Visible = false;

                registroTipov1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
      
            private void button12_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuConsulta.Visible = false;
                consultaSucursal1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnConsultaCliente_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuConsulta.Visible = false;
                consultaCliente1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnConsultaVehiculo_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuConsulta.Visible = false;
                consultaVehiculo1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnConsultaVehiculoS_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuConsulta.Visible = false;
                consultaVehiculoSucursal1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnConsultaTipoV_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuConsulta.Visible = false;
                consultaTipoVehiculo1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnConsultaCobertura_Click(object sender, EventArgs e) {
                esconderElementos();
                panelMenuConsulta.Visible = false;
                consultaCobertura1.Visible = true;
                btnInicio.Visible = true;
                cantUsuarios.Visible = true;
            }
            private void btnInicio_Click(object sender, EventArgs e) {
                esconderElementos();
                panelInicio.Visible = true;
                btnInicio.Visible = false;
                cantUsuarios.Visible = false;
            }
            private void btnMenuRegistro_Click(object sender, EventArgs e) {
                if (panelMenuRegistro.Visible) {
                    panelMenuRegistro.Visible = false;
                } else {
                    panelMenuRegistro.Visible = true;
                }
                panelMenuConsulta.Visible = false;
            }
        #endregion 
    }
}