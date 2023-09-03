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
            this.lblSeleccioneMetodo = new System.Windows.Forms.Label();
            this.pnlHoraEntrega = new TpIsGrupo2.GradientPanel();
            this.chkSeleccionarHora = new System.Windows.Forms.CheckBox();
            this.dtpSeleccionarFecha = new System.Windows.Forms.DateTimePicker();
            this.chkAntesPosible = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.pnlMetodo = new TpIsGrupo2.GradientPanel();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.pnlDatosTarjeta = new TpIsGrupo2.GradientPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.txtApellidoTitular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.btnMastercard = new System.Windows.Forms.Button();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.gradientPanel2 = new TpIsGrupo2.GradientPanel();
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
            this.pnlHoraEntrega.SuspendLayout();
            this.pnlMetodo.SuspendLayout();
            this.pnlDatosTarjeta.SuspendLayout();
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
            this.pnlGeneral.Controls.Add(this.lblSeleccioneMetodo);
            this.pnlGeneral.Controls.Add(this.pnlHoraEntrega);
            this.pnlGeneral.Controls.Add(this.button5);
            this.pnlGeneral.Controls.Add(this.lblCantidadProductos);
            this.pnlGeneral.Controls.Add(this.pnlMetodo);
            this.pnlGeneral.Controls.Add(this.btnCarrito);
            this.pnlGeneral.Controls.Add(this.btnComprar);
            this.pnlGeneral.Controls.Add(this.pnlDatosTarjeta);
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
            this.pnlGeneral.Size = new System.Drawing.Size(390, 844);
            this.pnlGeneral.TabIndex = 0;
            // 
            // lblSeleccioneMetodo
            // 
            this.lblSeleccioneMetodo.AutoSize = true;
            this.lblSeleccioneMetodo.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccioneMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccioneMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSeleccioneMetodo.Location = new System.Drawing.Point(70, 412);
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
            this.lblCantidadProductos.Visible = false;
            // 
            // pnlMetodo
            // 
            this.pnlMetodo.BackColor = System.Drawing.Color.White;
            this.pnlMetodo.ColorBottom = System.Drawing.Color.Empty;
            this.pnlMetodo.ColorTop = System.Drawing.Color.Empty;
            this.pnlMetodo.Controls.Add(this.chkTarjeta);
            this.pnlMetodo.Controls.Add(this.chkEfectivo);
            this.pnlMetodo.Controls.Add(this.label6);
            this.pnlMetodo.Location = new System.Drawing.Point(71, 372);
            this.pnlMetodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMetodo.Name = "pnlMetodo";
            this.pnlMetodo.Size = new System.Drawing.Size(245, 81);
            this.pnlMetodo.TabIndex = 13;
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.chkTarjeta.Location = new System.Drawing.Point(28, 56);
            this.chkTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(139, 21);
            this.chkTarjeta.TabIndex = 11;
            this.chkTarjeta.Text = "Tarjeta de credito";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            this.chkTarjeta.CheckedChanged += new System.EventHandler(this.chkTarjeta_CheckedChanged);
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.chkEfectivo.Location = new System.Drawing.Point(28, 33);
            this.chkEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(77, 21);
            this.chkEfectivo.TabIndex = 10;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
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
            this.btnCarrito.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(82)))), ((int)(((byte)(153)))));
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(69, 778);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(245, 48);
            this.btnComprar.TabIndex = 15;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // pnlDatosTarjeta
            // 
            this.pnlDatosTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlDatosTarjeta.ColorBottom = System.Drawing.Color.Empty;
            this.pnlDatosTarjeta.ColorTop = System.Drawing.Color.Empty;
            this.pnlDatosTarjeta.Controls.Add(this.label12);
            this.pnlDatosTarjeta.Controls.Add(this.label9);
            this.pnlDatosTarjeta.Controls.Add(this.label8);
            this.pnlDatosTarjeta.Controls.Add(this.txtCodigoSeguridad);
            this.pnlDatosTarjeta.Controls.Add(this.txtApellidoTitular);
            this.pnlDatosTarjeta.Controls.Add(this.label7);
            this.pnlDatosTarjeta.Controls.Add(this.label5);
            this.pnlDatosTarjeta.Controls.Add(this.txtNombreTitular);
            this.pnlDatosTarjeta.Controls.Add(this.btnMastercard);
            this.pnlDatosTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.pnlDatosTarjeta.Controls.Add(this.btnVisa);
            this.pnlDatosTarjeta.Location = new System.Drawing.Point(71, 468);
            this.pnlDatosTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosTarjeta.Name = "pnlDatosTarjeta";
            this.pnlDatosTarjeta.Size = new System.Drawing.Size(245, 284);
            this.pnlDatosTarjeta.TabIndex = 14;
            this.pnlDatosTarjeta.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label12.Location = new System.Drawing.Point(12, 10);
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
            this.label9.Location = new System.Drawing.Point(18, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ingrese el codigo (CVC)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label8.Location = new System.Drawing.Point(22, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ingrese su apellido";
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(22, 238);
            this.txtCodigoSeguridad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(92, 23);
            this.txtCodigoSeguridad.TabIndex = 12;
            // 
            // txtApellidoTitular
            // 
            this.txtApellidoTitular.Location = new System.Drawing.Point(18, 198);
            this.txtApellidoTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoTitular.Name = "txtApellidoTitular";
            this.txtApellidoTitular.Size = new System.Drawing.Size(170, 23);
            this.txtApellidoTitular.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(61)))), ((int)(((byte)(1)))));
            this.label7.Location = new System.Drawing.Point(24, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese su nombre";
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
            this.txtNombreTitular.Location = new System.Drawing.Point(24, 147);
            this.txtNombreTitular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(170, 23);
            this.txtNombreTitular.TabIndex = 12;
            // 
            // btnMastercard
            // 
            this.btnMastercard.BackgroundImage = global::TpIsGrupo2.Images.mastercard;
            this.btnMastercard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMastercard.FlatAppearance.BorderSize = 0;
            this.btnMastercard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMastercard.Location = new System.Drawing.Point(120, 38);
            this.btnMastercard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMastercard.Name = "btnMastercard";
            this.btnMastercard.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnMastercard.Size = new System.Drawing.Size(80, 26);
            this.btnMastercard.TabIndex = 1;
            this.btnMastercard.UseVisualStyleBackColor = true;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(24, 96);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(208, 23);
            this.txtNumeroTarjeta.TabIndex = 12;
            // 
            // btnVisa
            // 
            this.btnVisa.BackgroundImage = global::TpIsGrupo2.Images.visa2;
            this.btnVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisa.FlatAppearance.BorderSize = 0;
            this.btnVisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisa.Location = new System.Drawing.Point(30, 38);
            this.btnVisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnVisa.Size = new System.Drawing.Size(65, 26);
            this.btnVisa.TabIndex = 0;
            this.btnVisa.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel2.ColorTop = System.Drawing.Color.Empty;
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
            this.gradientPanel2.Size = new System.Drawing.Size(245, 155);
            this.gradientPanel2.TabIndex = 12;
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(30, 28);
            this.cmbCiudades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(178, 24);
            this.cmbCiudades.TabIndex = 8;
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
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(30, 125);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 23);
            this.txtNumero.TabIndex = 6;
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
            this.ClientSize = new System.Drawing.Size(390, 848);
            this.Controls.Add(this.pnlGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.pnlHoraEntrega.ResumeLayout(false);
            this.pnlHoraEntrega.PerformLayout();
            this.pnlMetodo.ResumeLayout(false);
            this.pnlMetodo.PerformLayout();
            this.pnlDatosTarjeta.ResumeLayout(false);
            this.pnlDatosTarjeta.PerformLayout();
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