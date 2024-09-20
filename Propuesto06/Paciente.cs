using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto06
{
    internal class Paciente
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Talla { get => talla; set => talla = value; }
        public double Peso { get => peso; set => peso = value; }

        public string EsMayorDeEdad()
        {
            return (edad >= 18) ? "Mayor de edad" : "Menor de edad";
        }
    }
}
