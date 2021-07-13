using CZBooks.senai.api.Domains;
using CZBooks.senai.api.Interfaces;
using CZBooks.senai.api.repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CZBooks.senai.api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }
        public UsuarioController()
        {
            _UsuarioRepository = new _UsuarioRepository();
        }
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Usuario NovoUsuario)
        {
            _UsuarioRepository.cadastrar(NovoUsuario);
            return StatusCode(204);
        }
       
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_UsuarioRepository.Listar());
        }
        

    }
}

