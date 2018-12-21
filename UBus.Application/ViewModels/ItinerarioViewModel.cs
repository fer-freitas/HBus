using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UBus.Application.ViewModels
{
    public class ItinerarioViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Local é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Local")]
        public string Local { get; set; }

        [Required(ErrorMessage = "O Hora é obrigatório")]
        [DataType(DataType.Time)]
        [DisplayName("Local")]
        public string Hora { get; set; }
    }
}
