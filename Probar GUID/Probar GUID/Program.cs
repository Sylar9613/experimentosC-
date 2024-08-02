using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Probar_GUID
{
    class Program
    {
        static string indUnico1 = Guid.NewGuid().ToString();
        
        static void Main(string[] args)
        {
            int contad = 1;
            
            #region Para hacer un contador q se guarda en un *.txt
            try
            {                
                StreamReader lectCont = new StreamReader("contador.txt");
                string lee = lectCont.ReadLine();
                lectCont.Close();
                contad = int.Parse(lee);
                contad++;
                StreamWriter cont = File.CreateText("contador.txt");
                cont.WriteLine(contad);
                cont.Close();
            }        
            catch(Exception m)
            {
                throw new Exception(m.Message);
            }
            #endregion

            #region Para verificar q se acepte un login con un password
            /**/
            try
            {
                Console.WriteLine("Para insertar un nuevo miembro pulse 1, \npara escribir su usuario y contraseña pulse 2");
                int pulse = int.Parse(Console.ReadLine());
                if (pulse == 1)
                {
                    Console.WriteLine("Inserte su login:");
                    string login = Console.ReadLine();
                    Console.WriteLine("\nInserte su password:");
                    string password = Console.ReadLine(); Console.WriteLine();
                    StreamWriter d = File.AppendText(login + ".csv");
                    d.WriteLine(login + ";" + password + ";" + indUnico1);
                    d.Close();
                }
                else
                {

                    Console.WriteLine("Inserte su login:");
                    string login = Console.ReadLine();

                    if (File.Exists(login + ".csv"))
                    {
                        Console.WriteLine("\nInserte su password:");
                        string password = Console.ReadLine(); Console.WriteLine();
                        StreamReader read = new StreamReader(login + ".csv");
                        string[] lec = read.ReadLine().Split(';');
                        if (password == lec[1])
                        {
                            Console.WriteLine("Ha entrado al sistema.\n");
                        }
                        else
                        {
                            Console.WriteLine("Ha escrito incorrectamente su contraseña.\n");
                            Main(args);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Su usuario no existe");
                    }
                }
                Console.ReadKey();
            }
            catch(Exception m)
            {
                throw new Exception(m.Message);
     
            }
            /**/
            #endregion
        }
    }
}
