using BackendAVMB.Dtos;
using BackendAVMB.Interfaces;
using BackendAVMB.Models;
using Newtonsoft.Json;
using System.Text;

namespace BackendAVMB.Rest
{
    public class SignatarioApiRest : ISignatarioApi
    {
        public async Task<ResponseInsereSignatario.Root> InserirSignatario(InserirSignatarioModel.Root envelope)
        {
            var json = JsonConvert.SerializeObject(envelope);
            var path = "inserirSignatarioEnvelope";
            var jsonString = await ApiRestGlobal.requisicaoAsync(json, path);

            ResponseInsereSignatario.Root jsonObject = JsonConvert.DeserializeObject<ResponseInsereSignatario.Root>(jsonString);
            return jsonObject;
        }

    }
}