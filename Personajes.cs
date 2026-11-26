using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_arbol
{
    public class Personajes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string titulo_1 { get; set; }
        public string titulo_2 { get; set; }
        public string titulo_3 { get; set; }

        public Personajes(int ID, string Nombre, string Genero, string Titulo_1, string Titulo_2, string Titulo_3)
        {
            id = ID;
            nombre = Nombre;
            genero = Genero;
            titulo_1 = Titulo_1;
            titulo_2 = Titulo_2;
            titulo_3 = Titulo_3;
        }
    }
}
