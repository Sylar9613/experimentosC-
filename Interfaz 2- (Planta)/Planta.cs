using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Planta
    {
        #region Parámetros y propiedades
        private string nombreComun;
        private string nombreCientifico;

        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }

        private string tipoFruto;

        public string TipoFruto
        {
            get { return tipoFruto; }
            set { tipoFruto = value; }
        }

        private double altura;
        public double Altura { get; set; }

#endregion

        public Planta(string nCom, string nCient, string tF, double a)
        {
            nombreComun = nCom;
            nombreCientifico = nCient;
            tipoFruto = tF;
            altura = a;
        }

        public string Clasif()
        {
            if (Altura > 5)
            {
                return "Arbol";
            }
            else if (Altura <= 5 && Altura >= 2)
                return "Arbusto";
            else
                return "Hierba";
        }
    }
}
