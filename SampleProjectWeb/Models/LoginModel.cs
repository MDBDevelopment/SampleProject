using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechnicalTest.Models
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}