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
    public partial class Carrito : Form
    {
        //Form form1 = new Form(); //forma 1

        private ConfirmarPedido form1; //forma 2



        decimal cant;

        Producto producto;

        public Carrito(ConfirmarPedido form, Producto producto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(500, 10);
            this.form1 = form;
            subtotal.Text = producto.SubtotalProducto.ToString();
            cantProducto.Value = producto.CantProducto;
            total.Text = "$4500";
            total.Text = "$" + producto.SubtotalProducto.ToString();
            this.producto = producto;
            cant = 1;

            cant = cantProducto.Value * 4500;
            subtotal.Text = "$" + cant.ToString();
            total.Text = "$" + cant.ToString();
            button5.Visible = false;
            button5.Hide();
        }



        private void btnComprar_Click(object sender, EventArgs e)
        {

            // Elimina el símbolo "$" de total.Text y convierte la cadena resultante a entero
            decimal monto = decimal.Parse(total.Text.Replace("$", ""));

            // Luego, llama al método ActualizarMontoEfectivoCarrito con el valor entero
            form1.ActualizarMontoEfectivoCarrito(monto);

            if (cant > 0)
            {
                this.producto.NombreProducto = lblNombre.Text;
                this.producto.SubtotalProducto = (float)cant;
                this.producto.TotalProducto = (float)cant + 500;
                this.producto.ExisteProducto = true;
                this.producto.CantProducto = (int)cantProducto.Value;

            }
            else
            {

                ErrorProductoMessage error = new ErrorProductoMessage();
                error.ShowDialog();

                return;

            }


            form1.Show();

            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cant = cantProducto.Value * 4500;
            subtotal.Text = "$" + cant.ToString();
            total.Text = "$" + cant.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            lblPorAhora.Visible = true;
            btnComprar.Visible = false;
            btnAgregar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            lblPorAhora.Visible = false;
            btnComprar.Visible = true;
            btnAgregar.Visible = false;


            this.producto.NombreProducto = lblNombre.Text;
            this.producto.SubtotalProducto = 1;
            this.producto.TotalProducto = 4500;
            this.producto.ExisteProducto = true;
            this.producto.CantProducto = 1;
            cantProducto.Value = 1;
            cant = (decimal)producto.SubtotalProducto;
        }
    }
}
