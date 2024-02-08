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
    public class SharingRepository : IRepository<Sharing>
    {
        private readonly IContext context;
        public SharingRepository(IContext context)
        {
            this.context = context;
        }

        public async Task AddItemAsync(Sharing item)
        {
            await context.Sharings.AddAsync(item);
            await context.Save();
        }

        public async Task DeleteAsync(int id)
        {
            context.Sharings.Remove(await GetAsyncById(id));
            await context.Save();
        }

        public async Task<List<Sharing>> GetAllAsync()
        {
            return await context.Sharings.ToListAsync();
        }

        public async Task<Sharing> GetAsyncById(int id)
        {
            return await context.Sharings.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, Sharing newSharing)
        {
            var sharing = await GetAsyncById(id);
            if(newSharing.Kind!=0)sharing.Kind = newSharing.Kind;
            if(newSharing.Content!=null) sharing.Content = newSharing.Content;
            if(newSharing.IsApproval!=false)sharing.IsApproval = newSharing.IsApproval;
            if (newSharing.Date != DateTime.MinValue) sharing.Date = newSharing.Date;
            if (newSharing.Responses !=0) sharing.Responses = newSharing.Responses;
            if(newSharing.UserId!=0) sharing.UserId = newSharing.UserId;
            await context.Save();
        }

        //public void Add(Sharing sharing)
        //{
        //    this.context.Sharings.Add(sharing);
        //    this.context.save();
        //}

        //public void Delete(Sharing sharing)
        //{
        //    this.context.Sharings.Remove(sharing);
        //}

        //public List<Sharing> GetAll()
        //{
        //    return this.context.Sharings.ToList();
        //}

        //public Sharing GetById(int id)
        //{
        //    return this.context.Sharings.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(int id, Sharing newSharing)
        //{
        //    var sharing = this.context.Sharings.FirstOrDefault(x => x.Id == id);
        //    sharing.Kind = newSharing.Kind;
        //    sharing.Content= newSharing.Content;
        //    sharing.IsApproval = newSharing.IsApproval;
        //    sharing.Date=newSharing.Date;
        //    sharing.User=newSharing.User;
        //    this.context.save();
        //}
    }
}
