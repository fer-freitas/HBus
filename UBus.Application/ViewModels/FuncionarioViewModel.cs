using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UBus.Application.ViewModels
{
    public class FuncionarioViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O primeiro nome é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Primeiro Nome")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "O último nome é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Último Nome")]
        public string UltimoNome { get; set; }

        public bool Ativo { get; set; }
    }
}
