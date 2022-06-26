using Microsoft.AspNetCore.Components;
using CameraShop.Shared;

namespace CameraShop.Client.Pages
{
    partial class CameraList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Camera> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Camera> Selected { get; set; }
    }
}
