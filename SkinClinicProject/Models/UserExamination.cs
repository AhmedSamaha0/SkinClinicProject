using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Pkcs;

namespace SkinClinicProject.Models
{
    public class UserExamination
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Examination")]
        public int ExaminationId { get; set; }
        public Examination Examination { get; set; }
    }
}
