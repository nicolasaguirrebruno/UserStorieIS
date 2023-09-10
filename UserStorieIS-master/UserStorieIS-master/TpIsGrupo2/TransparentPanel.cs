using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIsGrupo2
{
   
    public class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // No hacemos nada en este método para lograr la transparencia
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Aquí puedes personalizar el dibujo del panel según tus necesidades
            // Por ejemplo, puedes dibujar un fondo semitransparente

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(128, Color.Gray)))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            base.OnPaint(e);
        }
    }

}
