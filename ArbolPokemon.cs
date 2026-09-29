using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_n8
{
    internal class ArbolPokemon
    {
        public NodoPokemon raiz;

        public void Insertar(Pokemon pokemon)
        {
            raiz = Recursiva(raiz, pokemon);
        }
        public NodoPokemon Recursiva(NodoPokemon nodo, Pokemon pokemon)
        {
            if (nodo == null)
            {
                return new NodoPokemon(pokemon);
            }

            if (pokemon.ID < nodo.Pokemon.ID)
            {
                nodo.Izquierda = Recursiva(nodo.Izquierda, pokemon);
            }
            else
            {
                nodo.Derecha = Recursiva(nodo.Derecha, pokemon);
            }

            return nodo;
        }


        public void Mostrar()
        {
            Mostrarr(raiz);
        }
        public void Mostrarr(NodoPokemon nodo)
        {
            if (nodo != null)
            {
                Mostrarr(nodo.Izquierda);
                nodo.Pokemon.Mostrar();
                Mostrarr(nodo.Derecha);
            }
        }


        public Pokemon Buscar(int id)
        {
            NodoPokemon actual = raiz;

            while (actual != null)
            {
                if (id == actual.Pokemon.ID)
                {
                    return actual.Pokemon;
                }

                if (id < actual.Pokemon.ID)
                {
                    actual = actual.Izquierda;
                }
                else
                {
                    actual = actual.Derecha;
                }
            }
            return null;
        }

        public void Limpiar()
        {
            raiz = null;
        }
    }
}
