using CZBooks.senai.api.Domains;
using CZBooks.senai.api.Interfaces;
using CZBooks.senai.api.repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ICategoriaRepository _CategoriaRepository { get; set; }
        public CategoriaController()
        {
            _CategoriaRepository = new _CategoriaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_CategoriaRepository.Listar());
        }


        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Categorium NovaCat)
        {
            _CategoriaRepository.cadastrar(NovaCat);
            return StatusCode(204);
        }
    }
}
