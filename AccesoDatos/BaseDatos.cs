using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using CapaEntidades;

namespace AccesoDatos {
    public class BaseDatos {
        private string stringConexion;
        public BaseDatos() {
            stringConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
        }

        #region sucursal
        public void guardarSucursal(Sucursal sucursal) {
            //instanciamos el sqlconnection que permite iniciar una conexion a la bd
            SqlConnection conexion = new SqlConnection(stringConexion);
            try {

                //instanciasmos sqlcommand que permite enviar consulta a BD
                SqlCommand sqlCommand = new SqlCommand();

                string query = "INSERT INTO Sucursal (IdSucursal,Nombre, Direccion, Estado, Telefono)" +
                    " VALUES (@IdSucursal, @Nombre, @Direccion, @Estado, @Telefono)";

                //decimos que el comando va a ser interpretado como texto
                sqlCommand.CommandType = System.Data.CommandType.Text;
                //decimos que el texto del comando va a ser el query
                sqlCommand.CommandText = query;

                //decimos que la conexion de este comando va a ser igual a la que inicializamos con nuestro string de conexion
                sqlCommand.Connection = conexion;

                //especificamos que los parametros del query van a ser los atributos de cada objeto de la clase
                sqlCommand.Parameters.AddWithValue("@IdSucursal", sucursal.Id);
                sqlCommand.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
                sqlCommand.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
                sqlCommand.Parameters.AddWithValue("@Estado", sucursal.Estado);
                sqlCommand.Parameters.AddWithValue("@Telefono", sucursal.Telefono);

                //abrimos la conexion
                conexion.Open();

                //ejecutamos el query
                sqlCommand.ExecuteNonQuery();

            } catch (Exception ex) {
                throw;
            } finally {
                //cerramos conexion en cualquier caso
                conexion.Close();
            }
        }

        public List<Sucursal> obtenerSucursal(bool generalSearch = true) {

            //creamos lista de sucursales a retornar
            List<Sucursal> listaSucursal = new();

            //instanciamos el sqlconnection que permite iniciar una conexion a la bd
            SqlConnection conexion = new SqlConnection(stringConexion);

            //instanciasmos sqlcommand que permite enviar consulta a BD
            SqlCommand sqlCommand = new SqlCommand();

            //decimos que la conexion de este comando va a ser igual a la que inicializamos con nuestro string de conexion
            sqlCommand.Connection = conexion;

            //decimos que el comando va a ser interpretado como texto
            sqlCommand.CommandType = System.Data.CommandType.Text;


            string query = generalSearch ? "SELECT * FROM SUCURSAL" : "SELECT * FROM SUCURSAL WHERE ESTADO = 1";

            //decimos que el texto del comando va a ser el query
            sqlCommand.CommandText = query;

            conexion.Open();

            //creamos un sqldatareader para leer los elementos de la tabla
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows) {//si hay filas en la tabla

                Sucursal sucursal; //se instancia la clase sucursal sucursal

                while (dataReader.Read()) { //mientras hayan elementos en la fila

                    listaSucursal.Add(sucursal = new Sucursal { //inicializamos obj sucursal con valores de la tabla
                        Id = dataReader.GetInt32(0),            //y lo agregamos a la lista
                        Nombre = dataReader.GetString(1),
                        Direccion = dataReader.GetString(2),
                        Estado = dataReader.GetBoolean(3),
                        Telefono = dataReader.GetString(4)

                    });
                }
            }
            conexion.Close(); //cerramos conexion y retornamos lista
            return listaSucursal;

        }

        #endregion

        #region cliente
        public void guardarCliente(Cliente cliente) {
            //instanciamos el sqlconnection que permite iniciar una conexion a la bd
            SqlConnection conexion = new SqlConnection(stringConexion);
            try {

                //instanciasmos sqlcommand que permite enviar consulta a BD
                SqlCommand sqlCommand = new SqlCommand();

                string query = "INSERT INTO CLIENTE (IdCliente,Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero)" +
                        " VALUES(@IdCliente, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Genero)";

                //decimos que el comando va a ser interpretado como texto
                sqlCommand.CommandType = System.Data.CommandType.Text;
                //decimos que el texto del comando va a ser el query
                sqlCommand.CommandText = query;

                //decimos que la conexion de este comando va a ser igual a la que inicializamos con nuestro string de conexion
                sqlCommand.Connection = conexion;

                //especificamos que los parametros del query van a ser los atributos de cada objeto de la clase
                sqlCommand.Parameters.AddWithValue("@IdCliente", cliente.Id);
                sqlCommand.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                sqlCommand.Parameters.AddWithValue("@PrimerApellido", cliente.PrimerApellido);
                sqlCommand.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                sqlCommand.Parameters.AddWithValue("@FechaNacimiento", cliente.Nacimiento);
                sqlCommand.Parameters.AddWithValue("@Genero", cliente.Genero);

                //abrimos la conexion
                conexion.Open();

                //ejecutamos el query
                sqlCommand.ExecuteNonQuery();

            } catch (Exception ex) {
                throw;
            } finally {
                //cerramos conexion en cualquier caso
                conexion.Close();
            }
        }

