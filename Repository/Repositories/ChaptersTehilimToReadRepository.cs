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
    public class ChaptersTehilimToReadRepository : IRepository<ChaptersTehilimToRead>
    {
        private readonly IContext context;
        public ChaptersTehilimToReadRepository(IContext context)
        {
            this.context = context;
        }
        public async Task AddItemAsync(ChaptersTehilimToRead item)
        {
            await context.ChaptersTehilimToReads.AddAsync(item);
            await context.Save();
        }

        public async Task DeleteAsync(int id)
        {
            context.ChaptersTehilimToReads.Remove(await GetAsyncById(id));
            await context.Save();
        }

        public async Task<List<ChaptersTehilimToRead>> GetAllAsync()
        {
            return await context.ChaptersTehilimToReads.ToListAsync();
        }

        public async Task<ChaptersTehilimToRead> GetAsyncById(int id)
        {
            return await context.ChaptersTehilimToReads.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, ChaptersTehilimToRead newChaptersTehilimToRead)
        {
            var chaptersTehilimToRead = await GetAsyncById(id);
            if (newChaptersTehilimToRead.UserId!= 0) chaptersTehilimToRead.UserId = newChaptersTehilimToRead.UserId;
            if(newChaptersTehilimToRead.ChaptersOfTehilimId!=0) chaptersTehilimToRead.ChaptersOfTehilimId=newChaptersTehilimToRead.ChaptersOfTehilimId;
            if(newChaptersTehilimToRead.GroupId!=0) chaptersTehilimToRead.GroupId = newChaptersTehilimToRead.GroupId;
            await context.Save();
        }
    }
}
