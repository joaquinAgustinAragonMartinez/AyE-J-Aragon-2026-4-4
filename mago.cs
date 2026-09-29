using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_structs
{
    public class mago
    {
        public int VidaTotal { get; set; }
        public int VidaActual { get; set; }
        public string UltimoHechizo { get; set; }

        public mago(int VidaTotal, int VidaActual, string UltimoHechizo)
        {
            this.VidaTotal = VidaTotal;
            this.VidaActual = VidaActual;
            this.UltimoHechizo = UltimoHechizo;
        }
    }
}