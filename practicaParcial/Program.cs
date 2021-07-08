using ejemploParcial.Entidades;
using ejemploParcial.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace ejemploParcial
{
    class Program
    {
        public static List<Viaje> viajes;
        public static List<Persona> personas;
        public static List<Gasto> gastos;

        static void Main(string[] args)
        {
            viajes = new List<Viaje>();
            personas = new List<Persona>();
            gastos = new List<Gasto>();

            //Persona p1 = new Persona();  p1.Id = 01; p1.Nombre = "alex"; p1.Apellido = "ernst"; p1.Gastos = 40000; personas.Add(p1);
            //Persona p2 = new Persona(); p2.Id = 02; p2.Nombre = "el"; p2.Apellido = "sebuli"; p2.Gastos = 50000; personas.Add(p2);
            //Persona p3 = new Persona(); p3.Id = 01; p3.Nombre = "puto"; p3.Apellido = "by"; p3.Gastos = 60000; personas.Add(p3);

            Menu();
        }

        public static void ListarPersona()
        {
            string[] lista = new string[Program.personas.Count];
            foreach (Persona p in Program.personas)
            {
                lista[Program.personas.IndexOf(p)] = p.Nombre + " " + p.Apellido;
            }
            Herramientas.DibujoMenu("Personas", lista);
        }

        public static int SeleccionarPersona()
        {
            ListarPersona();
            Console.Write("Seleccione una persona: ");
            int p = Herramientas.IngresoEnteros(1, Program.personas.Count);
            return p - 1;
        }

        public static void ListarGasto()
        {
            string[] lista = new string[Program.gastos.Count];
            foreach (Gasto p in Program.gastos)
            {
                lista[Program.gastos.IndexOf(p)] = p.Id + " " + p.Monto + " " + p.Descripcion;
            }
            Herramientas.DibujoMenu("Personas", lista);
        }

        public static int SeleccionarGasto()
        {
            ListarGasto();
            Console.Write("Seleccione un gasto: ");
            int p = Herramientas.IngresoEnteros(1, Program.gastos.Count);
            return p - 1;
        }

        public static void ListarViaje()
        {
            string[] lista = new string[Program.viajes.Count];
            foreach (Viaje v in Program.viajes)
            {
                lista[Program.viajes.IndexOf(v)] = v.Id + " " + v.Destino + " " + v.FechaS.ToString();
            }
            Herramientas.DibujoMenu("Personas", lista);
        }

        public static int SeleccionarCostViaje()
        {
            Viaje v = Program.viajes.ElementAt(SeleccionarViaje());
            ListarCostViaje(v);
            Console.Write("Seleccione un Costo: ");
            int p = Herramientas.IngresoEnteros(1, v.CostViaje.Count);
            return p - 1;
        }

        public static void ListarCostViaje(Viaje v)
        {
            string[] lista = new string[v.CostViaje.Count];
            foreach (Gasto e in v.CostViaje)
            {
                lista[v.CostViaje.IndexOf(e)] = e.Id + " " + e.Monto + " " + e.Descripcion;
            }
            Herramientas.DibujoMenu("Personas", lista);
        }

        public static int SeleccionarViaje()
        {
            ListarViaje();
            Console.Write("Seleccione un Viaje: ");
            int p = Herramientas.IngresoEnteros(1, Program.viajes.Count);
            return p - 1;
        }

        public static void punto2()
        {
            Gasto g = new Gasto();

            Console.Write("Ingrese ID: ");
            g.Id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Descripcion: ");
            g.Descripcion = Console.ReadLine();

            Console.Write("Ingrese Monto: ");
            g.Monto = int.Parse(Console.ReadLine());

            Program.gastos.Add(g);

            Viaje v = new Viaje();

            Console.Write("Ingrese ID: ");
            v.Id = int.Parse(Console.ReadLine());

            int h, j, k, l;

            Console.WriteLine(" año salida (YYYY):");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine(" mes salida (MM):");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("Dia salida (DD):");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Hora salida (HH):");
            l = int.Parse(Console.ReadLine());

            v.FechaS = new DateTime(h, j, k, l, 0, 0);

            Console.Write("Ingrese Destino: ");
            v.Destino = Console.ReadLine();

            Console.Write("Seleccione un gasto: ");
            Gasto r = Program.gastos.ElementAt(SeleccionarGasto());
            v.CostViaje.Add(r);
            Program.viajes.Add(v);
        }

        public static void Punto3()
        {
            Viaje v = Program.viajes.ElementAt(SeleccionarViaje());

            Gasto g = v.CostViaje.ElementAt(SeleccionarCostViaje());

            float total = 0;
            foreach (Gasto c in v.CostViaje)
            {
                total = total + c.Monto;
            }
            foreach (Persona p in v.PersViaje)
            {
                Console.WriteLine(p.Nombre + " " + p.Apellido + " " + total / v.PersViaje.Count());
            }
        }
        public static void Menu()
        {
            Console.Clear();
            string[] opciones = new string[3] { "Punto 3", "Punto 2", "Salir" };
            int l = opciones.Length;
            string titulo = "TP 2";
            Herramientas.DibujoMenu(titulo, opciones);
            Console.WriteLine("Ingrese una opción: ");
            int op = Herramientas.IngresoEnteros(1, l);

            switch (op)
            {
                case 1: Punto3(); Menu(); break;
                case 2: punto2(); Menu(); break;
                default: Menu(); break;
            }
            //public static void OrdenarPorRecaudacion(List<Playa> p)
            //{
            //    Playa aux = new Playa();
            //    for (int a = 1; a < p.Count; a++)
            //        for (int b = p.Count - 1; b >= a; b--)
            //        {
            //            if (p[b - 1].Recaudacion < p[b].Recaudacion)
            //            {
            //                aux = p[b - 1];
            //                p[b - 1] = p[b];
            //                p[b] = aux;
            //            }
            //        }
            //    Listar();
            //    Console.ReadLine();
            //}
        }
    }
}
