using System;
using System.Text;
using System.Globalization;
namespace HerançaPolimorfismo.Entitys
{
	class UsedProduct:Product
	{
		public DateTime Manufacture { get; set; }

		public UsedProduct() { }

		public UsedProduct(DateTime manufacture, string name, double price): base(name,price)
		{
			Manufacture = manufacture;
		}

		public override string PriceTag()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(Name);
			sb.Append("(used) $ ");
			sb.Append(Price.ToString("f2", CultureInfo.InvariantCulture));
			sb.Append(" (Manufacture date: " + Manufacture.ToString("dd/MM/yyyy"));
			return sb.ToString();

		}
	}
}
