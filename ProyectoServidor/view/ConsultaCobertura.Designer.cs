namespace ProyectoServidor.view {
    partial class ConsultaCobertura {
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coberturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.coberturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coberturaDataGrid = new System.Windows.Forms.DataGridView();
            this.coberturaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.montoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // idTipoVehiculoDataGridViewTextBoxColumn
            // 
            this.idTipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.HeaderText = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.Name = "idTipoVehiculoDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // coberturaBindingSource
            // 
            this.coberturaBindingSource.DataSource = typeof(void);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta de Cobertura";
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(356, 152);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(352, 42);
            this.btnVerDatos.TabIndex = 4;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // coberturaBindingSource1
            // 
            this.coberturaBindingSource1.DataSource = typeof(CapaEntidades.Cobertura);
            // 
            // coberturaDataGrid
            // 
            this.coberturaDataGrid.AutoGenerateColumns = false;
            this.coberturaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coberturaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1,
            this.idTipoVehiculoDataGridViewTextBoxColumn1,
            this.estadoDataGridViewCheckBoxColumn,
            this.montoDataGridViewTextBoxColumn1});
            this.coberturaDataGrid.DataSource = this.coberturaBindingSource2;
            this.coberturaDataGrid.Location = new System.Drawing.Point(275, 225);
            this.coberturaDataGrid.Name = "coberturaDataGrid";
            this.coberturaDataGrid.RowTemplate.Height = 25;
            this.coberturaDataGrid.Size = new System.Drawing.Size(547, 150);
            this.coberturaDataGrid.TabIndex = 5;
            // 
            // coberturaBindingSource2
            // 
            this.coberturaBindingSource2.DataSource = typeof(CapaEntidades.Cobertura);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            // 
            // idTipoVehiculoDataGridViewTextBoxColumn1
            // 
            this.idTipoVehiculoDataGridViewTextBoxColumn1.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn1.HeaderText = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn1.Name = "idTipoVehiculoDataGridViewTextBoxColumn1";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn1
            // 
            this.montoDataGridViewTextBoxColumn1.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn1.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn1.Name = "montoDataGridViewTextBoxColumn1";
            // 
            // ConsultaCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.coberturaDataGrid);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaCobertura";
            this.Size = new System.Drawing.Size(1067, 495);
         /*   ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource2)).EndInit();*/
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private BindingSource coberturaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTipoVehiculoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private Button btnVerDatos;
        private BindingSource coberturaBindingSource1;
        private DataGridView coberturaDataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idTipoVehiculoDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn1;
        private BindingSource coberturaBindingSource2;
    }
}
