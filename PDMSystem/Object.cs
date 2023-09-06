using System.Text.Json.Serialization;

namespace PDMSystem
{
    public class Object
    {
        [JsonPropertyName("ident")]
        public string Ident { get; set; }

        [JsonPropertyName("z_index")]
        public string ZIndex { get; set; }

        [JsonPropertyName("output_folder")]
        public string OutputFolder { get; set; }

        [JsonPropertyName("extensions")]
        public string Extensions { get; set; }
    }
}
