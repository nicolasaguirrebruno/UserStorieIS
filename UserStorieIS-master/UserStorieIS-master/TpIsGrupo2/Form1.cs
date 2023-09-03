using System.Windows.Forms;

namespace TpIsGrupo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Hago que se pueda seleccionar fecha y hora, aunque debe modificarse para que muestre solamente el dia de hoy
            dtpSeleccionarFecha.Format = DateTimePickerFormat.Custom;
            dtpSeleccionarFecha.CustomFormat = "dd/MM/yyyy     hh:mm:ss";

            // Le digo al form donde quiero que arranque en la pantalla de mi coputadora
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(500, 10);

            // Llamo a setDefault para establecer las posiciones por defecto de los elementos
            SetDefaultConidtions();
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            // Debe programarse que no se puedan seleccionar ambas al mismo tiempo y que si selecciono una reconozca el numero de esa tarjeta
            setBorderToCard(this.btnVisa);
        }

        private void btnMastercard_Click(object sender, EventArgs e)
        {
            // Debe programarse que no se puedan seleccionar ambas al mismo tiempo y que si selecciono una reconozca el numero de esa tarjeta

            setBorderToCard(this.btnMastercard);
        }

        private void setBorderToCard(Button button)
        {
            // Le pongo un color al borde, si se les ocurre una mejor forma de resaltar el tipo de tarjeta modifiquen esto
            button.FlatAppearance.BorderColor = Color.FromArgb(255, 178, 128);
            button.FlatAppearance.BorderSize = 2;
        }

        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // Programar todo lo que sea marcar uno y desmarcar el otro
            if (!chkTarjeta.Checked)
            {
                SetDefaultConidtions();
            }
            else
            {
                setCardConditions();
            }
        }

        private void setCardConditions()
        {
            // Este metodo hace que se vea el panel del metodo tarjeta y reubicar la posicion de boton
            pnlDatosTarjeta.Visible = true;
            lblSeleccioneMetodo.Visible = false;

            btnComprar.Enabled = true;
            btnComprar.Location = new Point(btnComprar.Location.X, 780);
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
            btnComprar.Enabled = false;

            // Padding
            lblSeleccioneMetodo.Padding = new Padding(0, 10, 0, 0);

            // Medidas basadas en el Iphone 12 Pro
            this.Height = 844;
            this.Width = 390;
            pnlDatosTarjeta.Visible = false;
            lblSeleccioneMetodo.Visible = true;

            //// Deshabilitar el scroll horizontal y que quede nomas el vertical
            //pnlGeneral.HorizontalScroll.Maximum = 0;
            //pnlGeneral.AutoScroll = false;
            //pnlGeneral.HorizontalScroll.Visible = false;
            //pnlGeneral.AutoScroll = true; // Habilitar nuevamente el scroll vertical
        }
    }
}
