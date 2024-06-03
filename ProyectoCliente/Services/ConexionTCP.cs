using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using CapaEntidades;
using Serializar;

namespace ProyectoCliente {
    public class ConexionTCP {
        private static IPAddress ipServer;
        private static TcpClient tcpClient;
        private static IPEndPoint remoteEndPoint;

        private static StreamWriter clientStreamWriter;
        private static StreamReader clientStreamReader;

        private static bool connected = false;

        public static Cliente obtenerCliente(string idCliente) {

            ipServer = IPAddress.Parse("127.0.0.1");
            tcpClient = new TcpClient();
            remoteEndPoint = new IPEndPoint(ipServer, 14100);
            tcpClient.Connect(remoteEndPoint);
            connected = true;

            ClsSerializar<string> packageToSend = new ClsSerializar<string> { Method = "connect", Entity = idCliente };

            clientStreamWriter = new StreamWriter(tcpClient.GetStream());
            clientStreamReader = new StreamReader(tcpClient.GetStream());

            clientStreamWriter.WriteLine(JsonConvert.SerializeObject(packageToSend));
            clientStreamWriter.Flush();

            var serverPackage = clientStreamReader.ReadLine();

            Cliente cliente = new Cliente();
            cliente = JsonConvert.DeserializeObject<Cliente>(serverPackage);

            return cliente;
        }

        public static List<Sucursal> solicitarSucursales() {
            List<Sucursal> listaSucursales = new List<Sucursal>();

            ClsSerializar<string> mensajeObtenerSucursales = new ClsSerializar<string> { Method = "SucursalesParaCliente" };

            clientStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerSucursales));
            clientStreamWriter.Flush();

            var mensaje = clientStreamReader.ReadLine();
            listaSucursales = JsonConvert.DeserializeObject<List<Sucursal>>(mensaje);

            return listaSucursales;
        }

        public static List<Vehiculo> solicitarVehiculos(int idSucursal) {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            ClsSerializar<string> mensajeObtenerVehiculos = new ClsSerializar<string> { Method = "VehiculosParaCliente", Entity = idSucursal.ToString() };

            clientStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerVehiculos));
            clientStreamWriter.Flush();

            var mensaje = clientStreamReader.ReadLine();
            listaVehiculos = JsonConvert.DeserializeObject<List<Vehiculo>>(mensaje);

            return listaVehiculos;
        }

        public static List<Cobertura> solicitarCoberturas(string idTipoVehiculo) {
            List<Cobertura> listaCoberturas = new List<Cobertura>();

            ClsSerializar<string> mensajeObtenerCoberturas = new ClsSerializar<string> { Method = "CoberturasParaCliente", Entity = idTipoVehiculo};

            clientStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerCoberturas));
            clientStreamWriter.Flush();

            var mensaje = clientStreamReader.ReadLine();
            listaCoberturas = JsonConvert.DeserializeObject<List<Cobertura>>(mensaje);

            return listaCoberturas;
        }

        public static bool desconectar(string idCliente) {

            try {
                ipServer = IPAddress.Parse("127.0.0.1");
                tcpClient = new TcpClient();
                remoteEndPoint = new IPEndPoint(ipServer, 14100);
                tcpClient.Connect(remoteEndPoint);
                ClsSerializar<string> connectionMessage = new ClsSerializar<string> { Method = "disconnect", Entity = idCliente };

                clientStreamWriter = new StreamWriter(tcpClient.GetStream());
                clientStreamReader = new StreamReader(tcpClient.GetStream());

                clientStreamWriter.WriteLine(JsonConvert.SerializeObject(connectionMessage));
                clientStreamWriter.Flush();

                return true;

            } catch (Exception ex) {
                return false;
            }
        }
    }
}
