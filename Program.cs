using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayannaDelgadoLopez3A.Clases;
using DayannaDelgadoLopez3A.Interfaz ;

namespace DayannaDelgadoLopez3A
{
    class Program
    {
        static void Main(string[] args)
        {
            new cliente( "Delgado López" , "Dayanna María" , 1316876453 , "Tarqui" ). MostrarDatos();
            new gasolina( " Extra " , 5 , 2.0 ). MostrarDatos();
            new gasolina( " Extra " , 5 , 2.0 ). HacerCalculo();
            Console.ReadKey();
        }
    }
}
