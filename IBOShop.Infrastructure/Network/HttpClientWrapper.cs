using System.Net.Http.Json;

namespace IBOShop.Infrastructure.Network
{
    public class HttpClientWrapper : IHttpClientWrapper{
        public void Post(string address, string data){
            using var client = new HttpClient();
            client.PostAsJsonAsync(address, data).Wait();
        }
    }
}