using System.Text.Json;
using dashboard.Application.Interfaces.Serialization.Options;

namespace dashboard.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}