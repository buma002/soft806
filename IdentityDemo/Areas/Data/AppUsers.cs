using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Areas.Data
{
    public class AppUsers : IdentityUser

    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
       
    }
}