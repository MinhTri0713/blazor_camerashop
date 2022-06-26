using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CameraShop.Shared;
using System.Linq;
namespace CameraShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly CameraShopDbContext db;
        public OrdersController(CameraShopDbContext db)
        {
            this.db = db;
        }
        [HttpPost("/orders")]
        public IActionResult InsertOrder([FromBody] ShoppingBasket basket)
        {
            Order order = new Order();
            order.Customer = basket.Customer;
            order.Cameras = new List<Camera>();
            foreach (int cameraId in basket.Orders)
            {
                var camera = db.Cameras.Single(p => p.Id == cameraId);
            }
            db.Orders.Add(order);
            db.SaveChanges();
            return Created("/orders", order.Id);
        }
    }
}
