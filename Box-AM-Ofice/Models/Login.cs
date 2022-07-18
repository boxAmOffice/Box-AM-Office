using System.ComponentModel.DataAnnotations;

namespace boxAmOffice.Models
{
    public class Login
    {
        [Display(Name = "User Name ")]
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
