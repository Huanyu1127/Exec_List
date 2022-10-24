using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Exec_List
{//宣告一個 List<Product> 變數, 存放多筆購買商品
	internal class Program
	{
		static void Main(string[] args)
		{
			
			List<Product> list2 = new List<Product>()
			{
				new Product(){Id="123",Buyer="小紅"},
				new Product(){Id="456",Buyer="小藍"},
			};

			Product product = new Product() { Id = "666", Buyer = "小魚" };
			list2.Add(product);

			foreach (Product all in list2) //list2有三個值依序放入Product all內 並依序跑圈
			{
				Console.WriteLine(all.Id + all.Buyer);		
			}
			Console.WriteLine();
			for(int n = 0; n < list2.Count; n++)
			{
				Console.WriteLine(list2[n].Id + list2[n].Buyer);
			}

			Console.WriteLine(list2.Count);//3

			//constructer
			List<Product1> list = new List<Product1>() {
			new Product1("牙膏", 1, 20),
			new Product1("沐浴乳", 2, 200),
			new Product1("洗髮精", 3, 500), };
		}
	}
	class Product
	{
		public string Id { get; set; }
		public string Buyer { get; set; }
	}
	class Product1 //constructer
	{
		public string Name;
		public int Count;
		public decimal Price;
		public int ttt { get; set; }
		public Product1(string name, int count, decimal price)
		{

			Name = name;
			Count = count;
			Price = price;
		}
	}
}
