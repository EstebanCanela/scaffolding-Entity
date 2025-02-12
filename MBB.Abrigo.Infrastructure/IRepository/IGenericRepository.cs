﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBB.Abrigo.Infrastructure.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity p);
        void Edit(TEntity p);
        void Remove(string Id);
        IEnumerable<TEntity> GetAll();
        TEntity FindById(string Id);

    }
}
