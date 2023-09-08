using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TpIsGrupo2
{
    public partial class Form1 : Form
    {
        private List<string> ciudadesCordoba = new List<string>
        {
            "Córdoba", "Carlos Paz", "Villa Allende", "Villa María", "Río Cuarto", "Río Primero",
                "Río Tercero", "Alta Gracia", "Pilar",
        };
        public Form1()
        {
            InitializeComponent();


            // Le digo al form donde quiero que arranque en la pantalla de mi coputadora
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(500, 10);

            CargarComboCiudades();
            lbl_completarCiudad.Visible = false;
            lbl_completarCalle.Visible = false;
            lbl_completarNumCalle.Visible = false;

            // bandera para validar que el monto sea distinto de cero
            lblMontoValido.Visible = false;

            btnError.Visible = false;
            lblSimbolo.Visible = false;
            lblErrorTarjeta.Visible = false;

            // Llamo a setDefault para establecer las posiciones por defecto de los elementos
            SetDefaultConidtions();

            dtpSeleccionarFecha.Format = DateTimePickerFormat.Custom;
            dtpSeleccionarFecha.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpSeleccionarFecha.Visible = false;
        }


        private void setBorderToCard(System.Windows.Forms.Button button)
        {
            // Le pongo un color al borde, si se les ocurre una mejor forma de resaltar el tipo de tarjeta modifiquen esto
            button.FlatAppearance.BorderColor = Color.FromArgb(255, 178, 128);
            button.FlatAppearance.BorderSize = 2;
        }



        private void setCardConditions()
        {
            // Este metodo hace que se vea el panel del metodo tarjeta y reubicar la posicion de boton
            pnlDatosTarjeta.Visible = true;
            lblSeleccioneMetodo.Visible = false;
            pnlDatosEfectivo.Visible = false;
            lblSimbolo.Visible = false;

            // Setea los valores

            txtApellidoTitular.Text = "";
            txtNumeroTarjeta.Text = "";
            txtCodigoSeguridad.Text = "";
            txtNombreTitular.Text = "";

            btnVisa.Visible = true;
            btnError.Visible = false;
            lblSimbolo.Visible = false;
            lblErrorTarjeta.Visible = false;


            btnComprar.Enabled = true;
            btnComprar.Location = new Point(btnComprar.Location.X, 785);
            pnlDatosTarjeta.Location = new Point(btnComprar.Location.X, 480);

        }

        private void SetDefaultConidtions()
        {
            // Este metodo es cuando no se tiene seleccionado nada en el checkbox del metodo de pago

            pnlGeneral.VerticalScroll.Value = 0;
            // Aca le meto un enter al texto asi seleccione un metodo esta por arriba de "de pago para continuar"
            lblSeleccioneMetodo.Text = "Seleccione un método\nde pago para continuar";

            // Aca le digo al lblSeleccioneMetodo que no se ajusta automaticamente el tamaño asi me queda como buscamos
            lblSeleccioneMetodo.AutoSize = false;

            // Le doy el tamaño fijo para que quede bien en la pantalla
            lblSeleccioneMetodo.Size = new Size(300, 80);

            // Reubicaciones, estan px primero x y despues el eje y
            lblSeleccioneMetodo.Location = new Point(pnlHoraEntrega.Location.X + 20, 470);


            btnComprar.Location = new Point(btnComprar.Location.X, 550);
            btnComprar.Enabled = true;

            // Padding
            lblSeleccioneMetodo.Padding = new Padding(0, 10, 0, 0);


            //this.Height = 844;
            //this.Width = 390;
            // Medidas basadas en el Iphone 12 Pro
            this.Height = 844;
            this.Width = 390;
            pnlDatosTarjeta.Visible = false;
            lblSeleccioneMetodo.Visible = true;
            pnlDatosEfectivo.Visible = false;
            //// Deshabilitar el scroll horizontal y que quede nomas el vertical
            //pnlGeneral.HorizontalScroll.Maximum = 0;
            //pnlGeneral.AutoScroll = false;
            //pnlGeneral.HorizontalScroll.Visible = false;
            //pnlGeneral.AutoScroll = true; // Habilitar nuevamente el scroll vertical
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cmbCiudades.Text == "")
            {
                ControlPaint.DrawBorder(cmbCiudades.CreateGraphics(), cmbCiudades.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                lbl_completarCiudad.Visible = true;
            }
            string ciudadIngresada = cmbCiudades.Text;
            if (!ciudadesCordoba.Contains(ciudadIngresada) && (cmbCiudades.Text != ""))
            {
                MessageBox.Show("Por favor, seleccione una ciudad válida de la lista.");
            }

            if (txtCalle.Text == "")
            {
                ControlPaint.DrawBorder(txtCalle.CreateGraphics(), txtCalle.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                lbl_completarCalle.Visible = true;
            }
            if (txtNumero.Text == "")
            {
                ControlPaint.DrawBorder(txtNumero.CreateGraphics(), txtNumero.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
                lbl_completarNumCalle.Visible = true;
            }
            if (cmbCiudades.Text == "" || txtCalle.Text == "" || txtNumero.Text == "")
            {
                MessageBox.Show("Debe completar campos obligatorios");
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

        }

        private void ValidarEfectivo()
        {
            // Obtener el valor actual del control NumericUpDown
            decimal valorEfectivo = nupEfectivo.Value;


            // Verificar si el valor es igual a cero
            if (valorEfectivo == 0)
            {
                // Si es cero, mostrar el mensaje de error en el lblMontoValido
                lblMontoValido.Visible = true;
            }
            else
            {
                // Si no es cero, ocultar el mensaje de error
                lblMontoValido.Visible = false;
            }
        }

        private void ValidarTarjetaYDatos()
        {
            // Obtener el número de tarjeta ingresado en txtNumeroTarjeta
            string numeroTarjeta = txtNumeroTarjeta.Text.Replace(" ", "");

            // Verificar si el número de tarjeta es de tipo Visa (comprobación trivial)
            if (numeroTarjeta.StartsWith("4") && numeroTarjeta.Length == 16)
            {
                // El número de tarjeta es válido, oculta el botón de error y muestra el de Visa
                btnVisa.Visible = true;
                btnError.Visible = false;
                lblErrorTarjeta.Visible = false;

            }
            else
            {
                // El número de tarjeta no es de tipo Visa o no tiene la longitud correcta, muestra el botón de error y oculta el de Visa
                btnVisa.Visible = false;
                btnError.Visible = true;
                lblErrorTarjeta.Visible = true;

                return; // Sale de la función si el número de tarjeta no es válido
            }

            // Obtener el nombre y apellido del titular
            string nombreTitular = txtNombreTitular.Text.Trim();
            string apellidoTitular = txtApellidoTitular.Text.Trim();

            // Verificar que los campos de nombre y apellido no estén vacíos
            if (string.IsNullOrWhiteSpace(nombreTitular) || string.IsNullOrWhiteSpace(apellidoTitular))
            {
                // El nombre o el apellido están vacíos, muestra el botón de error y oculta el de Visa
                btnVisa.Visible = false;
                btnError.Visible = true;
                lblErrorTarjeta.Visible = true;
                return; // Sale de la función si el nombre o el apellido están vacíos
            }

            // Obtener el CVC ingresado en txtCodigoSeguridad
            string cvc = txtCodigoSeguridad.Text.Trim();

            // Verificar que el campo CVC no esté vacío y tenga 3 o 4 dígitos
            if (string.IsNullOrEmpty(cvc) || (cvc.Length != 3 && cvc.Length != 4))
            {
                // El CVC no es válido, muestra el botón de error y oculta el de Visa
                btnVisa.Visible = false;
                btnError.Visible = true;
                lblErrorTarjeta.Visible = true;
                return; // Sale de la función si el CVC no es válido
            }

            // Si todas las validaciones son exitosas, muestra el botón de Visa y oculta el de error
            btnVisa.Visible = true;
            btnError.Visible = false;
            lblErrorTarjeta.Visible = false;
        }





        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            lbl_completarCalle.Visible = false;
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_completarCiudad.Visible = false;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            lbl_completarNumCalle.Visible = false;
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
            // Verifica si la tecla presionada no es un número o la tecla de retroceso (borrar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada de caracteres no numéricos
            }

            // Verifica si el número de tarjeta ya tiene 16 dígitos
            if (txtNumeroTarjeta.Text.Replace(" ", "").Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada si ya se alcanzó la longitud máxima
            }
        }

        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
            // Formatea el número de tarjeta en grupos de cuatro dígitos
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
            // Verifica si la tecla presionada no es un número o la tecla de retroceso (borrar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada de caracteres no numéricos
            }

            // Verifica si el CVC ya tiene 3 dígitos
            if (txtCodigoSeguridad.Text.Length >= 3 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquea la entrada si ya se alcanzó la longitud máxima (3 dígitos)
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

        private void setCashConditions()
        {
            // Este metodo hace que se vea el panel del metodo tarjeta y reubicar la posicion de boton
            pnlDatosTarjeta.Visible = false;
            lblSeleccioneMetodo.Visible = false;
            pnlDatosEfectivo.Visible = true;
            lblSimbolo.Visible = Visible;
            nupEfectivo.Value = 0;
            lblMontoValido.Visible = false;

            btnComprar.Enabled = true;
            btnComprar.Location = new Point(btnComprar.Location.X, 625);

            pnlDatosEfectivo.Location = new Point(btnComprar.Location.X, 490);
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

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            Carrito consultarCarrito = new Carrito(this);
            consultarCarrito.Show();
            this.Hide();
        }

        private void rbFechaSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            dtpSeleccionarFecha.Visible = true;
            dtpSeleccionarFecha.Format = DateTimePickerFormat.Custom;
            dtpSeleccionarFecha.CustomFormat = "yyyy-MM-dd HH:mm";

            dtpSeleccionarFecha.MinDate = DateTime.Now;
            dtpSeleccionarFecha.MaxDate = DateTime.Now.AddDays(6);

            dtpSeleccionarFecha.Enabled = true;

            //seteo la fecha minima de seleccion en el datepicker

        }



        private void rnPronto_CheckedChanged(object sender, EventArgs e)
        {
            dtpSeleccionarFecha.Visible = false;
            dtpSeleccionarFecha.Value= DateTime.Now;
            //acá tambien debería quedar acentado en algún lado 
        }



        public void checkeo_rango_horario()
        {
            // Obtener la fecha y hora seleccionada en el DateTimePicker
            int HoraSeleccionada = dtpSeleccionarFecha.Value.Hour;


            // Establecer los límites del rango
            int limiteInferior = 7; // 7:00 AM
            int limiteSuperior = 24; // 11:59 PM

            // Verificar si la hora seleccionada está dentro del rango

            /// és un checkeo para borrar 
            if (HoraSeleccionada >= limiteInferior && HoraSeleccionada < limiteSuperior)
            {/*si vamos a poner el horario en algún lado, va acá */ 
            }
            else
            {
                MessageBox.Show("Seleccione un horario dentro de nuestro turno (7:00 - 23:59).");
            }
        }

    }
    
}
