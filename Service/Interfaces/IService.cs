using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IService<T> where T : class
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetAsyncById(int id);
        public Task UpdateAsync(int id, T entity);
        public Task DeleteAsync(int id);
        public Task AddItemAsync(T entity);

        //public void Add(T service);
        //public void Delete(T service);

        //public T GetById(int id);
        //public List<T> GetAll();

        //public void Update(int id, T service);

    }
}
