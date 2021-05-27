using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterUsuario()
        {
            var usuario = new Usuario()
            {
                Nome = "Teste",
                Email = "teste@teste.com",
                Senha = "1234567"
            };
            return Ok(usuario);
        }

    }
}