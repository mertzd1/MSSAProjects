using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace customersDAO
{
    public class customersDAO<T> : IDAO<T> where T : class
    {
        private customersContext context { get; set; }
        public IQueryable<T> Data { get => GetDbSet(); set => Data = Data; }

        public customersDAO(customersContext ctx)
        {
            context = ctx;
        }

        public void Create(T obj)
        {
            GetDbSet().Add(obj);
            context.SaveChanges();
        }

        public IQueryable<T> Read() => GetDbSet();

        public void Update(T obj)
        {
            GetDbSet().Update(obj);
            context.SaveChanges();
        }

        public void Delete(T obj)
        {
            GetDbSet().Remove(obj);
            context.SaveChanges();
        }

        public DbSet<T> GetDbSet()
        {
            foreach(var prop in context.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(DbSet<T>))
                {
                    return prop.GetValue(context, null) as DbSet<T>;
                }
            }
            return null;
        }
    }
}
