namespace TpIsGrupo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGeneral = new TpIsGrupo2.GradientPanel();
            this.pnlDatosEfectivo = new TpIsGrupo2.GradientPanel();
            this.lblSimbolo = new System.Windows.Forms.Label();
            this.lblMontoValido = new System.Windows.Forms.Label();
            this.nupEfectivo = new System.Windows.Forms.NumericUpDown();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblSeleccioneMetodo = new System.Windows.Forms.Label();
            this.pnlHoraEntrega = new TpIsGrupo2.GradientPanel();
            this.chkSeleccionarHora = new System.Windows.Forms.CheckBox();
            this.dtpSeleccionarFecha = new System.Windows.Forms.DateTimePicker();
            this.chkAntesPosible = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlDatosTarjeta = new TpIsGrupo2.GradientPanel();
            this.lblErrorCodigo = new System.Windows.Forms.Label();
            this.lblErrorFechaVencimiento = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorNumero = new System.Windows.Forms.Label();
            this.lblFechita = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.lblErrorTarjeta = new System.Windows.Forms.Label();
            this.btnError = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.pnlMetodo = new TpIsGrupo2.GradientPanel();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.gradientPanel2 = new TpIsGrupo2.GradientPanel();
            this.lbl_completarNumCalle = new System.Windows.Forms.Label();
            this.lbl_completarCalle = new System.Windows.Forms.Label();
            this.lbl_completarCiudad = new System.Windows.Forms.Label();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGeneral.SuspendLayout();
            this.pnlDatosEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEfectivo)).BeginInit();
            this.pnlHoraEntrega.SuspendLayout();
            this.pnlDatosTarjeta.SuspendLayout();
            this.pnlMetodo.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGeneral.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGeneral.Controls.Add(this.pnlDatosEfectivo);
            this.pnlGeneral.Controls.Add(this.lblSeleccioneMetodo);
            this.pnlGeneral.Controls.Add(this.pnlHoraEntrega);
            this.pnlGeneral.Controls.Add(this.button5);
            this.pnlGeneral.Controls.Add(this.pnlDatosTarjeta);
            this.pnlGeneral.Controls.Add(this.lblCantidadProductos);
            this.pnlGeneral.Controls.Add(this.pnlMetodo);
            this.pnlGeneral.Controls.Add(this.btnCarrito);
            this.pnlGeneral.Controls.Add(this.btnComprar);
            this.pnlGeneral.Controls.Add(this.gradientPanel2);
            this.pnlGeneral.Controls.Add(this.label1);
            this.pnlGeneral.Controls.Add(this.pictureBox3);
            this.pnlGeneral.Controls.Add(this.pictureBox2);
            this.pnlGeneral.Controls.Add(this.pictureBox1);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGeneral.MaximumSize = new System.Drawing.Size(0, 844);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(390, 788);
            this.pnlGeneral.TabIndex = 0;
            // 
            // pnlDatosEfectivo
            // 
            this.pnlDatosEfectivo.BackColor = System.Drawing.Color.White;
            this.pnlDatosEfectivo.ColorBottom = System.Drawing.Color.Empty;
            this.pnlDatosEfectivo.ColorTop = System.Drawing.Color.Empty;
            this.pnlDatosEfectivo.Controls.Add(this.lblSimbolo);
            this.pnlDatosEfectivo.Controls.Add(this.lblMontoValido);
            this.pnlDatosEfectivo.Controls.Add(this.nupEfectivo);
            this.pnlDatosEfectivo.Controls.Add(this.lblEfectivo);
            this.pnlDatosEfectivo.Location = new System.Drawing.Point(66, 988);
            this.pnlDatosEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosEfectivo.Name = "pnlDatosEfectivo";
            this.pnlDatosEfectivo.Size = new System.Drawing.Size(243, 105);
            this.pnlDatosEfectivo.TabIndex = 17;
            this.pnlDatosEfectivo.Visible = false;
            // 
            // lblSimbolo
            // 
            this.lblSimbolo.AutoSize = true;
            this.lblSimbolo.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSimbolo.Location = new System.Drawing.Point(5, 52);
            this.lblSimbolo.Name = "lblSimbolo";
            this.lblSimbolo.Size = new System.Drawing.Size(17, 19);
            this.lblSimbolo.TabIndex = 16;
            this.lblSimbolo.Text = "$";
            // 
            // lblMontoValido
            // 
            this.lblMontoValido.AutoSize = true;
            this.lblMontoValido.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMontoValido.ForeColor = System.Drawing.Color.Red;
            this.lblMontoValido.Location = new System.Drawing.Point(28, 77);
            this.lblMontoValido.Name = "lblMontoValido";
            this.lblMontoValido.Size = new System.Drawing.Size(120, 13);
            this.lblMontoValido.TabIndex = 15;
            this.lblMontoValido.Text = "Ingrese un monto valido";
            // 
            // nupEfectivo
            // 
            this.nupEfectivo.Location = new System.Drawing.Point(28, 51);
            this.nupEfectivo.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.nupEfectivo.Name = "nupEfectivo";
            this.nupEfectivo.Size = new System.Drawing.Size(120, 23);
            this.nupEfectivo.TabIndex = 14;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.lblEfectivo.Location = new System.Drawing.Point(27, 19);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(186, 17);
            this.lblEfectivo.TabIndex = 13;
            this.lblEfectivo.Text = "Ingrese el monto en efectivo";
            // 
            // lblSeleccioneMetodo
            // 
            this.lblSeleccioneMetodo.AutoSize = true;
            this.lblSeleccioneMetodo.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccioneMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccioneMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSeleccioneMetodo.Location = new System.Drawing.Point(23, 471);
            this.lblSeleccioneMetodo.Name = "lblSeleccioneMetodo";
            this.lblSeleccioneMetodo.Size = new System.Drawing.Size(335, 20);
            this.lblSeleccioneMetodo.TabIndex = 16;
            this.lblSeleccioneMetodo.Text = "Seleccione un método de pago para continuar";
            // 
            // pnlHoraEntrega
            // 
            this.pnlHoraEntrega.BackColor = System.Drawing.Color.White;
            this.pnlHoraEntrega.ColorBottom = System.Drawing.Color.Empty;
            this.pnlHoraEntrega.ColorTop = System.Drawing.Color.Empty;
            this.pnlHoraEntrega.Controls.Add(this.chkSeleccionarHora);
            this.pnlHoraEntrega.Controls.Add(this.dtpSeleccionarFecha);
            this.pnlHoraEntrega.Controls.Add(this.chkAntesPosible);
            this.pnlHoraEntrega.Controls.Add(this.label11);
            this.pnlHoraEntrega.Location = new System.Drawing.Point(69, 234);
            this.pnlHoraEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHoraEntrega.Name = "pnlHoraEntrega";
            this.pnlHoraEntrega.Size = new System.Drawing.Size(245, 122);
            this.pnlHoraEntrega.TabIndex = 14;
            // 
            // chkSeleccionarHora
            // 
            this.chkSeleccionarHora.AutoSize = true;
            this.chkSeleccionarHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSeleccionarHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.chkSeleccionarHora.Location = new System.Drawing.Point(30, 58);
            this.chkSeleccionarHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSeleccionarHora.Name = "chkSeleccionarHora";
            this.chkSeleccionarHora.Size = new System.Drawing.Size(134, 21);
            this.chkSeleccionarHora.TabIndex = 12;
            this.chkSeleccionarHora.Text = "Seleccionar hora";
            this.chkSeleccionarHora.UseVisualStyleBackColor = true;
            // 
            // dtpSeleccionarFecha
            // 
            this.dtpSeleccionarFecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.dtpSeleccionarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSeleccionarFecha.Location = new System.Drawing.Point(12, 82);
            this.dtpSeleccionarFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSeleccionarFecha.MinDate = new System.DateTime(2023, 8, 29, 0, 0, 0, 0);
            this.dtpSeleccionarFecha.Name = "dtpSeleccionarFecha";
            this.dtpSeleccionarFecha.Size = new System.Drawing.Size(219, 23);
            this.dtpSeleccionarFecha.TabIndex = 11;
            // 
            // chkAntesPosible
            // 
            this.chkAntesPosible.AutoSize = true;
            this.chkAntesPosible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAntesPosible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.chkAntesPosible.Location = new System.Drawing.Point(30, 32);
            this.chkAntesPosible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAntesPosible.Name = "chkAntesPosible";
            this.chkAntesPosible.Size = new System.Drawing.Size(131, 21);
            this.chkAntesPosible.TabIndex = 10;
            this.chkAntesPosible.Text = "Lo antes posible";
            this.chkAntesPosible.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label11.Location = new System.Drawing.Point(57, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Hora de entrega";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::TpIsGrupo2.Images.leftarrow1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(23, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 32);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pnlDatosTarjeta
            // 
            this.pnlDatosTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlDatosTarjeta.ColorBottom = System.Drawing.Color.Empty;
            this.pnlDatosTarjeta.ColorTop = System.Drawing.Color.Empty;
            this.pnlDatosTarjeta.Controls.Add(this.lblErrorCodigo);
            this.pnlDatosTarjeta.Controls.Add(this.lblErrorFechaVencimiento);
            this.pnlDatosTarjeta.Controls.Add(this.lblErrorNombre);
            this.pnlDatosTarjeta.Controls.Add(this.lblErrorNumero);
            this.pnlDatosTarjeta.Controls.Add(this.lblFechita);
            this.pnlDatosTarjeta.Controls.Add(this.lblFechaVencimiento);
            this.pnlDatosTarjeta.Controls.Add(this.txtFechaVencimiento);
            this.pnlDatosTarjeta.Controls.Add(this.lblErrorTarjeta);
            this.pnlDatosTarjeta.Controls.Add(this.btnError);
            this.pnlDatosTarjeta.Controls.Add(this.label12);
            this.pnlDatosTarjeta.Controls.Add(this.label9);
            this.pnlDatosTarjeta.Controls.Add(this.txtCodigoSeguridad);
            this.pnlDatosTarjeta.Controls.Add(this.lblNombreTitular);
            this.pnlDatosTarjeta.Controls.Add(this.label5);
            this.pnlDatosTarjeta.Controls.Add(this.txtNombreTitular);
            this.pnlDatosTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.pnlDatosTarjeta.Controls.Add(this.btnVisa);
            this.pnlDatosTarjeta.Location = new System.Drawing.Point(66, 515);
            this.pnlDatosTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosTarjeta.Name = "pnlDatosTarjeta";
            this.pnlDatosTarjeta.Size = new System.Drawing.Size(243, 324);
            this.pnlDatosTarjeta.TabIndex = 14;
            this.pnlDatosTarjeta.Visible = false;
            // 
            // lblErrorCodigo
            // 
            this.lblErrorCodigo.AutoSize = true;
            this.lblErrorCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodigo.Location = new System.Drawing.Point(25, 297);
            this.lblErrorCodigo.Name = "lblErrorCodigo";
            this.lblErrorCodigo.Size = new System.Drawing.Size(123, 13);
            this.lblErrorCodigo.TabIndex = 25;
            this.lblErrorCodigo.Text = "Ingrese un codigo valido";
            // 
            // lblErrorFechaVencimiento
            // 
            this.lblErrorFechaVencimiento.AutoSize = true;
            this.lblErrorFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorFechaVencimiento.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFechaVencimiento.Location = new System.Drawing.Point(26, 240);
            this.lblErrorFechaVencimiento.Name = "lblErrorFechaVencimiento";
            this.lblErrorFechaVencimiento.Size = new System.Drawing.Size(124, 13);
            this.lblErrorFechaVencimiento.TabIndex = 24;
            this.lblErrorFechaVencimiento.Text = "Ingrese una fecha valida";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(27, 180);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(126, 13);
            this.lblErrorNombre.TabIndex = 22;
            this.lblErrorNombre.Text = "Ingrese un nombre valido";
            // 
            // lblErrorNumero
            // 
            this.lblErrorNumero.AutoSize = true;
            this.lblErrorNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorNumero.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNumero.Location = new System.Drawing.Point(28, 123);
            this.lblErrorNumero.Name = "lblErrorNumero";
            this.lblErrorNumero.Size = new System.Drawing.Size(126, 13);
            this.lblErrorNumero.TabIndex = 21;
            this.lblErrorNumero.Text = "Ingrese un numero valido";
            // 
            // lblFechita
            // 
            this.lblFechita.AutoSize = true;
            this.lblFechita.BackColor = System.Drawing.Color.Transparent;
            this.lblFechita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechita.ForeColor = System.Drawing.Color.Black;
            this.lblFechita.Location = new System.Drawing.Point(125, 217);
            this.lblFechita.Name = "lblFechita";
            this.lblFechita.Size = new System.Drawing.Size(80, 17);
            this.lblFechita.TabIndex = 20;
            this.lblFechita.Text = "(MM/AAAA)";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaVencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(27, 196);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(208, 17);
            this.lblFechaVencimiento.TabIndex = 19;
            this.lblFechaVencimiento.Text = "Ingrese la fecha de vencimiento";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(26, 215);
            this.txtFechaVencimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(92, 23);
            this.txtFechaVencimiento.TabIndex = 18;
            this.txtFechaVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaVencimiento_KeyPress);
            // 
            // lblErrorTarjeta
            // 
            this.lblErrorTarjeta.AutoSize = true;
            this.lblErrorTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblErrorTarjeta.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTarjeta.Location = new System.Drawing.Point(91, 55);
            this.lblErrorTarjeta.Name = "lblErrorTarjeta";
            this.lblErrorTarjeta.Size = new System.Drawing.Size(110, 17);
            this.lblErrorTarjeta.TabIndex = 17;
            this.lblErrorTarjeta.Text = "Datos Invalidos!!";
            // 
            // btnError
            // 
            this.btnError.BackgroundImage = global::TpIsGrupo2.Images.Imagen_de_error;
            this.btnError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnError.FlatAppearance.BorderSize = 0;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.Location = new System.Drawing.Point(28, 51);
            this.btnError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnError.Name = "btnError";
            this.btnError.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnError.Size = new System.Drawing.Size(65, 26);
            this.btnError.TabIndex = 16;
            this.btnError.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnError.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label12.Location = new System.Drawing.Point(22, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ingrese los datos de su tarjeta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label9.Location = new System.Drawing.Point(26, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ingrese el codigo (CVC)";
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(26, 272);
            this.txtCodigoSeguridad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(92, 23);
            this.txtCodigoSeguridad.TabIndex = 12;
            this.txtCodigoSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSeguridad_KeyPress);
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreTitular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.lblNombreTitular.Location = new System.Drawing.Point(28, 136);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(186, 17);
            this.lblNombreTitular.TabIndex = 13;
            this.lblNombreTitular.Text = "Ingrese el nombre y apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(28, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ingrese el numero";
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Location = new System.Drawing.Point(29, 155);
            this.txtNombreTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(170, 23);
            this.txtNombreTitular.TabIndex = 12;
            this.txtNombreTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreTitular_KeyPress);
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(28, 98);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(208, 23);
            this.txtNumeroTarjeta.TabIndex = 12;
            this.txtNumeroTarjeta.TextChanged += new System.EventHandler(this.txtNumeroTarjeta_TextChanged);
            this.txtNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTarjeta_KeyPress);
            // 
            // btnVisa
            // 
            this.btnVisa.BackgroundImage = global::TpIsGrupo2.Images.visa2;
            this.btnVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisa.FlatAppearance.BorderSize = 0;
            this.btnVisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisa.Location = new System.Drawing.Point(91, 51);
            this.btnVisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnVisa.Size = new System.Drawing.Size(65, 26);
            this.btnVisa.TabIndex = 0;
            this.btnVisa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVisa.UseVisualStyleBackColor = true;
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.lblCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadProductos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadProductos.Location = new System.Drawing.Point(318, 0);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(17, 18);
            this.lblCantidadProductos.TabIndex = 18;
            this.lblCantidadProductos.Text = "0";
            // 
            // pnlMetodo
            // 
            this.pnlMetodo.BackColor = System.Drawing.Color.White;
            this.pnlMetodo.ColorBottom = System.Drawing.Color.Empty;
            this.pnlMetodo.ColorTop = System.Drawing.Color.Empty;
            this.pnlMetodo.Controls.Add(this.rbDebito);
            this.pnlMetodo.Controls.Add(this.rbCredito);
            this.pnlMetodo.Controls.Add(this.rbEfectivo);
            this.pnlMetodo.Controls.Add(this.label6);
            this.pnlMetodo.Location = new System.Drawing.Point(71, 372);
            this.pnlMetodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMetodo.Name = "pnlMetodo";
            this.pnlMetodo.Size = new System.Drawing.Size(243, 93);
            this.pnlMetodo.TabIndex = 13;
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDebito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.rbDebito.Location = new System.Drawing.Point(22, 64);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(134, 21);
            this.rbDebito.TabIndex = 14;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Tarjeta de debito";
            this.rbDebito.UseVisualStyleBackColor = true;
            this.rbDebito.CheckedChanged += new System.EventHandler(this.rbDebito_CheckedChanged);
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.rbCredito.Location = new System.Drawing.Point(22, 46);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(138, 21);
            this.rbCredito.TabIndex = 13;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Tarjeta de credito";
            this.rbCredito.UseVisualStyleBackColor = true;
            this.rbCredito.CheckedChanged += new System.EventHandler(this.rbCredito_CheckedChanged);
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.rbEfectivo.Location = new System.Drawing.Point(23, 28);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(76, 21);
            this.rbEfectivo.TabIndex = 12;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(57, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Metodo de pago";
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.Transparent;
            this.btnCarrito.BackgroundImage = global::TpIsGrupo2.Images.shoppingcart2;
            this.btnCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarrito.Location = new System.Drawing.Point(279, 6);
            this.btnCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(47, 38);
            this.btnCarrito.TabIndex = 17;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(66, 856);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(245, 48);
            this.btnComprar.TabIndex = 15;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel2.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel2.Controls.Add(this.lbl_completarNumCalle);
            this.gradientPanel2.Controls.Add(this.lbl_completarCalle);
            this.gradientPanel2.Controls.Add(this.lbl_completarCiudad);
            this.gradientPanel2.Controls.Add(this.cmbCiudades);
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.label3);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.txtCalle);
            this.gradientPanel2.Controls.Add(this.txtNumero);
            this.gradientPanel2.ForeColor = System.Drawing.Color.Coral;
            this.gradientPanel2.Location = new System.Drawing.Point(71, 55);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(245, 165);
            this.gradientPanel2.TabIndex = 12;
            // 
            // lbl_completarNumCalle
            // 
            this.lbl_completarNumCalle.AutoSize = true;
            this.lbl_completarNumCalle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_completarNumCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_completarNumCalle.ForeColor = System.Drawing.Color.Red;
            this.lbl_completarNumCalle.Location = new System.Drawing.Point(31, 148);
            this.lbl_completarNumCalle.Name = "lbl_completarNumCalle";
            this.lbl_completarNumCalle.Size = new System.Drawing.Size(106, 13);
            this.lbl_completarNumCalle.TabIndex = 14;
            this.lbl_completarNumCalle.Text = "Ingrese el n° de calle";
            // 
            // lbl_completarCalle
            // 
            this.lbl_completarCalle.AutoSize = true;
            this.lbl_completarCalle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_completarCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_completarCalle.ForeColor = System.Drawing.Color.Red;
            this.lbl_completarCalle.Location = new System.Drawing.Point(29, 101);
            this.lbl_completarCalle.Name = "lbl_completarCalle";
            this.lbl_completarCalle.Size = new System.Drawing.Size(120, 13);
            this.lbl_completarCalle.TabIndex = 13;
            this.lbl_completarCalle.Text = "Ingrese nombre de calle";
            // 
            // lbl_completarCiudad
            // 
            this.lbl_completarCiudad.AutoSize = true;
            this.lbl_completarCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_completarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_completarCiudad.ForeColor = System.Drawing.Color.Red;
            this.lbl_completarCiudad.Location = new System.Drawing.Point(28, 52);
            this.lbl_completarCiudad.Name = "lbl_completarCiudad";
            this.lbl_completarCiudad.Size = new System.Drawing.Size(116, 13);
            this.lbl_completarCiudad.TabIndex = 12;
            this.lbl_completarCiudad.Text = "Seleccione una ciudad";
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(30, 28);
            this.cmbCiudades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(178, 24);
            this.cmbCiudades.TabIndex = 8;
            this.cmbCiudades.SelectedIndexChanged += new System.EventHandler(this.cmbCiudades_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(30, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ingrese el numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(30, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleccione su ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese su calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(30, 78);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(170, 23);
            this.txtCalle.TabIndex = 7;
            this.txtCalle.TextChanged += new System.EventHandler(this.txtCalle_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(30, 125);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 23);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(111, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Confirmar Pedido";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TpIsGrupo2.Images.circlesv2;
            this.pictureBox3.Location = new System.Drawing.Point(236, 730);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(304, 256);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TpIsGrupo2.Images.circlesv2;
            this.pictureBox2.Location = new System.Drawing.Point(-98, 302);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TpIsGrupo2.Images.circlesv2;
            this.pictureBox1.Location = new System.Drawing.Point(308, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 788);
            this.Controls.Add(this.pnlGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.pnlDatosEfectivo.ResumeLayout(false);
            this.pnlDatosEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEfectivo)).EndInit();
            this.pnlHoraEntrega.ResumeLayout(false);
            this.pnlHoraEntrega.PerformLayout();
            this.pnlDatosTarjeta.ResumeLayout(false);
            this.pnlDatosTarjeta.PerformLayout();
            this.pnlMetodo.ResumeLayout(false);
            this.pnlMetodo.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel pnlGeneral;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox txtNumero;
        private TextBox txtCalle;
        private Label label3;
        private ComboBox cmbCiudades;
        private Label label2;
        private Label label4;
        private GradientPanel gradientPanel2;
        private GradientPanel pnlMetodo;
        private Label label6;
        private CheckBox chkTarjeta;
        private CheckBox chkEfectivo;
        private GradientPanel pnlDatosTarjeta;
        private Button btnVisa;
        private Button btnMastercard;
        private Label label5;
        private TextBox txtNumeroTarjeta;
        private Label label9;
        private TextBox txtCodigoSeguridad;
        private Label lblNombreTitular;
        private TextBox txtNombreTitular;
        private Button btnComprar;
        private Button btnCarrito;
        private Label lblCantidadProductos;
        private GradientPanel pnlHoraEntrega;
        private CheckBox chkAntesPosible;
        private Label label11;
        private DateTimePicker dtpSeleccionarFecha;
        private CheckBox chkSeleccionarHora;
        private Label label12;
        private Label lblSeleccioneMetodo;
        private Button button5;
        private Label lbl_completarCiudad;
        private Label lbl_completarCalle;
        private Label lbl_completarNumCalle;
        private RadioButton rbDebito;
        private RadioButton rbCredito;
        private RadioButton rbEfectivo;
        private Button btnError;
        private GradientPanel pnlDatosEfectivo;
        private NumericUpDown nupEfectivo;
        private Label lblEfectivo;
        private Label lblMontoValido;
        private Label lblSimbolo;
        private Label lblErrorTarjeta;
        private Label lblFechita;
        private Label lblFechaVencimiento;
        private TextBox txtFechaVencimiento;
        private Label lblErrorCodigo;
        private Label lblErrorFechaVencimiento;
        private Label lblErrorNombre;
        private Label lblErrorNumero;
    }
}