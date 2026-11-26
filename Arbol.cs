using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_arbol
{
    internal class Arbol
    {
        public Nodo raiz { get; set; }

        public Arbol()
        {
            raiz = null;
        }

        public void Insertar()
        {
            raiz = InsertarRecursivo(PersonajeAInsertar, raiz);
        }

        public Nodo InsertarRecursivo(Personajes PersonajeAInsertar, Nodo NodoActual)
        {
            if (NodoActual == null)
            {
                Nodo NodoNuevo = new Nodo(PersonajeAInsertar, null, null);
                return NodoNuevo;
            }

            if (NodoActual.valor.id == PersonajeAInsertar.id)
            {
                Console.WriteLine("el id esta repetido");
                return NodoActual;
            }

            if (PersonajeAInsertar.Id < NodoActual.valor.Id)
            {
                NodoActual.izquierdo = InsertarRecursivo(PersonajeAInsertar, NodoActual.izquierdo);
            }
            else if (PersonajeAInsertar.Id > NodoActual.valor.Id)
            {
                NodoActual.derecho = InsertarRecursivo(PersonajeAInsertar, NodoActual.derecho);
            }

            return NodoActual;
        }

        public void Buscar(int BuscarNumero)
        {
            Nodo NodoActual = raiz;
            BuscarRecursivo(BuscarNumero, NodoActual);
        }

        public void BuscarRecursivo(int BuscarNumero, Nodo NodoActual)
        {
            if (NodoActual == null)
            {
                Console.WriteLine("Su personaje no existe en la base de datps");
                return;
            }

            if (NodoActual.valor.Id == BuscarNumero)
            {
                Console.WriteLine("Encontrado: " + NodoActual.valor.id + "su nombre es: " + NodoActual.valor.nombre + "y su genero es: " + NodoActual.valor.genero;
                return;
            }

            if (NodoActual.valor.id < BuscarNumero)
            {
                BuscarRecursivo(BuscarNumero, NodoActual.derecho);
            }
            else if (NodoActual.valor.Id > BuscarNumero)
            {
                BuscarRecursivo(BuscarNumero, NodoActual.izquierdo);
            }
        }
    }
}
