using AccesoDatos;
using CapaEntidades;
using System.Data.SqlClient;

namespace ProyectoServidor.view {
    public partial class RegistroTipoV : UserControl {
        public RegistroTipoV() {
            InitializeComponent();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e) {
           
            try {

                TipoVehiculo tipoVehiculo = new TipoVehiculo {
                    Id = tIdTipoVehiculo.Text,
                    Descripcion = tDescripcionTipoV.Text,
                    Estado = comboEstadoTipoV.SelectedIndex == 0 ? true : comboEstadoTipoV.SelectedIndex == 1 ? false : throw new Exception(),
                };

                BaseDatos dataBase = new();
                dataBase.guardarTipoVehiculo(tipoVehiculo);
                //tipoVehiculo.saveInDataBase();
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
            tIdTipoVehiculo.Text = "";
            tDescripcionTipoV.Text = "";
            comboEstadoTipoV.SelectedIndex = -1;
        }
    }
}
