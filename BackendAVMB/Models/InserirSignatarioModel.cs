using System.Text.Json.Serialization;

namespace BackendAVMB.Models
{
    public class InserirSignatarioModel
    {
        public class Root
        {
            [JsonPropertyName("token")]
            public string token { get; set; }

            [JsonPropertyName("params")]
            public Params @params { get; set; }
        }
        public class ConfigAssinatura
        {
            [JsonPropertyName("emailSignatario")]
            public string emailSignatario { get; set; }

            [JsonPropertyName("nomeSignatario")]
            public string nomeSignatario { get; set; }

            [JsonPropertyName("tipoAssinatura")]
            public int? tipoAssinatura { get; set; }

            [JsonPropertyName("permitirDelegar")]
            public string permitirDelegar { get; set; }

            [JsonPropertyName("apenasCelular")]
            public string apenasCelular { get; set; }

            [JsonPropertyName("exigirLogin")]
            public string exigirLogin { get; set; }

            [JsonPropertyName("exigirCodigo")]
            public string exigirCodigo { get; set; }

            [JsonPropertyName("exigirDadosIdentif")]
            public string exigirDadosIdentif { get; set; }

            [JsonPropertyName("assinaturaPresencial")]
            public string assinaturaPresencial { get; set; }

            [JsonPropertyName("ignorarRecusa")]
            public string ignorarRecusa { get; set; }

            [JsonPropertyName("incluirImagensAutentEnvelope")]
            public string incluirImagensAutentEnvelope { get; set; }

            [JsonPropertyName("analisarFaceImagem")]
            public string analisarFaceImagem { get; set; }

            [JsonPropertyName("percentualPrecisaoFace")]
            public int? percentualPrecisaoFace { get; set; }
        }

        public class Envelope
        {
            [JsonPropertyName("id")]
            public int? id { get; set; }
        }

        public class Params
        {
            [JsonPropertyName("SignatarioEnvelope")]
            public SignatarioEnvelope SignatarioEnvelope { get; set; }
        }

        

        public class SignatarioEnvelope
        {
            [JsonPropertyName("Envelope")]
            public Envelope Envelope { get; set; }

            [JsonPropertyName("ordem")]
            public int? ordem { get; set; }

            [JsonPropertyName("ConfigAssinatura")]
            public ConfigAssinatura ConfigAssinatura { get; set; }
        }


    }
}
