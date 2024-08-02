using System;
using Fechas;

namespace Personas
{

	public class Persona
	{
		public string nombre, apellidos;
		public Fecha fechaNacimiento;

		public Persona(string unNombre, string unApellido, Fecha unaFecha)
		{
			nombre = unNombre;
			apellidos = unApellido;
			fechaNacimiento = unaFecha;
		}

		public Persona(string unNombre, string unApellido, uint d, uint m, uint a)
			: this(unNombre, unApellido, new Fecha(d, m, a))

		{
        }
		public long Edad()
		{
			return DateTime.Now.Year - fechaNacimiento.año;
		}

	}
}
