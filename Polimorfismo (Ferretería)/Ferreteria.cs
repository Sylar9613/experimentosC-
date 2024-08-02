using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Practica
{
    public class Ferreteria
    {
        private Utensilio[] utensilios;

        public Ferreteria(Utensilio[] u)
        {
            utensilios = new Utensilio[u.Length];
            u.CopyTo(utensilios, 0);
            /*
            for (int i = 0; i < u.Length; i++)
            {
                utensilios[i] = u[i];
            }*/
        }
        /// <summary>
        /// Calcular el monto total de la ferreteria a partir del Precio de Venta de cada utensilio
        /// </summary>
        /// <returns>double</returns>
        public double MontoTotal()
        {
            double result = 0;
            foreach (var utensilio in utensilios)
            {
                result += utensilio.PV();
            }
            return result;
        }

        public bool Existe(string n)
        {
            foreach (var u in utensilios)
            {
                if (u.Nombre == n) return true;
            }
            return false;
        }
        public double GananciaNOm(string n)
        {
            foreach (var u in utensilios)
            {
                if (u.Nombre == n) return u.Ganancia();
            }
            return 0.00;
        }

        public int CantMat(string n)
        {
            int cont = 0;
            foreach (var u in utensilios)
            {
                if ((u is Plomeria) && (u as Plomeria).Material == n)
                    cont++;
            }
            return cont;
        }

    }

    public abstract class Utensilio
    {
        private string nombre;
        private double preciocosto;
        private bool ocioso;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Preciocosto
        {
            get { return preciocosto; }
            set { preciocosto = value; }
        }

        public bool Ocioso
        {
            get { return ocioso; }
            set { ocioso = value; }
        }

        public Utensilio(string n, double pc, bool o)
        {
            nombre = n;
            preciocosto = pc;
            ocioso = o;
        }

        public abstract double Ganancia();

        public double PV()
        {
            return preciocosto + Ganancia();
        }
    }

    public class Construccion : Utensilio
    {
        public uint Vida { get; set; }

        public Construccion(string n, double pc, bool ocioso,
            uint v)
            : base(n, pc, ocioso)
        {
            Vida = v;
        }

        public override double Ganancia()
        {
            return Preciocosto * 0.25;
        }
    }
    public class Plomeria : Utensilio
    {
        public double Diametro { get; set; }
        public string Material { get; set; }

        public Plomeria(string n, double pc, bool ocioso,
            double d, string m)
            : base(n, pc, ocioso)
        {
            Diametro = d;
            Material = m;
        }

        public override double Ganancia()
        {
            return Preciocosto * 0.75;
        }
    }

    public class Mecanica : Utensilio
    {
        public string Numeracion { get; set; }

        public Mecanica(string n, double pc, bool ocioso,
           string num)
            : base(n, pc, ocioso)
        {
            Numeracion = num;
        }

        public override double Ganancia()
        {
            return Preciocosto * 0.55;
        }
    }
}
