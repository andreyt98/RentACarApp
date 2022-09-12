using AccesoDatos;
using CapaEntidades;
using System.Data.SqlClient;

namespace ProyectoServidor.view {
    public partial class RegistroVehiculoSucursal : UserControl {
        public RegistroVehiculoSucursal() {
            InitializeComponent();
        }
        public int? seleccionIdSucursal { get; set; } = null;
        public string idVehiculos { get; set; } = null;
        private void btnMostrarS_Click(object sender, EventArgs e) {
            BaseDatos dataBase = new BaseDatos();

            sucursalDataGrid.DataSource = dataBase.obtenerSucursal(false);
            btnMostrarS.Visible = false;
            sucursalDataGrid.ClearSelection();
        }

        private void btnMostrarV_Click(object sender, EventArgs e) {
            BaseDatos dataBase = new BaseDatos();

            //si existen vehiculos
            if (dataBase.obtenerVehiculo(true).Count > 0) {
                //verificamos que ya se hayan vinculado sucursales a vehiculos
                if (dataBase.obtenerVehiculoSucursal().Count > 0) {

                    //y mostramos en el datagridview los que no se hayan vinculado a la sucursal seleccionada
                    vehiculosDataGrid.DataSource = dataBase.obtenerVehiculo(false, dataBase.vehiculosAsociados((int)seleccionIdSucursal));
                    btnMostrarV.Visible = false;

                    if (dataBase.obtenerVehiculo(false, dataBase.vehiculosAsociados((int)seleccionIdSucursal)).Count <= 0) {

                        MessageBox.Show("ya vinculo con esta sucursal todos los vehiculos disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnMostrarV.Visible = true;
                    }

                }else{
                    //si no se ha hecho ninguna vinculacion, se muestran todos los vehiculos existentes
                    vehiculosDataGrid.DataSource = dataBase.obtenerVehiculo(true);
                    btnMostrarV.Visible = false;
                }
            }
            

            vehiculosDataGrid.ClearSelection();
        }

        private void btnVinculacion_Click(object sender, EventArgs e) {
            if(seleccionIdSucursal != null) {
                panel2.Visible = true;
                panel1.Visible = false;
                sSeleccion.Text = seleccionIdSucursal.ToString();
            } else {
                MessageBox.Show("Haga click en la fila de sucursal que desea vincular", "Ningun elemento seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label7.Text += seleccionIdSucursal.ToString();
        }
   
        private void sucursalDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                btnBorrarSeleccionS.Visible = true;
                seleccionIdSucursal = int.Parse(sucursalDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                sSeleccion.Text = seleccionIdSucursal.ToString();
            }
        }

        private void btnBorrarSeleccionS_Click(object sender, EventArgs e) {
            if (sucursalDataGrid.SelectedRows.Count > 0) {
                btnBorrarSeleccionS.Visible = false;
                sucursalDataGrid.ClearSelection();
                seleccionIdSucursal = null;
                sSeleccion.Text = "--";
            }
        }

        private void btnBorrarSeleccionV_Click(object sender, EventArgs e) {
            if (vehiculosDataGrid.SelectedRows.Count > 0) {
                btnBorrarSeleccionV.Visible = false;
                vehiculosDataGrid.ClearSelection();
                idVehiculos = null;
                vSeleccion.Text = "--";
            }           
        }

        private void btnContinuarPaso2_Click(object sender, EventArgs e) {
            if (idVehiculos != null) {
                panel2.Visible = false;
                panel3.Visible = true;
            } else {
                MessageBox.Show("Debe guardar un vehiculo para asociar con la sucursal", "Ningun elemento seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarDatosAsociacion_Click(object sender, EventArgs e) {

            try {
                VehiculoSucursal vehiculoSucursal = new VehiculoSucursal {
                    IdAsignacion = int.Parse(tIdAsociacion.Text),
                    FechaAsignacion = DateTime.Parse(fechaAsociacion.Text),
                    IdSucursal = (int)seleccionIdSucursal,
                    IdPlaca = idVehiculos,
                };

                BaseDatos dataBase = new();
                dataBase.guardarVehiculoSucursal(vehiculoSucursal);

                MessageBox.Show("Datos guardados correctamente!", "Proceso completado con éxito", MessageBoxButtons.OK, MessageBoxIcon.None);

                limpiarCampos();

                asociacionesDataGrid.DataSource = dataBase.obtenerVehiculoSucursal();
                    
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
            tIdAsociacion.Text = "";
        }
        private void vehiculosDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                btnBorrarSeleccionV.Visible = true;
                idVehiculos = vehiculosDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                vSeleccion.Text = idVehiculos;
            }
        }
    }
}
