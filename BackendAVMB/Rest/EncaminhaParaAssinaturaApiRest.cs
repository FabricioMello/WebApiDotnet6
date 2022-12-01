using BackendAVMB.Dtos;
using BackendAVMB.Interfaces;
using BackendAVMB.Models;
using Newtonsoft.Json;
using System.Text;

namespace BackendAVMB.Rest
{
    public class EncaminharParaAssinaturaApiRest : IEncaminhaParaAssinaturaApi
    {
        public async Task<ResponseEncaminhaParaAssinatura.Root> EncaminhaParaAssinatura(EncaminhaParaAssinatura.Root encaminhaAssinatura)
        {
      
            var json = JsonConvert.SerializeObject(encaminhaAssinatura);
            var path = "encaminharEnvelopeParaAssinaturas";
            var jsonString = await ApiRestGlobal.requisicaoAsync(json, path);
            ResponseEncaminhaParaAssinatura.Root jsonObject = JsonConvert.DeserializeObject<ResponseEncaminhaParaAssinatura.Root>(jsonString);
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