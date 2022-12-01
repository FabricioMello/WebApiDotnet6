using BackendAVMB.Dtos;
using BackendAVMB.Interfaces;
using BackendAVMB.Models;
using Newtonsoft.Json;
using System.Text;

namespace BackendAVMB.Rest
{
    public class GetDadosApiRest : IGetDadosEnvelope
    {
        public async Task<ResponseGetDadosEnvelope.Root> GetDadosEnvelope(GetDadosEnvelopeModel.Root getDados)
        {
            try
            {
                var json = JsonConvert.SerializeObject(getDados);
                var path = "getDadosEnvelope";
                var jsonString = await ApiRestGlobal.requisicaoAsync(json, path);

                ResponseGetDadosEnvelope.Root jsonObject = JsonConvert.DeserializeObject<ResponseGetDadosEnvelope.Root>(jsonString);
                if (jsonObject.response != null)
                {
                    return jsonObject;
                }
                else
                {
                    ResponseError jsonErro = JsonConvert.DeserializeObject<ResponseError>(jsonString);
                    throw new Exception(jsonErro.error);
                }

            } catch
            {
                throw new Exception("Erro ao buscar dados do Envelope.");
            }
        }  
        

    }
}