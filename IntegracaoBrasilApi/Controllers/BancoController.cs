using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace IntegracaoBrasilApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        private readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/todos")]
        public async Task<IActionResult> BuscarTodos()
        {
            var response = await _bancoService.BuscarTodos();
            if (response.CodigoHttp == HttpStatusCode.OK) return Ok(response.DadosRetorno);

            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }

        [HttpGet("busca/{codigoBanco}")]

        public async Task<IActionResult> Buscar([RegularExpression("^[0-9]*$")] string codigoBanco)
        {
            var response = await _bancoService.BuscaBanco(codigoBanco);

            if (response.CodigoHttp == HttpStatusCode.OK) return Ok(response.DadosRetorno);

            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);

        }

    }
}
