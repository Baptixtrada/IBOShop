using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;

namespace IBOShop.Domain.Sales
{
    public class Sale : ISale
    {
        private int _quantity;
        private decimal _totalPrice;
        private decimal _unitPrice;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer? Customer { get; set; }
        public Employee? Employee { get; set; }
        public Product? Product { get; set; }
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; UpdateTotalPrice(); }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; UpdateTotalPrice(); }
        }
        public decimal TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }
        private void UpdateTotalPrice()
        {
            _totalPrice = _unitPrice * _quantity;
        }
    }
}