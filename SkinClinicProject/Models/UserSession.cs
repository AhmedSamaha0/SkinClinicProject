using System.ComponentModel.DataAnnotations.Schema;

namespace SkinClinicProject.Models
{
    public class UserSession
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Session")]
        public int SessionId { get; set; }
        public Session Session { get; set; }

    }
}
