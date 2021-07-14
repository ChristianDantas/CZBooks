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
    public class InstituicaoController : ControllerBase
    {
        private IInstituicaoRepository _InstituicaoRepository { get; set; }
        public InstituicaoController()
        {
            _InstituicaoRepository = new _InstituicaoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_InstituicaoRepository.Listar());
        }

        //[Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Instituicao NovaIns)
        {
            try
            {
                _InstituicaoRepository.Cadastrar(NovaIns);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
