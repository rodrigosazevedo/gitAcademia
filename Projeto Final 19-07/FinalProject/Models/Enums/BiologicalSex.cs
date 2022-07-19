using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.Enums
{
    public enum BiologicalSex
    {
        [Display(Name = "Masculino")]
        Male,
        [Display(Name = "Feminino")]
        Female,
    }
}
