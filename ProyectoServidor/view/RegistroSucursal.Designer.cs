namespace ProyectoServidor.view {
    partial class RegistroSucursal {
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
            this.tNombreSucursal = new System.Windows.Forms.TextBox();
            this.tDirSucursal = new System.Windows.Forms.TextBox();
            this.tTelefonoSucursal = new System.Windows.Forms.TextBox();
            this.comboEstadoSucursal = new System.Windows.Forms.ComboBox();
            this.tIdSucursal = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(445, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro Sucursal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mensaje);
            this.panel1.Controls.Add(this.btnGuardarDatos);
            this.panel1.Controls.Add(this.tNombreSucursal);
            this.panel1.Controls.Add(this.tDirSucursal);
            this.panel1.Controls.Add(this.tTelefonoSucursal);
            this.panel1.Controls.Add(this.comboEstadoSucursal);
            this.panel1.Controls.Add(this.tIdSucursal);
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
            this.mensaje.Location = new System.Drawing.Point(253, 347);
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
            // tNombreSucursal
            // 
            this.tNombreSucursal.Location = new System.Drawing.Point(366, 43);
            this.tNombreSucursal.Name = "tNombreSucursal";
            this.tNombreSucursal.Size = new System.Drawing.Size(181, 23);
            this.tNombreSucursal.TabIndex = 12;
            // 
            // tDirSucursal
            // 
            this.tDirSucursal.Location = new System.Drawing.Point(139, 107);
            this.tDirSucursal.Name = "tDirSucursal";
            this.tDirSucursal.Size = new System.Drawing.Size(181, 23);
            this.tDirSucursal.TabIndex = 11;
            // 
            // tTelefonoSucursal
            // 
            this.tTelefonoSucursal.Location = new System.Drawing.Point(366, 107);
            this.tTelefonoSucursal.Name = "tTelefonoSucursal";
            this.tTelefonoSucursal.Size = new System.Drawing.Size(181, 23);
            this.tTelefonoSucursal.TabIndex = 10;
            // 
            // comboEstadoSucursal
            // 
            this.comboEstadoSucursal.FormattingEnabled = true;
            this.comboEstadoSucursal.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboEstadoSucursal.Location = new System.Drawing.Point(279, 188);
            this.comboEstadoSucursal.Name = "comboEstadoSucursal";
            this.comboEstadoSucursal.Size = new System.Drawing.Size(121, 23);
            this.comboEstadoSucursal.TabIndex = 8;
            // 
            // tIdSucursal
            // 
            this.tIdSucursal.Location = new System.Drawing.Point(139, 43);
            this.tIdSucursal.Name = "tIdSucursal";
            this.tIdSucursal.Size = new System.Drawing.Size(181, 23);
            this.tIdSucursal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // RegistroSucursal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroSucursal1";
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
        private TextBox tNombreSucursal;
        private TextBox tDirSucursal;
        private TextBox tTelefonoSucursal;
        private ComboBox comboEstadoSucursal;
        private TextBox tIdSucursal;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
