using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.Enums
{
    public enum MaritalStatus
    {
        [Display(Name = "Solteiro(a)")]
        Single,
        [Display(Name = "Casado(a)")]
        Married,
        [Display(Name = "Divorciado(a)")]
        Divorced,
        [Display(Name = "Separado(a)")]
        Separated,
        [Display(Name = "Viúvo(a)")]
        Widowed
    }
}
