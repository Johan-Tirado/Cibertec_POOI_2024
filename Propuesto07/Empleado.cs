using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto07
{
    internal class Empleado
    {
        private int codigo;
        private string nombre;
        private int numeroCelular;
        private double sueldoSoles;
        public Empleado(int codigo, string nombre, int numeroCelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numeroCelular = numeroCelular;
            this.sueldoSoles = sueldoSoles;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
        public double SueldoSoles { get => sueldoSoles; set => sueldoSoles = value; }

        public string ObtenerClasificacionSueldo()
        {
            if (sueldoSoles > 3500)
                return "mayor a 3500";
            else if (sueldoSoles < 3500)
                return "menor a 3500";
            else
                return "igual a 3500";
        }
    }
}
