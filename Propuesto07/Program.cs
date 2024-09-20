using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Empleado empleado = new Empleado(1, "J", 1231, 3300);
            Listar(empleado);
            empleado.NumeroCelular = 999888777;
            empleado.SueldoSoles += 200;
            Listar(empleado);
            Console.ReadKey();
        }

        static void Listar(Empleado empleado)
        {
            Console.WriteLine($"Código: {empleado.Codigo}");
            Console.WriteLine($"Nombre: {empleado.Nombre}");
            Console.WriteLine($"Número de Celular: {empleado.NumeroCelular}");
            Console.WriteLine($"Sueldo en Soles: {empleado.SueldoSoles} soles");
            Console.WriteLine($"Clasificación de Sueldo: {empleado.ObtenerClasificacionSueldo()}");
            Console.WriteLine("-----------------------");
        }
    }
}
