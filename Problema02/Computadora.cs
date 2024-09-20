using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Computadora
    {
        private int codigo;
        private string marca;
        private string color;
        private double precio;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public double Precio { get => precio; set => precio = value; }

        public Computadora(int codigo, string marca, string color, double precio)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precio = precio;
        }
        
        public double precioEnSoles()
        {
            return precio * 3.35;
        }
        public double precioEnEuros()
        {
            return precioEnSoles() * 1.2;
        }
    }
}