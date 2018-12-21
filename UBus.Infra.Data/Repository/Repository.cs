using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UBus.Domain.Interfaces;
using UBus.Infra.Data.Context;

namespace UBus.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly UBusContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(UBusContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
            Db.SaveChanges();
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            var entity = DbSet.Find(id);
            Db.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public virtual IQueryable<TEntity> ObterTodos()
        {
            return DbSet.AsNoTracking();
        }

        public virtual void Atualizar(TEntity obj)
        {
            DbSet.Update(obj);
            Db.SaveChanges();
        }

        public virtual void Excluir(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
