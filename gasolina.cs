using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayannaDelgadoLopez3A.Interfaz;

namespace DayannaDelgadoLopex3A.clases
{
    class gasolina : ICalc, IDatos
    {
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int cantGal;
        public int CantGal
        {
            get { return cantGal; }
            set { cantGal = value; }
        }

        private int preVenta;
        public int PreVenta
        {
            get { return preVenta; }
            set { preVenta = value; }
        }

        public void calculo()
        {
            double precio = 0;
            if (tipo == " Extra " || tipo == " extra ")
            {
                precio = 1.5;
                double Subtotal = precio * cantGal;
                double IVA = (precio * cantGal) * 12 / 100;
                double Total = Subtotal + IVA;

                Console.WriteLine(" Subtotal: " + Subtotal);
                Console.WriteLine(" IVA: " + IVA);
                Console.WriteLine(" Total: " + Total);
            }
            else
            {
                precio = 2.0;
                double Subtotal = precio * cantGal;
                double IVA = (precio * cantGal) * 12 / 100;
                double Total = Subtotal + IVA;

                Console.WriteLine(" Subtotal: " + Subtotal);
                Console.WriteLine(" IVA: " + IVA);
                Console.WriteLine(" Total: " + Total);
            }

        }
        public void mostrarDatos()
        {
            Console.WriteLine(" Tipo de gasolina: " + tipo);
            Console.WriteLine(" Cantidad de Galones:   " + cantGal);
            Console.WriteLine(" Precio de venta: " + preVenta);
        }
    }
}
