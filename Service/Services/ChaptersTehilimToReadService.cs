using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ChaptersTehilimToReadService : IService<ChaptersTehilimToReadDto>
    {
        private readonly IRepository<ChaptersTehilimToRead> repository;
        private readonly IMapper mapper;
        public ChaptersTehilimToReadService(IRepository<ChaptersTehilimToRead> repository, IMapper map)
        {
            this.repository = repository;
            this.mapper = map;
        }
        public async Task AddItemAsync(ChaptersTehilimToReadDto entity)
        {
            await repository.AddItemAsync(mapper.Map<ChaptersTehilimToRead>(entity));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<ChaptersTehilimToReadDto>> GetAllAsync()
        {
            return mapper.Map<List<ChaptersTehilimToReadDto>>(await repository.GetAllAsync());
        }

        public async Task<ChaptersTehilimToReadDto> GetAsyncById(int id)
        {
            return mapper.Map<ChaptersTehilimToReadDto>(await repository.GetAsyncById(id));
        }

        public async Task UpdateAsync(int id, ChaptersTehilimToReadDto entity)
        {
            await repository.UpdateAsync(id, mapper.Map<ChaptersTehilimToRead>(entity));
        }
    }
}
