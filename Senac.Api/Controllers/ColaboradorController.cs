using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Senac.Api.Validators;
using Senac.Core.Models;
using Senac.Core.Services;

namespace Senac.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradorController(IColaboradorService colaboradorService)
        {
            this._colaboradorService = colaboradorService;

        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Registro>>> GetAllColaboradores()
        {
            var colaboradores = await _colaboradorService.GetAllColaboradores();

            return Ok(colaboradores);
        }

        [HttpPost("")]
        public async Task<ActionResult<Colaborador>> CreateMusic([FromBody] Colaborador colaborador)
        {
            var colaboradorCriado = await _colaboradorService.CreateColaborador(colaborador);

            return Ok(colaborador);
        }

    }
}