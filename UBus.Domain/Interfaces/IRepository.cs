using System;
using System.Linq;

namespace UBus.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity ObterPorId(Guid id);
        IQueryable<TEntity> ObterTodos();
        void Atualizar(TEntity obj);
        void Excluir(Guid id);
    }
}
