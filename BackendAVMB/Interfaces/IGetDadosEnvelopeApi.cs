using BackendAVMB.Models;
using BackendAVMB.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BackendAVMB.Interfaces
{
    public interface IGetDadosEnvelope
    {
        [HttpPost("/getDadosEnvelope")]
        Task<ResponseGetDadosEnvelope.Root> GetDadosEnvelope(GetDadosEnvelopeModel.Root getDadosModel);
    }
}
    