using System.ComponentModel.DataAnnotations;

namespace RawTorpedo.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
