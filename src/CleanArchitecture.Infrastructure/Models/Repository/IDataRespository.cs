﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Medline.Recall.Infrastructure.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(Employee employee, TEntity entity);
        void Delete(Employee employee);
    }
}
