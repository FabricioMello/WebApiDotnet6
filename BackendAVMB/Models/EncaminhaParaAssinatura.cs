using System.Text.Json.Serialization;

namespace BackendAVMB.Models
{
    public class EncaminhaParaAssinatura
    {
        public class Envelope
        {
            [JsonPropertyName("id")]
            public int? id { get; set; }
        }

        public class Params
        {
            [JsonPropertyName("Envelope")]
            public Envelope Envelope { get; set; }

            [JsonPropertyName("agendarEnvio")]
            public string agendarEnvio { get; set; }

            [JsonPropertyName("detectarCampos")]
            public string detectarCampos { get; set; }

            [JsonPropertyName("dataEnvioAgendado")]
            public string? dataEnvioAgendado { get; set; }

            [JsonPropertyName("horaEnvioAgendado")]
            public string? horaEnvioAgendado { get; set; }
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
