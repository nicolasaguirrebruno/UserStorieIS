using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpIsGrupo2.Entidades;

namespace TpIsGrupo2
{

    public partial class ConfirmarCompra : Form
    {
        LoadingSpinner loading;
        public Form anterior1;
        public ConfirmarCompra(Envio envio, Producto producto, Form envios)
        {
            anterior1 = envios;
            InitializeComponent();
            lblCalle.Text = envio.Calle ;
            lblCiudad.Text = envio.Ciudad;
            lblHoraEntrega.Text = envio.horaentrega.ToString();
            lblCantidadProducto.Text = producto.CantProducto.ToString();
            lblPrecioFinal.Text = "$" + " " + producto.TotalProducto.ToString();
            lblSubtotal.Text = "$" + " " + producto.SubtotalProducto.ToString();
            lblNombreProducto.Text = producto.NombreProducto;

        }

        private async void btnComprar_Click(object sender, EventArgs e)
        {

            Show();
            Task oTask = new Task(Delay);
            oTask.Start();
            await oTask;

            Hide();
            Compra_Exitosa compra = new Compra_Exitosa();
            compra.Show();
            this.Close();
        }

        public void Delay()
        {
            Thread.Sleep(3000);
        }

        public void Show()
        {
            loading = new();
            loading.Show();
        }
        public void Hide()
        {
            loading.Close();
        }

        private void btnEditarEnvío_Click(object sender, EventArgs e)
        {
            anterior1.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
