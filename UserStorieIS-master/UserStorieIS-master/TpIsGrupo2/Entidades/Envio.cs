using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpIsGrupo2.Entidades
{
    public class Envio
    {
        public string Ciudad { get; set; }

        public string Calle { get; set; }   

        public int NumeroCalle {  get; set; }

        public Envio(string ciudad, string calle, int numeroCalle) { 
        
            this.Ciudad = ciudad;
            this.Calle = calle; 
            this.NumeroCalle = numeroCalle;
        }

        public Envio() { }
    }
}
