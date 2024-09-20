using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto06 {
    internal class program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente("Luis", "Leon", 17, 1.70, 64.5);
            Listado(p);
            p.Edad = 25;
            Listado(p);
            Console.ReadKey();
        }
        static void Listado(Paciente p)
        {
            Console.WriteLine("Datos del paciente");
            Console.WriteLine($"Nombre: {p.Nombre}");
            Console.WriteLine($"apellido: {p.Apellido}");
            Console.WriteLine($"Edad: {p.Edad}");
            Console.WriteLine($"Talla {p.Talla}");
            Console.WriteLine($"Peso {p.Peso}");
            Console.WriteLine(p.EsMayorDeEdad()); 
            Console.WriteLine($"-------");
        }
    }
}
