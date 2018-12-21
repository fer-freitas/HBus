using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UBus.Application.ViewModels
{
    public class RotaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Origem é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Origem")]
        public string Origem { get; set; }

        [Required(ErrorMessage = "O Destino é obrigatório")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Destino")]
        public string Destino { get; set; }

        [Required(ErrorMessage = "O Início Previsto é obrigatório")]
        [DisplayName("Início Previsto")]
        public DateTime Inicio { get; set; }

        [Required(ErrorMessage = "O Fim Previsto é obrigatório")]
        [DisplayName("Fim Previsto")]
        public DateTime Fim { get; set; }

        [Required(ErrorMessage = "O Valor é obrigatório")]
        [DisplayName("Valor")]
        public decimal Valor { get; set; }
    }
}
