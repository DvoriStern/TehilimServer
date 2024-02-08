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
    public class ChaptersOfTehilimRepository : IRepository<ChaptersOfTehilim>
    {
        private readonly IContext context;
        public ChaptersOfTehilimRepository(IContext context)
        {
            this.context = context;
        }

        public async Task AddItemAsync(ChaptersOfTehilim item)
        {
            await context.ChaptersOfTehilims.AddAsync(item);
            await context.Save();
        }

        public async Task DeleteAsync(int id)
        {
            context.ChaptersOfTehilims.Remove(await GetAsyncById(id));
            await context.Save();
        }

        public async Task<List<ChaptersOfTehilim>> GetAllAsync()
        {
            return await context.ChaptersOfTehilims.ToListAsync();
        }

        public async Task<ChaptersOfTehilim> GetAsyncById(int id)
        {
            return await context.ChaptersOfTehilims.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, ChaptersOfTehilim newChaptersTehilim)
        {
                var chaptersOfTehilim = await GetAsyncById(id);
                if(newChaptersTehilim.NameOfChapters!=null) chaptersOfTehilim.NameOfChapters = newChaptersTehilim.NameOfChapters;
                if(newChaptersTehilim.Content != null) chaptersOfTehilim.Content = newChaptersTehilim.Content;
                await context.Save();
        }

        //public void Add(ChaptersOfTehilim chaptersOfTehilim)
        //{
        //    this.context.ChaptersOfTehilims.Add(chaptersOfTehilim);
        //    this.context.save();
        //}

        //public void Delete(ChaptersOfTehilim chaptersOfTehilim)
        //{
        //   this.context.ChaptersOfTehilims.Remove(chaptersOfTehilim);
        //}

        //public List<ChaptersOfTehilim> GetAll()
        //{
        //    return this.context.ChaptersOfTehilims.ToList();
        //}

        //public ChaptersOfTehilim GetById(int id)
        //{
        //    return this.context.ChaptersOfTehilims.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(int id, ChaptersOfTehilim newChaptersTehilim)
        //{
        //    var chaptersOfTehilim = this.context.ChaptersOfTehilims.FirstOrDefault(x => x.Id == id);
        //    chaptersOfTehilim.NameOfChapters = newChaptersTehilim.NameOfChapters;
        //    this.context.save();
        //}
    }
}
