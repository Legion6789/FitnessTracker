using Microsoft.AspNetCore.Identity;

namespace BusinessEntities.Authentication
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
