using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace customersDAO
{
    public interface IDAO<T> where T : class
    {
        IQueryable<T> Data { get; set; }
        
        IQueryable<T> Read();

        void Create(T obj);

        void Update(T obj);

        void Delete(T obj);
    }
}
