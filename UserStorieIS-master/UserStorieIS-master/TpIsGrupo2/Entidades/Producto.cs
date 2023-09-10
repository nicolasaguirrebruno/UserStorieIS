using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIsGrupo2.Entidades
{

    public class Producto
    {
        public string NombreProducto { get; set; }

        public float SubtotalProducto { get; set; }

        public float PrecioProducto { get; set; }   

        public float TotalProducto { get; set; }

        public bool ExisteProducto { get; set; }

        public int CantProducto { get; set; }   


        // Constructor sobrecargado con parámetros
        public Producto(string nombre, float precio, float total, bool existe, int cantProducto)
        {
            SubtotalProducto = 4500;
            NombreProducto = nombre;
            SubtotalProducto = precio;
            TotalProducto = total;
            ExisteProducto = existe;
            CantProducto = cantProducto;
        }

        public Producto(bool existe) {
            ExisteProducto = existe;
        }
    }

   
}
