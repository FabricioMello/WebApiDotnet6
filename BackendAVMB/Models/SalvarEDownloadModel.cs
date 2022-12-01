using System.Text.Json.Serialization;

namespace BackendAVMB.Models
{
    public class SalvarEDownloadModel
    {
        public class Params
        {
            [JsonPropertyName("idEnvelope")]
            public int? idEnvelope { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("token")]
            public string token { get; set; }

            [JsonPropertyName("params")]
            public Params @params { get; set; }
        }


    }
}
