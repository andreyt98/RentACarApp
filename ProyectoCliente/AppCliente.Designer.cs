namespace ProyectoCliente {
    partial class AppCliente {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.idCliente = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.panelInicioSesion = new System.Windows.Forms.Panel();
            this.mensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarConexion = new System.Windows.Forms.Button();
            this.tIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRealizarReserva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.realizarReserva1 = new ProyectoCliente.View.RealizarReserva();
            this.panelContenedor.SuspendLayout();
            this.panelInicioSesion.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelContenedor.Controls.Add(this.idCliente);
            this.panelContenedor.Controls.Add(this.btnDesconectar);
            this.panelContenedor.Controls.Add(this.panelInicioSesion);
            this.panelContenedor.Controls.Add(this.nombreCliente);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.label4);
            this.panelContenedor.Controls.Add(this.realizarReserva1);
            this.panelContenedor.ForeColor = System.Drawing.Color.White;
            this.panelContenedor.Location = new System.Drawing.Point(-2, -2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1070, 663);
            this.panelContenedor.TabIndex = 3;
            // 
            // idCliente
            // 
            this.idCliente.AutoSize = true;
            this.idCliente.Location = new System.Drawing.Point(129, 14);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(0, 15);
            this.idCliente.TabIndex = 15;
            this.idCliente.Visible = false;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ForeColor = System.Drawing.Color.Black;
            this.btnDesconectar.Location = new System.Drawing.Point(972, 14);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(88, 32);
            this.btnDesconectar.TabIndex = 14;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Visible = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // panelInicioSesion
            // 
            this.panelInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelInicioSesion.Controls.Add(this.mensaje);
            this.panelInicioSesion.Controls.Add(this.label1);
            this.panelInicioSesion.Controls.Add(this.btnIniciarConexion);
            this.panelInicioSesion.Controls.Add(this.tIdCliente);
            this.panelInicioSesion.Controls.Add(this.label2);
            this.panelInicioSesion.Location = new System.Drawing.Point(372, 173);
            this.panelInicioSesion.Name = "panelInicioSesion";
            this.panelInicioSesion.Size = new System.Drawing.Size(346, 275);
            this.panelInicioSesion.TabIndex = 12;
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensaje.Location = new System.Drawing.Point(85, 232);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(0, 21);
            this.mensaje.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rent A Car App";
            // 
            // btnIniciarConexion
            // 
            this.btnIniciarConexion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarConexion.Location = new System.Drawing.Point(85, 172);
            this.btnIniciarConexion.Name = "btnIniciarConexion";
            this.btnIniciarConexion.Size = new System.Drawing.Size(174, 45);
            this.btnIniciarConexion.TabIndex = 11;
            this.btnIniciarConexion.Text = "Iniciar conexión";
            this.btnIniciarConexion.UseVisualStyleBackColor = true;
            this.btnIniciarConexion.Click += new System.EventHandler(this.btnIniciarConexion_Click);
            // 
            // tIdCliente
            // 
            this.tIdCliente.Location = new System.Drawing.Point(62, 124);
            this.tIdCliente.Name = "tIdCliente";
            this.tIdCliente.Size = new System.Drawing.Size(214, 23);
            this.tIdCliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese su identificación";
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSize = true;
            this.nombreCliente.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreCliente.Location = new System.Drawing.Point(18, 11);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(0, 40);
            this.nombreCliente.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.btnRealizarReserva);
            this.panelMenu.Location = new System.Drawing.Point(212, 71);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(643, 81);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(371, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Consultar mis reservas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnRealizarReserva
            // 
            this.btnRealizarReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRealizarReserva.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarReserva.Location = new System.Drawing.Point(27, 4);
            this.btnRealizarReserva.Name = "btnRealizarReserva";
            this.btnRealizarReserva.Size = new System.Drawing.Size(256, 38);
            this.btnRealizarReserva.TabIndex = 3;
            this.btnRealizarReserva.Text = "Realizar reservas de vehiculo";
            this.btnRealizarReserva.UseVisualStyleBackColor = true;
            this.btnRealizarReserva.Click += new System.EventHandler(this.btnRealizarReserva_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(15, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rent A Car App";
            // 
            // realizarReserva1
            // 
            this.realizarReserva1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.realizarReserva1.fechaFin = null;
            this.realizarReserva1.fechaInicio = null;
            this.realizarReserva1.Location = new System.Drawing.Point(3, 173);
            this.realizarReserva1.Name = "realizarReserva1";
            this.realizarReserva1.seleccionIdCobertura = null;
            this.realizarReserva1.seleccionIdSucursal = null;
            this.realizarReserva1.seleccionIdTipoV = null;
            this.realizarReserva1.seleccionIdVehiculo = null;
            this.realizarReserva1.seleccionMontoCobertura = null;
            this.realizarReserva1.Size = new System.Drawing.Size(1067, 485);
            this.realizarReserva1.TabIndex = 13;
            this.realizarReserva1.Visible = false;
            this.realizarReserva1.Load += new System.EventHandler(this.realizarReserva1_Load);
            // 
            // AppCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 656);
            this.Controls.Add(this.panelContenedor);
            this.Name = "AppCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppCliente_FormClosed);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelInicioSesion.ResumeLayout(false);
            this.panelInicioSesion.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelContenedor;
        private Button btnIniciarConexion;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnRealizarReserva;
        private Panel panelInicioSesion;
        private Panel panelMenu;
        public TextBox tIdCliente;
        public Label nombreCliente;
        private Label mensaje;
        private View.RealizarReserva realizarReserva1;
        private Button btnDesconectar;
        public Label idCliente;
        private Label label4;
    }
}