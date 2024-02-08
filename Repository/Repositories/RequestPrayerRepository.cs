using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class RequestPrayerRepository : IRepository<RequestPrayer>
    {
        private readonly IContext context;
        public RequestPrayerRepository(IContext context)
        {
            this.context = context;
        }

        public async Task AddItemAsync(RequestPrayer item)
        {
            await context.RequestPrayers.AddAsync(item);
            await context.Save();
        }

        public async Task DeleteAsync(int id)
        {
            context.RequestPrayers.Remove(await GetAsyncById(id));
            await context.Save();
        }

        public async Task<List<RequestPrayer>> GetAllAsync()
        {
            return await context.RequestPrayers.ToListAsync();
        }

        public async Task<RequestPrayer> GetAsyncById(int id)
        {
            return await context.RequestPrayers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, RequestPrayer newRequestPrayer)
        {
            var requestPrayers = await GetAsyncById(id);
            requestPrayers.Content = newRequestPrayer.Content;
            await context.Save();
        }

        //public void Add(RequestPrayer requestPrayer)
        //{
        //    this.context.RequestPrayers.Add(requestPrayer);
        //    this.context.save();
        //}

        //public void Delete(RequestPrayer requestPrayer)
        //{
        //    this.context.RequestPrayers.Remove(requestPrayer);
        //}

        //public List<RequestPrayer> GetAll()
        //{
        //    return this.context.RequestPrayers.ToList();
        //}

        //public RequestPrayer GetById(int id)
        //{
        //    return this.context.RequestPrayers.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(int id, RequestPrayer newRequestPrayer)
        //{
        //    var requestPrayers = this.context.RequestPrayers.FirstOrDefault(x => x.Id == id);
        //    requestPrayers.Content=newRequestPrayer.Content;
        //    this.context.save();
        //}
    }
}
