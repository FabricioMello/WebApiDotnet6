using System.Text.Json.Serialization;

namespace BackendAVMB.Dtos
{
    public class ResponseError
    {
        [JsonPropertyName("error")]
        public string error { get; set; }
    }
}
