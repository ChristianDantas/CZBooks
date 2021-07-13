using CZBooks.senai.api.Domains;
using CZBooks.senai.api.Interfaces;
using CZBooks.senai.api.repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;


namespace CZBooks.senai.api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private ILivrosRepository _LivroRepository { get; set; }
        public LivroController()
        {
            _LivroRepository = new _LivroRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_LivroRepository.Listar());
        }
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Livro NovoLivro)
        {
            _LivroRepository.Cadastrar(NovoLivro);
            return StatusCode(204);
        }
        [Authorize(Roles = "3")]
        [HttpGet ("meu")]
        public IActionResult GetById()
        {
            try
            {
                // Cria uma variável idUsuario que recebe o valor do ID do usuário que está logado
                int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                // Retora a resposta da requisição 200 - OK fazendo a chamada para o método e trazendo a lista
                return Ok(_LivroRepository.Minhas(idUsuario));
            }
            catch (Exception error)
            {
                // Retorna a resposta da requisição 400 - Bad Request e o erro ocorrido
                return BadRequest(new
                {
                    mensagem = "Não é possível mostrar os livros escritos se o usuário não estiver logado!",
                    error
                });
            }

        }
    }
}