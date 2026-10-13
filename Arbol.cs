using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_AyE
{
    internal class Arbol
    {
        Nodo Raiz = null;
        public Arbol()
        {
            if(Raiz == null)
            {
                Insertar(Raiz, nodonuevo);
            }
        }
        public void Insertar(Raiz, int nodonuevo)
        {

        }
        public void InsertarRecursivo(Nodo nodoactual, Nodo nodonuevo)
        {
            if(nodonuevo.id < nodoactual.id)
            {
                if(nodoactual.izquierdo == null)
                {
                    nodoactual.izquierdo = nodonuevo;
                }
                else
                {
                    InsertarRecursivo(nodoactual.izquierdo, nodonuevo)
                }
            }
            if (nodonuevo.id > nodoactual.id)
            {
                if(nodoactual.derecho == null)
                {
                    nodoactual.derecho = nodonuevo;
                }
                else
                {
                    InsertarRecursivo(nodoactual.derecho, nodonuevo)
                }
            }
        }
        public void Buscar(Raiz, int idbuscado)
        {

        }
        public void BuscarRecursivo(Nodo nodoactual, int idbuscado)
        {
            if(nodoactual == null)
            {
                Console.WriteLine("no se encontro ningun jugador con el id "+ idbuscado);
            }
            if(idbuscado < nodoactual.id)
            {
                BuscarRecursivo(nodoactual.izquierdo, idbuscado);
            }
            else
            {
                BuscarRecursivo(nodoactual.derecho, idbuscado);
            }
        }
    }
}
