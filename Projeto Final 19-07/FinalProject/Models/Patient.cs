using FinalProject.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Patient : Person
    {
        [Display(Name = "Apelido")]
        public string Nickname { get; set; }

        [Display(Name = "Peso")]
        public double Weight { get; set; }
        
        [Display(Name = "Altura")]
        public double Height { get; set; }
    }
}
