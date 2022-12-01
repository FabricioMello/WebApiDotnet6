using BackendAVMB.Models;
using BackendAVMB.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BackendAVMB.Interfaces
{
    public interface ISignatarioApi
    {
        [HttpPost("/inserirSignatario")]
        Task<ResponseInsereSignatario.Root> InserirSignatario(InserirSignatarioModel.Root signatarioModel);
    }
}
    