using AccesoDatos;
using CapaEntidades;
using System.Data.SqlClient;

namespace ProyectoServidor.view {
    public partial class RegistroSucursal : UserControl {
        public RegistroSucursal() {
            InitializeComponent();
        }

        //1.
        private void btnGuardarDatos_Click(object sender, EventArgs e) {
           
            BaseDatos database = new();
                try {
                    Sucursal sucursal = new Sucursal {
                        Id = int.Parse(tIdSucursal.Text),
                        Nombre = tNombreSucursal.Text,
                        Direccion = tDirSucursal.Text,
                        Estado = comboEstadoSucursal.SelectedIndex == 0 ? true : comboEstadoSucursal.SelectedIndex == 1 ? false : throw new Exception(),
                        Telefono = tTelefonoSucursal.Text,
                    };

                    database.guardarSucursal(sucursal);
                    MessageBox.Show("Datos guardados correctamente!", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.None);

                    limpiarCampos();
              
                } catch (FormatException fe) {

                 MessageBox.Show("Datos incorrectos, intentelo nuevamente", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } catch (SqlException se) {
                    switch (se.Number) {
                        //violacion llave primaria
                        case 2627:
                            MessageBox.Show("El id ingresado ya está registrado, intentelo nuevamente", "Valor duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                        break;

                        default:
                            MessageBox.Show("No ha sido posible registrar los datos, intentelo nuevamente", "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Es posile que los datos contengan errores, intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void limpiarCampos() {
            tIdSucursal.Text = "";
            tNombreSucursal.Text = "";
            tDirSucursal.Text = "";
            tTelefonoSucursal.Text = "";
            comboEstadoSucursal.SelectedIndex = -1;

        }
    }
}
