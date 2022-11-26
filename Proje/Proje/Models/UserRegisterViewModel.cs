using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "lütfen soyadınızı giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "lütfen mailinizi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "lütfen şifrenizi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "lütfen şifrenizi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
