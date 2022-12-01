using BackendAVMB.Models;
using BackendAVMB.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BackendAVMB.Interfaces
{
    public interface IEnvelopeApi
    {
        [HttpPost("/inserirEnvelope")]
        Task<ResponseInserirEnvelope.Root> InserirEnvelope(InsereEnvelopeModel.Root envelopeModel);
    }
}
