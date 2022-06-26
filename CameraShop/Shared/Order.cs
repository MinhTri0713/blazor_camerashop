using System.Collections.Generic;
namespace CameraShop.Shared {
    public class Order {
        public int Id { get; set; }
        public Customer Customer { get; set; } = default!;
        public ICollection<Camera> Cameras { get; set; } = default!;
    }
}