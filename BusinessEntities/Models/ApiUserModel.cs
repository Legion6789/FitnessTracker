using System.ComponentModel.DataAnnotations;

namespace BusinessEntities.Models
{
    public class ApiUserModel : LoginModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
