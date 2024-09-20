using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular c = new Celular(31321,"dd",22,22);
            Listado(c);
            c.SegundosConsumidos += 20;
            c.Precio *= 0.95;
            Listado(c);
            Console.ReadLine();
        }
        static void Listado(Celular c)
        {
            Console.WriteLine("Boleta-----");
            Console.WriteLine($"Numero del Celular : {c.Numero}");
            Console.WriteLine($"Usuario : {c.Usuario}");
            Console.WriteLine($"Segundos Consumidos : {c.SegundosConsumidos}");
            Console.WriteLine($"Precio por segundo : {c.Precio:C}");
            Console.WriteLine($"Costo por consumo : {c.GetCostoConsumo():C}");
            Console.WriteLine($"Impuesto IGV : {c.GetImpuesto():C}");
            Console.WriteLine($"Total a pagar : {c.GetTotalPagar():C}");
            Console.WriteLine("------------------------");
        }
    }
}
