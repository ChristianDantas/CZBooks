using CZBooks.senai.api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();
        void cadastrar(Usuario NovoUsuario);
        Usuario login(string email, string senha);
    }
}
