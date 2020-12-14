using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using schoolapi.Base.Models;

namespace schoolapi.services
{
    public class DatabaseService<T> : IDatabaseService<T> where T : class
    {
        public async Task<IEnumerable<T>> Get()
        {
            using(var dbContext = new ArchaosDbContext())
            {
                return await dbContext.Set<T>().ToListAsync();
            }
        }

        public async Task<T> Get(int id)
        {
            using(var dbContext = new ArchaosDbContext())
            {
                return await dbContext.Set<T>().FindAsync(id);
            }
        }

        public async Task<T> Add(T entity)
        {
            using(var dbContext = new ArchaosDbContext())
            {
                await dbContext.Set<T>().AddAsync(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            }
        }

        public async Task<T> Update(T entity)
        {
            using(var dbContext = new ArchaosDbContext())
            {
                var record = (BaseRecord)Convert.ChangeType(entity, typeof(T));
                if(await Get(record.Id) == null)
                {
                    return null;
                }
                record.LastModDate = DateTime.Now;
                dbContext.Set<T>().Update(entity);
                await dbContext.SaveChangesAsync();
                return entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using(var dbContext = new ArchaosDbContext())
            {
                var entity = await Get(id);
                dbContext.Set<T>().Remove(entity);
                await dbContext.SaveChangesAsync();
                return true;
            }
        }
    }
}