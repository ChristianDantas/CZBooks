using CZBooks.senai.api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.Interfaces
{
    interface IInstituicaoRepository
    {
        List<Instituicao> Listar();
        void Cadastrar(Instituicao NovaIns);
    }
}
