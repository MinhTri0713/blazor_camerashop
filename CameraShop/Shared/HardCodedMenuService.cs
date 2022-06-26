using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraShop.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Cameras = new List<Camera> {
                    new Camera(1, "Chân dung", 8.99M, Lens.portrait),
                    new Camera(2, "Toàn cảnh", 7.99M, Lens.overview),
                    new Camera(3, "Cận cảnh", 9.99M, Lens.macro)
                }
             });
    }
}

