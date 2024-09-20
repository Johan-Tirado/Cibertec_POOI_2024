using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video v = new Video(231,"video1",40,30,3.70);
            Listado(v);
            v.PrecioSol += 5.50;
            Listado(v);
            Console.ReadKey();
        }

        static void Listado(Video v)
        {
            Console.WriteLine($"Código: { v.Codigo} ");
            Console.WriteLine($"Nombre: { v.Nombre} ");
            Console.WriteLine($"Duración: {v.Duracion}min");
            Console.WriteLine($"Precio en Soles: {v.PrecioSol:C}");
            Console.WriteLine($"Tipo de Cambio: ${v.TipoCambio}");
            Console.WriteLine($"Precio en Dólares: ${v.CalcularPrecioEnDolares():F}");
            Console.WriteLine("---------------------------");
        }
    }
}
