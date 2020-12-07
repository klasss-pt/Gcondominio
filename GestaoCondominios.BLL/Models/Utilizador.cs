using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.BLL.Models
{
    public class Utilizador : IdentityUser<string>
    {
        public string Contribuinte { get; set; }
        public string Foto { get; set; }
        public bool PrimeiroAcesso { get; set; }
        public StatusConta Status { get; set; }

        public virtual ICollection<Apartamento> MoradoresApartamentos { get; set; }
        public virtual ICollection<Apartamento> ProprietariosApartamentos { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }

    public enum StatusConta
    {
        Analise, Aprovado, Reprovado
    }
}
