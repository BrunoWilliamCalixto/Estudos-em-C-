using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto_Heranca_Polimorfismo.Entities
{
	internal sealed class ImportedProduct : Product
	{
		public double CustomsFee { get; private set; }

		public ImportedProduct() { }

		public ImportedProduct(string name, double price, double customsFee) : base(name, price)
		{
			CustomsFee = customsFee;
		}

		public sealed override string PriceTag()
		{
			Price += CustomsFee;
			return base.PriceTag() + $" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
			
		}
	}
}
