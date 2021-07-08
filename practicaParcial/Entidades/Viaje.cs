using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemploParcial.Entidades;

namespace ejemploParcial.Entidades
{
    class Viaje
    {
        int id;
        DateTime fechaS;
        string destino;
        public List<Persona> persViaje;
        public List<Gasto> costViaje;

        public Viaje()
        {
        }

        Viaje(DateTime fechaS, string destino, List<Persona> persViaje, List<Gasto> costViaje, int id)
        {
            this.fechaS = fechaS;
            this.destino = destino;
            this.persViaje = persViaje;
            this.costViaje = costViaje;
            this.id = id;

        }

        public DateTime FechaS { get => fechaS; set => fechaS = value; }
        public string Destino { get => destino; set => destino = value; }
        public List<Persona> PersViaje { get => persViaje; set => persViaje = value; }
        public List<Gasto> CostViaje { get => costViaje; set => costViaje = value; }
        public int Id { get => id; set => id = value; }

    }
}
