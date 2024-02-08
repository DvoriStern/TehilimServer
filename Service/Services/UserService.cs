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
    public class UserService : IService<UserDto>
    {
        private readonly IRepository<User> repository;
        private readonly IMapper mapper;
        public UserService(IRepository<User> repository, IMapper map)
        {
            this.repository = repository;
            this.mapper = map;
        }

        public async Task AddItemAsync(UserDto entity)
        {
            await repository.AddItemAsync(mapper.Map<User>(entity));
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            return mapper.Map<List<UserDto>>(await repository.GetAllAsync());
        }

        public async Task<UserDto> GetAsyncById(int id)
        {
            return mapper.Map<UserDto>(await repository.GetAsyncById(id));
        }

        public async Task UpdateAsync(int id, UserDto entity)
        {
            await repository.UpdateAsync(id, mapper.Map<User>(entity));
        }

        //public void Add(UserDto service)
        //{
        //    this._repository.Add(mapper.Map<User>(service));
        //}

        //public void Delete(UserDto service)
        //{
        //    _repository.Delete(mapper.Map<User>(service));
        //}

        //public List<UserDto> GetAll()
        //{
        //    return mapper.Map<List<UserDto>>(_repository.GetAll());
        //}

        //public UserDto GetById(int id)
        //{
        //    return mapper.Map<UserDto>(_repository.GetById(id));
        //}

        //public void Update(int id, UserDto service)
        //{
        //    _repository.Update(id, mapper.Map<User>(service));
        //}
    }
}
