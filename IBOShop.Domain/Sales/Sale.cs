using IBOShop.Domain.Common;

namespace IBOShop.Domain.Sales
{
    public class Sale : IEntity
    {
        private int _quantity;
        private decimal _totalPrice;
        private decimal _unitPrice;
        public int Id { get; set; }
        public DateTime date { get; set; }
        public Customer customer { get; set; }
        public Employee employee { get; set; }
        public Product product { get; set; }
        public decimal UnitPrice
        {
            get { return _unitPrice; };
            set { _unitPrice = value; UpdateTotalPrice(); }
        }
        public decimal Quantity
        {
            get { return _quantity; };
            set { _quantity = value; UpdateTotalPrice(); }
        }
        public decimal TotalPrice { get { return _totalPrice; }; set { _totalPrice = value; }; }
        private void UpdateTotalPrice()
        {
            _totalPrice = _unitPrice * _quantity;
        }
    }
}