using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraShop.Shared {
    public class Menu {
        public List<Camera> Cameras { get; set; }
            = new List<Camera>();
        public void Add(Camera camera)
            => Cameras.Add(camera);
        public Camera? GetCamera(int id)
            => Cameras.SingleOrDefault(camera => camera.Id == id);
    }
}
