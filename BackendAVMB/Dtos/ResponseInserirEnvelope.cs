using System.Text.Json.Serialization;

namespace BackendAVMB.Dtos
{
    public class ResponseInserirEnvelope
    {
        public class Aviso
        {
            [JsonPropertyName("tipo")]
            public string tipo { get; set; }

            [JsonPropertyName("mensagem")]
            public string mensagem { get; set; }
        }

        public class DadosSignatarioReenvio
        {
            [JsonPropertyName("nome")]
            public string nome { get; set; }

            [JsonPropertyName("email")]
            public string email { get; set; }

            [JsonPropertyName("celular")]
            public object celular { get; set; }

            [JsonPropertyName("linkAcesso")]
            public string linkAcesso { get; set; }
        }

        public class Data
        {
            [JsonPropertyName("idEnvelope")]
            public string idEnvelope { get; set; }

            [JsonPropertyName("hashSHA256")]
            public string hashSHA256 { get; set; }

            [JsonPropertyName("listaDadosSignatarios")]
            public ListaDadosSignatarios listaDadosSignatarios { get; set; }

            [JsonPropertyName("listaAvisos")]
            public ListaAvisos listaAvisos { get; set; }
        }

        public class ListaAvisos
        {
            [JsonPropertyName("aviso")]
            public Aviso aviso { get; set; }
        }

        public class ListaDadosSignatarios
        {
            [JsonPropertyName("DadosSignatarioReenvio")]
            public List<DadosSignatarioReenvio> DadosSignatarioReenvio { get; set; }
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
