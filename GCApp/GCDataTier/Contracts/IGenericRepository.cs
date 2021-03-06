﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GCDataTier.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");


        IEnumerable<TEntity> GetPaged(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, int skip, int take);
        IEnumerable<TEntity> GetPaged(string orderByText, int skip, int take);

        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
    }
}