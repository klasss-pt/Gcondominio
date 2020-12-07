using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.BLL.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public int UtilizadorId { get; set; }

        public virtual Utilizador Utilizador { get; set; }
        public Aluguer Aluguer { get; set; }

        public DateTime? DataPagamento { get; set; }

        public StatusPagamento Status { get; set; }

    }

    public enum StatusPagamento
    {
        Pago, Pendente, Atrasado
    }
}
