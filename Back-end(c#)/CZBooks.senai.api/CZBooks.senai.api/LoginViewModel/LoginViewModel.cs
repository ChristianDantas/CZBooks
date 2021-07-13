using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.senai.api.LoginViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Envie Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Envie senha")]
        public string Senha { get; set; }
    }
}
