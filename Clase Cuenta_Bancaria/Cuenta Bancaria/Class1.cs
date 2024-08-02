using System;
using Fechas;
using Personas;
using CuentaBancarias;

namespace Bancos
{
	
	class Banco
	{
		
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("**%%%BANCO CENTRAL%%%**");
			Console.WriteLine("Datos del Propietario de la Cuenta:");
			Console.WriteLine("Nombre: ");
		    string nombre = Console.ReadLine();
			Console.WriteLine("Apellidos: ");
			string apellidos = Console.ReadLine();
			Console.WriteLine("Fecha de Nacimiento: ");
			Console.WriteLine("D�a: ");
			uint d = uint.Parse(Console.ReadLine());
			Console.WriteLine("Mes:");
			uint m = uint.Parse(Console.ReadLine()); 
			Console.WriteLine("A�o:");
			uint a = uint.Parse(Console.ReadLine());
			Console.WriteLine("Saldo a Depositar: ");
			uint saldo = uint.Parse(Console.ReadLine());
			Persona p = new Persona(nombre, apellidos, d, m, a);
			CuentaBancaria cuenta1 = new CuentaBancaria(p,saldo);
            Console.ReadLine();


		}
	}
}
