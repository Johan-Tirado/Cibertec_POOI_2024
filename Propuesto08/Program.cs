using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor ac = new Asesor(232,"Jorge",32,34.1);
            Listado(ac);
            ac.HorasTbj += 10;
            ac.TarifaHora *= 0.85;
            Listado(ac);
            Console.ReadKey();
        }

        static void Listado(Asesor ac)
        {
            Console.WriteLine($"Datos del asesor");
            Console.WriteLine($"Codigo: {ac.Codigo}");
            Console.WriteLine($"Nombre:{ac.Nombre}");
            Console.WriteLine($"Horas trabajadas: {ac.HorasTbj}");
            Console.WriteLine($"Tarifa por hora: {ac.TarifaHora}");
            Console.WriteLine($"Sueldo Bruto: {ac.SueldoBruto()}");
            Console.WriteLine($"Descuento: {ac.Descuento()}");
            Console.WriteLine($"SueldoNeto:{ac.SueldoNeto()}");
            Console.WriteLine($"------------------");
        }
    }
}
