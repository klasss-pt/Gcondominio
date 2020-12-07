using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestaoCondominios.BLL.Models
{
    public class Apartamento
    {
        public int ApartamentoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 1000, ErrorMessage = "Valor Invalido")]
        [Display(Name="Número")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 10, ErrorMessage = "Valor Invalido")]
        public int Andar { get; set; }

        public string Foto { get; set; }
        public string MoradorId { get; set; }
        public virtual Utilizador Morador { get; set; }

        public string ProprietarioId { get; set; }
        public virtual Utilizador Proprietario { get; set; }
    }
}
