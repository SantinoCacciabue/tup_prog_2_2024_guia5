using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.models
{
    abstract class Producto:IComparable
    {
        protected double precioBase;
        protected double largo;
        private int codigo;
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public Producto(double precio, double largo)
        {
            precioBase = precio;
            this.largo = largo;
        }
        public abstract double Peso();
        public abstract double Precio();
        public int CompareTo(object obj)
        {
            Producto p = obj as Producto;
            if (p != null)
            {
                return Codigo.CompareTo(p.Codigo);
            }
            return 1;
        }
    }
}
