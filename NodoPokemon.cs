using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_23
{
    public class NodoPokemon
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string tipo_1 { get; set; }
        public string tipo_2 { get; set; }
        public int hp { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int ataque_especial { get; set; }
        public int defensa_especial { get; set; }
        public int velocidad { get; set; }
        public int nivel { get; set; }

        public NodoPokemon izquierdo { get; set; }

        public NodoPokemon derecho { get; set; }


        public NodoPokemon(int id)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo_1 = tipo_1;
            this.tipo_2 = tipo_2;
            this.hp = hp;
            this.ataque = ataque;
            this.defensa = defensa;
            this.ataque_especial = ataque_especial;
            this.velocidad = velocidad;
            this.nivel = nivel;
            this.izquierdo = null;
            this.derecho = null;
        }
    }
}