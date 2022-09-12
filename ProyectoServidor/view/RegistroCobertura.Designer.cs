namespace ProyectoServidor.view {
    partial class RegistroCobertura {
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
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.tIdTipoVehiculo = new System.Windows.Forms.TextBox();
            this.tMontoCobertura = new System.Windows.Forms.TextBox();
            this.comboEstadoCobertura = new System.Windows.Forms.ComboBox();
            this.tIdCobertura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(441, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro Cobertura";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mensaje);
            this.panel1.Controls.Add(this.btnGuardarDatos);
            this.panel1.Controls.Add(this.tDescripcion);
            this.panel1.Controls.Add(this.tIdTipoVehiculo);
            this.panel1.Controls.Add(this.tMontoCobertura);
            this.panel1.Controls.Add(this.comboEstadoCobertura);
            this.panel1.Controls.Add(this.tIdCobertura);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
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
            this.mensaje.Location = new System.Drawing.Point(227, 347);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 21);
            this.mensaje.TabIndex = 17;
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
            // tDescripcion
            // 
            this.tDescripcion.Location = new System.Drawing.Point(366, 43);
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(181, 23);
            this.tDescripcion.TabIndex = 12;
            // 
            // tIdTipoVehiculo
            // 
            this.tIdTipoVehiculo.Location = new System.Drawing.Point(139, 107);
            this.tIdTipoVehiculo.Name = "tIdTipoVehiculo";
            this.tIdTipoVehiculo.Size = new System.Drawing.Size(181, 23);
            this.tIdTipoVehiculo.TabIndex = 11;
            // 
            // tMontoCobertura
            // 
            this.tMontoCobertura.Location = new System.Drawing.Point(366, 107);
            this.tMontoCobertura.Name = "tMontoCobertura";
            this.tMontoCobertura.Size = new System.Drawing.Size(181, 23);
            this.tMontoCobertura.TabIndex = 10;
            // 
            // comboEstadoCobertura
            // 
            this.comboEstadoCobertura.FormattingEnabled = true;
            this.comboEstadoCobertura.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstadoCobertura.Location = new System.Drawing.Point(277, 197);
            this.comboEstadoCobertura.Name = "comboEstadoCobertura";
            this.comboEstadoCobertura.Size = new System.Drawing.Size(121, 23);
            this.comboEstadoCobertura.TabIndex = 8;
            // 
            // tIdCobertura
            // 
            this.tIdCobertura.Location = new System.Drawing.Point(139, 43);
            this.tIdCobertura.Name = "tIdCobertura";
            this.tIdCobertura.Size = new System.Drawing.Size(181, 23);
            this.tIdCobertura.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Tipo vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Cobertura";
            // 
            // RegistroCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroCobertura";
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
        private TextBox tDescripcion;
        private TextBox tIdTipoVehiculo;
        private TextBox tMontoCobertura;
        private ComboBox comboEstadoCobertura;
        private TextBox tIdCobertura;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
