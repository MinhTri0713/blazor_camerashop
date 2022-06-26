using Microsoft.AspNetCore.Components;
using CameraShop.Shared;

namespace CameraShop.Client.Pages
{
    partial class CameraItem
    {
        [Parameter]
        public Camera Camera { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Camera> Selected { get; set; }
        private string lensImage(Lens lens)
        => $"images/{lens.ToString().ToLower()}.png";
    }
}
