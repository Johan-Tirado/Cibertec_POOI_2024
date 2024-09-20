using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora cpu = new Computadora(1234, "Intel","rojo",1500.00);
            Listado(cpu);
            cpu.Precio *= 0.9;
            Listado(cpu);
            Console.ReadKey();
        }
        static void Listado(Computadora cpu)
        {
            Console.WriteLine("Datos de la Computadora");
            Console.WriteLine($"Codigo : {cpu.Codigo}");
            Console.WriteLine($"Marca : {cpu.Marca}");
            Console.WriteLine($"Color : {cpu.Color}");
            Console.WriteLine($"Precio en dolares : ${cpu.Precio}");
            Console.WriteLine($"Precio en soles : {cpu.precioEnSoles():C}");
            Console.WriteLine($"Precio en Euros : {cpu.precioEnEuros()}");
            Console.WriteLine("-----------------");
        }
    }
}
