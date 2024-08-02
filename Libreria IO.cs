using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntradaSalida
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TextWrite
            /*
            TextWriter texto = File.AppendText("prueba.txt");
            texto.WriteLine("kaka");
            texto.Close();
            */
            #endregion
            #region StreamWriter
            /*
            StreamWriter texto = File.AppendText("prueba.txt");
            texto.WriteLine("kaka");
            texto.Close();
             */
            #endregion
            #region Programa
            /*
            Console.WriteLine("Introduce el nombre que deseas registrar");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce el teléfono que deseas registrar");
            string telefono = Console.ReadLine();

            StreamWriter texto = File.AppendText("prueba.csv");  //El uso de separar por ; el nombre
            texto.WriteLine(nombre + ";" + telefono);  //y el telefono me permite q cualquier 
                                                      //programa q trabaje con Hoja de Calculo
                                                     //me los lea en columnas independientes
                                                    //en otros editores de texto puede ser en
                                                   //vez de ; la , o el .
            texto.Close();
            Console.WriteLine("Tu registro ha sido correctamente introducido en el archivo");            
            Console.ReadLine();
            */
            #endregion

            string a = "Arián";
            string b = "Viviana";
            string identificadorUnico = Guid.NewGuid().ToString();
            string identificadorUnico2 = Guid.NewGuid().ToString();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(a, identificadorUnico);
            dict.Add(b, identificadorUnico2);
            Console.WriteLine("Escriba su login\n");
            string lect1 = Console.ReadLine();
            Console.WriteLine("\nEscriba su contraseña\n");
            string lect2 = Console.ReadLine();
            if (lect1==dict[a]&&lect2==dict..Keys())
            {
                
            }
            

            /* string identificadorUnico = Guid.NewGuid().ToString();
            TextReader texto2 = new StreamReader("prueba.txt");//ReadLine() lee solo una linea,
            Console.WriteLine(texto2.ReadToEnd());      //ReadToEnd() lee hasta el final del doc.
            texto2.Close();
            Console.ReadLine();
            */
        }
    }
}
