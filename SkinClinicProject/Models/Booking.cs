using System.ComponentModel.DataAnnotations.Schema;

namespace SkinClinicProject.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime BookingDate { get; set; }
        public bool BookingConfirmation { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
