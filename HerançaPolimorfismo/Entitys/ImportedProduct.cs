using System.Globalization;

namespace HerançaPolimorfismo.Entitys
{
	class ImportedProduct : Product
	{
		public double CustomsFee { get; set; }

		public ImportedProduct() { }

		public ImportedProduct(double customsFee, string name, double price) : base ( name, price)
		{
			CustomsFee = customsFee;
		}

		public double TotalPrice()
		{
			return Price + CustomsFee;
		}

		public override string PriceTag()
		{
			return base.PriceTag() + TotalPrice().ToString("f2",CultureInfo.InvariantCulture)+
				" (Customs fee:) $ " +
				CustomsFee.ToString("f2",CultureInfo.InvariantCulture);
		}
	}
}
