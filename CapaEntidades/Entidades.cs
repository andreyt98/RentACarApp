namespace CapaEntidades {
    public class Sucursal {

        #region Atributos
        private int id;
        private string nombre = "";
        private string direccion = "";
        private bool estado;
        private string telefono = "";
        #endregion

        #region Properties    
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        #endregion

    }
    public class Cliente {
        //attributes
        #region Atributos
        private string id = "";
        private string nombre = "";
        private string primerApellido = "";
        private string segundoApellido = "";
        private DateTime nacimiento;
        private char genero = ' ';
        #endregion

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public char Genero { get => genero; set => genero = value; }
        #endregion
    }
    public class TipoVehiculo {
        #region atributos
        private string id = "";
        private string descripcion = "";
        private bool estado;
        #endregion

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
        #endregion
    }
    public class Vehiculo {
        //attributes
        #region Atributos
        private string idPlaca = "";
        private string marca = "";
        private string modelo = "";
        private int idTipoVehiculo = 0;
        // private TipoVehiculo idTipoVehiculo = null;
        private int costoAlquilerDia = 0;
        private int kilometraje = 0;
        #endregion

        #region Properties
        public string IdPlaca { get => idPlaca; set => idPlaca = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int IdTipoVehiculo { get => idTipoVehiculo; set => idTipoVehiculo = value; }
        public int CostoAlquilerDia { get => costoAlquilerDia; set => costoAlquilerDia = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        #endregion

    }
    public class VehiculoSucursal {

        #region Atributos
        private int idAsignacion;
        private int idSucursal;
        private string idPlaca;
        private DateTime fechaAsignacion;
        #endregion

        #region Properties
        public int IdAsignacion { get => idAsignacion; set => idAsignacion = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public string IdPlaca { get => idPlaca; set => idPlaca = value; }
        public DateTime FechaAsignacion { get => fechaAsignacion; set => fechaAsignacion = value; }


        #endregion

    }
    public class Cobertura {
        //attributes
        #region Atributos

        private int idCobertura = 0;
        private string descripcion = "";
        private int idTipoVehiculo = 0;
        private bool estado;
        private int monto = 0;
        #endregion

        //properties to set attributes
        #region Properties
        public int Id { get => idCobertura; set => idCobertura = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTipoVehiculo { get => idTipoVehiculo; set => idTipoVehiculo = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Monto { get => monto; set => monto = value; }
        #endregion

    }
    public class Reserva {
        #region Atributos
        private int idReserva = 0;
        private string idPlaca = "";
        private string idCliente = "";
        private DateTime fechaReserva;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int montoReserva = 0;
        #endregion

        #region Properties
        public int IdReserva { get => idReserva; set => idReserva = value; }
        public string IdPlaca { get => idPlaca; set => idPlaca = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int MontoReserva { get => montoReserva; set => montoReserva = value; }
        #endregion
    }
}
