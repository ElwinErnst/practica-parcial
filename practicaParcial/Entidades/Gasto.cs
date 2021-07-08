using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemploParcial.Entidades;

namespace ejemploParcial.Entidades
{
    class Gasto
    {
        string descripcion;
        int id;
        float monto;

        
        public Gasto() { }
        
        Gasto(string descripcion, int id, float monto)
        {
            this.descripcion = descripcion;
            this.id = id;
            this.monto = monto;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id { get => id; set => id = value; }
        public float Monto { get => monto; set => monto = value; }
    }
}