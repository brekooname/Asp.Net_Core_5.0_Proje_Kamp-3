using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Şifrenizi Giriniz !")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Şifrenizi Onaylayınız !")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
