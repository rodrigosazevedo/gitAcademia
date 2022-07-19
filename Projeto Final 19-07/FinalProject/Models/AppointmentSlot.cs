using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class AppointmentSlot
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor preencher data da consulta")]
        [Display(Name="Data da Consulta")]
        public DateTime Start { get; set; }

        [Display(Name = "Data Final")]
        public DateTime End { get; set; }

        [Display(Name = "Disponível?")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Doutor")]
        public string DoctorId { get; set; }

        [Display(Name = "Paciente")]
        public string? PatientId { get; set; }

        [Display(Name = "Exame")]
        public int? ExamId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        [ForeignKey("ExamId")]
        public Exam? Exam { get; set; }
    }
}