        public List<Cliente> obtenerClientes() {

            List<Cliente> listaCliente = new();

            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexion;
            sqlCommand.CommandType = System.Data.CommandType.Text;

            string query = "SELECT * FROM CLIENTE";
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows) {
               // Cliente cliente;
                while (dataReader.Read()) {
                    listaCliente.Add(new Cliente {
                        Id = dataReader.GetString(0),
                        Nombre = dataReader.GetString(1),
                        PrimerApellido = dataReader.GetString(2),
                        SegundoApellido = dataReader.GetString(3),
                        Nacimiento = dataReader.GetDateTime(4),
                        Genero = char.Parse(dataReader.GetString(5)),

                    });
                }
            }
            conexion.Close();
            return listaCliente;
        }

        public Cliente obtenerCliente(string id) {

            SqlConnection conexion = new SqlConnection(stringConexion);
            try {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conexion;
                sqlCommand.CommandType = System.Data.CommandType.Text;

                string query = $"SELECT * FROM CLIENTE WHERE IDCLIENTE = {id}";
                sqlCommand.CommandText = query;

                conexion.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows) {
                    Cliente cliente;
                    while (dataReader.Read()) {
                        cliente = new Cliente {
                            Id = dataReader.GetString(0),
                            Nombre = dataReader.GetString(1),
                            PrimerApellido = dataReader.GetString(2),
                            SegundoApellido = dataReader.GetString(3),
                            Nacimiento = dataReader.GetDateTime(4),
                            Genero = char.Parse(dataReader.GetString(5)),

                        };
                        return cliente;
                    }
                }

            } finally { conexion.Close(); }

            return null;
        }

        #endregion

        #region tipoVehiculo
        public void guardarTipoVehiculo(TipoVehiculo tipoVehiculo) {
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();

            string query = "INSERT INTO TIPOVEHICULO (IdTipo,Descripcion,Estado) VALUES(@IdTipo, @Descripcion, @Estado)";
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = conexion;
            sqlCommand.Parameters.AddWithValue("@IdTipo", tipoVehiculo.Id);
            sqlCommand.Parameters.AddWithValue("@Descripcion", tipoVehiculo.Descripcion);
            sqlCommand.Parameters.AddWithValue("@Estado", tipoVehiculo.Estado);

            conexion.Open();
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public List<TipoVehiculo> obtenerTipoVehiculo() {

            List<TipoVehiculo> listaTipoVehiculo = new();

            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexion;
            sqlCommand.CommandType = System.Data.CommandType.Text;

            string query = "SELECT * FROM TIPOVEHICULO";
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows) {
                TipoVehiculo tipoVehiculo;
                while (dataReader.Read()) {
                    listaTipoVehiculo.Add(tipoVehiculo = new TipoVehiculo {
                        Id = dataReader.GetInt32(0).ToString(),
                        Descripcion = dataReader.GetString(1),
                        Estado = dataReader.GetBoolean(2),

                    });
                }
            }
            conexion.Close();
            return listaTipoVehiculo;

        }
        #endregion

        #region vehiculo
        public void guardarVehiculo(Vehiculo vehiculo) {
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();

            string query = "INSERT INTO VEHICULO (IdPlaca,Marca,Modelo,IdTipoVehiculo, CostoAlquilerDia, Kilometraje) VALUES(@IdPlaca, @Marca, @Modelo, @IdTipoVehiculo, @CostoAlquilerDia, @Kilometraje)";
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = conexion;
            sqlCommand.Parameters.AddWithValue("@IdPlaca", vehiculo.IdPlaca);
            sqlCommand.Parameters.AddWithValue("@Marca", vehiculo.Marca);
            sqlCommand.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
            sqlCommand.Parameters.AddWithValue("@IdTipoVehiculo", vehiculo.IdTipoVehiculo);
            sqlCommand.Parameters.AddWithValue("@CostoAlquilerDia", vehiculo.CostoAlquilerDia);
            sqlCommand.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);


            conexion.Open();
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Vehiculo> obtenerVehiculo(bool generalSearch, [Optional] List<string> ids) {

            List<Vehiculo> listaVehiculo = new();

            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexion;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            var items = "";
            if (!generalSearch) {
                items = "\'" + string.Join("\', \'", ids) + "\'";
            }
            string query = generalSearch ? "SELECT * FROM VEHICULO" : $"SELECT * FROM VEHICULO WHERE IdPlaca NOT IN ({items})";
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows) {
                Vehiculo vehiculo;
                while (dataReader.Read()) {
                    listaVehiculo.Add(vehiculo = new Vehiculo {
                        IdPlaca = dataReader.GetString(0),
                        Marca = dataReader.GetString(1),
                        Modelo = dataReader.GetString(2),
                        IdTipoVehiculo = dataReader.GetInt32(3),
                        CostoAlquilerDia = dataReader.GetInt32(4),
                        Kilometraje = dataReader.GetInt32(5),
                    });
                }
            }
            conexion.Close();
            return listaVehiculo;

        }

        public List<string> vehiculosAsociados(int idSucursal) {

            List<string> listaVehiculosAsociados = new();

            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexion;
            sqlCommand.CommandType = System.Data.CommandType.Text;

            string query = "SELECT * FROM VEHICULOSUCURSAL";
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows) {
                while (dataReader.Read()) {
                    //si la sucursal ya tiene vehiculo asociados...
                    if (dataReader.GetInt32(1) == idSucursal) {
                        listaVehiculosAsociados.Add(dataReader.GetString(2));
                    }
                }
            }
            conexion.Close();

            return listaVehiculosAsociados;
        }

        #endregion

        #region vehiculoSucursal
        public void guardarVehiculoSucursal(VehiculoSucursal vehiculoSucursal) {
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();

            string query = "INSERT INTO VEHICULOSUCURSAL (IdAsignacion,IdSucursal,IdPlaca, FechaAsignacion) VALUES (@IdAsignacion, @IdSucursal, @IdPlaca, @FechaAsignacion)";
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = conexion;
            sqlCommand.Parameters.AddWithValue("@IdAsignacion", vehiculoSucursal.IdAsignacion);
            sqlCommand.Parameters.AddWithValue("@IdSucursal", vehiculoSucursal.IdSucursal);
            sqlCommand.Parameters.AddWithValue("@IdPlaca", vehiculoSucursal.IdPlaca);
            sqlCommand.Parameters.AddWithValue("@FechaAsignacion", vehiculoSucursal.FechaAsignacion);

            conexion.Open();
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public List<VehiculoSucursal> obtenerVehiculoSucursal() {

            List<VehiculoSucursal> listaVehiculoSucursal = new();

            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexion;
            sqlCommand.CommandType = System.Data.CommandType.Text;

            string query = "SELECT * FROM VEHICULOSUCURSAL";
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows) {
                VehiculoSucursal vehiculoSucursal;
                while (dataReader.Read()) {
                    listaVehiculoSucursal.Add(vehiculoSucursal = new VehiculoSucursal {
                        IdAsignacion = dataReader.GetInt32(0),
                        IdSucursal = dataReader.GetInt32(1),
                        IdPlaca = dataReader.GetString(2),
                        FechaAsignacion = dataReader.GetDateTime(3),
                    });
                }
            }
            conexion.Close();
            return listaVehiculoSucursal;

        }
        #endregion

        #region cobertura
        public void guardarCobertura(Cobertura cobertura) {
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();

            string query = "INSERT INTO COBERTURASEGURO (IdCobertura,Descripcion,IdTipoVehiculo, Estado, Monto) VALUES (@IdCobertura,@Descripcion, @IdTipoVehiculo, @Estado,@Monto)";
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = conexion;
            sqlCommand.Parameters.AddWithValue("@IdCobertura", cobertura.Id);
            sqlCommand.Parameters.AddWithValue("@Descripcion", cobertura.Descripcion);
            sqlCommand.Parameters.AddWithValue("@IdTipoVehiculo", cobertura.IdTipoVehiculo);
            sqlCommand.Parameters.AddWithValue("@Estado", cobertura.Estado);
            sqlCommand.Parameters.AddWithValue("@Monto", cobertura.Monto);

            conexion.Open();
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Cobertura> obtenerCobertura([Optional] string id, bool generalSearch = true) {

            List<Cobertura> listaCobertura = new();

            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conexion;
            sqlCommand.CommandType = System.Data.CommandType.Text;

            string query = generalSearch ? "SELECT * FROM COBERTURASEGURO" : $"SELECT * FROM COBERTURASEGURO WHERE IDTIPOVEHICULO = {id} AND ESTADO = 1";
            sqlCommand.CommandText = query;

            conexion.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows) {
                Cobertura cobertura;
                while (dataReader.Read()) {
                    listaCobertura.Add(cobertura = new Cobertura {
                        Id = dataReader.GetInt32(0),
                        Descripcion = dataReader.GetString(1),
                        IdTipoVehiculo = dataReader.GetInt32(2),
                        Estado = dataReader.GetBoolean(3),
                        Monto = dataReader.GetInt32(4)

                    });
                }
            }
            conexion.Close();
            return listaCobertura;
        }
        #endregion

        #region reserva

        #endregion
    }
}
