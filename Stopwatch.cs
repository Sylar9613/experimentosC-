using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            /*
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Telee su nombre:");
            crono.Start();
            string nombre = Console.ReadLine();
            crono.Stop();
            Console.Write("\nHola {0}, ", nombre);
            if (nombre.Length/(crono.ElapsedMilliseconds/1000)>=2)
            {
                Console.Write("eres rápido/a tecleando tu nombre.\n\n");
            }
            else if (nombre.Length/(crono.ElapsedMilliseconds/1000)<2&&nombre.Length/(crono.ElapsedMilliseconds/1000)>=1)
            {
                Console.Write("eres regular tecleando tu nombre.\n\n");
            }
            else
            {
                Console.Write("eres lento/a tecleando tu nombre.\n\n");
            }
            */
            #endregion

            #region Exercise 2

            Stopwatch crono1, crono2, crono3;
            crono1 = new Stopwatch(); crono2 = new Stopwatch(); crono3 = new Stopwatch();
            Console.WriteLine("Escriba su nombre:");
            crono1.Start();
            string name1 = Console.ReadLine();
            crono1.Stop();
            Console.WriteLine("Escriba su nombre de nuevo:");
            crono2.Start();
            string name2 = Console.ReadLine();
            crono2.Stop();
            Console.WriteLine("Escriba una vez más:");
            crono3.Start();
            string name3 = Console.ReadLine();
            crono3.Stop();
            if (name1==name2&&name1==name3)
            {
                if (crono1.ElapsedMilliseconds<=crono2.ElapsedMilliseconds&&crono1.ElapsedMilliseconds<=crono3.ElapsedMilliseconds)
                {
                    Console.WriteLine("{0}, la vez que has tecleado más rápido ha sido la primera con {1} s.", name1, (crono1.ElapsedMilliseconds / 1000));
                }
                else if (crono1.ElapsedMilliseconds>=crono2.ElapsedMilliseconds&&crono2.ElapsedMilliseconds<=crono3.ElapsedMilliseconds)
                {
                    Console.WriteLine("{0}, la vez que has tecleado más rápido ha sido la segunda con {1} s.", name1, (crono2.ElapsedMilliseconds / 1000));
                }
                else
                {
                    Console.WriteLine("{0}, la vez que has tecleado más rápido ha sido la tercera con {1} s.", name1, (crono3.ElapsedMilliseconds / 1000));
                }
            }
            else
            {
                Console.WriteLine("ERROR el nombre no fue bien escrito las 3 veces, intente de nuevo.\n");
                Main(args);
            }
            
            #endregion

        }
    }
}
