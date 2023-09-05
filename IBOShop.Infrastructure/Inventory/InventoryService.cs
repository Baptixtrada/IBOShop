using IBOShop.Application.Interfaces;
using IBOShop.Infrastructure.Network;

namespace IBOShop.Infrastructure.Inventory
{
    public class InventoryService : IInventoryService
    {
        private const string AddressTemplate = "http://abc123.com/inventory/products/{0}/notifysaleoccured/";
        private const string DataTemplate = "{{\"quantity\": {0}}}";
        private IHttpClientWrapper? _client;

        public void NotifySaleOccured(int productId, int quantity)
        {
            var address = string.Format(AddressTemplate, productId);
            var data = string.Format(DataTemplate, quantity);
            _client = new HttpClientWrapper();
            _client.Post(address, data);
        }
    }
}