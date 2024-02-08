using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tehilim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IService<GroupDto> service;

        public GroupController(IService<GroupDto> service)
        {
            this.service = service;
        }
        // GET: api/<GroupController>
        [HttpGet]
        public async Task<List<GroupDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public async Task<GroupDto> Get(int id)
        {
            return await service.GetAsyncById(id);
        }

        // POST api/<GroupController>
        [HttpPost]
        public async Task Post([FromBody] GroupDto group)
        {
            await service.AddItemAsync(group);
        }

        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] GroupDto group)
        {
            await service.UpdateAsync(id, group);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);
        }
    }
}
