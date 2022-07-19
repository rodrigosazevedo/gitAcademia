using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Especialização")]
        public int SpecializationId { get; set; }

        [Required]
        [Display(Name = "Descritivo")]
        public string ExamDescription { get; set; }

        [Required]
        [Display(Name = "Duração (horas)")]
        public int Duration { get; set; }

        [ForeignKey("SpecializationId")]
        public Specialization? Specialization { get; set; }

    }
}
