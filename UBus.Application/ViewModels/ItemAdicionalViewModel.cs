using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UBus.Application.ViewModels
{
    public class ItemAdicionalViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Veículo")]
        public Guid VeiculoId { get; set; }
    }
}
