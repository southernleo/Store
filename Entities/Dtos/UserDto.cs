using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos{
     public record UserDto{
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "UserName is required.")]
        public String?UserName{ get; init;}
        [Required(ErrorMessage = "Email is requried")]
        [DataType(DataType.EmailAddress)]
        public String?Email{ get; init;}
        [DataType(DataType.PhoneNumber)]
        public String?PhoneNumber{ get; init;}
        public HashSet<String>Roles{ get; set;}=new HashSet<String>();

     }

}