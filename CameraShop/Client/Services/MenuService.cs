using CameraShop.Shared;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
namespace CameraShop.Client.Services {
    public class MenuService : IMenuService {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
        public async ValueTask<Menu> GetMenu() {
            var cameras = await httpClient
                .GetFromJsonAsync<Camera[]>("/cameras");
            return new Menu { Cameras = cameras!.ToList() };
        }
    }
}