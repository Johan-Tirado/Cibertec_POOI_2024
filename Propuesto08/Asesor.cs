using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto08
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horasTbj;
        private double tarifaHora;

        public Asesor(int codigo, string nombre, int horasTbj, double tarifaHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTbj = horasTbj;
            this.tarifaHora = tarifaHora;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTbj { get => horasTbj; set => horasTbj = value; }
        public double TarifaHora { get => tarifaHora; set => tarifaHora = value; }
    
        public double SueldoBruto()
        {
            return tarifaHora * horasTbj;
        }
        public double Descuento()
        {
            return SueldoBruto() * 0.15;
        }

        public double SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }
    }
}
