using CalculoNumerosPrimos.Domain.Commands;
using CalculoNumerosPrimos.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculoNumerosPrimos.API.Controllers
{
    /// <summary>
    /// Números Primos
    /// </summary>
    [Route("api/v1/[controller]")]
    public class NumerosPrimosController : Controller
    {
        private readonly ICalculoNumerosPrimosApplication _calculoNumerosPrimosApplication;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="calculoNumerosPrimosApplication"></param>
        public NumerosPrimosController(ICalculoNumerosPrimosApplication calculoNumerosPrimosApplication)
        {
            _calculoNumerosPrimosApplication = calculoNumerosPrimosApplication;
        }

        /// <summary>
        /// Calcular númers primos e divisores.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [ActionName(nameof(CalcularPrimos))]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ICommandResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<IActionResult> CalcularPrimos([FromQuery]NumeroCommand command)
        {
            var result = await _calculoNumerosPrimosApplication.HandleAsync(command);
            if (result.Success)
                return Ok(result);

            return BadRequest(result?.Message);
        }
    }
}
