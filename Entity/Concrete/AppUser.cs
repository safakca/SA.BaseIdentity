using Microsoft.AspNetCore.Identity;

namespace Entity.Concrete
{ 
    public class AppUser : IdentityUser<int>
    {
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
    }
}
