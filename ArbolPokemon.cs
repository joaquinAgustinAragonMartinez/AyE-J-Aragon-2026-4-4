using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_23
{
    public class ArbolPokemon
    {
        public NodoPokemon raiz;
        public void Insertar(int NuevoValor)
        {
            NodoPokemon nuevo = new NodoPokemon(NuevoValor);

            if (raiz == null)
            {
                raiz = nuevo;
                return;
            }

            NodoPokemon actual = raiz;
            NodoPokemon padre = null;

            while (actual != null)
            {
                padre = actual;
                if (NuevoValor < actual.id)
                {
                    actual = actual.izquierdo;
                }
                else
                {
                    actual = actual.derecho;
                }
            }

            if (NuevoValor < padre.id)
            {
                padre.izquierdo = nuevo;
            }
            else
            {
                padre.derecho = nuevo;
            }
        }
    }
}