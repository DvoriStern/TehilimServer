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
    public class NameForPrayerRepository : IRepository<NameForPrayer>
    {
        private readonly IContext context;
        public NameForPrayerRepository(IContext context)
        {
            this.context = context;
        }

        public async Task AddItemAsync(NameForPrayer item)
        {
            await context.NameForPrayers.AddAsync(item);
            await context.Save();
        }

        public async Task DeleteAsync(int id)
        {
            context.NameForPrayers.Remove(await GetAsyncById(id));
            await context.Save();
        }

        public async Task<List<NameForPrayer>> GetAllAsync()
        {
            return await context.NameForPrayers.ToListAsync();
        }

        public async Task<NameForPrayer> GetAsyncById(int id)
        {
            return await context.NameForPrayers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, NameForPrayer newNameForPrayer)
        {
            var nameForPrayer = await GetAsyncById(id);
            if(newNameForPrayer.PersonalRequest!=null) nameForPrayer.PersonalRequest = newNameForPrayer.PersonalRequest;
            if(newNameForPrayer.NameForPray!=null) nameForPrayer.NameForPray = newNameForPrayer.NameForPray;
            if(newNameForPrayer.RequestPrayerId!= 0)nameForPrayer.RequestPrayerId = newNameForPrayer.RequestPrayerId;
            if (newNameForPrayer.UserId != 0) nameForPrayer.UserId = newNameForPrayer.UserId;
            await context.Save();
        }

        //public void Add(NameForPrayer nameForPrayer)
        //{
        //    this.context.NameForPrayers.Add(nameForPrayer);
        //    this.context.save();
        //}

        //public void Delete(NameForPrayer nameForPrayer)
        //{
        //    this.context.NameForPrayers.Remove(nameForPrayer);
        //}

        //public List<NameForPrayer> GetAll()
        //{
        //    return this.context.NameForPrayers.ToList();
        //}

        //public NameForPrayer GetById(int id)
        //{
        //    return this.context.NameForPrayers.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(int id, NameForPrayer newNameForPrayer)
        //{
        //    var nameForPrayer = this.context.NameForPrayers.FirstOrDefault(x => x.Id == id);
        //    nameForPrayer.PersonalRequest = newNameForPrayer.PersonalRequest;
        //    nameForPrayer.NameForPray = newNameForPrayer.NameForPray;
        //    nameForPrayer.RequestPrayer = newNameForPrayer.RequestPrayer;
        //    this.context.save();
        //}
    }
}
