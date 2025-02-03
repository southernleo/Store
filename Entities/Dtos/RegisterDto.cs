using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos{
    public record RegisterDto{
        [Required(ErrorMessage = "Username is required")]
        public String? UserName{ get; init; }
        [Required(ErrorMessage = "Password is init")]
        public String? Password{ get; set; }
        [Required(ErrorMessage = "Email is init")]
        public String? Email{ get; set; }


    }
}