using System.Text.Json.Serialization;

namespace Lecture10.Shared
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Female,
        Male,
        Other
    }
}
