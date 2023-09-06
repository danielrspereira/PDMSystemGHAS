using System.Text.Json.Serialization;

namespace PDMSystem
{
    internal class Objects
    {
        [JsonPropertyName("objects")]
        public Object[] Obj { get; set; }
    }
}
