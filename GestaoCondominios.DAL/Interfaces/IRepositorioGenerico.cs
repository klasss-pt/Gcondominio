using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCondominios.DAL.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> ApanharTodos();
        Task<TEntity> ApanharPeloId(int id);
        Task<TEntity> ApanharPeloId(string id);
        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Eliminar(TEntity entity);
        Task Eliminar(int id);
        Task Eliminar(string id);

    }
}
