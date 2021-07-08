using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemploParcial.Entidades;

namespace ejemploParcial.Entidades
{
    class Persona
    {
        int id;
        string nombre;
        string apellido;
        float gastos;

        public Persona() { }

        Persona(int id, string nombre, string apellido, float gastos)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.gastos = gastos;
        }

        public int Id { get => id; set => id = value; }
        public float Gastos { get => gastos; set => gastos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}

