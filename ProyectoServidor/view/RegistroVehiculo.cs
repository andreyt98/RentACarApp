using AccesoDatos;
using CapaEntidades;
using System.Data.SqlClient;

namespace ProyectoServidor.view {
    public partial class RegistroVehiculo : UserControl {
        public RegistroVehiculo() {
            InitializeComponent();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e) {
         
            try {                    
                Vehiculo vehiculo = new Vehiculo {
                    IdPlaca = tIdVehiculo.Text,
                    Marca = tMarcaVehiculo.Text,
                    Modelo = tModeloVeehiculo.Text,
                    IdTipoVehiculo = int.Parse(tIdTipovehiculoV.Text),
                    CostoAlquilerDia = int.Parse(tCostoAlquilerV.Text),
                    Kilometraje = int.Parse(tKilometrajeVehiculo.Text),
                };

                BaseDatos dataBase = new();
                dataBase.guardarVehiculo(vehiculo);

                MessageBox.Show("Datos guardados correctamente!", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                limpiarCampos();

            } catch (FormatException fe) {

                MessageBox.Show("Datos incorrectos, intentelo nuevamente", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (SqlException se) {
                switch (se.Number) {
                    //violacion llave primaria
                    case 2627:
                        MessageBox.Show("El id de vehiculo ingresado ya está registrado, intentelo nuevamente", "Valor duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tIdVehiculo.Text = "";
            tMarcaVehiculo.Text = "";
            tModeloVeehiculo.Text = "";
            tIdTipovehiculoV.Text = "";
            tCostoAlquilerV.Text = "";
            tKilometrajeVehiculo.Text = "";
        }
    }
}
