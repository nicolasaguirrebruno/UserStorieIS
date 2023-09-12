using System.Globalization;
using System.Windows.Forms;
using TpIsGrupo2.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TpIsGrupo2
{
    public partial class ConfirmarPedido : Form
    {
        private List<string> ciudadesCordoba = new List<string>
        {
            "C�rdoba", "Carlos Paz"
        };

        private decimal montoEfectivoCarrito = 4500;

        Producto producto;

        Envio envio = new Envio();

        bool allTestPassed = false;

        bool entregaPronto = false;

        public ConfirmarPedido()
        {
            InitializeComponent();

            producto = new Producto("Hamburguesa Simple", 4500, 5000, true, 1);


            CargarComboCiudades();
            cmbCiudades.SelectedIndex = -1;
            lbl_completarCiudad.Visible = false;
            lbl_completarCalle.Visible = false;

            // bandera para validar que el monto sea distinto de cero
            lblMontoValido.Visible = false;

            btnError.Visible = false;
            lblSimbolo.Visible = false;
            lblErrorTarjeta.Visible = false;

            // Hago invisible los mensajes de error de la tarjeta

            lblErrorNumero.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorCodigo.Visible = false;
            lblErrorFechaVencimiento.Visible = false;



            // Llamo a setDefault para establecer las posiciones por defecto de los elementos
            SetDefaultConidtions();

            dtpSeleccionarFecha.Format = DateTimePickerFormat.Custom;
            dtpSeleccionarFecha.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpSeleccionarFecha.Visible = false;

            setCashConditions();
        }


        private void SetDefaultConidtions()
        {
            // Este metodo es cuando no se tiene seleccionado nada en el checkbox del metodo de pago

            pnlGeneral.VerticalScroll.Value = 0;
            // Aca le meto un enter al texto asi seleccione un metodo esta por arriba de "de pago para continuar"
            lblSeleccioneMetodo.Text = "Seleccione un m�todo\nde pago para continuar";

            // Aca le digo al lblSeleccioneMetodo que no se ajusta automaticamente el tama�o asi me queda como buscamos
            lblSeleccioneMetodo.AutoSize = false;

            // Le doy el tama�o fijo para que quede bien en la pantalla
            lblSeleccioneMetodo.Size = new Size(300, 80);

            // Reubicaciones, estan px primero x y despues el eje y
            lblSeleccioneMetodo.Location = new Point(100, 620);
            pnlHoraEntrega.Location = new Point(71, 300);
            pnlDireccion.Location = new Point(71, 65);

            pnlMetodo.Location = new Point(71, 470);
            btnComprar.Location = new Point(71, 710);
            btnComprar.Enabled = true;

            // Padding
            lblSeleccioneMetodo.Padding = new Padding(0, 10, 0, 0);
            btnComprar.Enabled = false;

            //this.Height = 844;
            //this.Width = 390;
            // Medidas basadas en el Iphone 12 Pro
            this.Height = 844;
            this.Width = 390;
            pnlDatosTarjeta.Visible = false;
            lblSeleccioneMetodo.Visible = true;
            pnlDatosEfectivo.Visible = false;
            // Deshabilitar el scroll horizontal y que quede nomas el vertical
            pnlGeneral.HorizontalScroll.Maximum = 0;
            pnlGeneral.AutoScroll = false;
            pnlGeneral.HorizontalScroll.Visible = false;
            pnlGeneral.AutoScroll = true; // Habilitar nuevamente el scroll vertical
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            allTestPassed = true;
            if (cmbCiudades.Text == "")
            {
                ControlPaint.DrawBorder(cmbCiudades.CreateGraphics(), cmbCiudades.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                lbl_completarCiudad.Visible = true;
                lbl_completarCiudad.Text = "Debe seleccionar una ciudad";
                allTestPassed = false;
            }
            string ciudadIngresada = cmbCiudades.Text;
            if (!ciudadesCordoba.Contains(ciudadIngresada) && (cmbCiudades.Text != ""))
            {
                lbl_completarCiudad.Visible = true;
                lbl_completarCiudad.Text = "Seleccione una ciudad de la lista";
                allTestPassed = false;
            }

            if (txtCalle.Text == "" )
            {
                
                ControlPaint.DrawBorder(txtCalle.CreateGraphics(), txtCalle.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                lbl_completarCalle.Visible = true;
                allTestPassed = false;
            }
            else
            {



               if (!VerificarDireccion(txtCalle.Text)) 
                {
                    lbl_completarCalle.Text = "Ingrese correctamente la \ndirecci�n";
                    lbl_completarCalle.Visible = true;
                    allTestPassed = false;
                }
            }

            if (pnlDatosTarjeta.Visible == true)
            {
                ValidarTarjetaYDatos();
            }
            else
            {
                ValidarEfectivo();
            }


            checkeo_rango_horario();

            if (allTestPassed == true)
            {
                envio.Ciudad = cmbCiudades.Text;
                envio.Calle = CapitalizarPalabras(txtCalle.Text.ToLower());

                if (entregaPronto)
                {
                    envio.horaentrega = dtpSeleccionarFecha.Value.ToString();
                }
                else
                {
                    envio.horaentrega = "lo m�s pronto posible ";
                }

                this.Hide();
                lblErrorFecha.Visible = false;
                ConfirmarCompra confirmarComprar = new ConfirmarCompra(envio, producto, this);
                confirmarComprar.ShowDialog();



            }


        }
        public static string CapitalizarPalabras(string texto)
        {
            // Dividir el texto en palabras utilizando espacios como separadores
            string[] palabras = texto.Split(' ');

            // Crear un TextInfo en espaniol para capitalizar correctamente las palabras
            TextInfo ti = new CultureInfo("es-ES", false).TextInfo;

            // Capitalizar la primera letra de cada palabra y unirlas nuevamente
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = ti.ToTitleCase(palabras[i]);
            }

            // Unir las palabras en un solo texto nuevamente
            string resultado = string.Join(" ", palabras);

            return resultado;
        }

        private void ValidarEfectivo()
        {
            // Obtener el valor actual del control NumericUpDown
            decimal valorEfectivo = nupEfectivo.Value;

            // Verificar si el valor es igual a 0
            if (valorEfectivo == 0)
            {
                // Si igual a 0, mostrar el mensaje de error en el lblMontoValido y salir
                lblMontoValido.Visible = true;
                allTestPassed = false;
                //return;
            }

            // Verificar si el valor es igual o mayor al montoEfectivoCarrito
            if (valorEfectivo >= montoEfectivoCarrito+500)
            {
                // Si es igual o mayor, ocultar el mensaje de error
                lblMontoValido.Visible = false;
            }
            else
            {
                // Si es menor, mostrar el mensaje de error en el lblMontoValido
                lblMontoValido.Visible = true;
                allTestPassed = false;
            }
        }


        public void ActualizarMontoEfectivoCarrito(decimal nuevoMonto)
        {
            montoEfectivoCarrito = nuevoMonto; // Esto est� permitido dentro de la misma clase
            setCashConditions();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito consultarCarrito = new Carrito(this, producto);
            consultarCarrito.Show();
            this.Hide();
        }

        private void ValidarTarjetaYDatos()
        {
            // Hago invisible los mensajes de error de la tarjeta

            lblErrorNumero.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorCodigo.Visible = false;
            lblErrorFechaVencimiento.Visible = false;



            // Obtener el n�mero de tarjeta ingresado en txtNumeroTarjeta
            string numeroTarjeta = txtNumeroTarjeta.Text.Replace(" ", "");

            // Verificar si el n�mero de tarjeta es de tipo Visa (comprobaci�n trivial)
            if (numeroTarjeta.StartsWith("4") && numeroTarjeta.Length == 16)
            {
                // El n�mero de tarjeta es v�lido, oculta el bot�n de error y muestra el de Visa
                btnVisa.Visible = true;
                btnError.Visible = false;
                lblErrorTarjeta.Visible = false;

            }
            else
            {
                // El n�mero de tarjeta no es de tipo Visa o no tiene la longitud correcta, muestra el bot�n de error y oculta el de Visa
                btnVisa.Visible = false;
                btnError.Visible = true;
                lblErrorTarjeta.Visible = true;
                lblErrorNumero.Visible = true;
                allTestPassed = false;
                //return; // Sale de la funci�n si el n�mero de tarjeta no es v�lido
            }



            // Obtener el nombre y apellido del titular
            string nombreTitular = txtNombreTitular.Text.Trim();

            // Verificar que los campos de nombre y apellido no est�n vac�os
            if (string.IsNullOrWhiteSpace(nombreTitular))
            {
                // El nombre o el apellido est�n vac�os, muestra el bot�n de error y oculta el de Visa
                btnVisa.Visible = false;
                btnError.Visible = true;
                lblErrorTarjeta.Visible = true;
                lblErrorNombre.Visible = true;
                allTestPassed = false;

                //return; // Sale de la funci�n si el nombre o el apellido est�n vac�os
            }

            // Obtener el CVC ingresado en txtCodigoSeguridad
            string cvc = txtCodigoSeguridad.Text.Trim();

            // Verificar que el campo CVC no est� vac�o y tenga 3 o 4 d�gitos
            if (string.IsNullOrEmpty(cvc) || (cvc.Length != 3 && cvc.Length != 4))
            {
                // El CVC no es v�lido, muestra el bot�n de error y oculta el de Visa
                btnVisa.Visible = false;
                btnError.Visible = true;
                lblErrorTarjeta.Visible = true;
                lblErrorCodigo.Visible = true;
                //return; // Sale de la funci�n si el CVC no es v�lido
                allTestPassed = false;
            }


            // Obtener la fecha de vencimiento ingresada en txtFechaVencimiento
            string fechaVencimiento = txtFechaVencimiento.Text.Trim();

            // Verificar si el campo fecha de vencimiento no est� vac�o y tenga el formato MM/AAAA
            if (string.IsNullOrWhiteSpace(fechaVencimiento) || !EsFormatoFechaValido(fechaVencimiento))
            {
                // La fecha de vencimiento no es v�lida, muestra el bot�n de error y oculta el de Visa
                btnVisa.Visible = false;
                btnError.Visible = true;
                lblErrorTarjeta.Visible = true;
                lblErrorFechaVencimiento.Visible = true;
                allTestPassed = false;
                return; // Sale de la funci�n si la fecha de vencimiento no es v�lida
            }

            // Obtener el mes y el a�o de la fecha de vencimiento
            string[] partesFecha = fechaVencimiento.Split('/');
            int mes, a�o;

            if (partesFecha.Length == 2 && int.TryParse(partesFecha[0], out mes) && int.TryParse(partesFecha[1], out a�o))
            {

                // Crear una fecha de vencimiento
                DateTime fechaVencimientoTarjeta = new DateTime(a�o, mes, 1);

                // Verificar si la fecha de vencimiento es menor o igual que la fecha actual
                if (fechaVencimientoTarjeta <= DateTime.Now)
                {
                    // La fecha de vencimiento es menor o igual que la fecha actual, muestra el bot�n de error y oculta el de Visa
                    btnVisa.Visible = false;
                    btnError.Visible = true;
                    lblErrorTarjeta.Visible = true;
                    lblErrorFechaVencimiento.Visible = true;
                    allTestPassed = false;
                    //return; // Sale de la funci�n si la fecha de vencimiento es menor o igual
                }
            }

            // Si todas las validaciones son exitosas, muestra el bot�n de Visa y oculta el de error
            btnVisa.Visible = true;
            btnError.Visible = false;
            lblErrorTarjeta.Visible = false;

        }

        // Funci�n para verificar el formato MM/AAAA
        bool EsFormatoFechaValido(string fecha)
        {
            if (fecha.Length != 7) // Cambiamos la longitud esperada a 7 caracteres
                return false;

            string[] partes = fecha.Split('/');
            if (partes.Length != 2)
                return false;

            if (!int.TryParse(partes[0], out int mes) || !int.TryParse(partes[1], out int a�o))
                return false;

            return mes >= 1 && mes <= 12 && a�o >= DateTime.Now.Year && a�o <= DateTime.Now.Year + 10; // Cambiamos la validaci�n del a�o
        }




        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            lbl_completarCalle.Visible = false;
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_completarCiudad.Visible = false;
        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            // Programar todo lo que sea marcar uno y desmarcar el otro
            if (!rbCredito.Checked)
            {
                SetDefaultConidtions();
            }
            else
            {
                setCardConditions();
            }
        }

        private void rbDebito_CheckedChanged(object sender, EventArgs e)
        {
            // Programar todo lo que sea marcar uno y desmarcar el otro
            if (!rbDebito.Checked)
            {
                SetDefaultConidtions();
            }
            else
            {
                setCardConditions();
            }
        }

        private void txtNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un n�mero o la tecla de retroceso (borrar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada de caracteres no num�ricos
            }

            // Verifica si el n�mero de tarjeta ya tiene 16 d�gitos
            if (txtNumeroTarjeta.Text.Replace(" ", "").Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada si ya se alcanz� la longitud m�xima
            }
        }

        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            // Formatea el n�mero de tarjeta en grupos de cuatro d�gitos
            string input = txtNumeroTarjeta.Text.Replace(" ", ""); // Elimina espacios en blanco
            if (input.Length > 0)
            {
                string formattedNumber = string.Join(" ", Enumerable.Range(0, (input.Length + 3) / 4).Select(i => input.Substring(i * 4, Math.Min(4, input.Length - i * 4))));
                txtNumeroTarjeta.Text = formattedNumber;
                txtNumeroTarjeta.SelectionStart = txtNumeroTarjeta.Text.Length; // Coloca el cursor al final
            }
        }

        private void txtCodigoSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un n�mero o la tecla de retroceso (borrar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada de caracteres no num�ricos
            }

            // Verifica si el CVC ya tiene 3 d�gitos
            if (txtCodigoSeguridad.Text.Length >= 3 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada si ya se alcanz� la longitud m�xima (3 d�gitos)
            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // Programar todo lo que sea marcar uno y desmarcar el otro
            if (!rbEfectivo.Checked)
            {
                SetDefaultConidtions();
            }
            else
            {
                setCashConditions();
            }
        }

        private void setCardConditions()
        {
            pnlGeneral.VerticalScroll.Value = 0;
            // Este metodo hace que se vea el panel del metodo tarjeta y reubicar la posicion de boton
            pnlDatosTarjeta.Visible = true;
            lblSeleccioneMetodo.Visible = false;
            pnlDatosEfectivo.Visible = false;
            lblSimbolo.Visible = false;

            // Setea los valores

            txtNumeroTarjeta.Text = "";
            txtCodigoSeguridad.Text = "";
            txtNombreTitular.Text = "";
            txtFechaVencimiento.Text = "";



            btnVisa.Visible = true;
            btnError.Visible = false;
            lblSimbolo.Visible = false;
            lblErrorTarjeta.Visible = false;


            // quitar visibilidad a errores

            lblErrorNumero.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorCodigo.Visible = false;
            lblErrorFechaVencimiento.Visible = false;

            if ((rbEfectivo.Checked || rbCredito.Checked || rbDebito.Checked) && (rnPronto.Checked || rbFechaSeleccion.Checked))
            {
                btnComprar.Enabled = true;

            }

            btnComprar.Location = new Point(71, 1000);
            pnlDatosTarjeta.Location = new Point(71, 600);
            pnlHoraEntrega.Location = new Point(71, 290);


            pnlMetodo.Location = new Point(71, 450);

        }



        private void setCashConditions()
        {
            nupEfectivo.Value = (decimal)producto.SubtotalProducto +500 ;
            pnlGeneral.VerticalScroll.Value = 0;
            // Este metodo hace que se vea el panel del metodo tarjeta y reubicar la posicion de boton
            pnlDatosTarjeta.Visible = false;
            lblSeleccioneMetodo.Visible = false;

            pnlDatosEfectivo.Visible = true;
            lblSimbolo.Visible = true;

            lblMontoValido.Visible = false;

            // quitar visible errores de tarjeta

            lblErrorNumero.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorCodigo.Visible = false;
            lblErrorFechaVencimiento.Visible = false;




            if ((rbEfectivo.Checked || rbCredito.Checked || rbDebito.Checked) && (rnPronto.Checked || rbFechaSeleccion.Checked))
            {
                btnComprar.Enabled = true;

            }
            btnComprar.Location = new Point(71, 780);

            pnlDatosEfectivo.Location = new Point(71, 630);
        }



        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarComboCiudades()
        {
            // Se asigna la lista como fuente de datos del Combo
            cmbCiudades.DataSource = ciudadesCordoba;
            cmbCiudades.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCiudades.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // Crea una fuente de datos para el autocompletado
            AutoCompleteStringCollection fuenteAutocompletado = new AutoCompleteStringCollection();
            fuenteAutocompletado.AddRange(ciudadesCordoba.ToArray());
            // Asigna la fuente de datos al ComboBox
            cmbCiudades.AutoCompleteCustomSource = fuenteAutocompletado;
        }


        private void txtFechaVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un n�mero o una tecla de control v�lida
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un n�mero ni una tecla de control v�lida, no se permite escribir el car�cter
                e.Handled = true;
            }

            // Verificar si el texto en el TextBox tiene ya 2 caracteres (MM)
            if (txtFechaVencimiento.Text.Length == 2 && e.KeyChar != (char)Keys.Back)
            {
                // Si ya se han ingresado los dos caracteres del mes, agregar autom�ticamente el car�cter "/"
                txtFechaVencimiento.Text += "/";
                txtFechaVencimiento.SelectionStart = txtFechaVencimiento.Text.Length;
            }

            // Verificar si el texto en el TextBox tiene m�s de 7 caracteres (MM/AAAA) y el car�cter actual no es retroceso
            if (txtFechaVencimiento.Text.Length >= 7 && e.KeyChar != (char)Keys.Back)
            {
                // Si ya se han ingresado los siete caracteres (MM/AAAA), no se permite escribir m�s
                e.Handled = true;
            }
        }

        private void txtNombreTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o una tecla de control v�lida
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Si no es una letra ni una tecla de control v�lida ni un espacio, no se permite escribir el car�cter
                e.Handled = true;
            }
        }

        private void rbFechaSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            if ((rbEfectivo.Checked || rbCredito.Checked || rbDebito.Checked) && (rnPronto.Checked || rbFechaSeleccion.Checked))
            {
                btnComprar.Enabled = true;

            }
            dtpSeleccionarFecha.Visible = true;
            dtpSeleccionarFecha.Format = DateTimePickerFormat.Custom;
            dtpSeleccionarFecha.CustomFormat = "yyyy-MM-dd HH:mm";

            dtpSeleccionarFecha.MinDate = DateTime.Now;
            dtpSeleccionarFecha.MaxDate = DateTime.Now.AddDays(6);

            dtpSeleccionarFecha.Enabled = true;

            entregaPronto = true;
            //seteo la fecha minima de seleccion en el datepicker

        }



        private void rnPronto_CheckedChanged(object sender, EventArgs e)
        {
            if ((rbEfectivo.Checked || rbCredito.Checked || rbDebito.Checked) && (rnPronto.Checked || rbFechaSeleccion.Checked))
            {
                btnComprar.Enabled = true;

            }
            dtpSeleccionarFecha.Visible = false;
            dtpSeleccionarFecha.Value = DateTime.Now;
            entregaPronto = false;
        }



        public void checkeo_rango_horario()
        {
            // Obtener la fecha y hora seleccionada en el DateTimePicker
            int HoraSeleccionada = dtpSeleccionarFecha.Value.Hour;


            // Establecer los l�mites del rango
            int limiteInferior = 7; // 7:00 AM
            int limiteSuperior = 24; // 11:59 PM

            // Verificar si la hora seleccionada est� dentro del rango

            /// �s un checkeo para borrar 
            if (HoraSeleccionada >= limiteInferior && HoraSeleccionada < limiteSuperior)
            {/*si vamos a poner el horario en alg�n lado, va ac� */
            }
            else
            {
                allTestPassed = false;
                lblErrorFecha.Visible = true;
                lblErrorFecha.Text = "Las entregas son de 7:00 - 23:59.";
            }
        }

        private void ConfirmarCompra_Activated(object sender, EventArgs e)
        {

            nupEfectivo.Value = (decimal)producto.TotalProducto;

            lblMontoValido.Visible = false; 
            if (producto.ExisteProducto)
            {
                lblCantidadProductos.Text = "1";
            }
            else
            {
                lblCantidadProductos.Text = "0";

            }
        }

        private void nupEfectivo_Leave(object sender, EventArgs e)
        {
            if ((float)nupEfectivo.Value > ((float)producto.SubtotalProducto+500) )
            {

                lblMontoValido.Visible = true;
                lblMontoValido.ForeColor = Color.Black;
                lblMontoValido.Text = "Su vuelto es " + ((float)nupEfectivo.Value - (producto.SubtotalProducto+500)).ToString();
            }
            else
            {
                lblMontoValido.ForeColor = Color.Red;
                lblMontoValido.Text = "Ingrese un monto valido";
            }
        }

        private void pnlGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto evita que el car�cter se escriba en el TextBox.
            }
        }


        // chatgepeteda

        public static bool VerificarDireccion(string direccion)
        {
            // Dividir la direcci�n en palabras
            string[] palabras = direccion.Split(' ');

            // Verificar si hay al menos dos palabras y si la �ltima es un n�mero
            return palabras.Length >= 2 && int.TryParse(palabras[palabras.Length - 1], out _);





        }


    }

}
