using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using schoolapi.services;

namespace schoolapi.Base.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class
    {
        // GET api/values
        [HttpGet]
        async public Task<IEnumerable<T>> Get()
        {
            return await new DatabaseService<T>().Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        async public Task<T> Get(int id)
        {
            return await new DatabaseService<T>().Get(id);
        }

        // POST api/values
        [HttpPost]
        public Task<T> Post([FromBody] T entity)
        {
            return new DatabaseService<T>().Add(entity);
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<T> Put([FromBody] T entity)
        {
            return await new DatabaseService<T>().Update(entity);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Task<bool> Delete(int id)
        {
            return new DatabaseService<T>().Delete(id);
        }
    }
}