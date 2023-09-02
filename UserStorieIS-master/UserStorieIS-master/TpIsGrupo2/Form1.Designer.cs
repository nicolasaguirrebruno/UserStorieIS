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
            lblSeleccioneMetodo = new Label();
            pnlHoraEntrega = new GradientPanel();
            chkSeleccionarHora = new CheckBox();
            dtpSeleccionarFecha = new DateTimePicker();
            chkAntesPosible = new CheckBox();
            label11 = new Label();
            lblCantidadProductos = new Label();
            pnlMetodo = new GradientPanel();
            chkTarjeta = new CheckBox();
            chkEfectivo = new CheckBox();
            label6 = new Label();
            btnCarrito = new Button();
            btnComprar = new Button();
            pnlDatosTarjeta = new GradientPanel();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtCodigoSeguridad = new TextBox();
            txtApellidoTitular = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtNombreTitular = new TextBox();
            btnMastercard = new Button();
            txtNumeroTarjeta = new TextBox();
            btnVisa = new Button();
            gradientPanel2 = new GradientPanel();
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
            button5 = new Button();
            pnlGeneral.SuspendLayout();
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
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(390, 1102);
            pnlGeneral.TabIndex = 0;
            // 
            // lblSeleccioneMetodo
            // 
            lblSeleccioneMetodo.AutoSize = true;
            lblSeleccioneMetodo.BackColor = Color.Transparent;
            lblSeleccioneMetodo.Font = new Font("Cyntho Next", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSeleccioneMetodo.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeleccioneMetodo.Location = new Point(80, 550);
            lblSeleccioneMetodo.Name = "lblSeleccioneMetodo";
            lblSeleccioneMetodo.Size = new Size(455, 24);
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
            pnlHoraEntrega.Location = new Point(43, 286);
            pnlHoraEntrega.Name = "pnlHoraEntrega";
            pnlHoraEntrega.Size = new Size(280, 163);
            pnlHoraEntrega.TabIndex = 14;
            // 
            // chkSeleccionarHora
            // 
            chkSeleccionarHora.AutoSize = true;
            chkSeleccionarHora.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkSeleccionarHora.ForeColor = Color.FromArgb(153, 61, 1);
            chkSeleccionarHora.Location = new Point(34, 78);
            chkSeleccionarHora.Name = "chkSeleccionarHora";
            chkSeleccionarHora.Size = new Size(165, 24);
            chkSeleccionarHora.TabIndex = 12;
            chkSeleccionarHora.Text = "Seleccionar hora";
            chkSeleccionarHora.UseVisualStyleBackColor = true;
            // 
            // dtpSeleccionarFecha
            // 
            dtpSeleccionarFecha.CalendarForeColor = Color.FromArgb(153, 61, 1);
            dtpSeleccionarFecha.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpSeleccionarFecha.Location = new Point(14, 110);
            dtpSeleccionarFecha.MinDate = new DateTime(2023, 8, 29, 0, 0, 0, 0);
            dtpSeleccionarFecha.Name = "dtpSeleccionarFecha";
            dtpSeleccionarFecha.Size = new Size(250, 26);
            dtpSeleccionarFecha.TabIndex = 11;
            // 
            // chkAntesPosible
            // 
            chkAntesPosible.AutoSize = true;
            chkAntesPosible.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkAntesPosible.ForeColor = Color.FromArgb(153, 61, 1);
            chkAntesPosible.Location = new Point(34, 43);
            chkAntesPosible.Name = "chkAntesPosible";
            chkAntesPosible.Size = new Size(163, 24);
            chkAntesPosible.TabIndex = 10;
            chkAntesPosible.Text = "Lo antes posible";
            chkAntesPosible.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(153, 61, 1);
            label11.Location = new Point(65, 11);
            label11.Name = "label11";
            label11.Size = new Size(141, 20);
            label11.TabIndex = 9;
            label11.Text = "Hora de entrega";
            // 
            // lblCantidadProductos
            // 
            lblCantidadProductos.AutoSize = true;
            lblCantidadProductos.BackColor = Color.FromArgb(204, 81, 1);
            lblCantidadProductos.Font = new Font("Cyntho Next Bold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadProductos.ForeColor = Color.White;
            lblCantidadProductos.Location = new Point(342, 0);
            lblCantidadProductos.Name = "lblCantidadProductos";
            lblCantidadProductos.Size = new Size(21, 22);
            lblCantidadProductos.TabIndex = 18;
            lblCantidadProductos.Text = "0";
            lblCantidadProductos.Visible = false;
            // 
            // pnlMetodo
            // 
            pnlMetodo.BackColor = Color.White;
            pnlMetodo.ColorBottom = Color.Empty;
            pnlMetodo.ColorTop = Color.Empty;
            pnlMetodo.Controls.Add(chkTarjeta);
            pnlMetodo.Controls.Add(chkEfectivo);
            pnlMetodo.Controls.Add(label6);
            pnlMetodo.Location = new Point(47, 466);
            pnlMetodo.Name = "pnlMetodo";
            pnlMetodo.Size = new Size(280, 108);
            pnlMetodo.TabIndex = 13;
            // 
            // chkTarjeta
            // 
            chkTarjeta.AutoSize = true;
            chkTarjeta.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkTarjeta.ForeColor = Color.FromArgb(153, 61, 1);
            chkTarjeta.Location = new Point(32, 74);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(174, 24);
            chkTarjeta.TabIndex = 11;
            chkTarjeta.Text = "Tarjeta de credito";
            chkTarjeta.UseVisualStyleBackColor = true;
            chkTarjeta.CheckedChanged += chkTarjeta_CheckedChanged;
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            chkEfectivo.ForeColor = Color.FromArgb(153, 61, 1);
            chkEfectivo.Location = new Point(32, 44);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(99, 24);
            chkEfectivo.TabIndex = 10;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(153, 61, 1);
            label6.Location = new Point(65, 11);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 9;
            label6.Text = "Metodo de pago";
            // 
            // btnCarrito
            // 
            btnCarrito.BackColor = Color.Transparent;
            btnCarrito.BackgroundImage = Images.shoppingcart2;
            btnCarrito.BackgroundImageLayout = ImageLayout.Stretch;
            btnCarrito.Location = new Point(300, 8);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(54, 51);
            btnCarrito.TabIndex = 17;
            btnCarrito.UseVisualStyleBackColor = false;
            btnCarrito.Visible = false;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(192, 82, 153);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Cyntho Next Bold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(47, 989);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(280, 64);
            btnComprar.TabIndex = 15;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            // 
            // pnlDatosTarjeta
            // 
            pnlDatosTarjeta.BackColor = Color.White;
            pnlDatosTarjeta.ColorBottom = Color.Empty;
            pnlDatosTarjeta.ColorTop = Color.Empty;
            pnlDatosTarjeta.Controls.Add(label12);
            pnlDatosTarjeta.Controls.Add(label9);
            pnlDatosTarjeta.Controls.Add(label8);
            pnlDatosTarjeta.Controls.Add(txtCodigoSeguridad);
            pnlDatosTarjeta.Controls.Add(txtApellidoTitular);
            pnlDatosTarjeta.Controls.Add(label7);
            pnlDatosTarjeta.Controls.Add(label5);
            pnlDatosTarjeta.Controls.Add(txtNombreTitular);
            pnlDatosTarjeta.Controls.Add(btnMastercard);
            pnlDatosTarjeta.Controls.Add(txtNumeroTarjeta);
            pnlDatosTarjeta.Controls.Add(btnVisa);
            pnlDatosTarjeta.Location = new Point(43, 614);
            pnlDatosTarjeta.Name = "pnlDatosTarjeta";
            pnlDatosTarjeta.Size = new Size(280, 354);
            pnlDatosTarjeta.TabIndex = 14;
            pnlDatosTarjeta.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(153, 61, 1);
            label12.Location = new Point(14, 14);
            label12.Name = "label12";
            label12.Size = new Size(252, 20);
            label12.TabIndex = 12;
            label12.Text = "Ingrese los datos de su tarjeta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(153, 61, 1);
            label9.Location = new Point(21, 294);
            label9.Name = "label9";
            label9.Size = new Size(197, 20);
            label9.TabIndex = 13;
            label9.Text = "Ingrese el codigo (CVC)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(153, 61, 1);
            label8.Location = new Point(25, 241);
            label8.Name = "label8";
            label8.Size = new Size(159, 20);
            label8.TabIndex = 15;
            label8.Text = "Ingrese su apellido";
            // 
            // txtCodigoSeguridad
            // 
            txtCodigoSeguridad.Location = new Point(25, 317);
            txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            txtCodigoSeguridad.Size = new Size(104, 27);
            txtCodigoSeguridad.TabIndex = 12;
            // 
            // txtApellidoTitular
            // 
            txtApellidoTitular.Location = new Point(21, 264);
            txtApellidoTitular.Name = "txtApellidoTitular";
            txtApellidoTitular.Size = new Size(194, 27);
            txtApellidoTitular.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(153, 61, 1);
            label7.Location = new Point(27, 173);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 13;
            label7.Text = "Ingrese su nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(153, 61, 1);
            label5.Location = new Point(32, 105);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 13;
            label5.Text = "Ingrese el numero";
            // 
            // txtNombreTitular
            // 
            txtNombreTitular.Location = new Point(27, 196);
            txtNombreTitular.Name = "txtNombreTitular";
            txtNombreTitular.Size = new Size(194, 27);
            txtNombreTitular.TabIndex = 12;
            // 
            // btnMastercard
            // 
            btnMastercard.BackgroundImage = Images.mastercard;
            btnMastercard.BackgroundImageLayout = ImageLayout.Zoom;
            btnMastercard.FlatAppearance.BorderSize = 0;
            btnMastercard.FlatStyle = FlatStyle.Flat;
            btnMastercard.Location = new Point(137, 51);
            btnMastercard.Name = "btnMastercard";
            btnMastercard.Padding = new Padding(10);
            btnMastercard.Size = new Size(91, 34);
            btnMastercard.TabIndex = 1;
            btnMastercard.UseVisualStyleBackColor = true;
            btnMastercard.Click += btnMastercard_Click;
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.Location = new Point(27, 128);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(237, 27);
            txtNumeroTarjeta.TabIndex = 12;
            // 
            // btnVisa
            // 
            btnVisa.BackgroundImage = Images.visa2;
            btnVisa.BackgroundImageLayout = ImageLayout.Zoom;
            btnVisa.FlatAppearance.BorderSize = 0;
            btnVisa.FlatStyle = FlatStyle.Flat;
            btnVisa.Location = new Point(34, 51);
            btnVisa.Name = "btnVisa";
            btnVisa.Padding = new Padding(10);
            btnVisa.Size = new Size(74, 34);
            btnVisa.TabIndex = 0;
            btnVisa.UseVisualStyleBackColor = true;
            btnVisa.Click += btnVisa_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BackColor = Color.White;
            gradientPanel2.ColorBottom = Color.Empty;
            gradientPanel2.ColorTop = Color.Empty;
            gradientPanel2.Controls.Add(cmbCiudades);
            gradientPanel2.Controls.Add(label4);
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(txtCalle);
            gradientPanel2.Controls.Add(txtNumero);
            gradientPanel2.ForeColor = Color.Coral;
            gradientPanel2.Location = new Point(43, 73);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(280, 207);
            gradientPanel2.TabIndex = 12;
            // 
            // cmbCiudades
            // 
            cmbCiudades.FormattingEnabled = true;
            cmbCiudades.Location = new Point(34, 38);
            cmbCiudades.Name = "cmbCiudades";
            cmbCiudades.Size = new Size(203, 28);
            cmbCiudades.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(153, 61, 1);
            label4.Location = new Point(34, 144);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 11;
            label4.Text = "Ingrese el numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(153, 61, 1);
            label3.Location = new Point(34, 15);
            label3.Name = "label3";
            label3.Size = new Size(177, 20);
            label3.TabIndex = 9;
            label3.Text = "Seleccione su ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cyntho Next", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(153, 61, 1);
            label2.Location = new Point(38, 81);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 10;
            label2.Text = "Ingrese su calle";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(34, 104);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(194, 27);
            txtCalle.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(34, 167);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(104, 27);
            txtNumero.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cyntho Next Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(37, 36, 34);
            label1.Location = new Point(80, 23);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 3;
            label1.Text = "Confirmar Pedido";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Images.circlesv2;
            pictureBox3.Location = new Point(253, 659);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(347, 342);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Images.circlesv2;
            pictureBox2.Location = new Point(-112, 402);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(212, 252);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Images.circlesv2;
            pictureBox1.Location = new Point(277, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Images.leftarrow1;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(26, 12);
            button5.Name = "button5";
            button5.Size = new Size(48, 43);
            button5.TabIndex = 19;
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 1102);
            Controls.Add(pnlGeneral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlGeneral.ResumeLayout(false);
            pnlGeneral.PerformLayout();
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
        private CheckBox chkTarjeta;
        private CheckBox chkEfectivo;
        private GradientPanel pnlDatosTarjeta;
        private Button btnVisa;
        private Button btnMastercard;
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
    }
}