using BackendAVMB.Models;
using BackendAVMB.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BackendAVMB.Interfaces
{
    public interface ISalvarEDownload
    {
        [HttpPost("/salvarEDownload")]
        Task<ResponseSalvarEDownload.Root> SalvarEDownload(SalvarEDownloadModel.Root signatarioModel);
    }
}
    