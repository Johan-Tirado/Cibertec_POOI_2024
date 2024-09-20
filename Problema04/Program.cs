using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero ob = new Obrero(123,"Luis",45,20);
            Listado(ob);
            ob.HorasTbj += 8;
            ob.Tarifa = (int)(ob.Tarifa* 0.985);
            Listado(ob);
            Console.ReadKey();
        }
        static void Listado(Obrero ob)
        {
            Console.WriteLine("Datos del Obrero");
            Console.WriteLine($"Código: {ob.Codigo}");
            Console.WriteLine($"Nombre: {ob.Nombre}");
            Console.WriteLine($"Horas Trabajadas: {ob.HorasTbj}");
            Console.WriteLine($"Tarifa por Hora: {ob.Tarifa}");
            Console.WriteLine($"Sueldo Bruto: {ob.SueldoBruto():C}");
            Console.WriteLine($"Descuento AFP: {ob.Descuentoafp():C}");
            Console.WriteLine($"Descuento EPS: {ob.DescuentoEPS():C}");
            Console.WriteLine($"Sueldo Neto: {ob.SueldoNeto():C}");
            Console.WriteLine();
        }

    }
}
