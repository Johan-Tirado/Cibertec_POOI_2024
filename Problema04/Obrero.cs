using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Obrero
    {
        private int codigo;
        private string nombre;
        private int horasTbj;
        private int tarifa;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTbj { get => horasTbj; set => horasTbj = value; }
        public int Tarifa { get => tarifa; set => tarifa = value; }

        public Obrero(int codigo, string nombre, int horasTbj, int tarifa)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTbj = horasTbj;
            this.tarifa = tarifa;
        }
        
        public double SueldoBruto()
        {
            return horasTbj * tarifa;
        }
        public double Descuentoafp()
        {
            return SueldoBruto() * 0.10;
        }
        public double DescuentoEPS()
        {
            return SueldoBruto() * 0.05;
        }
        public double SueldoNeto()
        {
            return SueldoBruto() * Descuentoafp() - DescuentoEPS();
        }
    }
}
