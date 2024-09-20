using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    internal class Celular
    {
        private int numero;
        private string usuario;
        private int segundosConsumidos;
        private double precio;

        public Celular(int numero, string usuario, int segundosConsumidos, double precio)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precio = precio;
        }
        public void setNumero(int numero)
        {
            this.numero=numero;
        }
        public int getNumero()
        {
            return numero;
        }
        public int Numero { get => numero; set => numero = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public int SegundosConsumidos { get => segundosConsumidos; set => segundosConsumidos = value; }
        public double Precio { get => precio; set => precio = value; }

        public double GetCostoConsumo()
        {
            return precio * segundosConsumidos;
        }
        public double GetImpuesto()
        {
            return GetCostoConsumo() * 0.18;
        }
        public double GetTotalPagar()
        {
            return GetCostoConsumo() + GetImpuesto();
        }
    }
}
