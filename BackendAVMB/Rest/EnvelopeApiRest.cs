using BackendAVMB.Dtos;
using BackendAVMB.Interfaces;
using BackendAVMB.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace BackendAVMB.Rest
{
    public class EnvelopeApiRest : IEnvelopeApi
    {
        public async Task<ResponseInserirEnvelope.Root> InserirEnvelope(InsereEnvelopeModel.Root envelope)
        {
            var json = JsonConvert.SerializeObject(envelope);
            var path = "inserirEnvelope";
            var jsonString = await ApiRestGlobal.requisicaoAsync(json, path);

            ResponseInserirEnvelope.Root jsonObject = JsonConvert.DeserializeObject<ResponseInserirEnvelope.Root>(jsonString);
            if (jsonObject.response != null)
            {
                return jsonObject;
            }
            else
            {
                ResponseError jsonErro = JsonConvert.DeserializeObject<ResponseError>(jsonString);
                throw new Exception(jsonErro.error);
            }
        }

    }
}