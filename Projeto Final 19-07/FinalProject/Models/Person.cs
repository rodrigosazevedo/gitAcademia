using FinalProject.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Person : IdentityUser
    {
        //[Key]
        //public int Id { get; set; }

        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "{0} deve conter apenas letras")]
        [StringLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "{0} deve conter apenas letras")]
        [StringLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} deve ser selecionado")]
        [EnumDataType(typeof(BiologicalSex))]
        [Display(Name = "Sexo")]
        public BiologicalSex BiologicalSex { get; set; }

        [Required(ErrorMessage = "{0} deve ser especificada")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        [Display(Name = "Data de Expedição")]
        public DateTime? RG_ExpeditionDate { get; set; }

        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} inválido! Deve ser composto por {1} números")]
        [RegularExpression("[0-9]+", ErrorMessage = "{0} deve conter apenas números")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        //[Required(ErrorMessage = "E-mail não pode estar em branco!")]
        //[DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "Endereço de e-mail inválido!")]
        //public string Email { get; set; }

        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "{0} deve ter entre {2} e {1} números")]
        [RegularExpression("[0-9]+")]
        [Display(Name = "Celular")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Idade")]
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        [EnumDataType(typeof(Gender))]
        [Display(Name = "Identidade de Gênero")]
        public Gender? Gender { get; set; }

        [StringLength(8, MinimumLength = 8)]
        public string? CEP { get; set; }

        [EnumDataType(typeof(MaritalStatus))]
        [Display(Name = "Estado Civil")]
        public MaritalStatus? MaritalStatus { get; set; }

        [Display(Name = "Número do RG")]
        public string? RG_Number { get; set; }

        [Display(Name = "Orgão Emissor")]
        public string? RG_Agency { get; set; }

        [EnumDataType(typeof(BrazilianStates))]
        [Display(Name = "Estado")]
        public BrazilianStates? State { get; set; }

        [Display(Name = "Cidade")]
        public string? City { get; set; }

        [Display(Name = "Bairro")]
        public string? District { get; set; }

        [Display(Name = "Endereço")]
        public string? Address { get; set; }

        [RegularExpression("[0-9]+")]
        [Display(Name = "Numero")]
        public string? AddressNumber { get; set; }

        [Display(Name = "Complemento")]
        public string? Complement { get; set; }

        [Display(Name = "Foto de Perfil")]
        public string? ProfileImage { get; set; }

        [NotMapped]
        [Display(Name ="Nome Completo")]
        public string FullName
        {
            get 
            {
                return FirstName + " " + LastName; 
            }
        }
        public ICollection<AppointmentSlot>? AppointmentSlot { get; set; }
    }
}

