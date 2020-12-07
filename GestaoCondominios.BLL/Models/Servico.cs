using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.BLL.Models
{
    public class Servico
    {
        public int ServicoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public StatusServico Status { get; set; }

        public string UtilizadorId { get; set; }
        public virtual Utilizador Utilizador { get; set; }

        public ICollection<ServicoPredio> ServicoPredios { get; set; }

    }

    public enum StatusServico
    {
        Pendente, Recusado, Aceite
    }
}
