using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UBus.Application.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Marca é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Modelo é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Marca")]
        public string Modelo { get; set; }


        public virtual IEnumerable<ItemAdicionalViewModel> ItensAdicionais { get; set; }
    }
}
