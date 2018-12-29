﻿using System;
using System.Threading.Tasks;
using Dapper;
using Smooth.IoC.Repository.UnitOfWork.Extensions;
using Smooth.IoC.UnitOfWork;

namespace OPUPMS.Infrastructure.Dapper
{
    public abstract partial class MultiDbRepository<TEntity, TPk>
        where TEntity : class
        where TPk : IComparable
    {
        public virtual bool DeleteKey(TPk key, ISession session)
        {
            var entity = CreateEntityAndSetKeyValue(key);
            return session.Delete(entity);
        }

        public virtual bool DeleteKey(TPk key, IUnitOfWork uow)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return uow.Connection.Execute($"DELETE FROM {Sql.Table<TEntity>(uow.SqlDialect)} WHERE {Sql.Column<TEntity>(uow.SqlDialect, "Id")} = @Id",
                    new { Id = key }, uow.Transaction) == 1;

            }
            var entity = CreateEntityAndSetKeyValue(key);
            return uow.Delete(entity);
        }

        public virtual bool DeleteKey<TSession>(string dbToken, TPk key) where TSession : class, ISession
        {
            using (var session = Factory.Create<TSession>(dbToken))
            {
                return DeleteKey(key, session);
            }
        }

        public virtual bool DeleteKey<TSession>(TPk key) where TSession : class, ISession
        {
            return DeleteKey<TSession>(null, key);
        }

        public virtual Task<bool> DeleteKeyAsync(TPk key, ISession session)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return Task.Run(() => session.Execute(
                    $"DELETE FROM {Sql.Table<TEntity>(session.SqlDialect)} WHERE {Sql.Column<TEntity>(session.SqlDialect, "Id")} = @Id",
                    new { Id = key }) == 1);
            }

            var entity = CreateEntityAndSetKeyValue(key);
            return session.DeleteAsync(entity);
        }

        public virtual Task<bool> DeleteKeyAsync(TPk key, IUnitOfWork uow)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return Task.Run(() => uow.Connection.Execute($"DELETE FROM {Sql.Table<TEntity>(uow.SqlDialect)} WHERE {Sql.Column<TEntity>(uow.SqlDialect, "Id")} = @Id",
                                          new { Id = key }, uow.Transaction) == 1);
            }
            var entity = CreateEntityAndSetKeyValue(key);
            return uow.DeleteAsync(entity);
        }

        public virtual async Task<bool> DeleteKeyAsync<TSession>(string dbToken, TPk key) where TSession : class, ISession
        {

            using (var uow = Factory.Create<IUnitOfWork, TSession>(dbToken))
            {
                return await DeleteKeyAsync(key, uow);
            }
        }

        public virtual async Task<bool> DeleteKeyAsync<TSession>(TPk key) where TSession : class, ISession
        {

            using (var uow = Factory.Create<IUnitOfWork, TSession>())
            {
                return await DeleteKeyAsync(key, uow);
            }
        }

        public virtual bool Delete(TEntity entity, ISession session)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return session.Execute($"DELETE FROM {Sql.Table<TEntity>(session.SqlDialect)} WHERE {Sql.Column<TEntity>(session.SqlDialect, "Id")} = @Id",
                    new { ((IEntity<TPk>)entity).Id }) == 1;
            }
            return session.Delete(entity);
        }

        public virtual bool Delete(TEntity entity, IUnitOfWork uow)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return uow.Connection.Execute($"DELETE FROM {Sql.Table<TEntity>(uow.SqlDialect)} WHERE {Sql.Column<TEntity>(uow.SqlDialect, "Id")} = @Id",
                    new { ((IEntity<TPk>)entity).Id }, uow.Transaction) == 1;
            }
            return uow.Delete(entity);
        }

        public virtual bool Delete<TSession>(string dbToken, TEntity entity) where TSession : class, ISession
        {
            using (var uow = Factory.Create<IUnitOfWork, TSession>(dbToken))
            {
                if (_container.IsIEntity<TEntity, TPk>())
                {
                    return uow.Connection.Execute($"DELETE FROM {Sql.Table<TEntity>(uow.SqlDialect)} WHERE {Sql.Column<TEntity>(uow.SqlDialect, "Id")} = @Id",
                        new { ((IEntity<TPk>)entity).Id }, uow.Transaction) == 1;
                }
                return uow.Delete(entity);
            }
        }

        public virtual bool Delete<TSession>(TEntity entity) where TSession : class, ISession
        {
            return Delete<TSession>(null, entity);
        }

        public virtual Task<bool> DeleteAsync(TEntity entity, ISession session)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return Task.Run(() => session.Execute(
                            $"DELETE FROM {Sql.Table<TEntity>(session.SqlDialect)} WHERE {Sql.Column<TEntity>(session.SqlDialect, "Id")} = @Id",
                            new { ((IEntity<TPk>)entity).Id }) == 1);
            }
            return session.DeleteAsync(entity);
        }

        public virtual Task<bool> DeleteAsync(TEntity entity, IUnitOfWork uow)
        {
            if (_container.IsIEntity<TEntity, TPk>())
            {
                return Task.Run(() => uow.Connection.Execute(
                                $"DELETE FROM {Sql.Table<TEntity>(uow.SqlDialect)} WHERE {Sql.Column<TEntity>(uow.SqlDialect, "Id")} = @Id",
                                new { ((IEntity<TPk>)entity).Id }, uow.Transaction) == 1);
            }
            return uow.DeleteAsync(entity);
        }

        public virtual async Task<bool> DeleteAsync<TSession>(string dbToken, TEntity entity) where TSession : class, ISession
        {
            using (var session = Factory.Create<TSession>(dbToken))
            {
                return await DeleteAsync(entity, session);
            }
        }

        public virtual async Task<bool> DeleteAsync<TSession>(TEntity entity) where TSession : class, ISession
        {
            using (var session = Factory.Create<TSession>())
            {
                return await DeleteAsync(entity, session);
            }
        }
    }
}
