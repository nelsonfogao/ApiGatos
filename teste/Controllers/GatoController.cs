using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace teste.Controllers
{
    [ApiController]
    [Route("api/gatos")]
    public class GatoController : ControllerBase
    {
        private readonly IGatoService _gatoService;
        public GatoController(IGatoService gatoService)
        {
            _gatoService = gatoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetGatos()
        {
            return Ok(await _gatoService.GetGatosAsync());
        }
    }
}
