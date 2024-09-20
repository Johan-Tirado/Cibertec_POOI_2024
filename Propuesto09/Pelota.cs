using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propuesto09
{
    internal class Pelota
    {
        private string marca;
        private double pesoGramos;
        private double presionLibras;
        private double diametroCm;
        private double precio;

        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCm, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCm = diametroCm;
            this.precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public double PesoGramos { get => pesoGramos; set => pesoGramos = value; }
        public double PresionLibras { get => presionLibras; set => presionLibras = value; }
        public double DiametroCm { get => diametroCm; set => diametroCm = value; }
        public double Precio { get => precio; set => precio = value; }
    
        public double Radio()
        {
            return diametroCm / 2;
        }
        public double VolunenBalon()
        { 
            return 4 * 3.1416 * Radio() * Radio() * Radio()/3;
        }
        public double Descuento()
        {
            return precio * 0.10;
        }
        public double ImportePagar()
        {
            return precio - Descuento();
        }

    }
}
