using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_21
{
    public class ArbolBusqueda
    {
        private Nodo raiz;
        public void Insertar(int NuevoValor)
        {
            Nodo nuevo = new Nodo(NuevoValor);

            if (raiz == null)
            {
                raiz = nuevo;
                return;
            }

            Nodo actual = raiz;
            Nodo padre = null;

            while (actual != null)
            {
                padre = actual;
                if (NuevoValor < actual.valor)
                {
                    actual = actual.izquierdo;
                }
                else
                {
                    actual = actual.derecho;
                }
            }

            if (NuevoValor < padre.valor)
            {
                padre.izquierdo = nuevo;
            }
            else
            {
                padre.derecho = nuevo;
            }
        }
        public int ObtenerMinimo()
        {
            if (raiz == null)
            {
                throw new InvalidCastException("vacio");
            }
            Nodo actual = raiz;
            while (actual.izquierdo != null) actual = actual.izquierdo;
            return actual.valor;
        }
        public int ObtenerMaximo()
        {
            if (raiz == null)
            {
                throw new InvalidCastException("vacio");
            }
            Nodo actual = raiz;
            while (actual.derecho != null) actual = actual.derecho;
            return actual.valor;
        }

        public int ContarNodosRecursivo(Nodo actual)
        {
            if (actual == null)
            {
                return 0;
            }
            return 1 + ContarNodosRecursivo(actual.izquierdo) + ContarNodosRecursivo(actual.derecho);
        }
        public int ObtenerCantidadNodos()
        {
            return ContarNodosRecursivo(raiz);
        }

        public int CalcularAlturaRecursivo(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            int alturaIzquierda = CalcularAlturaRecursivo(nodo.izquierdo);
            int alturaDerecha = CalcularAlturaRecursivo(nodo.derecho);

            return 1 + Math.Max(alturaIzquierda, alturaDerecha);
        }

        public int ObtenerAltura()
        {
            return CalcularAlturaRecursivo(raiz);
        }

        public int CalcularCantidadHojasRecursivo(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
        }
        public int ObtenerHojas()
        {
            return CalcularCantidadHojasRecursivo(raiz);
        }
    }
}
