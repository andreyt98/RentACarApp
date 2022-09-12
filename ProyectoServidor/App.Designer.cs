namespace ProyectoServidor {
    partial class App {
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
            this.btnMenuRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cantUsuarios = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelMenuConsulta = new System.Windows.Forms.Panel();
            this.btnConsultaCobertura = new System.Windows.Forms.Button();
            this.btnConsultaTipoV = new System.Windows.Forms.Button();
            this.btnConsultaVehiculoS = new System.Windows.Forms.Button();
            this.btnConsultaVehiculo = new System.Windows.Forms.Button();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.btnConsultaSucursal = new System.Windows.Forms.Button();
            this.btnMenuConsulta = new System.Windows.Forms.Button();
            this.panelMenuRegistro = new System.Windows.Forms.Panel();
            this.btnRegistroCobertura = new System.Windows.Forms.Button();
            this.btnRegistroTipoV = new System.Windows.Forms.Button();
            this.btnRegistroVehiculoS = new System.Windows.Forms.Button();
            this.btnRegistroVehiculo = new System.Windows.Forms.Button();
            this.btnRegistroCliente = new System.Windows.Forms.Button();
            this.btnRegistroSucursal = new System.Windows.Forms.Button();
            this.btnIniciarServidor = new System.Windows.Forms.Button();
            this.registroVehiculo1 = new ProyectoServidor.view.RegistroVehiculo();
            this.registroVehiculoSucursal1 = new ProyectoServidor.view.RegistroVehiculoSucursal();
            this.consultaSucursal1 = new ProyectoServidor.view.ConsultaSucursal();
            this.consultaCliente1 = new ProyectoServidor.view.ConsultaCliente();
            this.consultaCobertura1 = new ProyectoServidor.view.ConsultaCobertura();
            this.consultaTipoVehiculo1 = new ProyectoServidor.view.ConsultaTipoVehiculo();
            this.consultaVehiculo1 = new ProyectoServidor.view.ConsultaVehiculo();
            this.consultaVehiculoSucursal1 = new ProyectoServidor.view.ConsultaVehiculoSucursal();
            this.registroCliente1 = new ProyectoServidor.view.RegistroCliente();
            this.registroSucursal1 = new ProyectoServidor.view.RegistroSucursal();
            this.registroTipov1 = new ProyectoServidor.view.RegistroTipoV();
            this.registroCobertura1 = new ProyectoServidor.view.RegistroCobertura();
            this.listRegistroConexiones = new System.Windows.Forms.ListBox();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstadoServidor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetenerServidor = new System.Windows.Forms.Button();
            this.listConnectedUsers = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panelMenuConsulta.SuspendLayout();
            this.panelMenuRegistro.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuRegistro
            // 
            this.btnMenuRegistro.Location = new System.Drawing.Point(366, 11);
            this.btnMenuRegistro.Name = "btnMenuRegistro";
            this.btnMenuRegistro.Size = new System.Drawing.Size(145, 41);
            this.btnMenuRegistro.TabIndex = 0;
            this.btnMenuRegistro.Text = "Registro";
            this.btnMenuRegistro.UseVisualStyleBackColor = true;
            this.btnMenuRegistro.Click += new System.EventHandler(this.btnMenuRegistro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.cantUsuarios);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.panelMenuConsulta);
            this.panel1.Controls.Add(this.btnMenuConsulta);
            this.panel1.Controls.Add(this.panelMenuRegistro);
            this.panel1.Controls.Add(this.btnMenuRegistro);
            this.panel1.Location = new System.Drawing.Point(27, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 157);
            this.panel1.TabIndex = 1;
            // 
            // cantUsuarios
            // 
            this.cantUsuarios.AutoSize = true;
            this.cantUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cantUsuarios.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cantUsuarios.Location = new System.Drawing.Point(911, 11);
            this.cantUsuarios.Name = "cantUsuarios";
            this.cantUsuarios.Size = new System.Drawing.Size(126, 15);
            this.cantUsuarios.TabIndex = 13;
            this.cantUsuarios.Text = "Usuarios conectados: ";
            this.cantUsuarios.Visible = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Location = new System.Drawing.Point(3, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(118, 29);
            this.btnInicio.TabIndex = 9;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Visible = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelMenuConsulta
            // 
            this.panelMenuConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelMenuConsulta.Controls.Add(this.btnConsultaCobertura);
            this.panelMenuConsulta.Controls.Add(this.btnConsultaTipoV);
            this.panelMenuConsulta.Controls.Add(this.btnConsultaVehiculoS);
            this.panelMenuConsulta.Controls.Add(this.btnConsultaVehiculo);
            this.panelMenuConsulta.Controls.Add(this.btnConsultaCliente);
            this.panelMenuConsulta.Controls.Add(this.btnConsultaSucursal);
            this.panelMenuConsulta.Location = new System.Drawing.Point(556, 53);
            this.panelMenuConsulta.Name = "panelMenuConsulta";
            this.panelMenuConsulta.Size = new System.Drawing.Size(460, 101);
            this.panelMenuConsulta.TabIndex = 8;
            this.panelMenuConsulta.Visible = false;
            // 
            // btnConsultaCobertura
            // 
            this.btnConsultaCobertura.Location = new System.Drawing.Point(308, 50);
            this.btnConsultaCobertura.Name = "btnConsultaCobertura";
            this.btnConsultaCobertura.Size = new System.Drawing.Size(145, 41);
            this.btnConsultaCobertura.TabIndex = 7;
            this.btnConsultaCobertura.Text = "Cobertura";
            this.btnConsultaCobertura.UseVisualStyleBackColor = true;
            this.btnConsultaCobertura.Click += new System.EventHandler(this.btnConsultaCobertura_Click);
            // 
            // btnConsultaTipoV
            // 
            this.btnConsultaTipoV.Location = new System.Drawing.Point(308, 3);
            this.btnConsultaTipoV.Name = "btnConsultaTipoV";
            this.btnConsultaTipoV.Size = new System.Drawing.Size(145, 41);
            this.btnConsultaTipoV.TabIndex = 6;
            this.btnConsultaTipoV.Text = "Tipo vehiculo";
            this.btnConsultaTipoV.UseVisualStyleBackColor = true;
            this.btnConsultaTipoV.Click += new System.EventHandler(this.btnConsultaTipoV_Click);
            // 
            // btnConsultaVehiculoS
            // 
            this.btnConsultaVehiculoS.Location = new System.Drawing.Point(154, 50);
            this.btnConsultaVehiculoS.Name = "btnConsultaVehiculoS";
            this.btnConsultaVehiculoS.Size = new System.Drawing.Size(145, 41);
            this.btnConsultaVehiculoS.TabIndex = 5;
            this.btnConsultaVehiculoS.Text = "Vehiculo sucursal";
            this.btnConsultaVehiculoS.UseVisualStyleBackColor = true;
            this.btnConsultaVehiculoS.Click += new System.EventHandler(this.btnConsultaVehiculoS_Click);
            // 
            // btnConsultaVehiculo
            // 
            this.btnConsultaVehiculo.Location = new System.Drawing.Point(3, 50);
            this.btnConsultaVehiculo.Name = "btnConsultaVehiculo";
            this.btnConsultaVehiculo.Size = new System.Drawing.Size(145, 41);
            this.btnConsultaVehiculo.TabIndex = 4;
            this.btnConsultaVehiculo.Text = "Vehiculo";
            this.btnConsultaVehiculo.UseVisualStyleBackColor = true;
            this.btnConsultaVehiculo.Click += new System.EventHandler(this.btnConsultaVehiculo_Click);
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Location = new System.Drawing.Point(154, 3);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(145, 41);
            this.btnConsultaCliente.TabIndex = 3;
            this.btnConsultaCliente.Text = "Cliente";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // btnConsultaSucursal
            // 
            this.btnConsultaSucursal.Location = new System.Drawing.Point(3, 3);
            this.btnConsultaSucursal.Name = "btnConsultaSucursal";
            this.btnConsultaSucursal.Size = new System.Drawing.Size(145, 41);
            this.btnConsultaSucursal.TabIndex = 2;
            this.btnConsultaSucursal.Text = "Sucursal";
            this.btnConsultaSucursal.UseVisualStyleBackColor = true;
            this.btnConsultaSucursal.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnMenuConsulta
            // 
            this.btnMenuConsulta.Location = new System.Drawing.Point(557, 11);
            this.btnMenuConsulta.Name = "btnMenuConsulta";
            this.btnMenuConsulta.Size = new System.Drawing.Size(145, 41);
            this.btnMenuConsulta.TabIndex = 1;
            this.btnMenuConsulta.Text = "Consulta";
            this.btnMenuConsulta.UseVisualStyleBackColor = true;
            this.btnMenuConsulta.Click += new System.EventHandler(this.btnMenuConsulta_Click);
            // 
            // panelMenuRegistro
            // 
            this.panelMenuRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelMenuRegistro.Controls.Add(this.btnRegistroCobertura);
            this.panelMenuRegistro.Controls.Add(this.btnRegistroTipoV);
            this.panelMenuRegistro.Controls.Add(this.btnRegistroVehiculoS);
            this.panelMenuRegistro.Controls.Add(this.btnRegistroVehiculo);
            this.panelMenuRegistro.Controls.Add(this.btnRegistroCliente);
            this.panelMenuRegistro.Controls.Add(this.btnRegistroSucursal);
            this.panelMenuRegistro.Location = new System.Drawing.Point(57, 53);
            this.panelMenuRegistro.Name = "panelMenuRegistro";
            this.panelMenuRegistro.Size = new System.Drawing.Size(460, 101);
            this.panelMenuRegistro.TabIndex = 2;
            this.panelMenuRegistro.Visible = false;
            // 
            // btnRegistroCobertura
            // 
            this.btnRegistroCobertura.Location = new System.Drawing.Point(308, 50);
            this.btnRegistroCobertura.Name = "btnRegistroCobertura";
            this.btnRegistroCobertura.Size = new System.Drawing.Size(145, 41);
            this.btnRegistroCobertura.TabIndex = 7;
            this.btnRegistroCobertura.Text = "Cobertura";
            this.btnRegistroCobertura.UseVisualStyleBackColor = true;
            this.btnRegistroCobertura.Click += new System.EventHandler(this.btnRegistroCobertura_Click);
            // 
            // btnRegistroTipoV
            // 
            this.btnRegistroTipoV.Location = new System.Drawing.Point(308, 3);
            this.btnRegistroTipoV.Name = "btnRegistroTipoV";
            this.btnRegistroTipoV.Size = new System.Drawing.Size(145, 41);
            this.btnRegistroTipoV.TabIndex = 6;
            this.btnRegistroTipoV.Text = "Tipo vehiculo";
            this.btnRegistroTipoV.UseVisualStyleBackColor = true;
            this.btnRegistroTipoV.Click += new System.EventHandler(this.btnRegistroTipoV_Click);
            // 
            // btnRegistroVehiculoS
            // 
            this.btnRegistroVehiculoS.Location = new System.Drawing.Point(154, 50);
            this.btnRegistroVehiculoS.Name = "btnRegistroVehiculoS";
            this.btnRegistroVehiculoS.Size = new System.Drawing.Size(145, 41);
            this.btnRegistroVehiculoS.TabIndex = 5;
            this.btnRegistroVehiculoS.Text = "Vehiculo sucursal";
            this.btnRegistroVehiculoS.UseVisualStyleBackColor = true;
            this.btnRegistroVehiculoS.Click += new System.EventHandler(this.btnRegistroVehiculoS_Click);
            // 
            // btnRegistroVehiculo
            // 
            this.btnRegistroVehiculo.Location = new System.Drawing.Point(3, 50);
            this.btnRegistroVehiculo.Name = "btnRegistroVehiculo";
            this.btnRegistroVehiculo.Size = new System.Drawing.Size(145, 41);
            this.btnRegistroVehiculo.TabIndex = 4;
            this.btnRegistroVehiculo.Text = "Vehiculo";
            this.btnRegistroVehiculo.UseVisualStyleBackColor = true;
            this.btnRegistroVehiculo.Click += new System.EventHandler(this.btnRegistroVehiculo_Click);
            // 
            // btnRegistroCliente
            // 
            this.btnRegistroCliente.Location = new System.Drawing.Point(154, 3);
            this.btnRegistroCliente.Name = "btnRegistroCliente";
            this.btnRegistroCliente.Size = new System.Drawing.Size(145, 41);
            this.btnRegistroCliente.TabIndex = 3;
            this.btnRegistroCliente.Text = "Cliente";
            this.btnRegistroCliente.UseVisualStyleBackColor = true;
            this.btnRegistroCliente.Click += new System.EventHandler(this.btnRegistroCliente_Click);
            // 
            // btnRegistroSucursal
            // 
            this.btnRegistroSucursal.Location = new System.Drawing.Point(3, 3);
            this.btnRegistroSucursal.Name = "btnRegistroSucursal";
            this.btnRegistroSucursal.Size = new System.Drawing.Size(145, 41);
            this.btnRegistroSucursal.TabIndex = 2;
            this.btnRegistroSucursal.Text = "Sucursal";
            this.btnRegistroSucursal.UseVisualStyleBackColor = true;
            this.btnRegistroSucursal.Click += new System.EventHandler(this.btnRegistroSucursal_Click);
            // 
            // btnIniciarServidor
            // 
            this.btnIniciarServidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarServidor.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarServidor.Location = new System.Drawing.Point(230, 35);
            this.btnIniciarServidor.Name = "btnIniciarServidor";
            this.btnIniciarServidor.Size = new System.Drawing.Size(128, 45);
            this.btnIniciarServidor.TabIndex = 14;
            this.btnIniciarServidor.Text = "Iniciar";
            this.btnIniciarServidor.UseVisualStyleBackColor = true;
            this.btnIniciarServidor.Click += new System.EventHandler(this.btnIniciarServidor_Click);
            // 
            // registroVehiculo1
            // 
            this.registroVehiculo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.registroVehiculo1.Location = new System.Drawing.Point(1, 161);
            this.registroVehiculo1.Name = "registroVehiculo1";
            this.registroVehiculo1.Size = new System.Drawing.Size(1067, 495);
            this.registroVehiculo1.TabIndex = 5;
            this.registroVehiculo1.Visible = false;
            // 
            // registroVehiculoSucursal1
            // 
            this.registroVehiculoSucursal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.registroVehiculoSucursal1.idVehiculos = null;
            this.registroVehiculoSucursal1.Location = new System.Drawing.Point(2, 161);
            this.registroVehiculoSucursal1.Name = "registroVehiculoSucursal1";
            this.registroVehiculoSucursal1.seleccionIdSucursal = null;
            this.registroVehiculoSucursal1.Size = new System.Drawing.Size(1067, 495);
            this.registroVehiculoSucursal1.TabIndex = 6;
            this.registroVehiculoSucursal1.Visible = false;
            // 
            // consultaSucursal1
            // 
            this.consultaSucursal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.consultaSucursal1.Location = new System.Drawing.Point(1, 161);
            this.consultaSucursal1.Name = "consultaSucursal1";
            this.consultaSucursal1.Size = new System.Drawing.Size(1067, 495);
            this.consultaSucursal1.TabIndex = 8;
            this.consultaSucursal1.Visible = false;
            // 
            // consultaCliente1
            // 
            this.consultaCliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.consultaCliente1.Location = new System.Drawing.Point(1, 161);
            this.consultaCliente1.Name = "consultaCliente1";
            this.consultaCliente1.Size = new System.Drawing.Size(1067, 495);
            this.consultaCliente1.TabIndex = 9;
            this.consultaCliente1.Visible = false;
            // 
            // consultaCobertura1
            // 
            this.consultaCobertura1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.consultaCobertura1.Location = new System.Drawing.Point(2, 161);
            this.consultaCobertura1.Name = "consultaCobertura1";
            this.consultaCobertura1.Size = new System.Drawing.Size(1067, 495);
            this.consultaCobertura1.TabIndex = 10;
            this.consultaCobertura1.Visible = false;
            // 
            // consultaTipoVehiculo1
            // 
            this.consultaTipoVehiculo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.consultaTipoVehiculo1.Location = new System.Drawing.Point(1, 161);
            this.consultaTipoVehiculo1.Name = "consultaTipoVehiculo1";
            this.consultaTipoVehiculo1.Size = new System.Drawing.Size(1067, 495);
            this.consultaTipoVehiculo1.TabIndex = 11;
            this.consultaTipoVehiculo1.Visible = false;
            // 
            // consultaVehiculo1
            // 
            this.consultaVehiculo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.consultaVehiculo1.Location = new System.Drawing.Point(-2, 161);
            this.consultaVehiculo1.Name = "consultaVehiculo1";
            this.consultaVehiculo1.Size = new System.Drawing.Size(1067, 495);
            this.consultaVehiculo1.TabIndex = 12;
            this.consultaVehiculo1.Visible = false;
            // 
            // consultaVehiculoSucursal1
            // 
            this.consultaVehiculoSucursal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.consultaVehiculoSucursal1.Location = new System.Drawing.Point(2, 161);
            this.consultaVehiculoSucursal1.Name = "consultaVehiculoSucursal1";
            this.consultaVehiculoSucursal1.Size = new System.Drawing.Size(1067, 495);
            this.consultaVehiculoSucursal1.TabIndex = 13;
            this.consultaVehiculoSucursal1.Visible = false;
            // 
            // registroCliente1
            // 
            this.registroCliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.registroCliente1.ForeColor = System.Drawing.Color.White;
            this.registroCliente1.Location = new System.Drawing.Point(-2, 161);
            this.registroCliente1.Name = "registroCliente1";
            this.registroCliente1.Size = new System.Drawing.Size(1067, 495);
            this.registroCliente1.TabIndex = 14;
            this.registroCliente1.Visible = false;
            // 
            // registroSucursal1
            // 
            this.registroSucursal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.registroSucursal1.ForeColor = System.Drawing.Color.White;
            this.registroSucursal1.Location = new System.Drawing.Point(1, 161);
            this.registroSucursal1.Name = "registroSucursal1";
            this.registroSucursal1.Size = new System.Drawing.Size(1067, 495);
            this.registroSucursal1.TabIndex = 15;
            this.registroSucursal1.Visible = false;
            // 
            // registroTipov1
            // 
            this.registroTipov1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.registroTipov1.Location = new System.Drawing.Point(-2, 161);
            this.registroTipov1.Name = "registroTipov1";
            this.registroTipov1.Size = new System.Drawing.Size(1067, 495);
            this.registroTipov1.TabIndex = 16;
            this.registroTipov1.Visible = false;
            // 
            // registroCobertura1
            // 
            this.registroCobertura1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.registroCobertura1.ForeColor = System.Drawing.Color.White;
            this.registroCobertura1.Location = new System.Drawing.Point(-2, 161);
            this.registroCobertura1.Name = "registroCobertura1";
            this.registroCobertura1.Size = new System.Drawing.Size(1067, 495);
            this.registroCobertura1.TabIndex = 17;
            this.registroCobertura1.Visible = false;
            // 
            // listRegistroConexiones
            // 
            this.listRegistroConexiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.listRegistroConexiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listRegistroConexiones.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listRegistroConexiones.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listRegistroConexiones.FormattingEnabled = true;
            this.listRegistroConexiones.ItemHeight = 20;
            this.listRegistroConexiones.Location = new System.Drawing.Point(271, 347);
            this.listRegistroConexiones.Margin = new System.Windows.Forms.Padding(6);
            this.listRegistroConexiones.Name = "listRegistroConexiones";
            this.listRegistroConexiones.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listRegistroConexiones.Size = new System.Drawing.Size(487, 100);
            this.listRegistroConexiones.TabIndex = 9;
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.panelInicio.Controls.Add(this.label4);
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Controls.Add(this.listRegistroConexiones);
            this.panelInicio.Controls.Add(this.groupBox1);
            this.panelInicio.Controls.Add(this.listConnectedUsers);
            this.panelInicio.Location = new System.Drawing.Point(1, 164);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(1064, 492);
            this.panelInicio.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(11, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rent A Car App";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registro de conexiones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(444, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuarios conectados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstadoServidor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDetenerServidor);
            this.groupBox1.Controls.Add(this.btnIniciarServidor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(183, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 114);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVIDOR";
            // 
            // txtEstadoServidor
            // 
            this.txtEstadoServidor.AutoSize = true;
            this.txtEstadoServidor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEstadoServidor.ForeColor = System.Drawing.Color.Red;
            this.txtEstadoServidor.Location = new System.Drawing.Point(82, 43);
            this.txtEstadoServidor.Name = "txtEstadoServidor";
            this.txtEstadoServidor.Size = new System.Drawing.Size(133, 25);
            this.txtEstadoServidor.TabIndex = 17;
            this.txtEstadoServidor.Text = "Desconectado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado:";
            // 
            // btnDetenerServidor
            // 
            this.btnDetenerServidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetenerServidor.Enabled = false;
            this.btnDetenerServidor.ForeColor = System.Drawing.Color.Black;
            this.btnDetenerServidor.Location = new System.Drawing.Point(397, 35);
            this.btnDetenerServidor.Name = "btnDetenerServidor";
            this.btnDetenerServidor.Size = new System.Drawing.Size(128, 45);
            this.btnDetenerServidor.TabIndex = 15;
            this.btnDetenerServidor.Text = "Detener";
            this.btnDetenerServidor.UseVisualStyleBackColor = true;
            this.btnDetenerServidor.Click += new System.EventHandler(this.btnDetenerServidor_Click);
            // 
            // listConnectedUsers
            // 
            this.listConnectedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.listConnectedUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listConnectedUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listConnectedUsers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listConnectedUsers.FormattingEnabled = true;
            this.listConnectedUsers.ItemHeight = 20;
            this.listConnectedUsers.Location = new System.Drawing.Point(348, 200);
            this.listConnectedUsers.Margin = new System.Windows.Forms.Padding(6);
            this.listConnectedUsers.Name = "listConnectedUsers";
            this.listConnectedUsers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listConnectedUsers.Size = new System.Drawing.Size(337, 100);
            this.listConnectedUsers.TabIndex = 11;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1069, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.registroSucursal1);
            this.Controls.Add(this.registroCliente1);
            this.Controls.Add(this.registroCobertura1);
            this.Controls.Add(this.registroTipov1);
            this.Controls.Add(this.registroVehiculo1);
            this.Controls.Add(this.consultaVehiculoSucursal1);
            this.Controls.Add(this.consultaVehiculo1);
            this.Controls.Add(this.consultaTipoVehiculo1);
            this.Controls.Add(this.consultaCobertura1);
            this.Controls.Add(this.consultaCliente1);
            this.Controls.Add(this.consultaSucursal1);
            this.Controls.Add(this.registroVehiculoSucursal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent A Car";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenuConsulta.ResumeLayout(false);
            this.panelMenuRegistro.ResumeLayout(false);
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMenuRegistro;
        private Panel panel1;
        private Button btnMenuConsulta;
        private Panel panelMenuRegistro;
        private Panel panelMenuConsulta;
        private Button btnConsultaCobertura;
        private Button btnConsultaTipoV;
        private Button btnConsultaVehiculoS;
        private Button btnConsultaVehiculo;
        private Button btnConsultaCliente;
        private Button btnConsultaSucursal;
        private Button btnRegistroCobertura;
        private Button btnRegistroTipoV;
        private Button btnRegistroVehiculoS;
        private Button btnRegistroVehiculo;
        private Button btnRegistroCliente;
        private Button btnRegistroSucursal;
        private view.RegistroSucursal registroSucursal1;
        private view.RegistroCliente registroCliente1;
        private view.RegistroTipoV registroTipov1;
        private view.RegistroVehiculo registroVehiculo1;
        public view.RegistroVehiculoSucursal registroVehiculoSucursal1;
        private view.RegistroCobertura registroCobertura1;
        private view.ConsultaCliente consultaCliente1;
        private view.ConsultaTipoVehiculo consultaTipoVehiculo1;
        private view.ConsultaVehiculo consultaVehiculo1;
        private view.ConsultaVehiculoSucursal consultaVehiculoSucursal1;
        private view.ConsultaCobertura consultaCobertura1;
        public view.ConsultaSucursal consultaSucursal1;
        private Panel panelInicio;
        private Label label1;
        private Label label2;
        private Label cantUsuarios;
        private Button btnInicio;
        public ListBox listRegistroConexiones;
        public ListBox listConnectedUsers;
        private Button btnIniciarServidor;
        public GroupBox groupBox1;
        private Label txtEstadoServidor;
        private Label label3;
        private Button btnDetenerServidor;
        private Label label4;
    }
}