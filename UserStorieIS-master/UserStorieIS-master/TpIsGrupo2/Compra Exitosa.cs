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
    public partial class Compra_Exitosa : Form
    {
        public Compra_Exitosa()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConfirmarPedido confirmar = new ConfirmarPedido();
            this.Close();
            confirmar.ShowDialog();
        }
    }
}
