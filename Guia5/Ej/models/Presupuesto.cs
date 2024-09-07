using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.models
{
    internal class Presupuesto
    {
        ArrayList productos = new ArrayList();
        private Cliente solicitante;
        public double Precio
        {
            get
            {
                double acum = 0;
                foreach(Producto p in productos)
                {
                    acum += p.Precio();
                }
                return acum;
            }
        }
        public Presupuesto(string nombre,string dir)
        {
            solicitante = new Cliente(nombre,dir);
        }
        public void AgregarProducto(Producto p)
        {
            if (p != null)
            {
                productos.Add(p);
            }
        }
        private Producto BuscarProducto(int codigo)
        {
            int izq = 0;
            int der = productos.Count - 1;
            while(izq <= der)
            {
                int i = izq+(der-izq)/2;
                Producto p = productos[i] as Producto;
                if(p.Codigo == codigo)
                {
                    return p;
                }
                else if (p.Codigo > codigo)
                {
                    izq = i+1;
                }
                else
                {
                    der = i - 1;
                }
            }
            return null;
        }
        public bool QuitarProducto(int codigo)
        {
            productos.Sort();
            Producto p = BuscarProducto(codigo);
            if(p != null)
            {
                productos.Remove(p);
            }
            return false;
        }
        public string[] Resumen()
        {
            string[] a = new string[productos.Count + 2] ;
            int i = 0;
            a[i++] = solicitante.ToString();
            foreach(Producto p in productos)
            {
                a[i++] = $"Código: {p.Codigo} Peso: {p.Peso()} Precio: {p.Precio()}";
            }
            a[i] = $"Precio final: {Precio}";
            return a;
        }
    }
}
