using Microsoft.AspNetCore.Mvc;
using VoeAirlines.Services;
using VoeAirlines.ViewModels.Piloto;

namespace VoeAirlines.Controllers
{
    [Route("api/pilotos")]
    [ApiController]
    public class PilotoController : ControllerBase
    {
        private readonly PilotoService _pilotoService;

        public PilotoController(PilotoService pilotoService)
        {
            _pilotoService = pilotoService;
        }

        [HttpGet]
        public IActionResult ListarPilotos()
        {
            var pilotos = _pilotoService.ListarPilotos();
            return Ok(pilotos);
        }

        [HttpGet("{id:int}")]
        public IActionResult ListarPilotosPorId(int id)
        {
            var piloto = _pilotoService.ListarPorId(id);
            return Ok(piloto);
        }

        [HttpPost]
        public IActionResult AdicionarPiloto(AdicionarPilotoViewModel dados)
        {
            var piloto = _pilotoService.AdicionarPiloto(dados);
            return Created(nameof(AdicionarPiloto), piloto);
        }

        [HttpPut("{id:int}")]
        public IActionResult AtualizarPiloto(int id, AtualizarPilotoViewModel dados)
        {
            var piloto = _pilotoService.AtualizarPiloto(id, dados);
            return Ok(piloto);
        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoverPiloto(int id)
        {
            var piloto = _pilotoService.RemoverPiloto(id);
            return Ok(piloto);
        }
    }
}