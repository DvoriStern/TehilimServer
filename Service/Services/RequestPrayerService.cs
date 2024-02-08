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
    public class RequestPrayerService : IService<RequestPrayerDto>
    {
        private readonly IRepository<RequestPrayer> repository;
        private readonly IMapper mapper;
        public RequestPrayerService(IRepository<RequestPrayer> repository, IMapper map)
        {
            this.repository = repository;
            this.mapper = map;
        }

        public async Task AddItemAsync(RequestPrayerDto entity)
        {
            await repository.AddItemAsync(mapper.Map<RequestPrayer>(entity));
        }

        public  async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<RequestPrayerDto>> GetAllAsync()
        {
            return mapper.Map<List<RequestPrayerDto>>(await repository.GetAllAsync());
        }

        public async Task<RequestPrayerDto> GetAsyncById(int id)
        {
            return mapper.Map<RequestPrayerDto>(await repository.GetAsyncById(id));
        }

        public async Task UpdateAsync(int id, RequestPrayerDto entity)
        {
            await repository.UpdateAsync(id, mapper.Map<RequestPrayer>(entity));
        }

        //public void Add(RequestPrayerDto service)
        //{
        //    this._repository.Add(mapper.Map<RequestPrayer>(service));
        //}

        //public void Delete(RequestPrayerDto service)
        //{
        //    _repository.Delete(mapper.Map<RequestPrayer>(service));
        //}

        //public List<RequestPrayerDto> GetAll()
        //{
        //    return mapper.Map<List<RequestPrayerDto>>(_repository.GetAll());
        //}

        //public RequestPrayerDto GetById(int id)
        //{
        //    return mapper.Map<RequestPrayerDto>(_repository.GetById(id));
        //}

        //public void Update(int id, RequestPrayerDto service)
        //{
        //    _repository.Update(id, mapper.Map<RequestPrayer>(service));
        //}
    }
}
