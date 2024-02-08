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
    public class ChaptersOfTehilimService : IService<ChaptersOfTehilimDto>
    {
        private readonly IRepository<ChaptersOfTehilim> repository;
        private readonly IMapper mapper;
        public ChaptersOfTehilimService(IRepository<ChaptersOfTehilim> repository, IMapper map)
        {
            this.repository = repository;
            this.mapper = map;
        }

        public async Task AddItemAsync(ChaptersOfTehilimDto entity)
        {
            await repository.AddItemAsync(mapper.Map<ChaptersOfTehilim>(entity));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<ChaptersOfTehilimDto>> GetAllAsync()
        {
            return mapper.Map<List<ChaptersOfTehilimDto>>(await repository.GetAllAsync());
        }

        public async Task<ChaptersOfTehilimDto> GetAsyncById(int id)
        {
            return mapper.Map<ChaptersOfTehilimDto>(await repository.GetAsyncById(id));
        }

        public async Task UpdateAsync(int id, ChaptersOfTehilimDto entity)
        {
            await repository.UpdateAsync(id, mapper.Map<ChaptersOfTehilim>(entity));
        }

        //public void Add(ChaptersOfTehilimDto service)
        //{
        //    this._repository.Add(mapper.Map<ChaptersOfTehilim>(service));
        //}

        //public List<ChaptersOfTehilimDto> GetAll()
        //{
        //    return mapper.Map<List<ChaptersOfTehilimDto>>(_repository.GetAll());
        //}

        //public ChaptersOfTehilimDto GetById(int id)
        //{
        //    return mapper.Map<ChaptersOfTehilimDto>(_repository.GetById(id));
        //}

        //public void Delete(ChaptersOfTehilimDto service)
        //{
        //    _repository.Delete(mapper.Map<ChaptersOfTehilim>(service));
        //}

        //public void Update(int id, ChaptersOfTehilimDto service)
        //{
        //    _repository.Update(id, mapper.Map<ChaptersOfTehilim>(service));
        //}
    }
}
