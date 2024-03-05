using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace esercizioS18L1.Models
{
    public class Login
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Il campo Username è obbligatorio.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Il campo Password è obbligatorio.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}