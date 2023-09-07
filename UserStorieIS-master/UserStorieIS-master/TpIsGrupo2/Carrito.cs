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
        Form form1 = new Form(); 
        public Carrito(Form form)
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
            Form1 form = new Form1();
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
