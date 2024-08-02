using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Papa : Planta,ICultivada,IPlantasAlimenticias
    {
        string destino;
        bool coccion;
        
        public string Destino { get; set; }

        public bool Coccion { get; set; }

        public Papa(string nCom, string nCient, string tF, double a,string destino,
        bool coccion)
            : base(nCom, nCient, tF, a)
        {
            this.destino = destino;
            this.coccion = coccion;
        }

               
    }
}
