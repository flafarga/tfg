
using dashboard.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace dashboard.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}