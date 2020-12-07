using GestaoCondominios.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCondominios.DAL.Interfaces
{
    public interface IUtilizadorRepositorio : IRepositorioGenerico<Utilizador>
    {
        int VerificarSeExisteRegisto();
        Task LoginUtilizador(Utilizador utilizador, bool lembrar);
        Task<IdentityResult> CriarUtilizador(Utilizador utilizador, string password);
        Task IncluirUtilizadorNaFuncao(Utilizador utilizador, string funcao);
    }
}
