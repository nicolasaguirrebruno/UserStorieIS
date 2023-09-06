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
            pnlGeneral = new GradientPanel();
            pnlDatosEfectivo = new GradientPanel();
            lblSimbolo = new Label();
            lblMontoValido = new Label();
            nupEfectivo = new NumericUpDown();
            lblEfectivo = new Label();
            lblSeleccioneMetodo = new Label();
            pnlHoraEntrega = new GradientPanel();
            chkSeleccionarHora = new CheckBox();
            dtpSeleccionarFecha = new DateTimePicker();
            chkAntesPosible = new CheckBox();
            label11 = new Label();
            button5 = new Button();
            lblCantidadProductos = new Label();
            pnlMetodo = new GradientPanel();
            rbDebito = new RadioButton();
            rbCredito = new RadioButton();
            rbEfectivo = new RadioButton();
            label6 = new Label();
            btnCarrito = new Button();
            btnComprar = new Button();
            pnlDatosTarjeta = new GradientPanel();
            lblErrorTarjeta = new Label();
            btnError = new Button();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtCodigoSeguridad = new TextBox();
            txtApellidoTitular = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtNombreTitular = new TextBox();
            txtNumeroTarjeta = new TextBox();
            btnVisa = new Button();
            gradientPanel2 = new GradientPanel();
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
            pnlMetodo.SuspendLayout();
            pnlDatosTarjeta.SuspendLayout();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlGeneral
            // 
            pnlGeneral.ColorBottom = Color.FromArgb(224, 224, 224);
            pnlGeneral.ColorTop = Color.FromArgb(224, 224, 224);
            pnlGeneral.Controls.Add(pnlDatosEfectivo);
            pnlGeneral.Controls.Add(lblSeleccioneMetodo);
            pnlGeneral.Controls.Add(pnlHoraEntrega);
            pnlGeneral.Controls.Add(button5);
            pnlGeneral.Controls.Add(lblCantidadProductos);
            pnlGeneral.Controls.Add(pnlMetodo);
            pnlGeneral.Controls.Add(btnCarrito);
            pnlGeneral.Controls.Add(btnComprar);
            pnlGeneral.Controls.Add(pnlDatosTarjeta);
            pnlGeneral.Controls.Add(gradientPanel2);
            pnlGeneral.Controls.Add(label1);
            pnlGeneral.Controls.Add(pictureBox3);
            pnlGeneral.Controls.Add(pictureBox2);
            pnlGeneral.Controls.Add(pictureBox1);
            pnlGeneral.Dock = DockStyle.Fill;
            pnlGeneral.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pnlGeneral.Location = new Point(0, 0);
            pnlGeneral.Margin = new Padding(3, 2, 3, 2);
            pnlGeneral.MaximumSize = new Size(0, 844);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(390, 844);
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
            pnlDatosEfectivo.Location = new Point(71, 513);
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
            lblSimbolo.Location = new Point(10, 51);
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
            nupEfectivo.Location = new Point(28, 51);
            nupEfectivo.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            nupEfectivo.Name = "nupEfectivo";
            nupEfectivo.Size = new Size(120, 23);
            nupEfectivo.TabIndex = 14;
            // 
            // lblEfectivo
            // 
            lblEfectivo.AutoSize = true;
            lblEfectivo.BackColor = Color.Transparent;
            lblEfectivo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEfectivo.ForeColor = Color.FromArgb(153, 61, 1);
            lblEfectivo.Location = new Point(28, 18);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(186, 17);
            lblEfectivo.TabIndex = 13;
            lblEfectivo.Text = "Ingrese el monto en efectivo";
            // 
            // lblSeleccioneMetodo
            // 
            lblSeleccioneMetodo.AutoSize = true;
            lblSeleccioneMetodo.BackColor = Color.Transparent;
            lblSeleccioneMetodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccioneMetodo.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeleccioneMetodo.Location = new Point(23, 471);
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
            pnlHoraEntrega.Controls.Add(chkSeleccionarHora);
            pnlHoraEntrega.Controls.Add(dtpSeleccionarFecha);
            pnlHoraEntrega.Controls.Add(chkAntesPosible);
            pnlHoraEntrega.Controls.Add(label11);
            pnlHoraEntrega.Location = new Point(69, 234);
            pnlHoraEntrega.Margin = new Padding(3, 2, 3, 2);
            pnlHoraEntrega.Name = "pnlHoraEntrega";
            pnlHoraEntrega.Size = new Size(245, 122);
            pnlHoraEntrega.TabIndex = 14;
            // 
            // chkSeleccionarHora
            // 
            chkSeleccionarHora.AutoSize = true;
            chkSeleccionarHora.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkSeleccionarHora.ForeColor = Color.FromArgb(153, 61, 1);
            chkSeleccionarHora.Location = new Point(30, 58);
            chkSeleccionarHora.Margin = new Padding(3, 2, 3, 2);
            chkSeleccionarHora.Name = "chkSeleccionarHora";
            chkSeleccionarHora.Size = new Size(134, 21);
            chkSeleccionarHora.TabIndex = 12;
            chkSeleccionarHora.Text = "Seleccionar hora";
            chkSeleccionarHora.UseVisualStyleBackColor = true;
            // 
            // dtpSeleccionarFecha
            // 
            dtpSeleccionarFecha.CalendarForeColor = Color.FromArgb(153, 61, 1);
            dtpSeleccionarFecha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSeleccionarFecha.Location = new Point(12, 82);
            dtpSeleccionarFecha.Margin = new Padding(3, 2, 3, 2);
            dtpSeleccionarFecha.MinDate = new DateTime(2023, 8, 29, 0, 0, 0, 0);
            dtpSeleccionarFecha.Name = "dtpSeleccionarFecha";
            dtpSeleccionarFecha.Size = new Size(219, 23);
            dtpSeleccionarFecha.TabIndex = 11;
            // 
            // chkAntesPosible
            // 
            chkAntesPosible.AutoSize = true;
            chkAntesPosible.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkAntesPosible.ForeColor = Color.FromArgb(153, 61, 1);
            chkAntesPosible.Location = new Point(30, 32);
            chkAntesPosible.Margin = new Padding(3, 2, 3, 2);
            chkAntesPosible.Name = "chkAntesPosible";
            chkAntesPosible.Size = new Size(131, 21);
            chkAntesPosible.TabIndex = 10;
            chkAntesPosible.Text = "Lo antes posible";
            chkAntesPosible.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(153, 61, 1);
            label11.Location = new Point(57, 8);
            label11.Name = "label11";
            label11.Size = new Size(112, 17);
            label11.TabIndex = 9;
            label11.Text = "Hora de entrega";
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Images.leftarrow1;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(23, 9);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(42, 32);
            button5.TabIndex = 19;
            button5.UseVisualStyleBackColor = false;
            // 
            // lblCantidadProductos
            // 
            lblCantidadProductos.AutoSize = true;
            lblCantidadProductos.BackColor = Color.FromArgb(204, 81, 1);
            lblCantidadProductos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadProductos.ForeColor = Color.White;
            lblCantidadProductos.Location = new Point(318, 0);
            lblCantidadProductos.Name = "lblCantidadProductos";
            lblCantidadProductos.Size = new Size(17, 18);
            lblCantidadProductos.TabIndex = 18;
            lblCantidadProductos.Text = "0";
            lblCantidadProductos.Visible = false;
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
            pnlMetodo.Location = new Point(71, 372);
            pnlMetodo.Margin = new Padding(3, 2, 3, 2);
            pnlMetodo.Name = "pnlMetodo";
            pnlMetodo.Size = new Size(243, 93);
            pnlMetodo.TabIndex = 13;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbDebito.ForeColor = Color.FromArgb(153, 61, 1);
            rbDebito.Location = new Point(22, 64);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(134, 21);
            rbDebito.TabIndex = 14;
            rbDebito.TabStop = true;
            rbDebito.Text = "Tarjeta de debito";
            rbDebito.UseVisualStyleBackColor = true;
            rbDebito.CheckedChanged += rbDebito_CheckedChanged;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbCredito.ForeColor = Color.FromArgb(153, 61, 1);
            rbCredito.Location = new Point(22, 46);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(138, 21);
            rbCredito.TabIndex = 13;
            rbCredito.TabStop = true;
            rbCredito.Text = "Tarjeta de credito";
            rbCredito.UseVisualStyleBackColor = true;
            rbCredito.CheckedChanged += rbCredito_CheckedChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbEfectivo.ForeColor = Color.FromArgb(153, 61, 1);
            rbEfectivo.Location = new Point(23, 28);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(76, 21);
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
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(153, 61, 1);
            label6.Location = new Point(57, 8);
            label6.Name = "label6";
            label6.Size = new Size(111, 17);
            label6.TabIndex = 9;
            label6.Text = "Metodo de pago";
            // 
            // btnCarrito
            // 
            btnCarrito.BackColor = Color.Transparent;
            btnCarrito.BackgroundImage = Images.shoppingcart2;
            btnCarrito.BackgroundImageLayout = ImageLayout.Stretch;
            btnCarrito.Location = new Point(279, 6);
            btnCarrito.Margin = new Padding(3, 2, 3, 2);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(47, 38);
            btnCarrito.TabIndex = 17;
            btnCarrito.UseVisualStyleBackColor = false;
            btnCarrito.Visible = false;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(192, 82, 153);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(69, 820);
            btnComprar.Margin = new Padding(3, 2, 3, 2);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(245, 48);
            btnComprar.TabIndex = 15;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // pnlDatosTarjeta
            // 
            pnlDatosTarjeta.BackColor = Color.White;
            pnlDatosTarjeta.ColorBottom = Color.Empty;
            pnlDatosTarjeta.ColorTop = Color.Empty;
            pnlDatosTarjeta.Controls.Add(lblErrorTarjeta);
            pnlDatosTarjeta.Controls.Add(btnError);
            pnlDatosTarjeta.Controls.Add(label12);
            pnlDatosTarjeta.Controls.Add(label9);
            pnlDatosTarjeta.Controls.Add(label8);
            pnlDatosTarjeta.Controls.Add(txtCodigoSeguridad);
            pnlDatosTarjeta.Controls.Add(txtApellidoTitular);
            pnlDatosTarjeta.Controls.Add(label7);
            pnlDatosTarjeta.Controls.Add(label5);
            pnlDatosTarjeta.Controls.Add(txtNombreTitular);
            pnlDatosTarjeta.Controls.Add(txtNumeroTarjeta);
            pnlDatosTarjeta.Controls.Add(btnVisa);
            pnlDatosTarjeta.Location = new Point(71, 513);
            pnlDatosTarjeta.Margin = new Padding(3, 2, 3, 2);
            pnlDatosTarjeta.Name = "pnlDatosTarjeta";
            pnlDatosTarjeta.Size = new Size(243, 292);
            pnlDatosTarjeta.TabIndex = 14;
            pnlDatosTarjeta.Visible = false;
            // 
            // lblErrorTarjeta
            // 
            lblErrorTarjeta.AutoSize = true;
            lblErrorTarjeta.BackColor = Color.Transparent;
            lblErrorTarjeta.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorTarjeta.ForeColor = Color.Red;
            lblErrorTarjeta.Location = new Point(91, 55);
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
            btnError.Location = new Point(28, 51);
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
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(153, 61, 1);
            label12.Location = new Point(22, 19);
            label12.Name = "label12";
            label12.Size = new Size(199, 17);
            label12.TabIndex = 12;
            label12.Text = "Ingrese los datos de su tarjeta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(153, 61, 1);
            label9.Location = new Point(28, 231);
            label9.Name = "label9";
            label9.Size = new Size(157, 17);
            label9.TabIndex = 13;
            label9.Text = "Ingrese el codigo (CVC)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(153, 61, 1);
            label8.Location = new Point(28, 181);
            label8.Name = "label8";
            label8.Size = new Size(127, 17);
            label8.TabIndex = 15;
            label8.Text = "Ingrese su apellido";
            // 
            // txtCodigoSeguridad
            // 
            txtCodigoSeguridad.Location = new Point(28, 250);
            txtCodigoSeguridad.Margin = new Padding(3, 2, 3, 2);
            txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            txtCodigoSeguridad.Size = new Size(92, 23);
            txtCodigoSeguridad.TabIndex = 12;
            txtCodigoSeguridad.KeyPress += txtCodigoSeguridad_KeyPress;
            // 
            // txtApellidoTitular
            // 
            txtApellidoTitular.Location = new Point(28, 200);
            txtApellidoTitular.Margin = new Padding(3, 2, 3, 2);
            txtApellidoTitular.Name = "txtApellidoTitular";
            txtApellidoTitular.Size = new Size(170, 23);
            txtApellidoTitular.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(153, 61, 1);
            label7.Location = new Point(24, 130);
            label7.Name = "label7";
            label7.Size = new Size(126, 17);
            label7.TabIndex = 13;
            label7.Text = "Ingrese su nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(153, 61, 1);
            label5.Location = new Point(28, 79);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 13;
            label5.Text = "Ingrese el numero";
            // 
            // txtNombreTitular
            // 
            txtNombreTitular.Location = new Point(28, 149);
            txtNombreTitular.Margin = new Padding(3, 2, 3, 2);
            txtNombreTitular.Name = "txtNombreTitular";
            txtNombreTitular.Size = new Size(170, 23);
            txtNombreTitular.TabIndex = 12;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(28, 98);
            txtNumeroTarjeta.Margin = new Padding(3, 2, 3, 2);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(208, 23);
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
            btnVisa.Location = new Point(91, 51);
            btnVisa.Margin = new Padding(3, 2, 3, 2);
            btnVisa.Name = "btnVisa";
            btnVisa.Padding = new Padding(9, 8, 9, 8);
            btnVisa.Size = new Size(65, 26);
            btnVisa.TabIndex = 0;
            btnVisa.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVisa.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BackColor = Color.White;
            gradientPanel2.ColorBottom = Color.Empty;
            gradientPanel2.ColorTop = Color.Empty;
            gradientPanel2.Controls.Add(lbl_completarNumCalle);
            gradientPanel2.Controls.Add(lbl_completarCalle);
            gradientPanel2.Controls.Add(lbl_completarCiudad);
            gradientPanel2.Controls.Add(cmbCiudades);
            gradientPanel2.Controls.Add(label4);
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(txtCalle);
            gradientPanel2.Controls.Add(txtNumero);
            gradientPanel2.ForeColor = Color.Coral;
            gradientPanel2.Location = new Point(71, 55);
            gradientPanel2.Margin = new Padding(3, 2, 3, 2);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(245, 165);
            gradientPanel2.TabIndex = 12;
            // 
            // lbl_completarNumCalle
            // 
            lbl_completarNumCalle.AutoSize = true;
            lbl_completarNumCalle.BackColor = Color.Transparent;
            lbl_completarNumCalle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_completarNumCalle.ForeColor = Color.Red;
            lbl_completarNumCalle.Location = new Point(31, 148);
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
            lbl_completarCalle.Location = new Point(29, 101);
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
            lbl_completarCiudad.Location = new Point(28, 52);
            lbl_completarCiudad.Name = "lbl_completarCiudad";
            lbl_completarCiudad.Size = new Size(116, 13);
            lbl_completarCiudad.TabIndex = 12;
            lbl_completarCiudad.Text = "Seleccione una ciudad";
            // 
            // cmbCiudades
            // 
            cmbCiudades.FormattingEnabled = true;
            cmbCiudades.Location = new Point(30, 28);
            cmbCiudades.Margin = new Padding(3, 2, 3, 2);
            cmbCiudades.Name = "cmbCiudades";
            cmbCiudades.Size = new Size(178, 24);
            cmbCiudades.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(153, 61, 1);
            label4.Location = new Point(30, 108);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 11;
            label4.Text = "Ingrese el numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(153, 61, 1);
            label3.Location = new Point(30, 11);
            label3.Name = "label3";
            label3.Size = new Size(142, 17);
            label3.TabIndex = 9;
            label3.Text = "Seleccione su ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(153, 61, 1);
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 10;
            label2.Text = "Ingrese su calle";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(30, 78);
            txtCalle.Margin = new Padding(3, 2, 3, 2);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(170, 23);
            txtCalle.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(30, 125);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(92, 23);
            txtNumero.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(37, 36, 34);
            label1.Location = new Point(111, 13);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 3;
            label1.Text = "Confirmar Pedido";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Images.circlesv2;
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
            pictureBox2.Image = Images.circlesv2;
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
            pictureBox1.Image = Images.circlesv2;
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
            ClientSize = new Size(390, 844);
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
            pnlMetodo.ResumeLayout(false);
            pnlMetodo.PerformLayout();
            pnlDatosTarjeta.ResumeLayout(false);
            pnlDatosTarjeta.PerformLayout();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
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
        private GradientPanel gradientPanel2;
        private GradientPanel pnlMetodo;
        private Label label6;
        private GradientPanel pnlDatosTarjeta;
        private Label label5;
        private TextBox txtNumeroTarjeta;
        private Label label9;
        private Label label8;
        private TextBox txtCodigoSeguridad;
        private TextBox txtApellidoTitular;
        private Label label7;
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
        private Button btnVisa;
        private Button btnError;
        private GradientPanel pnlDatosEfectivo;
        private NumericUpDown nupEfectivo;
        private Label lblEfectivo;
        private Label lblMontoValido;
        private Label lblSimbolo;
        private Label lblErrorTarjeta;
    }
}