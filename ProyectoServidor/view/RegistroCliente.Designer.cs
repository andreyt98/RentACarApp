namespace ProyectoServidor.view {
    partial class RegistroCliente {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mensaje = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.textApe1 = new System.Windows.Forms.TextBox();
            this.nacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.textApe2 = new System.Windows.Forms.TextBox();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mensaje);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textNombre);
            this.panel1.Controls.Add(this.btnGuardarDatos);
            this.panel1.Controls.Add(this.textApe1);
            this.panel1.Controls.Add(this.nacimientoPicker);
            this.panel1.Controls.Add(this.textApe2);
            this.panel1.Controls.Add(this.comboGenero);
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(216, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 402);
            this.panel1.TabIndex = 2;
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensaje.Location = new System.Drawing.Point(223, 347);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 21);
            this.mensaje.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "fecha nacimiento";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(366, 43);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(181, 23);
            this.textNombre.TabIndex = 12;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarDatos.Location = new System.Drawing.Point(152, 284);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(395, 60);
            this.btnGuardarDatos.TabIndex = 6;
            this.btnGuardarDatos.Text = "Guardar";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // textApe1
            // 
            this.textApe1.Location = new System.Drawing.Point(139, 107);
            this.textApe1.Name = "textApe1";
            this.textApe1.Size = new System.Drawing.Size(181, 23);
            this.textApe1.TabIndex = 11;
            // 
            // nacimientoPicker
            // 
            this.nacimientoPicker.Location = new System.Drawing.Point(139, 185);
            this.nacimientoPicker.Name = "nacimientoPicker";
            this.nacimientoPicker.Size = new System.Drawing.Size(181, 23);
            this.nacimientoPicker.TabIndex = 9;
            // 
            // textApe2
            // 
            this.textApe2.Location = new System.Drawing.Point(366, 107);
            this.textApe2.Name = "textApe2";
            this.textApe2.Size = new System.Drawing.Size(181, 23);
            this.textApe2.TabIndex = 10;
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboGenero.Location = new System.Drawing.Point(402, 185);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(121, 23);
            this.comboGenero.TabIndex = 8;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(139, 43);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(181, 23);
            this.textID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "segundo apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "primer apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "nombre";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(481, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registro Cliente";
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroCliente";
            this.Size = new System.Drawing.Size(1067, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label mensaje;
        private Label label7;
        private TextBox textNombre;
        private Button btnGuardarDatos;
        private TextBox textApe1;
        private DateTimePicker nacimientoPicker;
        private TextBox textApe2;
        private ComboBox comboGenero;
        private TextBox textID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
