namespace IBOShop.Infrastructure.Network
{
    public interface IHttpClientWrapper
    {
        void Post(string address, string data);
    }
}