using FinalProject.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Doctor : Person
    {   
        [Display(Name = "Especialização")]
        public int SpecializationId { get; set; }

        [StringLength(6, MinimumLength = 6, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres")]
        [RegularExpression("[0-9]+", ErrorMessage = "{0} deve conter apenas números")]
        [Display(Name = "Número de CRM")]
        public string CRM_Number { get; set; }

        [EnumDataType(typeof(BrazilianStates))]
        [Display(Name = "UF do CRM")]
        public BrazilianStates CRM_UF { get; set; } 

        [Display(Name = "Formação Acadêmica")]
        public string? Degree { get; set; }

        [ForeignKey("SpecializationId")]
        public Specialization? Specialization { get; set; }

        [NotMapped]
        [Display(Name = "CRM")]
        public string CRM_Complete
        {
            get
            {
                return CRM_Number + "-" + CRM_UF;
            }
        }

    }
}
