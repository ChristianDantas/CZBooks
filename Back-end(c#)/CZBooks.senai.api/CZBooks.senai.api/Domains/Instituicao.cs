using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks.senai.api.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdInstituicao { get; set; }
        public string NomeInstituicao { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
