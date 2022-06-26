using Microsoft.AspNetCore.Components;
using CameraShop.Shared;

namespace CameraShop.Client.Pages
{
    partial class ShoppingBasket
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Camera> GetCameraFromId { get; set; }
        = default!;
        private IEnumerable<(Camera camera, int pos)> Cameras { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet()
        {
            Cameras = Orders.Select((id, pos)
            => (camera: GetCameraFromId(id), pos: pos));
            TotalPrice = Cameras.Select(tuple
            => tuple.camera.Price).Sum();
        }
    }
}