using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre un Valor en Libras:");
            double unPesoLibras = double.Parse(Console.ReadLine());
            clsPeso unPeso = new clsPeso(unPesoLibras);
            Console.WriteLine("Convencion a Kilogramos:" + unPeso.Kilogramos());
            Console.WriteLine("Convencion a Gramos:" + unPeso.Gramos());
            Console.WriteLine("*****Operacion Realizada con Exito******");
            Console.ReadLine();

        }
    }

    public class clsPeso
    {
        public double libras;

        public clsPeso(double unPesoLibra)
        {
            libras = unPesoLibra;

        }
        public double Kilogramos()
        {
            return libras * 0.453592;
        }
        public double Gramos()
        {
            return Kilogramos() * 1000;
            {


            }
        }
    }
}
