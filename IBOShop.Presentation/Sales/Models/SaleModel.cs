using System;
namespace IBOShop.Presentation.Sales.Models
{
	public class SaleModel
	{
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
	}
}

