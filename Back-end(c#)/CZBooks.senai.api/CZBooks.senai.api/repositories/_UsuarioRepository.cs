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
    public class _UsuarioRepository : IUsuarioRepository
    {
        BlogContext ctx = new BlogContext();
        public void cadastrar(Usuario NovoUsuario)
        {
            ctx.Usuarios.Add(NovoUsuario);
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario login(string email, string senha)
        {
            return ctx.Usuarios.Include(u => u.IdTipoUsuarioNavigation).FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}