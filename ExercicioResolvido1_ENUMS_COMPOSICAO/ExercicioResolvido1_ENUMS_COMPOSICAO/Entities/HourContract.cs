using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido1_ENUMS_COMPOSICAO.Entities
{
	internal class HourContract
	{
		public DateTime Date { get; set; }
		public Double ValuePerHour { get; private set; }
        public int Hours { get; set; }

		public HourContract() { 
		}

		public HourContract(DateTime date, double valuePerHour, int hours)
		{
			Date = date;
			ValuePerHour = valuePerHour;
			Hours = hours;
		}

		public double TotalValue()
		{
			return Hours * ValuePerHour;
		}
	}
}
