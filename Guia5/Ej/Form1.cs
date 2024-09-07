using Ej.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            cBcodigo.Enabled = false;
            bBorrar.Enabled = false;
        }
        Presupuesto p;

        private void bIniciar_Click(object sender, EventArgs e)
        {
            string n = tBnombre.Text;
            string d = tBdir.Text;
            p = new Presupuesto(n, d);
            groupBox2.Enabled = true;
            rBbanco.Checked = true;
        }

        private void rBmesa_CheckedChanged(object sender, EventArgs e)
        {
            tBancho.Enabled = true;
            tBgrosor.Enabled = true;
        }

        private void rBbanco_CheckedChanged(object sender, EventArgs e)
        {
            tBancho.Enabled = false;
            tBgrosor.Enabled = false;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            double largo = Convert.ToDouble(tBlargo.Text);
            double precio = Convert.ToDouble(tBprecio.Text);
            int codigo = Convert.ToInt32(tBcodigo.Text);

            if (rBbanco.Checked)
            {
                Producto a = new Banco(precio, largo)
                {
                    Codigo = codigo,
                };
                p.AgregarProducto(a);
            }
            if (rBmesa.Checked)
            {
                double grosor = Convert.ToDouble(tBgrosor.Text);
                double ancho = Convert.ToDouble(tBancho.Text);
                Producto a = new Mesa(ancho, grosor, precio, largo)
                {
                    Codigo = codigo
                };
                p.AgregarProducto(a);
            }
            tBancho.Clear();
            tBcodigo.Clear();
            tBgrosor.Clear();
            tBlargo.Clear();
            tBprecio.Clear();
            cBcodigo.Enabled = true;
            bBorrar.Enabled = true;
            cBcodigo.Items.Add(codigo);
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cBcodigo.SelectedItem);
            p.QuitarProducto(codigo);
            cBcodigo.Items.Remove(codigo);
            cBcodigo.Text = "";

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            if(p!= null)
            {
                Datos datos = new Datos();
                datos.lBresumen.Items.AddRange(p.Resumen());
                datos.ShowDialog(); 
            }
        }
    }
}
