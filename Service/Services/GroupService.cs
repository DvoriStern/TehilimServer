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
    public class GroupService : IService<GroupDto>
    {
        private readonly IRepository<Group> repository;
        private readonly IMapper mapper;
        public GroupService(IRepository<Group> repository, IMapper map)
        {
            this.repository = repository;
            this.mapper = map;
        }

        public async Task AddItemAsync(GroupDto entity)
        {
            await repository.AddItemAsync(mapper.Map<Group>(entity));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<GroupDto>> GetAllAsync()
        {
            return mapper.Map<List<GroupDto>>(await repository.GetAllAsync());
        }

        public async Task<GroupDto> GetAsyncById(int id)
        {
            return mapper.Map<GroupDto>(await repository.GetAsyncById(id));
        }

        public async Task UpdateAsync(int id, GroupDto entity)
        {
            await repository.UpdateAsync(id, mapper.Map<Group>(entity));
        }

        //public void Add(GroupDto service)
        //{
        //    this._repository.Add(mapper.Map<Group>(service));
        //}

        //public List<GroupDto> GetAll()
        //{
        //    return mapper.Map<List<GroupDto>>(_repository.GetAll());
        //}

        //public GroupDto GetById(int id)
        //{
        //    return mapper.Map<GroupDto>(_repository.GetById(id));
        //}

        //public void Delete(GroupDto service)
        //{
        //    _repository.Delete(mapper.Map<Group>(service));
        //}

        //public void Update(int id, GroupDto service)
        //{
        //    _repository.Update(id, mapper.Map<Group>(service));
        //}
    }
}
