using System.Text.Json.Serialization;

namespace BackendAVMB.Dtos
{
    public class ResponseSalvarEDownload
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Response
        {
            [JsonPropertyName("envelopeContent")]
            public string envelopeContent { get; set; }

            [JsonPropertyName("nomeArquivo")]
            public string nomeArquivo { get; set; }

            [JsonPropertyName("mimeType")]
            public string mimeType { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("response")]
            public Response response { get; set; }
        }


    }
}
