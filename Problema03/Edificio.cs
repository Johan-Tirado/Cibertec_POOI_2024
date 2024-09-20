using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Edificio
    {
        private int codigo;
        private int nroDep;
        private int cantPisos;
        private double precioDepDol;

        public Edificio(int codigo, int nroDep, int cantPisos, double precioDepDol)
        {
            this.codigo = codigo;
            this.nroDep = nroDep;
            this.cantPisos = cantPisos;
            this.precioDepDol = precioDepDol;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int NroDep { get => nroDep; set => nroDep = value; }
        public int CantPisos { get => cantPisos; set => cantPisos = value; }
        public double PrecioDepDol { get => precioDepDol; set => precioDepDol = value; }

        public double precioDolaresEdificio()
        {
            return nroDep * precioDepDol;
        }
    }
}
