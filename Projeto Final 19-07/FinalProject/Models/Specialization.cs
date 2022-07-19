using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Specialization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
