using Microsoft.AspNetCore.Identity;

namespace Entity.Concrete
{
    /// <summary>
    /// default da stringdir IdentityUser key 
    /// </summary>
    public class AppUser : IdentityUser<int>
    {
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
    }
}
