using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido_Herança_Polimorfismo.Entities
{
	internal class OutSourcedEmployee : Employee
	{
		public double AdditionalCharge { get; set; }
		
		public OutSourcedEmployee() 
		{
		}

		public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
		{
			AdditionalCharge = additionalCharge;
		}

		public override double Payment()
		{
			return base.Payment() + AdditionalCharge;

		}
	}
}
