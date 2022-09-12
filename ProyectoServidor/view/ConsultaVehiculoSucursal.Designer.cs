namespace ProyectoServidor.view {
    partial class ConsultaVehiculoSucursal {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.vehiculoSucursalDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.vehiculoSucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idAsignacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoSucursalDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoSucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculoSucursalDataGrid
            // 
            this.vehiculoSucursalDataGrid.AllowUserToAddRows = false;
            this.vehiculoSucursalDataGrid.AllowUserToDeleteRows = false;
            this.vehiculoSucursalDataGrid.AllowUserToResizeColumns = false;
            this.vehiculoSucursalDataGrid.AllowUserToResizeRows = false;
            this.vehiculoSucursalDataGrid.AutoGenerateColumns = false;
            this.vehiculoSucursalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculoSucursalDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsignacionDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vehiculoSucursalDataGrid.DataSource = this.vehiculoSucursalBindingSource;
            this.vehiculoSucursalDataGrid.Location = new System.Drawing.Point(335, 191);
            this.vehiculoSucursalDataGrid.MultiSelect = false;
            this.vehiculoSucursalDataGrid.Name = "vehiculoSucursalDataGrid";
            this.vehiculoSucursalDataGrid.ReadOnly = true;
            this.vehiculoSucursalDataGrid.RowHeadersVisible = false;
            this.vehiculoSucursalDataGrid.RowTemplate.Height = 25;
            this.vehiculoSucursalDataGrid.Size = new System.Drawing.Size(403, 223);
            this.vehiculoSucursalDataGrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(374, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consulta de Vehiculo por Sucursal";
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(357, 132);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(352, 42);
            this.btnVerDatos.TabIndex = 8;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // vehiculoSucursalBindingSource
            // 
            this.vehiculoSucursalBindingSource.DataSource = typeof(CapaEntidades.VehiculoSucursal);
            // 
            // idAsignacionDataGridViewTextBoxColumn
            // 
            this.idAsignacionDataGridViewTextBoxColumn.DataPropertyName = "IdAsignacion";
            this.idAsignacionDataGridViewTextBoxColumn.HeaderText = "IdAsignacion";
            this.idAsignacionDataGridViewTextBoxColumn.Name = "idAsignacionDataGridViewTextBoxColumn";
            this.idAsignacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdSucursal";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdSucursal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdPlaca";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdPlaca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaAsignacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaAsignacion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ConsultaVehiculoSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehiculoSucursalDataGrid);
            this.Name = "ConsultaVehiculoSucursal";
            this.Size = new System.Drawing.Size(1067, 495);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoSucursalDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoSucursalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView vehiculoSucursalDataGrid;
        private Label label2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPlacaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaAsignacionDataGridViewTextBoxColumn;
        private Button btnVerDatos;
        private DataGridViewTextBoxColumn idAsignacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource vehiculoSucursalBindingSource;
    }
}
