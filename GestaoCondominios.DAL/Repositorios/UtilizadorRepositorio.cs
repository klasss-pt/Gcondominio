using GestaoCondominios.BLL.Models;
using GestaoCondominios.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCondominios.DAL.Repositorios
{
    public class UtilizadorRepositorio : RepositorioGenerico<Utilizador>, IUtilizadorRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<Utilizador> _GerirUtilizadores;
        private readonly SignInManager<Utilizador> _GerirLogin;


        public UtilizadorRepositorio(Contexto contexto, UserManager<Utilizador> GerirUtilizadores) : base(contexto)
        {
            _contexto = contexto;
            _GerirUtilizadores = GerirUtilizadores;
            //_GerirLogin = GerirLogin;
        }

        public async Task<IdentityResult> CriarUtilizador(Utilizador utilizador, string password)
        {
            try
            {
                return await _GerirUtilizadores.CreateAsync(utilizador, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task IncluirUtilizadorNaFuncao(Utilizador utilizador, string funcao)
        {
            try
            {
                await _GerirUtilizadores.AddToRoleAsync(utilizador, funcao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task LoginUtilizador(Utilizador utilizador, bool lembrar)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        public int VerificarSeExisteRegisto()
        {
            throw new NotImplementedException();
        }
    }
}
