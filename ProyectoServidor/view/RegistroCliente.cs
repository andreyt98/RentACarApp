using AccesoDatos;
using CapaEntidades;
using System.Data.SqlClient;

namespace ProyectoServidor.view {
    public partial class RegistroCliente : UserControl {

        public RegistroCliente() {
            InitializeComponent();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e) {         
            
            try {
                Cliente cliente = new Cliente {
                    Id = textID.Text,
                    Nombre = textNombre.Text,
                    PrimerApellido = textApe1.Text,
                    SegundoApellido = textApe2.Text,
                    Nacimiento = nacimientoPicker.Value,
                    Genero = char.Parse((string)comboGenero.SelectedItem),
                };

                BaseDatos database = new();
                database.guardarCliente(cliente);

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
            textID.Text = "";
            textNombre.Text = "";
            textApe1.Text = "";
            textApe2.Text = "";
            comboGenero.SelectedIndex = -1;
        }
    }
}
