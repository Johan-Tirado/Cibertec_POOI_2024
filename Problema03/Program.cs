using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio e = new Edificio(1321, 123, 123, 213);
            Listar(e);
            e.PrecioDepDol *= 1.20;
            Listar(e);
        }
        static void Listar(Edificio e)
        {
            Console.WriteLine("Datos del Edificio");
            Console.WriteLine($"Código: {e.Codigo}");
            Console.WriteLine($"Número de Departamentos: {e.NroDep}");
            Console.WriteLine($"Cantidad de Pisos: {e.CantPisos}");
            Console.WriteLine($"Precio por Departamento: ${e.PrecioDepDol}");
            Console.WriteLine($"Precio Total del Edificio: {e.precioDolaresEdificio():C}");
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }
    }
}
