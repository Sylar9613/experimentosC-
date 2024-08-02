using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// Clase genérica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj) { data[position++] = obj; }
        public T Pop() { return data[--position]; }
    }


    #region FeetToInches
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(100));
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }*/
    #endregion

    #region Funciones recursivas
    /*class Program
    {
        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int MCD(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return MCD(y, x % y);
        }

        static void Binario(int n)
        {
            if (n >= 2)
            {
                Binario(n / 2);
                Console.WriteLine(n % 2);
            }
            else
                Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(13));
            Console.WriteLine(Fibonacci(9));
            Console.WriteLine(MCD(100, 35));
            Binario(13);
        }        
    }*/
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de como instanciar tipos de datos genéricos
            //Dictionary<int, string> myDic = new Dictionary<int, string>();
            //var myDic = new Dictionary<int, string>();
            Stack<int> stack = new Stack<int>();
            int primero = int.Parse(Console.ReadLine());
            int segundo = int.Parse(Console.ReadLine());
            stack.Push(primero);
            stack.Push(segundo);
            //stack.Push(5);
            //stack.Push(10);
            int x = stack.Pop(); // x is 10
            int y = stack.Pop(); // y is 5
            Console.WriteLine("\n" + x + " " + y);
        }
    }
}
