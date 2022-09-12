namespace ProyectoServidor.view {
    partial class RegistroTipoV {
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mensaje = new System.Windows.Forms.Label();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.tDescripcionTipoV = new System.Windows.Forms.TextBox();
            this.comboEstadoTipoV = new System.Windows.Forms.ComboBox();
            this.tIdTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro Tipo de Vehiculo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mensaje);
            this.panel1.Controls.Add(this.btnGuardarDatos);
            this.panel1.Controls.Add(this.tDescripcionTipoV);
            this.panel1.Controls.Add(this.comboEstadoTipoV);
            this.panel1.Controls.Add(this.tIdTipoVehiculo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(192, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 402);
            this.panel1.TabIndex = 4;
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensaje.Location = new System.Drawing.Point(273, 347);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 21);
            this.mensaje.TabIndex = 18;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Location = new System.Drawing.Point(152, 284);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(395, 60);
            this.btnGuardarDatos.TabIndex = 16;
            this.btnGuardarDatos.Text = "Guardar";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // tDescripcionTipoV
            // 
            this.tDescripcionTipoV.Location = new System.Drawing.Point(241, 108);
            this.tDescripcionTipoV.Name = "tDescripcionTipoV";
            this.tDescripcionTipoV.Size = new System.Drawing.Size(181, 23);
            this.tDescripcionTipoV.TabIndex = 12;
            // 
            // comboEstadoTipoV
            // 
            this.comboEstadoTipoV.FormattingEnabled = true;
            this.comboEstadoTipoV.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstadoTipoV.Location = new System.Drawing.Point(273, 182);
            this.comboEstadoTipoV.Name = "comboEstadoTipoV";
            this.comboEstadoTipoV.Size = new System.Drawing.Size(121, 23);
            this.comboEstadoTipoV.TabIndex = 8;
            // 
            // tIdTipoVehiculo
            // 
            this.tIdTipoVehiculo.Location = new System.Drawing.Point(241, 37);
            this.tIdTipoVehiculo.Name = "tIdTipoVehiculo";
            this.tIdTipoVehiculo.Size = new System.Drawing.Size(181, 23);
            this.tIdTipoVehiculo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(295, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(320, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // RegistroTipoV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroTipoV1";
            this.Size = new System.Drawing.Size(1067, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label mensaje;
        private Button btnGuardarDatos;
        private TextBox tDescripcionTipoV;
        private ComboBox comboEstadoTipoV;
        private TextBox tIdTipoVehiculo;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}
