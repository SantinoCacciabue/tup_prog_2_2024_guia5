using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.models
{
    internal class Mesa : Producto
    {
        private double ancho;
        private double grosor;
        public Mesa(double ancho, double grosor,double precio,double largo):base(precio,largo)
        {
            this.ancho = ancho;
            this.grosor = grosor;
        }
        public override double Peso()
        {
            return (largo * ancho * grosor) * 0.3;
        }
        public override double Precio()
        {
            return Peso() * precioBase * 1.25;
        }

    }
}
