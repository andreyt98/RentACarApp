namespace ProyectoCliente.View {
    public partial class RealizarReserva : UserControl {
        public RealizarReserva() {
            InitializeComponent();
        }

        public int? seleccionIdSucursal { get; set; } = null;
        public string seleccionIdVehiculo { get; set; } = null;
        public string seleccionIdTipoV { get; set; } = null;
        public int? seleccionIdCobertura { get; set; } = null;
        public int? seleccionMontoCobertura { get; set; } = null;

        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }

        private void btnContinuarPaso1_Click(object sender, EventArgs e) {

            if (seleccionIdSucursal != null) {
                panelVehiculo.Visible = true;
                panelSucursal.Visible = false;
            } else {
                MessageBox.Show("Haga click en la fila de sucursal que desea vincular", "Ningun elemento seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label7.Text += seleccionIdSucursal.ToString();
        }

        private void btnContinuarPaso2_Click(object sender, EventArgs e) {

            fechaInicio = dateTimeFechaInicio.Value;
            fechaFin = dateTimeFechaFin.Value;
            if (seleccionIdVehiculo != null && seleccionIdTipoV!=null) {
                panelVehiculo.Visible = false;
                panelCobertura.Visible = true;
            } else {
                MessageBox.Show("Haga click en la fila de vehiculo que desea vincular", "Ningun elemento seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            //AppCliente appCliente = new();
 
            if (seleccionIdCobertura != null) {
                
               // listReserva.Items.Add($"Id de reserva {}");
                listReserva.Items.Add($"Id de placa: {seleccionIdVehiculo}");
               // listReserva.Items.Add($"Id de cliente: {idCliente}");
                listReserva.Items.Add($"Fecha inicio reserva: {fechaInicio.Value}");
                listReserva.Items.Add($"Fecha final reserva: {fechaFin.Value}");
                listReserva.Items.Add($"Monto de reserva: {seleccionMontoCobertura}");

                panelInfoReserva.Visible = true;
                panelCobertura.Visible = false;
            }
        }

        private void btnMostrarS_Click(object sender, EventArgs e) {
            btnMostrarS.Visible = false;

            sucursalesDataGridCliente.DataSource = ConexionTCP.solicitarSucursales();
            sucursalesDataGridCliente.ClearSelection();
        }

        private void btnMostrarV_Click(object sender, EventArgs e) {
            btnMostrarV.Visible = false;
            vehiculosDataGrid.DataSource = ConexionTCP.solicitarVehiculos((int)seleccionIdSucursal);
            vehiculosDataGrid.ClearSelection();
        }

        private void sucursalesDataGridCliente_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                btnBorrarSeleccionS.Visible = true;
                seleccionIdSucursal = int.Parse(sucursalesDataGridCliente.Rows[e.RowIndex].Cells[0].Value.ToString());
                sSeleccion.Text = seleccionIdSucursal.ToString();
            }
        }
        private void btnBorrarSeleccionS_Click(object sender, EventArgs e) {
            if (sucursalesDataGridCliente.SelectedRows.Count > 0) {
                btnBorrarSeleccionS.Visible = false;
                sucursalesDataGridCliente.ClearSelection();
                seleccionIdSucursal = null;
                sSeleccion.Text = "--";
            }
        }

        private void vehiculosDataGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                btnBorrarSeleccionV.Visible = true;
                seleccionIdVehiculo = vehiculosDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                seleccionIdTipoV = vehiculosDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                vSeleccion.Text = seleccionIdVehiculo.ToString();
            }
        }
        private void btnBorrarSeleccionV_Click(object sender, EventArgs e) {
            if (vehiculosDataGrid.SelectedRows.Count > 0) {
                btnBorrarSeleccionV.Visible = false;
                vehiculosDataGrid.ClearSelection();
                seleccionIdVehiculo = null;
                vSeleccion.Text = "--";
            }
        }
        private void btnMostrarCoberturas_Click(object sender, EventArgs e) {
            btnMostrarCoberturas.Visible = false;
            CoberturaDataGridView.DataSource = ConexionTCP.solicitarCoberturas(seleccionIdTipoV);
            CoberturaDataGridView.ClearSelection();
        }
        private void CoberturaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                btnBorrarSeleccionCoberturas.Visible = true;
                seleccionIdCobertura = int.Parse(CoberturaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                seleccionMontoCobertura = int.Parse(CoberturaDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                labelCoberturaSeleccionada.Text = seleccionIdCobertura.ToString();
            }
        }
        private void btnBorrarSeleccionCoberturas_Click(object sender, EventArgs e) {
            if (CoberturaDataGridView.SelectedRows.Count > 0) {
                btnBorrarSeleccionCoberturas.Visible = false;
                CoberturaDataGridView.ClearSelection();
                seleccionIdCobertura = null;
                labelCoberturaSeleccionada.Text = "--";
            }
        }
    }
}
