using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimentos_de_C_Sharp
{
    class Program
    {
        public static void TablaMultiplicacion(long number, long end)
        {
            Console.WriteLine();
            for (int i = 0; i <= end; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
            Console.WriteLine();
        }

        public static bool Prime(int number)
        {
            int divider = 2;
            if (number == 1) return false;
            while (number % divider != 0)
                divider++;
            return divider == number ? true : false;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine( Microsoft.CSharp.CSharpCodeProvider.GetAllCompilerInfo());
            //Console.WriteLine(Microsoft.CSharp.CSharpCodeProvider.IsDefinedLanguage("VisualBasic"));
            //Console.WriteLine(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException.Equals("raja","raja"));
            #region Region 1 multiplicacion
            /*
            int number1, number2, multiplication;
            Console.WriteLine("Enter 1st number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            number2 = Convert.ToInt32(Console.ReadLine());
            //multiplication = number1 * number2;
            //Console.WriteLine("The multiplication is: {0}", multiplication);
            TablaMultiplicacion(number1, number2);
             * */
            #endregion 

            #region Region 2 continue & break
            /*
            for (int i = 10; i <= 20; i+=2)
            {
                if (i==16)
                    continue;
                Console.WriteLine(i);
            }
            for (int i = 10; i <= 20; i++)
            {
                if (i == 16 || i % 2 != 0)
                    continue;
                Console.WriteLine(i);
            }
            for (int i = 10; ; i+=2)
            {
                if (i == 16)
                    continue;
                if (i > 20)
                    break;
                Console.WriteLine(i);
            }
             * */
            #endregion

            #region Region 3 operador conditional
            /*
            int age;
            Console.WriteLine("Enter your age :");
            age = Convert.ToInt32(Console.ReadLine());
            bool capslock = Console.CapsLock;
            Console.Clear();
            Console.WriteLine(age > 20 ? "You are older" : "You are younger");
            Console.WriteLine(capslock ? "The Caps Lock button is on" : "The Caps Lock button is off");
            Console.ReadKey();
            */

            /*
             * int amount;

            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            if ((a > 0) && (b > 0))
                amount = 2;
            else
            {
                if ((a > 0) || (b > 0))
                    amount = 1;
                else
                    amount = 0;
            }

            Console.WriteLine("{0}", amount);

            amount = ((a > 0) && (b > 0)) ? 2 : ((a > 0) || (b > 0)) ? 1 : 0;
            Console.WriteLine("{0} positives.", amount);
             */
            #endregion

            #region Region 4 primes
            /*
            int primo = int.Parse(Console.ReadLine());
            for (int i = 0; i <= primo; i++)
            {
                if (!Prime(i))
                    continue;
                Console.Write(i + " ");
            }
            Console.WriteLine();
             */
            #endregion

            #region Region 5 password
            /*
            string user, pass;
            int count = 0;
            do
            {
                Console.WriteLine("Enter username: ");
                user = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                pass = Console.ReadLine();
                count++;
            } while ((user != "user" || pass != "password") && (count != 5));

            if (count == 5)
                Console.WriteLine("Login attemp fail!");
            else
                Console.WriteLine("Password correct!");
             */
            #endregion

            #region Region 6 piramide
            /*
            Console.Write("Enter a number: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the desired width: "); int width = int.Parse(Console.ReadLine());
            Console.Write("Enter 1 or 2 for the used method: "); int method = int.Parse(Console.ReadLine());
            int height = width;
            if (method == 1)
            {
                for (int row = 0; row < height; row++)
                {
                    for (int column = 0; column < width; column++)
                    {
                        Console.Write(n);
                    }
                    Console.WriteLine(); width--;
                }
            }
            else
            {
                for (int row = 1; row < height; row++)
                {
                    for (int column = 1; column <= row; column++)
                    {
                        Console.Write(n);
                    }
                    Console.WriteLine();
                }
            }
            */
            #endregion

            #region Region 7 escapesequence
            /*
            int a = 12;
            Console.WriteLine("\\Welcome\\");
            Console.WriteLine("\'Welcome\'");
            Console.WriteLine("\"Welcome\"");
            Console.WriteLine("\a Alert Sound");
            Console.WriteLine("Welcome\b\b\b \b ");
            Console.WriteLine("\fFormfeed \ra ");
            Console.WriteLine("Hexa DecimalValue is {0:x}",a);
             */
            #endregion

            #region Region 8 strings
            DateTime waiting = new DateTime(2017, 3, 13, 20, 59, 5);
            Console.WriteLine(String.Format("Message sent at {0:t} on {0:D}",waiting));
            int a = String.Compare("culo", "cul");
            string[] r = new string[] { "Viviana", "por favor", "te pido", "un beso" };
            Console.WriteLine(a);
            Console.WriteLine(String.Join("\n",r));
            #endregion
        }
    }
}
