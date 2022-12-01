using System.Text.Json.Serialization;

namespace BackendAVMB.Models
{
    public class InsereEnvelopeModel
    {
        public class ConfigAuxiliar
        {
            [JsonPropertyName("documentosComXMLs")]
            public string documentosComXMLs { get; set; }
        }

        public class Documento
        {
            [JsonPropertyName("nomeArquivo")]
            public string nomeArquivo { get; set; }

            [JsonPropertyName("mimeType")]
            public string mimeType { get; set; }

            [JsonPropertyName("conteudo")]
            public string conteudo { get; set; }
        }

        public class Envelope
        {
            [JsonPropertyName("descricao")]
            public string descricao { get; set; }

            [JsonPropertyName("Repositorio")]
            public Repositorio Repositorio { get; set; }

            [JsonPropertyName("usarOrdem")]
            public string usarOrdem { get; set; }

            [JsonPropertyName("ConfigAuxiliar")]
            public ConfigAuxiliar ConfigAuxiliar { get; set; }

            [JsonPropertyName("listaDocumentos")]
            public ListaDocumentos listaDocumentos { get; set; }

            [JsonPropertyName("listaSignatariosEnvelope")]
            public ListaSignatariosEnvelope listaSignatariosEnvelope { get; set; }

            [JsonPropertyName("listaObservadores")]
            public ListaObservadores listaObservadores { get; set; }

            [JsonPropertyName("listaTags")]
            public ListaTags listaTags { get; set; }

            [JsonPropertyName("listaInfoAdicional")]
            public ListaInfoAdicional listaInfoAdicional { get; set; }

            [JsonPropertyName("incluirHashTodasPaginas")]
            public string incluirHashTodasPaginas { get; set; }

            [JsonPropertyName("permitirDespachos")]
            public string permitirDespachos { get; set; }

            [JsonPropertyName("ignorarNotificacoes")]
            public string ignorarNotificacoes { get; set; }

            [JsonPropertyName("ignorarNotificacoesPendentes")]
            public string ignorarNotificacoesPendentes { get; set; }
        }

        public class ListaDocumentos
        {
            [JsonPropertyName("Documento")]
            public List<Documento> Documento { get; set; }
        }

        public class ListaInfoAdicional
        {
            [JsonPropertyName("InfoAdicional")]
            public List<object> InfoAdicional { get; set; }
        }

        public class ListaObservadores
        {
            [JsonPropertyName("Observador")]
            public List<object> Observador { get; set; }
        }

        public class ListaSignatariosEnvelope
        {
            [JsonPropertyName("SignatarioEnvelope")]
            public List<object> SignatarioEnvelope { get; set; }
        }

        public class ListaTags
        {
            [JsonPropertyName("Tag")]
            public List<object> Tag { get; set; }
        }

        public class Params
        {
            [JsonPropertyName("Envelope")]
            public Envelope Envelope { get; set; }

            [JsonPropertyName("gerarTags")]
            public string gerarTags { get; set; }

            [JsonPropertyName("encaminharImediatamente")]
            public string encaminharImediatamente { get; set; }

            [JsonPropertyName("detectarCampos")]
            public string detectarCampos { get; set; }
        }

        public class Repositorio
        {
            [JsonPropertyName("id")]
            public int? id { get; set; }
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
