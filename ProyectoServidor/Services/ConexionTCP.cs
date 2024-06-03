using AccesoDatos;
using CapaEntidades;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Serializar;
using System.Net;
using System.Net.Sockets;

namespace ProyectoServidor
{
    public class ConexionTCP
    {

        public TcpListener tcpListener;
        public Thread connectWithClient;
        private bool isServerActive = false;


        public void initServer()
        {
            //instanciamos la clase ipadress y especificamos la dirrecion ip con la que se va a comunicar
            IPAddress localIp = IPAddress.Parse("127.0.0.1");
            //inicializa la escucha de las conexiones que vengan de la ip especificada comunicandose en el puerto especificado
            tcpListener = new(localIp, 14100);

            //creamos un hilo y especificamos el metodo que se ejecutara en ese hilo
            connectWithClient = new Thread(new ThreadStart(reponseToClientRequest));

            //iniciamos el thread listenClientRequest
            isServerActive = true;
            connectWithClient.Start();
        }

        public void reponseToClientRequest()
        {
            tcpListener.Start(); //incializa escucha de conexiones entrantes

            try
            {
                while (isServerActive)
                {

                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    //creamos un hilo y especificamos el metodo que se ejecutara en ese hilo
                    Thread serializeDataThread = new(new ParameterizedThreadStart(serializeMessage));

                    serializeDataThread.Start(tcpClient);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public void serializeMessage(object client)
        {
            TcpClient tcpClient = (TcpClient)client;

            StreamReader streamReader = new StreamReader(tcpClient.GetStream());
            StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());

            while (isServerActive)
            {

                try
                {
                    var dataFromStream = streamReader.ReadLine();

                    ClsSerializar<object> package = JsonConvert.DeserializeObject<ClsSerializar<object>>(dataFromStream);
                    methodToUse(package.Method, dataFromStream, ref streamWriter);

                }
                catch (Exception ex)
                {
                    break;
                }

            }
        }

        public void SucursalesParaCliente(ref StreamWriter servidorStreamWriter)
        {
            BaseDatos baseDatos = new();

            List<Sucursal> listaSucursales = new();

            listaSucursales = baseDatos.obtenerSucursal(false);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaSucursales));
            servidorStreamWriter.Flush();
        }

        private void VehiculosParaCliente(int seleccionIdSucursal, ref StreamWriter servidorStreamWriter)
        {
            BaseDatos baseDatos = new();

            List<Vehiculo> listaVehiculos = new();

            VehiculoSucursal vehiculoSucursal = new();

            if (baseDatos.obtenerVehiculo(true).Count > 0)
            {

                //verificamos que ya se hayan vinculado sucursales a vehiculos
                if (baseDatos.obtenerVehiculoSucursal().Count > 0)
                {

                    //y mostramos en el datagridview los que no se hayan vinculado a la sucursal seleccionada

                    listaVehiculos = baseDatos.obtenerVehiculo(false, baseDatos.vehiculosAsociados((int)seleccionIdSucursal));

                    if (baseDatos.obtenerVehiculo(false, baseDatos.vehiculosAsociados((int)seleccionIdSucursal)).Count <= 0)
                    {
                        MessageBox.Show("ya vincul� con esta sucursal todos los vehiculos disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //si no se ha hecho ninguna vinculacion, se muestran todos los vehiculos existentes
                    listaVehiculos = baseDatos.obtenerVehiculo(true);
                }
            }

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaVehiculos));
            servidorStreamWriter.Flush();
        }

        private void CoberturasParaCliente(string id, ref StreamWriter servidorStreamWriter)
        {
            BaseDatos baseDatos = new();

            Cobertura coberturas = new();
            List<Cobertura> listaCoberturas = new();

            listaCoberturas = baseDatos.obtenerCobertura(id, false);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaCoberturas));
            servidorStreamWriter.Flush();
        }
        public void disconnect(string id)
        {
            Cliente cliente = new();
            App app = new();
            app.modifyUsersLists(id, cliente.Id, "desconectado", false);
        }

        public void detenerServidor()
        {

            tcpListener.Stop();
            isServerActive = false;
        }

        public void methodToUse(string method, string inputStream, ref StreamWriter streamWriterServer)
        {
            ClsSerializar<string> serialized = JsonConvert.DeserializeObject<ClsSerializar<string>>(inputStream);

            switch (method)
            {
                case "connect":
                    connect(serialized.Entity, ref streamWriterServer);
                    break;


                case "disconnect":
                    disconnect(serialized.Entity);
                    break;

                case "SucursalesParaCliente":
                    SucursalesParaCliente(ref streamWriterServer);
                    break;


                case "VehiculosParaCliente":
                    VehiculosParaCliente(int.Parse(serialized.Entity), ref streamWriterServer);
                    break;


                case "CoberturasParaCliente":
                    CoberturasParaCliente(serialized.Entity, ref streamWriterServer);
                    break;

                default: break;
            }
        }


        public void connect(string entityId, ref StreamWriter streamWriterServer)
        {

            Cliente cliente = new();
            BaseDatos baseDatos = new();

            cliente = baseDatos.obtenerCliente(entityId);

            streamWriterServer.WriteLine(JsonConvert.SerializeObject(cliente));
            streamWriterServer.Flush();

            App app = new();

            if (cliente != null && !app.listConnectedUsers.Items.Contains(cliente.Id) && !app.listConnectedUsers.Items.Contains(cliente.Id))
            {
                app.modifyUsersLists(entityId, cliente.Id, "conectado", true);
            }

        }

    }
}
