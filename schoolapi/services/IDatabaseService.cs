using System.Collections.Generic;
using System.Threading.Tasks;
using schoolapi.Models;

namespace schoolapi.services
{
    public interface IDatabaseService<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}