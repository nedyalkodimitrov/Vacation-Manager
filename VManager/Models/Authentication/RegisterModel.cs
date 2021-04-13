using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VManager.Models.ViewModels.Authentication
{
    public class RegisterModel
    {

        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; } 
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Password is required")]

        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
