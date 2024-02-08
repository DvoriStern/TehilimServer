using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        //public void Add(T item);
        //public void Update(int id, T item);
        //public void Delete(T item);
        //public T GetById(int id);
        //public List<T> GetAll();
        public Task<List<T>> GetAllAsync();
        public Task<T> GetAsyncById(int id);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, T entity);
        public Task AddItemAsync(T item);
    }
}
