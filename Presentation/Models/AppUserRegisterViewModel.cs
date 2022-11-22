using System.ComponentModel.DataAnnotations;

namespace Presentation.Models
{
    //TODO: Business Rule Refactoring et !
    public class AppUserRegisterViewModel
    {
        [Required(ErrorMessage = "name don't empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "surname don't empty")]
        public string Surname { get; set; } 

        [Required(ErrorMessage = "username don't empty")]
        public string Username { get; set; }

        [Required(ErrorMessage = "mail don't empty")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "password don't empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "password confirm don't empty")]
        public string ConfirmPassword { get; set; }
    }
}
