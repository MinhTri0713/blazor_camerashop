using System.Net.Http.Json;
using CameraShop.Shared;
namespace CameraShop.Client.Services
{
    public class OrderService : IOrderService
    {
        public readonly HttpClient httpClient;
        public OrderService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask PlaceOrder(ShoppingBasket basket)
        {
            await httpClient.PostAsJsonAsync("/orders", basket);
        }
    }
}
