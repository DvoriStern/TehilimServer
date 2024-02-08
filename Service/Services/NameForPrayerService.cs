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
    public class NameForPrayerService : IService<NameForPrayerDto>
    {
        private readonly IRepository<NameForPrayer> repository;
        private readonly IMapper mapper;
        public NameForPrayerService(IRepository<NameForPrayer> repository, IMapper map)
        {
            this.repository = repository;
            this.mapper = map;
        }

        public async Task AddItemAsync(NameForPrayerDto entity)
        {
            await repository.AddItemAsync(mapper.Map<NameForPrayer>(entity));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<NameForPrayerDto>> GetAllAsync()
        {
            return mapper.Map<List<NameForPrayerDto>>(await repository.GetAllAsync());
        }

        public async Task<NameForPrayerDto> GetAsyncById(int id)
        {
            return mapper.Map<NameForPrayerDto>(await repository.GetAsyncById(id));
        }

        public async Task UpdateAsync(int id, NameForPrayerDto entity)
        {
            await repository.UpdateAsync(id, mapper.Map<NameForPrayer>(entity));
        }

        //public void Add(NameForPrayerDto service)
        //{
        //    this._repository.Add(mapper.Map<NameForPrayer>(service));
        //}

        //public void Delete(NameForPrayerDto service)
        //{
        //    _repository.Delete(mapper.Map<NameForPrayer>(service));
        //}

        //public List<NameForPrayerDto> GetAll()
        //{
        //    return mapper.Map<List<NameForPrayerDto>>(_repository.GetAll());
        //}

        //public NameForPrayerDto GetById(int id)
        //{
        //    return mapper.Map<NameForPrayerDto>(_repository.GetById(id));
        //}

        //public void Update(int id, NameForPrayerDto service)
        //{
        //    _repository.Update(id, mapper.Map<NameForPrayer>(service));
        //}
    }
}
