using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_a_base_de_datos
{
    internal class Punto2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Punto2D(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
