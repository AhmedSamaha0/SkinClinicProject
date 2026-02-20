namespace SkinClinicProject.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime SessionDate { get; set; }
        public bool Sessionconsultation { get; set; }
        public ICollection<UserSession> UserSessions { get; set; }

    }
}
