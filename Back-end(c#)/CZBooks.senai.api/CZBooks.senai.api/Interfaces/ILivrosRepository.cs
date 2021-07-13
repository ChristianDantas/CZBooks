using CZBooks.senai.api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.Interfaces
{
    interface ILivrosRepository
    {
        List<Livro> Listar();
        void Cadastrar(Livro NovoLivro);
        public List<Livro> Minhas(int idUsuario);
    }
}
