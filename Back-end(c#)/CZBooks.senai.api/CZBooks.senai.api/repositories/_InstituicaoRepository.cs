using CZBooks.senai.api.Contexts;
using CZBooks.senai.api.Domains;
using CZBooks.senai.api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.repositories
{
    public class _InstituicaoRepository : IInstituicaoRepository
    {
        BlogContext ctx = new BlogContext();
        public void Cadastrar(Instituicao NovaIns)
        {
            
        }

        public List<Instituicao> Listar()
        {
            return ctx.Instituicaos.ToList();
        }
    }
}
