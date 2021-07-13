using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks.senai.api.Domains
{
    public partial class Autor
    {
        public Autor()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdAutor { get; set; }
        public int? IdUsuario { get; set; }
        public int? Idade { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
