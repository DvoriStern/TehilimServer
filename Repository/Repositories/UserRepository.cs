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
    public class UserRepository : IRepository<User>
    {
        private readonly IContext context;
        public UserRepository(IContext context)
        {
            this.context = context;
        }

        public async Task AddItemAsync(User item)
        {
            await context.Users.AddAsync(item);
            await context.Save();
        }

        public async Task DeleteAsync(int id)
        {
            context.Users.Remove(await GetAsyncById(id));
            await context.Save();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetAsyncById(int id)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, User newUser)
        {
            var user = await GetAsyncById(id);
            if(newUser.Name!=null)user.Name = newUser.Name;//??
            if(newUser.Email!=null) user.Email = newUser.Email;
            if(newUser.Rank!=eRank.Empty) user.Rank = newUser.Rank;
            if(newUser.IsActive) user.IsActive = newUser.IsActive;
            if(newUser.Password!=null) user.Password = newUser.Password;
            await context.Save();
        }

        //public void Add(User user)
        //{
        //    this.context.Users.Add(user);
        //    this.context.save();
        //}

        //public void Delete(User user)
        //{
        //    this.context.Users.Remove(user);
        //}

        //public List<User> GetAll()
        //{
        //    return this.context.Users.ToList();
        //}

        //public User GetById(int id)
        //{
        //    return this.context.Users.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(int id, User newUser)
        //{
        //    var user= this.context.Users.FirstOrDefault(x => x.Id == id); 
        //    user.Group=newUser.Group;
        //    user.Email=newUser.Email;
        //    user.Rank=newUser.Rank;
        //    user.IsActive=newUser.IsActive;
        //    user.Name=newUser.Name;
        //    user.Password=newUser.Password;
        //    user.NameForPrayer=newUser.NameForPrayer;
        //    this.context.save();
        //}
    }
}
