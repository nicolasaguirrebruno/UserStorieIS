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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlGeneral = new GradientPanel();
            pnlDatosEfectivo = new GradientPanel();
            lblSimbolo = new Label();
            lblMontoValido = new Label();
            nupEfectivo = new NumericUpDown();
            lblEfectivo = new Label();
            lblSeleccioneMetodo = new Label();
            pnlHoraEntrega = new GradientPanel();
            rbFechaSeleccion = new RadioButton();
            rnPronto = new RadioButton();
            dtpSeleccionarFecha = new DateTimePicker();
            label11 = new Label();
            button5 = new Button();
            pnlDatosTarjeta = new GradientPanel();
            lblErrorCodigo = new Label();
            lblErrorFechaVencimiento = new Label();
            lblErrorNombre = new Label();
            lblErrorNumero = new Label();
            lblFechita = new Label();
            lblFechaVencimiento = new Label();
            txtFechaVencimiento = new TextBox();
            lblErrorTarjeta = new Label();
            btnError = new Button();
            label12 = new Label();
            label9 = new Label();
            txtCodigoSeguridad = new TextBox();
            lblNombreTitular = new Label();
            label5 = new Label();
            txtNombreTitular = new TextBox();
            txtNumeroTarjeta = new TextBox();
            btnVisa = new Button();
            lblCantidadProductos = new Label();
            pnlMetodo = new GradientPanel();
            rbDebito = new RadioButton();
            rbCredito = new RadioButton();
            rbEfectivo = new RadioButton();
            label6 = new Label();
            btnCarrito = new Button();
            btnComprar = new Button();
            pnlDireccion = new GradientPanel();
            lbl_completarNumCalle = new Label();
            lbl_completarCalle = new Label();
            lbl_completarCiudad = new Label();
            cmbCiudades = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCalle = new TextBox();
            txtNumero = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlGeneral.SuspendLayout();
            pnlDatosEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupEfectivo).BeginInit();
            pnlHoraEntrega.SuspendLayout();
            pnlDatosTarjeta.SuspendLayout();
            pnlMetodo.SuspendLayout();
            pnlDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlGeneral
            // 
            pnlGeneral.ColorBottom = Color.FromArgb(240, 230, 239);
            pnlGeneral.ColorTop = Color.FromArgb(224, 224, 224);
            pnlGeneral.Controls.Add(pnlDatosEfectivo);
            pnlGeneral.Controls.Add(lblSeleccioneMetodo);
            pnlGeneral.Controls.Add(pnlHoraEntrega);
            pnlGeneral.Controls.Add(button5);
            pnlGeneral.Controls.Add(pnlDatosTarjeta);
            pnlGeneral.Controls.Add(lblCantidadProductos);
            pnlGeneral.Controls.Add(pnlMetodo);
            pnlGeneral.Controls.Add(btnCarrito);
            pnlGeneral.Controls.Add(btnComprar);
            pnlGeneral.Controls.Add(pnlDireccion);
            pnlGeneral.Controls.Add(label1);
            pnlGeneral.Controls.Add(pictureBox3);
            pnlGeneral.Controls.Add(pictureBox2);
            pnlGeneral.Controls.Add(pictureBox1);
            pnlGeneral.Dock = DockStyle.Fill;
            pnlGeneral.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pnlGeneral.Location = new Point(0, 0);
            pnlGeneral.Margin = new Padding(3, 2, 3, 2);
            pnlGeneral.MaximumSize = new Size(0, 1100);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(390, 1100);
            pnlGeneral.TabIndex = 0;
            // 
            // pnlDatosEfectivo
            // 
            pnlDatosEfectivo.BackColor = Color.White;
            pnlDatosEfectivo.ColorBottom = Color.Empty;
            pnlDatosEfectivo.ColorTop = Color.Empty;
            pnlDatosEfectivo.Controls.Add(lblSimbolo);
            pnlDatosEfectivo.Controls.Add(lblMontoValido);
            pnlDatosEfectivo.Controls.Add(nupEfectivo);
            pnlDatosEfectivo.Controls.Add(lblEfectivo);
            pnlDatosEfectivo.Location = new Point(64, 924);
            pnlDatosEfectivo.Margin = new Padding(3, 2, 3, 2);
            pnlDatosEfectivo.Name = "pnlDatosEfectivo";
            pnlDatosEfectivo.Size = new Size(243, 105);
            pnlDatosEfectivo.TabIndex = 17;
            pnlDatosEfectivo.Visible = false;
            // 
            // lblSimbolo
            // 
            lblSimbolo.AutoSize = true;
            lblSimbolo.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSimbolo.Location = new Point(5, 52);
            lblSimbolo.Name = "lblSimbolo";
            lblSimbolo.Size = new Size(17, 19);
            lblSimbolo.TabIndex = 16;
            lblSimbolo.Text = "$";
            // 
            // lblMontoValido
            // 
            lblMontoValido.AutoSize = true;
            lblMontoValido.BackColor = Color.Transparent;
            lblMontoValido.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoValido.ForeColor = Color.Red;
            lblMontoValido.Location = new Point(28, 77);
            lblMontoValido.Name = "lblMontoValido";
            lblMontoValido.Size = new Size(120, 13);
            lblMontoValido.TabIndex = 15;
            lblMontoValido.Text = "Ingrese un monto valido";
            // 
            // nupEfectivo
            // 
            nupEfectivo.DecimalPlaces = 2;
            nupEfectivo.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nupEfectivo.Location = new Point(28, 51);
            nupEfectivo.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            nupEfectivo.Name = "nupEfectivo";
            nupEfectivo.Size = new Size(120, 21);
            nupEfectivo.TabIndex = 14;
            // 
            // lblEfectivo
            // 
            lblEfectivo.AutoSize = true;
            lblEfectivo.BackColor = Color.Transparent;
            lblEfectivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEfectivo.ForeColor = Color.FromArgb(120, 83, 101);
            lblEfectivo.Location = new Point(27, 19);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(198, 20);
            lblEfectivo.TabIndex = 13;
            lblEfectivo.Text = "Ingrese el monto en efectivo";
            // 
            // lblSeleccioneMetodo
            // 
            lblSeleccioneMetodo.AutoSize = true;
            lblSeleccioneMetodo.BackColor = Color.Transparent;
            lblSeleccioneMetodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccioneMetodo.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeleccioneMetodo.Location = new Point(23, 600);
            lblSeleccioneMetodo.Name = "lblSeleccioneMetodo";
            lblSeleccioneMetodo.Size = new Size(335, 20);
            lblSeleccioneMetodo.TabIndex = 16;
            lblSeleccioneMetodo.Text = "Seleccione un método de pago para continuar";
            // 
            // pnlHoraEntrega
            // 
            pnlHoraEntrega.BackColor = Color.White;
            pnlHoraEntrega.ColorBottom = Color.Empty;
            pnlHoraEntrega.ColorTop = Color.Empty;
            pnlHoraEntrega.Controls.Add(rbFechaSeleccion);
            pnlHoraEntrega.Controls.Add(rnPronto);
            pnlHoraEntrega.Controls.Add(dtpSeleccionarFecha);
            pnlHoraEntrega.Controls.Add(label11);
            pnlHoraEntrega.Location = new Point(71, 272);
            pnlHoraEntrega.Margin = new Padding(3, 2, 3, 2);
            pnlHoraEntrega.Name = "pnlHoraEntrega";
            pnlHoraEntrega.Size = new Size(245, 142);
            pnlHoraEntrega.TabIndex = 14;
            // 
            // rbFechaSeleccion
            // 
            rbFechaSeleccion.AutoSize = true;
            rbFechaSeleccion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbFechaSeleccion.ForeColor = Color.FromArgb(120, 83, 101);
            rbFechaSeleccion.Location = new Point(9, 65);
            rbFechaSeleccion.Name = "rbFechaSeleccion";
            rbFechaSeleccion.Size = new Size(223, 24);
            rbFechaSeleccion.TabIndex = 14;
            rbFechaSeleccion.TabStop = true;
            rbFechaSeleccion.Text = "Seleccionar Fecha De Entrega";
            rbFechaSeleccion.UseVisualStyleBackColor = true;
            rbFechaSeleccion.CheckedChanged += rbFechaSeleccion_CheckedChanged;
            // 
            // rnPronto
            // 
            rnPronto.AutoSize = true;
            rnPronto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rnPronto.ForeColor = Color.FromArgb(120, 83, 101);
            rnPronto.Location = new Point(9, 35);
            rnPronto.Name = "rnPronto";
            rnPronto.Size = new Size(176, 24);
            rnPronto.TabIndex = 13;
            rnPronto.TabStop = true;
            rnPronto.Text = "Lo más pronto posible";
            rnPronto.UseVisualStyleBackColor = true;
            rnPronto.CheckedChanged += rnPronto_CheckedChanged;
            // 
            // dtpSeleccionarFecha
            // 
            dtpSeleccionarFecha.CalendarForeColor = Color.FromArgb(153, 61, 1);
            dtpSeleccionarFecha.DropDownAlign = LeftRightAlignment.Right;
            dtpSeleccionarFecha.Enabled = false;
            dtpSeleccionarFecha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSeleccionarFecha.Format = DateTimePickerFormat.Short;
            dtpSeleccionarFecha.Location = new Point(9, 103);
            dtpSeleccionarFecha.Margin = new Padding(3, 2, 3, 2);
            dtpSeleccionarFecha.MaxDate = new DateTime(2023, 9, 15, 0, 0, 0, 0);
            dtpSeleccionarFecha.MinDate = new DateTime(2023, 9, 8, 0, 0, 0, 0);
            dtpSeleccionarFecha.Name = "dtpSeleccionarFecha";
            dtpSeleccionarFecha.Size = new Size(219, 23);
            dtpSeleccionarFecha.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(120, 83, 101);
            label11.Location = new Point(57, 8);
            label11.Name = "label11";
            label11.Size = new Size(121, 20);
            label11.TabIndex = 9;
            label11.Text = "Hora de entrega";
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(12, 15);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(42, 32);
            button5.TabIndex = 19;
            button5.UseVisualStyleBackColor = false;
            // 
            // pnlDatosTarjeta
            // 
            pnlDatosTarjeta.BackColor = Color.White;
            pnlDatosTarjeta.ColorBottom = Color.Empty;
            pnlDatosTarjeta.ColorTop = Color.Empty;
            pnlDatosTarjeta.Controls.Add(lblErrorCodigo);
            pnlDatosTarjeta.Controls.Add(lblErrorFechaVencimiento);
            pnlDatosTarjeta.Controls.Add(lblErrorNombre);
            pnlDatosTarjeta.Controls.Add(lblErrorNumero);
            pnlDatosTarjeta.Controls.Add(lblFechita);
            pnlDatosTarjeta.Controls.Add(lblFechaVencimiento);
            pnlDatosTarjeta.Controls.Add(txtFechaVencimiento);
            pnlDatosTarjeta.Controls.Add(lblErrorTarjeta);
            pnlDatosTarjeta.Controls.Add(btnError);
            pnlDatosTarjeta.Controls.Add(label12);
            pnlDatosTarjeta.Controls.Add(label9);
            pnlDatosTarjeta.Controls.Add(txtCodigoSeguridad);
            pnlDatosTarjeta.Controls.Add(lblNombreTitular);
            pnlDatosTarjeta.Controls.Add(label5);
            pnlDatosTarjeta.Controls.Add(txtNombreTitular);
            pnlDatosTarjeta.Controls.Add(txtNumeroTarjeta);
            pnlDatosTarjeta.Controls.Add(btnVisa);
            pnlDatosTarjeta.Location = new Point(71, 555);
            pnlDatosTarjeta.Margin = new Padding(3, 2, 3, 2);
            pnlDatosTarjeta.Name = "pnlDatosTarjeta";
            pnlDatosTarjeta.Size = new Size(243, 365);
            pnlDatosTarjeta.TabIndex = 14;
            pnlDatosTarjeta.Visible = false;
            // 
            // lblErrorCodigo
            // 
            lblErrorCodigo.AutoSize = true;
            lblErrorCodigo.BackColor = Color.Transparent;
            lblErrorCodigo.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCodigo.ForeColor = Color.Red;
            lblErrorCodigo.Location = new Point(8, 338);
            lblErrorCodigo.Name = "lblErrorCodigo";
            lblErrorCodigo.Size = new Size(123, 13);
            lblErrorCodigo.TabIndex = 25;
            lblErrorCodigo.Text = "Ingrese un codigo valido";
            // 
            // lblErrorFechaVencimiento
            // 
            lblErrorFechaVencimiento.AutoSize = true;
            lblErrorFechaVencimiento.BackColor = Color.Transparent;
            lblErrorFechaVencimiento.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorFechaVencimiento.ForeColor = Color.Red;
            lblErrorFechaVencimiento.Location = new Point(16, 263);
            lblErrorFechaVencimiento.Name = "lblErrorFechaVencimiento";
            lblErrorFechaVencimiento.Size = new Size(124, 13);
            lblErrorFechaVencimiento.TabIndex = 24;
            lblErrorFechaVencimiento.Text = "Ingrese una fecha valida";
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.BackColor = Color.Transparent;
            lblErrorNombre.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(13, 191);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(126, 13);
            lblErrorNombre.TabIndex = 22;
            lblErrorNombre.Text = "Ingrese un nombre valido";
            // 
            // lblErrorNumero
            // 
            lblErrorNumero.AutoSize = true;
            lblErrorNumero.BackColor = Color.Transparent;
            lblErrorNumero.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNumero.ForeColor = Color.Red;
            lblErrorNumero.Location = new Point(14, 123);
            lblErrorNumero.Name = "lblErrorNumero";
            lblErrorNumero.Size = new Size(126, 13);
            lblErrorNumero.TabIndex = 21;
            lblErrorNumero.Text = "Ingrese un numero valido";
            // 
            // lblFechita
            // 
            lblFechita.AutoSize = true;
            lblFechita.BackColor = Color.Transparent;
            lblFechita.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechita.ForeColor = Color.Black;
            lblFechita.Location = new Point(114, 240);
            lblFechita.Name = "lblFechita";
            lblFechita.Size = new Size(80, 17);
            lblFechita.TabIndex = 20;
            lblFechita.Text = "(MM/AAAA)";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.BackColor = Color.Transparent;
            lblFechaVencimiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaVencimiento.ForeColor = Color.FromArgb(120, 83, 101);
            lblFechaVencimiento.Location = new Point(13, 212);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(219, 20);
            lblFechaVencimiento.TabIndex = 19;
            lblFechaVencimiento.Text = "Ingrese la fecha de vencimiento";
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaVencimiento.Location = new Point(16, 240);
            txtFechaVencimiento.Margin = new Padding(3, 2, 3, 2);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(92, 21);
            txtFechaVencimiento.TabIndex = 18;
            txtFechaVencimiento.KeyPress += txtFechaVencimiento_KeyPress;
            // 
            // lblErrorTarjeta
            // 
            lblErrorTarjeta.AutoSize = true;
            lblErrorTarjeta.BackColor = Color.Transparent;
            lblErrorTarjeta.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTarjeta.ForeColor = Color.Red;
            lblErrorTarjeta.Location = new Point(91, 42);
            lblErrorTarjeta.Name = "lblErrorTarjeta";
            lblErrorTarjeta.Size = new Size(110, 17);
            lblErrorTarjeta.TabIndex = 17;
            lblErrorTarjeta.Text = "Datos Invalidos!!";
            // 
            // btnError
            // 
            btnError.BackgroundImage = Images.Imagen_de_error;
            btnError.BackgroundImageLayout = ImageLayout.Zoom;
            btnError.FlatAppearance.BorderSize = 0;
            btnError.FlatStyle = FlatStyle.Flat;
            btnError.Location = new Point(28, 38);
            btnError.Margin = new Padding(3, 2, 3, 2);
            btnError.Name = "btnError";
            btnError.Padding = new Padding(9, 8, 9, 8);
            btnError.Size = new Size(65, 26);
            btnError.TabIndex = 16;
            btnError.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnError.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(120, 83, 101);
            label12.Location = new Point(21, 12);
            label12.Name = "label12";
            label12.Size = new Size(211, 20);
            label12.TabIndex = 12;
            label12.Text = "Ingrese los datos de su tarjeta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(120, 83, 101);
            label9.Location = new Point(11, 296);
            label9.Name = "label9";
            label9.Size = new Size(165, 20);
            label9.TabIndex = 13;
            label9.Text = "Ingrese el codigo (CVC)";
            // 
            // txtCodigoSeguridad
            // 
            txtCodigoSeguridad.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoSeguridad.Location = new Point(11, 315);
            txtCodigoSeguridad.Margin = new Padding(3, 2, 3, 2);
            txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            txtCodigoSeguridad.Size = new Size(92, 21);
            txtCodigoSeguridad.TabIndex = 12;
            txtCodigoSeguridad.KeyPress += txtCodigoSeguridad_KeyPress;
            // 
            // lblNombreTitular
            // 
            lblNombreTitular.AutoSize = true;
            lblNombreTitular.BackColor = Color.Transparent;
            lblNombreTitular.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreTitular.ForeColor = Color.FromArgb(120, 83, 101);
            lblNombreTitular.Location = new Point(14, 147);
            lblNombreTitular.Name = "lblNombreTitular";
            lblNombreTitular.Size = new Size(199, 20);
            lblNombreTitular.TabIndex = 13;
            lblNombreTitular.Text = "Ingrese el nombre y apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(120, 83, 101);
            label5.Location = new Point(14, 79);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 13;
            label5.Text = "Ingrese el numero";
            // 
            // txtNombreTitular
            // 
            txtNombreTitular.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreTitular.Location = new Point(15, 166);
            txtNombreTitular.Margin = new Padding(3, 2, 3, 2);
            txtNombreTitular.Name = "txtNombreTitular";
            txtNombreTitular.Size = new Size(170, 21);
            txtNombreTitular.TabIndex = 12;
            txtNombreTitular.KeyPress += txtNombreTitular_KeyPress;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroTarjeta.Location = new Point(14, 98);
            txtNumeroTarjeta.Margin = new Padding(3, 2, 3, 2);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(208, 21);
            txtNumeroTarjeta.TabIndex = 12;
            txtNumeroTarjeta.TextChanged += txtNumeroTarjeta_TextChanged;
            txtNumeroTarjeta.KeyPress += txtNumeroTarjeta_KeyPress;
            // 
            // btnVisa
            // 
            btnVisa.BackgroundImage = Images.visa2;
            btnVisa.BackgroundImageLayout = ImageLayout.Zoom;
            btnVisa.FlatAppearance.BorderSize = 0;
            btnVisa.FlatStyle = FlatStyle.Flat;
            btnVisa.Location = new Point(91, 42);
            btnVisa.Margin = new Padding(3, 2, 3, 2);
            btnVisa.Name = "btnVisa";
            btnVisa.Padding = new Padding(9, 8, 9, 8);
            btnVisa.Size = new Size(65, 26);
            btnVisa.TabIndex = 0;
            btnVisa.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVisa.UseVisualStyleBackColor = true;
            // 
            // lblCantidadProductos
            // 
            lblCantidadProductos.AutoSize = true;
            lblCantidadProductos.BackColor = Color.FromArgb(144, 100, 121);
            lblCantidadProductos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadProductos.ForeColor = Color.White;
            lblCantidadProductos.Location = new Point(331, 3);
            lblCantidadProductos.Name = "lblCantidadProductos";
            lblCantidadProductos.Size = new Size(17, 18);
            lblCantidadProductos.TabIndex = 18;
            lblCantidadProductos.Text = "0";
            // 
            // pnlMetodo
            // 
            pnlMetodo.BackColor = Color.White;
            pnlMetodo.ColorBottom = Color.Empty;
            pnlMetodo.ColorTop = Color.Empty;
            pnlMetodo.Controls.Add(rbDebito);
            pnlMetodo.Controls.Add(rbCredito);
            pnlMetodo.Controls.Add(rbEfectivo);
            pnlMetodo.Controls.Add(label6);
            pnlMetodo.Location = new Point(69, 418);
            pnlMetodo.Margin = new Padding(3, 2, 3, 2);
            pnlMetodo.Name = "pnlMetodo";
            pnlMetodo.Size = new Size(243, 133);
            pnlMetodo.TabIndex = 13;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbDebito.ForeColor = Color.FromArgb(120, 83, 101);
            rbDebito.Location = new Point(21, 90);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(140, 24);
            rbDebito.TabIndex = 14;
            rbDebito.TabStop = true;
            rbDebito.Text = "Tarjeta de debito";
            rbDebito.UseVisualStyleBackColor = true;
            rbDebito.CheckedChanged += rbDebito_CheckedChanged;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbCredito.ForeColor = Color.FromArgb(120, 83, 101);
            rbCredito.Location = new Point(21, 60);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(143, 24);
            rbCredito.TabIndex = 13;
            rbCredito.TabStop = true;
            rbCredito.Text = "Tarjeta de credito";
            rbCredito.UseVisualStyleBackColor = true;
            rbCredito.CheckedChanged += rbCredito_CheckedChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbEfectivo.ForeColor = Color.FromArgb(120, 83, 101);
            rbEfectivo.Location = new Point(23, 32);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(80, 24);
            rbEfectivo.TabIndex = 12;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(120, 83, 101);
            label6.Location = new Point(57, 8);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 9;
            label6.Text = "Metodo de pago";
            // 
            // btnCarrito
            // 
            btnCarrito.BackColor = Color.Transparent;
            btnCarrito.BackgroundImage = (Image)resources.GetObject("btnCarrito.BackgroundImage");
            btnCarrito.BackgroundImageLayout = ImageLayout.Stretch;
            btnCarrito.Location = new Point(292, 9);
            btnCarrito.Margin = new Padding(3, 2, 3, 2);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(47, 38);
            btnCarrito.TabIndex = 17;
            btnCarrito.UseVisualStyleBackColor = false;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(192, 133, 162);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(64, 1033);
            btnComprar.Margin = new Padding(3, 2, 3, 2);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(245, 48);
            btnComprar.TabIndex = 15;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // pnlDireccion
            // 
            pnlDireccion.BackColor = Color.White;
            pnlDireccion.ColorBottom = Color.Empty;
            pnlDireccion.ColorTop = Color.Empty;
            pnlDireccion.Controls.Add(lbl_completarNumCalle);
            pnlDireccion.Controls.Add(lbl_completarCalle);
            pnlDireccion.Controls.Add(lbl_completarCiudad);
            pnlDireccion.Controls.Add(cmbCiudades);
            pnlDireccion.Controls.Add(label4);
            pnlDireccion.Controls.Add(label3);
            pnlDireccion.Controls.Add(label2);
            pnlDireccion.Controls.Add(txtCalle);
            pnlDireccion.Controls.Add(txtNumero);
            pnlDireccion.ForeColor = Color.Coral;
            pnlDireccion.Location = new Point(71, 55);
            pnlDireccion.Margin = new Padding(3, 2, 3, 2);
            pnlDireccion.Name = "pnlDireccion";
            pnlDireccion.Size = new Size(245, 213);
            pnlDireccion.TabIndex = 12;
            // 
            // lbl_completarNumCalle
            // 
            lbl_completarNumCalle.AutoSize = true;
            lbl_completarNumCalle.BackColor = Color.Transparent;
            lbl_completarNumCalle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_completarNumCalle.ForeColor = Color.Red;
            lbl_completarNumCalle.Location = new Point(25, 190);
            lbl_completarNumCalle.Name = "lbl_completarNumCalle";
            lbl_completarNumCalle.Size = new Size(106, 13);
            lbl_completarNumCalle.TabIndex = 14;
            lbl_completarNumCalle.Text = "Ingrese el n° de calle";
            // 
            // lbl_completarCalle
            // 
            lbl_completarCalle.AutoSize = true;
            lbl_completarCalle.BackColor = Color.Transparent;
            lbl_completarCalle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_completarCalle.ForeColor = Color.Red;
            lbl_completarCalle.Location = new Point(28, 122);
            lbl_completarCalle.Name = "lbl_completarCalle";
            lbl_completarCalle.Size = new Size(120, 13);
            lbl_completarCalle.TabIndex = 13;
            lbl_completarCalle.Text = "Ingrese nombre de calle";
            // 
            // lbl_completarCiudad
            // 
            lbl_completarCiudad.AutoSize = true;
            lbl_completarCiudad.BackColor = Color.Transparent;
            lbl_completarCiudad.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_completarCiudad.ForeColor = Color.Red;
            lbl_completarCiudad.Location = new Point(32, 60);
            lbl_completarCiudad.Name = "lbl_completarCiudad";
            lbl_completarCiudad.Size = new Size(116, 13);
            lbl_completarCiudad.TabIndex = 12;
            lbl_completarCiudad.Text = "Seleccione una ciudad";
            // 
            // cmbCiudades
            // 
            cmbCiudades.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCiudades.FormattingEnabled = true;
            cmbCiudades.Location = new Point(30, 35);
            cmbCiudades.Margin = new Padding(3, 2, 3, 2);
            cmbCiudades.Name = "cmbCiudades";
            cmbCiudades.Size = new Size(178, 22);
            cmbCiudades.TabIndex = 8;
            cmbCiudades.SelectedIndexChanged += cmbCiudades_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(120, 83, 101);
            label4.Location = new Point(29, 145);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 11;
            label4.Text = "Ingrese el numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(120, 83, 101);
            label3.Location = new Point(30, 12);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 9;
            label3.Text = "Seleccione su ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(120, 83, 101);
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 10;
            label2.Text = "Ingrese su calle";
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalle.Location = new Point(28, 99);
            txtCalle.Margin = new Padding(3, 2, 3, 2);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(170, 21);
            txtCalle.TabIndex = 7;
            txtCalle.TextChanged += txtCalle_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Cyntho Next", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(28, 167);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(92, 21);
            txtNumero.TabIndex = 6;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(37, 36, 34);
            label1.Location = new Point(100, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 3;
            label1.Text = "Confirmar Pedido";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(236, 730);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(304, 256);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-98, 302);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 189);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 61);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 1100);
            Controls.Add(pnlGeneral);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlGeneral.ResumeLayout(false);
            pnlGeneral.PerformLayout();
            pnlDatosEfectivo.ResumeLayout(false);
            pnlDatosEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupEfectivo).EndInit();
            pnlHoraEntrega.ResumeLayout(false);
            pnlHoraEntrega.PerformLayout();
            pnlDatosTarjeta.ResumeLayout(false);
            pnlDatosTarjeta.PerformLayout();
            pnlMetodo.ResumeLayout(false);
            pnlMetodo.PerformLayout();
            pnlDireccion.ResumeLayout(false);
            pnlDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private GradientPanel pnlDireccion;
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
        private Label label11;
        private DateTimePicker dtpSeleccionarFecha;
        private Label label12;
        private Label lblSeleccioneMetodo;
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
        private RadioButton rbFechaSeleccion;
        private RadioButton rnPronto;
        private Button button5;
    }
}