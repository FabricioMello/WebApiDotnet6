using Newtonsoft.Json;
using System.Text;

namespace BackendAVMB.Rest
{
    public class ApiRestGlobal
    {
        public static async Task<string> requisicaoAsync(string json, string path)
        {
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var responseReal = await client.PostAsync("https://plataforma.astenassinatura.com.br/api/"+ path, data);
            return await responseReal.Content.ReadAsStringAsync();
        }
    }
}
