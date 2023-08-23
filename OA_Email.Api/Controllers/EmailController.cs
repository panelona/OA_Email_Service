using Microsoft.AspNetCore.Mvc;
using OA_Email.Domain.Contracts;
using OA_Email.Domain.Interfaces;

namespace OA_Email.Api.Controllers
{
    [ApiController]
    public class EmailController : Controller
    {
        private readonly ICodigoService _codigoService;

        public EmailController(ICodigoService codigoService)
        {
            _codigoService = codigoService;
        }

        [HttpPost]
        [Route("api/v1/oe-email/gerar-codigo-confirmacao")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GerarCodigoConfirmacao([FromBody] EmailRequest request, [FromRoute] Guid id)
        {
            try
            {
                await _codigoService.gerarCodigoConfirmacaoAsync(request, id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
