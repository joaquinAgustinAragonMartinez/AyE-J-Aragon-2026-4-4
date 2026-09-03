using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_algoritmos
{
    public struct Personaje
    {
        public int VidaTotal;
        public int VidaActual;
        public string UltimaAccion;
        public Personaje(int VidaTotal, int VidaActual, string UltimaAccion)
        {
            this.VidaTotal = VidaTotal;
            this.VidaActual = VidaActual;
            this.UltimaAccion = UltimaAccion;
        }
    }
}
