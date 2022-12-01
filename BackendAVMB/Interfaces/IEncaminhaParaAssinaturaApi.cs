using BackendAVMB.Models;
using BackendAVMB.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BackendAVMB.Interfaces
{
    public interface IEncaminhaParaAssinaturaApi
    {
        [HttpPost("/encaminhaParaAssinatura")]
        Task<ResponseEncaminhaParaAssinatura.Root> EncaminhaParaAssinatura(EncaminhaParaAssinatura.Root signatarioModel);
    }
}
    