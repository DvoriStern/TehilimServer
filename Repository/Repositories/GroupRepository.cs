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
    public class GroupRepository : IRepository<Group>
    {
        private readonly IContext context;
        public GroupRepository(IContext context)
        {
            this.context = context;
        }

        public async Task AddItemAsync(Group item)
        {
            await context.Groups.AddAsync(item);
            await context.Save();
        }

        public async Task DeleteAsync(int id)
        {
            context.Groups.Remove(await GetAsyncById(id));
            await context.Save();
        }

        public async Task<List<Group>> GetAllAsync()
        {
            return await context.Groups.ToListAsync();
        }

        public async Task<Group> GetAsyncById(int id)
        {
            return await context.Groups.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, Group newGroup)
        {
            var group = await GetAsyncById(id);
            if(newGroup.StartDate != DateTime.MinValue) group.StartDate = newGroup.StartDate;
            if (newGroup.Status != 0) group.Status = newGroup.Status;
            await context.Save();
        }

        //public void Add(Group group)
        //{
        //    this.context.Groups.Add(group);
        //    this.context.save();
        //}

        //public void Delete(Group group)
        //{
        //    this.context.Groups.Remove(group);
        //}

        //public List<Group> GetAll()
        //{
        //    return this.context.Groups.ToList();
        //}

        //public Group GetById(int id)
        //{
        //    return this.context.Groups.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(int id, Group newGroup)
        //{
        //var group = this.context.Groups.FirstOrDefault(x => x.Id == id);
        //group.StartDate = newGroup.StartDate;
        //    group.Users = newGroup.Users;
        //    group.status=newGroup.status;
        //    this.context.save();
        //}
    }
}
