using HerançaPolimorfismo.Entitys;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerançaPolimorfismo
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the number of products: ");
			int prod = int.Parse(Console.ReadLine());

			List<Product> produtos = new List<Product>();

			for (int i = 1; i <= prod; i++)
			{
				Console.WriteLine("Product #" + i + " data:");
				Console.Write("Common, used or imported? ");
				char status = char.Parse(Console.ReadLine().ToUpper());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Price: ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (status == 'C')
				{
					produtos.Add(new Product(name, price));
				}
				else if (status == 'U')
				{
					Console.Write("Manufacture date (DD/MM/YYYY): ");
					DateTime date = DateTime.Parse(Console.ReadLine());
					produtos.Add(new UsedProduct(date, name, price));
				}
				else
				{
					Console.Write("Customs fee: ");
					double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					produtos.Add(new ImportedProduct(customsfee, name, price));
				}			
			}
			Console.WriteLine();
			Console.WriteLine("PRICE TAGS:");
			foreach (Product obj in produtos)
			{
				Console.WriteLine(obj.PriceTag());
			}
		}
	}
}
