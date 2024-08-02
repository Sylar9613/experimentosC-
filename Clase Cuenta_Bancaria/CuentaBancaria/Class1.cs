using System;
using Personas;
using Fechas;

namespace CuentaBancarias
{
	
	public class CuentaBancaria
	{
		public Persona propietario;
		public double saldo;
		public static double saldoMinimo=50;
		public Fecha fechaCreacion;
		public double cifra;

		public CuentaBancaria(Persona unaPersona, double unSaldo)
		{
			propietario = unaPersona;
			saldo = unSaldo;
			uint dia = (uint)DateTime.Now.Day;
			uint mes = (uint)DateTime.Now.Month;
			uint año = (uint)DateTime.Now.Year;
			fechaCreacion = new Fecha(dia, mes, año);
        }

		public void Depositar()
		{
			
			if (cifra>0)
				saldo += cifra;
			else 
				throw new Exception("Error");


		}
		public void Extraer()
		{
			if (saldo - cifra >= saldoMinimo)
				saldo -= cifra;
			else 
				throw new Exception("No se Puede Realizar la Operacion");

		}
	}
}
