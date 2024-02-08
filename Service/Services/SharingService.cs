using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class SharingService : IService<SharingDto>
    {
        private readonly IRepository<Sharing> repository;
        private readonly IMapper mapper;
        public SharingService(IRepository<Sharing> repository, IMapper map)
        {
            this.repository = repository;
            this.mapper = map;
        }

        public async Task AddItemAsync(SharingDto entity)
        {
            await repository.AddItemAsync(mapper.Map<Sharing>(entity));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<SharingDto>> GetAllAsync()
        {
            return mapper.Map<List<SharingDto>>(await repository.GetAllAsync());
        }

        public async Task<SharingDto> GetAsyncById(int id)
        {
            return mapper.Map<SharingDto>(await repository.GetAsyncById(id));
        }

        public async Task UpdateAsync(int id, SharingDto entity)
        {
            await repository.UpdateAsync(id, mapper.Map<Sharing>(entity));
        }

        //public void Add(SharingDto service)
        //{
        //    this._repository.Add(mapper.Map<Sharing>(service));
        //}

        //public void Delete(SharingDto service)
        //{
        //    _repository.Delete(mapper.Map<Sharing>(service));
        //}

        //public List<SharingDto> GetAll()
        //{
        //    return mapper.Map<List<SharingDto>>(_repository.GetAll());
        //}

        //public SharingDto GetById(int id)
        //{
        //    return mapper.Map<SharingDto>(_repository.GetById(id));
        //}

        //public void Update(int id, SharingDto service)
        //{
        //    _repository.Update(id, mapper.Map<Sharing>(service));
        //}
    }
}
