using CZBooks.senai.api.Contexts;
using CZBooks.senai.api.Domains;
using CZBooks.senai.api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.repositories
{
    public class _LivroRepository : ILivrosRepository
    {
        BlogContext ctx = new BlogContext();
        public void Cadastrar(Livro NovoLivro)
        {
            ctx.Livros.Add(NovoLivro);
            ctx.SaveChanges();
        }

        public List<Livro> Listar()
        {
            return ctx.Livros.ToList();
        }

        public List<Livro> Minhas(int idUsuario)
        {
            Autor LivroBuscado = ctx.Autors.FirstOrDefault(c => c.IdUsuario == idUsuario);
            return ctx.Livros
                .Where(a => a.IdAutor == LivroBuscado.IdAutor)
                .Include(a => a.IdAutorNavigation)
                .Include(a => a.IdCategoriaNavigation)
                .ToList();
        }
    }
}