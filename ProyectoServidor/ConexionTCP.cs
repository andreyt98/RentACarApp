using Newtonsoft.Json;
using Serializar;
using System.Net;
using System.Net.Sockets;
using CapaEntidades;
using AccesoDatos;

namespace ProyectoServidor {


    public class ConexionTCP {
        //delegados 
        public ModifyClientsList modifyStatus;
        public ClientStatus clientStatus;
        public ModifyCount modifyCount;

        public delegate void ModifyClientsList(string txt, bool added);
        public delegate void ClientStatus(string txt);
        public delegate void ModifyCount(string txt, bool added);

        public TcpListener tcpListener;
        public Thread connectWithClient;
        private bool isServerActive = false;
        private int conteoClientes = 0;

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

            /*if (cliente != null && !listConnectedUsers.Items.Contains(cliente.Id) && !listRegistroConexiones.Items.Contains(cliente.Id)) {

                listConnectedUsers.Invoke(clientStatus, new object[] { $"{cliente.Id} se ha conectado!" });
                listRegistroConexiones.Invoke(modifyStatus, new object[] { id, true });
                cantUsuarios.Invoke(modifyCount, new object[] { id, true });
                return true;
            }*/

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
                        MessageBox.Show("ya vinculo con esta sucursal todos los vehiculos disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void detenerServidor() {

            tcpListener.Stop();
            isServerActive = false;
        }
        //en una codificación particular
        public void disconnect(string id) {
            /*listConnectedUsers.Invoke(clientStatus, new object[] { $"{id} se ha desconectado!" });
            listRegistroConexiones.Invoke(modifyStatus, new object[] { id, false });
            cantUsuarios.Invoke(modifyCount, new object[] { id, false });*/
        }
    }
}
