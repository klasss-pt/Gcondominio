using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestaoCondominios.BLL.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        [Required (ErrorMessage="O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos caracteres")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use menos caracteres")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Matricula { get; set; }
        public string UtilizadorId { get; set; }
        public Utilizador Utilizador { get; set; }
    }
}
