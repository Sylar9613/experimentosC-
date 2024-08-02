using System;

namespace Fechas
{
	public class Fecha
	{
		public uint dia, mes, año;
        
		public Fecha(uint d, uint m, uint a)
		{
			if (m>0&&m<13)
				mes = m;
			año = a;
			if (d>0&&d<=DiaMes())
				dia = d;
			else
				throw new Exception("Dia Incorrecto");
		}

		public int DiaMes()
		{
			switch (mes)
			{
				case 4: case 6: case 9: case 11:
					return 30;
				case 2:
					if (Bisiesto())
						return 29;
					else 
						return 28;
				default:
					return 31;
			}
		}
		public bool Bisiesto()
		{
			return (año % 4==0);
		}
	}
}