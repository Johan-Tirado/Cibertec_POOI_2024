using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pl = new Pelota("marca", 1000, 43.4, 4, 100);
            Listado(pl);
            pl.Precio *= 0.75;
            pl.DiametroCm += 1;
            Listado(pl);
            Console.ReadKey();
        }

        static void Listado(Pelota pl)
        {
            Console.WriteLine($"Datos de la pelota");
            Console.WriteLine($"Marca:{pl.Marca}");
            Console.WriteLine($"Peso: {pl.PesoGramos}gr");
            Console.WriteLine($"Presion:{pl.PresionLibras}");
            Console.WriteLine($"Diametro:{pl.DiametroCm}");
            Console.WriteLine($"Precio:{pl.Precio}");
            Console.WriteLine($"Radio:{pl.Radio()}");
            Console.WriteLine($"Volumen:{pl.VolunenBalon()}");
            Console.WriteLine($"Descuento:{pl.Descuento()}");
            Console.WriteLine($"Importe a pagar: {pl.ImportePagar()}");
            Console.WriteLine("--------------------");
        }
    }
}
