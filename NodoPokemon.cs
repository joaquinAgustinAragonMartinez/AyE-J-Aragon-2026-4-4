using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_n8
{
    internal class NodoPokemon
    {
        public Pokemon Pokemon { get; set; }
        public NodoPokemon Izquierda { get; set; }
        public NodoPokemon Derecha { get; set; }

        public NodoPokemon(Pokemon poke)
        {
            Pokemon = poke;
            Izquierda = null;
            Derecha = null;
        }
    }
}
