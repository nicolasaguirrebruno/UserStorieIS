using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpIsGrupo2
{
    public partial class Carrito : Form
    {
        //Form form1 = new Form(); //forma 1
        
        private Form1 form1; //forma 2


        public Carrito(Form1 form)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(500, 10);
            this.form1 = form; 

            subtotal.Text = "$4500";
            total.Text = "$4500";
        }

  
    
        private void btnComprar_Click(object sender, EventArgs e)
        {

            // Elimina el símbolo "$" de total.Text y convierte la cadena resultante a entero
            decimal monto = decimal.Parse(total.Text.Replace("$", ""));

            // Luego, llama al método ActualizarMontoEfectivoCarrito con el valor entero
            form1.ActualizarMontoEfectivoCarrito(monto);


            form1.Show();

            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal cant = cantProducto.Value * 4500;
            subtotal.Text = "$" + cant.ToString();    
            total.Text = "$" + cant.ToString();   

        }
    }
}
