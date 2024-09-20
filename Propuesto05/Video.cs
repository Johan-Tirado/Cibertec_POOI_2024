using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto05
{
    internal class Video
    {
        private int codigo;
        private string nombre;
        private double duracion;
        private double precioSol;
        private double tipoCambio;

        public Video(int codigo, string nombre, double duracion, double precioSol, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.duracion = duracion;
            this.precioSol = precioSol;
            this.tipoCambio = tipoCambio;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double TipoCambio { get => tipoCambio; set => tipoCambio = value; }
        public double PrecioSol { get => precioSol; set => precioSol = value; }

        public double CalcularPrecioEnDolares()
        {
            return precioSol / tipoCambio;
        }
    }
}
