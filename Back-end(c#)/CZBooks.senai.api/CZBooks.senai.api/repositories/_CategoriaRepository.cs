using CZBooks.senai.api.Contexts;
using CZBooks.senai.api.Domains;
using CZBooks.senai.api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.repositories
{
    public class _CategoriaRepository : ICategoriaRepository
    {
        BlogContext ctx = new BlogContext();


        public void cadastrar(Categorium NovaCat)
        {
            ctx.Categoria.Add(NovaCat);
            ctx.SaveChanges();
        }

        public List<Categorium> Listar()
        {
            return ctx.Categoria.ToList();
        }
    }
}
