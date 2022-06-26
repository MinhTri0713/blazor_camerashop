using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace CameraShop.Shared {
    public class Camera {
        public Camera(int id, string name, decimal price,
        Lens lens) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Lens = lens;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Lens Lens { get; }
        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}