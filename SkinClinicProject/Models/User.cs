using Microsoft.AspNetCore.Identity;

namespace SkinClinicProject.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Gender { get; set;}
        public DateTime CreatedAt { get; set; }
        public ICollection<UserSession> UserSessions { get; set; }
    }
}
