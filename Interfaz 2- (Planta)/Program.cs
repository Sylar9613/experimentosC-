using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Planta p = new Papa("Papa", "Colisioum ramadae", "carnoso", 0.3, "placita", true);
            Console.WriteLine(p);
        }
    }
}
