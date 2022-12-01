using System.Text.Json.Serialization;

namespace BackendAVMB.Dtos
{
    public class ResponseGetDadosEnvelope
    {
        public class Repositorio
        {
            [JsonPropertyName("id")]
            public string id { get; set; }
        }

        public class Response
        {
            [JsonPropertyName("id")]
            public string id { get; set; }

            [JsonPropertyName("Repositorio")]
            public Repositorio Repositorio { get; set; }

            [JsonPropertyName("Usuario")]
            public Usuario Usuario { get; set; }

            [JsonPropertyName("descricao")]
            public string descricao { get; set; }

            [JsonPropertyName("conteudo")]
            public string conteudo { get; set; }

            [JsonPropertyName("incluirHashTodasPaginas")]
            public string incluirHashTodasPaginas { get; set; }

            [JsonPropertyName("permitirDespachos")]
            public string permitirDespachos { get; set; }

            [JsonPropertyName("usarOrdem")]
            public string usarOrdem { get; set; }

            [JsonPropertyName("hashSHA256")]
            public string hashSHA256 { get; set; }

            [JsonPropertyName("hashSHA512")]
            public string hashSHA512 { get; set; }

            [JsonPropertyName("mensagem")]
            public string mensagem { get; set; }

            [JsonPropertyName("mensagemObservadores")]
            public string mensagemObservadores { get; set; }

            [JsonPropertyName("motivoCancelamento")]
            public string motivoCancelamento { get; set; }

            [JsonPropertyName("numeroPaginas")]
            public string numeroPaginas { get; set; }

            [JsonPropertyName("status")]
            public string status { get; set; }

            [JsonPropertyName("dataHoraCriacao")]
            public DateTime? dataHoraCriacao { get; set; }

            [JsonPropertyName("dataHoraAlteracao")]
            public DateTime? dataHoraAlteracao { get; set; }

            [JsonPropertyName("objetoContrato")]
            public string objetoContrato { get; set; }

            [JsonPropertyName("statusContrato")]
            public string statusContrato { get; set; }

            [JsonPropertyName("numContrato")]
            public string numContrato { get; set; }

            [JsonPropertyName("descricaoContratante")]
            public string descricaoContratante { get; set; }

            [JsonPropertyName("descricaoContratado")]
            public string descricaoContratado { get; set; }

            [JsonPropertyName("Envelope")]
            public string Envelope { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("response")]
            public Response response { get; set; }
        }

        public class Usuario
        {
            [JsonPropertyName("id")]
            public string id { get; set; }
        }


    }
}
