using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShopProjectAsp_PhamVanLinh.ViewModels
{
    public class Input
    {
        [Required(ErrorMessage = "Email can not be blank")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password can not be blank")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
