using CapaEntidades;

namespace ProyectoServidor {
    public partial class App : Form {
        public App() {
            InitializeComponent();
/*
            //estado de cada cliente (conexion y desconexion)
            clientStatus = new ClientStatus(changeClientStatus);
            
            //lista de clientes conectados
            modifyStatus = new ModifyClientsList(updateClientsList);

            //cantidad de clientes conectados
            modifyCount = new ModifyCount(changeClientsCount);

            cantUsuarios.Text += conteoClientes.ToString();*/

        }

        ConexionTCP conexionTcp = new();
        
        private void btnIniciarServidor_Click(object sender, EventArgs e) {

            try {
                conexionTcp.initServer();

                #region diseño
                   // connectWithClient.IsBackground = true;
                    txtEstadoServidor.Text = "Conectado";
                    txtEstadoServidor.ForeColor = Color.Green;
                    btnIniciarServidor.Enabled = false;
                    btnDetenerServidor.Enabled = true;
                #endregion

            } catch (Exception) {
                return;
            }

        }
       
        Cliente cliente = new();

        //delegados 
        /*public ModifyClientsList modifyStatus;
        public ClientStatus clientStatus;
        public ModifyCount modifyCount; 

        public delegate void ModifyClientsList(string txt, bool added);
        public delegate void ClientStatus(string txt);
        public delegate void ModifyCount(string txt, bool added);

        public TcpListener tcpListener;
        public Thread connectWithClient;
        private bool isServerActive = false;
        private int conteoClientes = 0;*/

       /* public void initServer() {
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

                    Serialize<object> package = JsonConvert.DeserializeObject<Serialize<object>>(dataFromStream);
                    methodToUse(package.Method, dataFromStream, ref streamWriter);

                } catch (Exception ex) {
                    break;
                }

            }
        }

     
        public void methodToUse(string method, string inputStream, ref StreamWriter streamWriterServer) {
            switch (method) {

                case "connect":
                    Serialize<string> getClient = JsonConvert.DeserializeObject<Serialize<string>>(inputStream);
                    connect(getClient.Entity, ref streamWriterServer);
                break;


                case "disconnect":
                    Serialize<string> disconnectionMessage = JsonConvert.DeserializeObject<Serialize<string>>(inputStream);
                    disconnect(disconnectionMessage.Entity);
                break;

                case "SucursalesParaCliente":
                    Serialize<string> getSucursal = JsonConvert.DeserializeObject<Serialize<string>>(inputStream);
                    SucursalesParaCliente(ref streamWriterServer);
                break;


                case "VehiculosParaCliente":
                    Serialize<string> getVehiculos = JsonConvert.DeserializeObject<Serialize<string>>(inputStream);
                    VehiculosParaCliente(int.Parse(getVehiculos.Entity), ref streamWriterServer);
                break;


                case "CoberturasParaCliente":
                    Serialize<string> getCoberturas = JsonConvert.DeserializeObject<Serialize<string>>(inputStream);
                    CoberturasParaCliente(getCoberturas.Entity, ref streamWriterServer);
                break;

                default: break;
            }
        }

        public bool connect(string id, ref StreamWriter streamWriterServer) {

            Cliente cliente = new Cliente();
            DataBase database = new();

            cliente = database.obtenerCliente(id);

            streamWriterServer.WriteLine(JsonConvert.SerializeObject(cliente));
            streamWriterServer.Flush();

            if (cliente !=null && !listConnectedUsers.Items.Contains(cliente.Id) && !listRegistroConexiones.Items.Contains(cliente.Id)) {
               
                listConnectedUsers.Invoke(clientStatus, new object[] { $"{cliente.Id} se ha conectado!" });
                listRegistroConexiones.Invoke(modifyStatus, new object[] { id, true });
                cantUsuarios.Invoke(modifyCount, new object[] { id, true });
                return true;
            }

            return false;
        }

        public void SucursalesParaCliente(ref StreamWriter servidorStreamWriter) {
            DataBase dataBase = new DataBase();

            List<Sucursal> listaSucursales = new List<Sucursal>();

            listaSucursales = dataBase.obtenerSucursal(false);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaSucursales));
            servidorStreamWriter.Flush();
        }

        private void VehiculosParaCliente(int seleccionIdSucursal, ref StreamWriter servidorStreamWriter) {
            DataBase dataBase = new DataBase();

            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            VehiculoSucursal vehiculoSucursal = new VehiculoSucursal();

            Helpers helpers = new();

            if (dataBase.obtenerVehiculo(true).Count > 0) {

                //verificamos que ya se hayan vinculado sucursales a vehiculos
                if (dataBase.obtenerVehiculoSucursal().Count > 0) {

                    //y mostramos en el datagridview los que no se hayan vinculado a la sucursal seleccionada

                    listaVehiculos = dataBase.obtenerVehiculo(false, helpers.vehiculosAsociados((int)seleccionIdSucursal));

                    if (dataBase.obtenerVehiculo(false, helpers.vehiculosAsociados((int)seleccionIdSucursal)).Count <= 0) {
                        MessageBox.Show("ya vinculo con esta sucursal todos los vehiculos disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    //si no se ha hecho ninguna vinculacion, se muestran todos los vehiculos existentes
                    listaVehiculos = dataBase.obtenerVehiculo(true);
                }
            }

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaVehiculos));
            servidorStreamWriter.Flush();
        }

        private void CoberturasParaCliente(string id, ref StreamWriter servidorStreamWriter) {
            DataBase dataBase = new DataBase();

            Cobertura coberturas = new Cobertura();
            List<Cobertura> listaCoberturas = new List<Cobertura>();

            listaCoberturas = dataBase.obtenerCobertura(id, false);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaCoberturas));
            servidorStreamWriter.Flush();
        }
       
        */
        
        
        
        public void disconnect(string id) {
          /* listConnectedUsers.Invoke(clientStatus, new object[] { $"{id} se ha desconectado!" });
            listRegistroConexiones.Invoke(modifyStatus, new object[] { id, false });
            cantUsuarios.Invoke(modifyCount, new object[] { id, false });*/
        }

        private void btnDetenerServidor_Click(object sender, EventArgs e) {
            conexionTcp.detenerServidor();
           /* tcpListener.Stop();
            isServerActive = false;*/

            #region diseño
                txtEstadoServidor.Text = "Desconectado";
                txtEstadoServidor.ForeColor = Color.Red;
                btnIniciarServidor.Enabled = true;
                btnDetenerServidor.Enabled = false;
            #endregion
        }
                                                                                                               //en una codificación particular

        #region diseño

        //metodos de actualizacion de clientes y su estado
        private void updateClientsList(string txt, bool add) {
            if (add) {
                listConnectedUsers.Items.Add(txt);
            } else {
                listConnectedUsers.Items.Remove(txt);
            }
        }
        public void changeClientStatus(string txt) {
            try {
                listRegistroConexiones.Items.Add(txt);

            } catch (Exception a) {
                MessageBox.Show(a.ToString());
            }
        }
        private void changeClientsCount(string txt, bool added) {

           /* if (added) {
                conteoClientes += 1;
            } else {
                if (conteoClientes >= 0) {
                    conteoClientes -= 1;
                }
            }
            cantUsuarios.Text = $"Usuarios conectados: {conteoClientes}";*/
        }

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