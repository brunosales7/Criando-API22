using Microsoft.AspNetCore.Mvc;
using VoeAirlines.Entities;
using VoeAirlines.Services;

using VoeAirlines.ViewModels.Cancelamento;

namespace VoeAirlines.Controllers
{
    [Route("api/cancelamentos")]
    [ApiController]
    public class CancelamentoController : ControllerBase
    {
        public readonly CancelamentoService _cancelamentoService;
        public CancelamentoController(CancelamentoService service)
        {
            _cancelamentoService = service;
        }

        [HttpGet]
        public IActionResult ListarCancelamento()
        {
            var cancelamento = _cancelamentoService.ListarCancelamentos();
            return Ok(cancelamento);
        }
        [HttpGet("{id:int}")]
        public IActionResult ListarCancelamentoPorId(int id)
        {
            var cancelamento = _cancelamentoService.ListarCancelamentoPorId(id);
            return Ok(cancelamento);
        }

        [HttpPost]
        public IActionResult AdicionarCancelamento(AdicionarCancelamentoViewModel dados)
        {
            var aeronave = _cancelamentoService.AdicionarCancelamento(dados);
            return Created(nameof(AdicionarCancelamento), aeronave);
        }

        [HttpPut("{id:int}")]
        public IActionResult AtualizarCancelamento(int id, AtualizarCancelamentoViewModel dados)
        {
            var cancelamento = _cancelamentoService.AtualizarCancelamento(id, dados);
            return Ok(cancelamento);
        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoverCancelamento(int id)
        {
            var cancelamento = _cancelamentoService.RemoverCancelamento(id);
            return Ok(cancelamento);
        }


    }
}