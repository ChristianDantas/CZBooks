using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks.senai.api.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public int? IdAutor { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdInstituicao { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public double? Preco { get; set; }
        public string DataPublicacao { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual Instituicao IdInstituicaoNavigation { get; set; }
    }
}
