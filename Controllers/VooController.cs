using Microsoft.AspNetCore.Mvc;
using VoeAirlines.Services;
using VoeAirlines.ViewModels.Voo;

namespace VoeAirlines.Controllers
{
    [Route("api/voos")]
    [ApiController]
    public class VooController : ControllerBase
    {
        private readonly VooService _vooService;

        public VooController(VooService vooService)
        {
            _vooService = vooService;
        }


        [HttpGet]
        public IActionResult ListarVoos()
        {
            var voo = _vooService.ListarVoos();
            return Ok(voo);
        }

        [HttpGet("{id:int}")]
        public IActionResult ListarPilotosPorId(int id)
        {
            var voo = _vooService.ListarPorId(id);
            return Ok(voo);
        }

        [HttpPost]
        public IActionResult AdicionarVoo(AdicionarVooViewModel dados)
        {
            var voo = _vooService.AdicionarVoo(dados);
            return Created(nameof(AdicionarVoo), voo);
        }

        [HttpPut("{id:int}")]
        public IActionResult AtualizarVoo(int id, AtualizarVooViewModel dados)
        {
            var voo = _vooService.AtualizarVoo(id, dados);
            return Ok(voo);
        }

        [HttpDelete("{id:int}")]
        public IActionResult RemoverVoo(int id)
        {
            var voo = _vooService.RemoverVoo(id);
            return Ok(voo);
        }
    }
}