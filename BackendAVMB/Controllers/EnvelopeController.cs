using BackendAVMB.Interfaces;
using BackendAVMB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendAVMB.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class EnvelopeController : ControllerBase
    {
        public readonly IEnvelopeApi _envelopeApi;
        public readonly ISignatarioApi _signatarioApi;
        public readonly IEncaminhaParaAssinaturaApi _encaminhaParaAssinaturaApi;
        public readonly IGetDadosEnvelope _getDadosEnvelope;
        public readonly ISalvarEDownload _salvarEDownload;

        public EnvelopeController(IEnvelopeApi envelopeApi, ISignatarioApi signatarioApi
            , IEncaminhaParaAssinaturaApi encaminhaParaAssinaturaApi, IGetDadosEnvelope getDadosEnvelope, ISalvarEDownload salvarEDownload)
        {
            _envelopeApi = envelopeApi;
            _signatarioApi = signatarioApi;
            _encaminhaParaAssinaturaApi = encaminhaParaAssinaturaApi;
            _getDadosEnvelope = getDadosEnvelope;
            _salvarEDownload = salvarEDownload;
        }

        [HttpPost("/inserirEnvelope")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CriarEnvelope([FromBody] InsereEnvelopeModel.Root envelope)
        {
            try { 
                var response = await _envelopeApi.InserirEnvelope(envelope);
                return Ok(response);
            } catch (Exception erro) { 
                return BadRequest(erro.Message);
    }
}

        [HttpPost("/inserirSignatario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CriarSignatario([FromBody] InserirSignatarioModel.Root signatario)
        {
            try
            {
                var response = await _signatarioApi.InserirSignatario(signatario);
                return Ok(response);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost("/encaminhaParaAssinatura")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EncaminhaParaAssinatura([FromBody] EncaminhaParaAssinatura.Root encaminhaAssinatura)
        {
            try
            {
                var response = await _encaminhaParaAssinaturaApi.EncaminhaParaAssinatura(encaminhaAssinatura);
                return Ok(response);
            } catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost("/getDadosEnvelope")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDadosEnvelope([FromBody] GetDadosEnvelopeModel.Root getDadosEnvelope)
        {
            try
            {
                var response = await _getDadosEnvelope.GetDadosEnvelope(getDadosEnvelope);
                return Ok(response);
            } catch (Exception erro) { 
                return BadRequest(erro.Message);
    }
}

        [HttpPost("/salvarEDownload")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> SalvarEDownload([FromBody] SalvarEDownloadModel.Root salvarEDownload)
        {
            try
            {
                var response = await _salvarEDownload.SalvarEDownload(salvarEDownload);
                return Ok(response);
            } catch (Exception erro) { 
                return BadRequest(erro.Message);
            }
        }

    }
}
