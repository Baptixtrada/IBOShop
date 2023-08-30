namespace IBOShop.Application.Interfaces
{
    public interface IInventoryService{
        public void NotifySaleOccured(int productId, int quantity);
    }
}