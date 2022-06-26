using System.Text.Json;

namespace CameraShop.Client {
    public static class DebuggingExtensions {
        private static JsonSerializerOptions options = new
        JsonSerializerOptions { WriteIndented = true };
        public static string ToJson(this object obj)
        => JsonSerializer.Serialize(obj, options);
    }
}
