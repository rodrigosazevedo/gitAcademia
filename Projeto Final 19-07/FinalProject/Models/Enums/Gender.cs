using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.Enums
{
    public enum Gender
    {
        [Display(Name = "Masculino")]
        Male,
        [Display(Name = "Feminino")]
        Female,
        [Display(Name = "Outro")]
        Other,
        [Display(Name = "Prefiro não Informar")]
        NotInformed
    }
}
