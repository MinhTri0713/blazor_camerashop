using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraShop.Shared {
    public interface IMenuService {
        ValueTask<Menu> GetMenu();
    }
}

