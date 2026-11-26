using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_arbol
{
    public class Nodo
    {
        public Nodo derecho { get; set; }
        public Nodo izquierdo { get; set; }
        public Nodo valor { get; set; }

        public Nodo(Nodo Derecho, Nodo Izquierdo, Nodo Valor)
        {
            derecho = Derecho;
            izquierdo = Izquierdo;
            valor = Valor;
        }
    }
}
