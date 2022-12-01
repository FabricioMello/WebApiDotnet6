using System.Text.Json.Serialization;

namespace BackendAVMB.Dtos
{
    public class ResponseEncaminhaParaAssinatura
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Aviso
        {
            [JsonPropertyName("tipo")]
            public string tipo { get; set; }

            [JsonPropertyName("mensagem")]
            public string mensagem { get; set; }
        }

        public class Data
        {
            [JsonPropertyName("xmlns")]
            public string xmlns { get; set; }

            [JsonPropertyName("listaAvisos")]
            public ListaAvisos listaAvisos { get; set; }
        }

        public class ListaAvisos
        {
            [JsonPropertyName("aviso")]
            public Aviso aviso { get; set; }
        }

        public class Response
        {
            [JsonPropertyName("mensagem")]
            public string mensagem { get; set; }

            [JsonPropertyName("data")]
            public Data data { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("response")]
            public Response response { get; set; }
        }


    }
}
