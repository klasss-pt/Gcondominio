using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestaoCondominios.BLL.Models
{
    public class Evento
    {
        public int EventoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage ="Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Data { get; set; }
        public string UtilizadorId { get; set; }
        public virtual Utilizador Utilizador { get; set; }
    }
}
