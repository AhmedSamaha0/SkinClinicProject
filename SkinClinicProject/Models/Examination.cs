namespace SkinClinicProject.Models
{
    public class Examination
    {
        public int Id { get; set; }
        public DateTime ExaminationDate { get; set; }
        public bool ExaminationConsultation { get; set; }
        public ICollection<UserExamination> UserExaminations { get; set; }
    }
}
