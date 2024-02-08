using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tehilim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharingController : ControllerBase
    {
        private readonly IService<SharingDto> service;

        public SharingController(IService<SharingDto> service)
        {
            this.service = service;
        }
        // GET: api/<SharingController>
        [HttpGet]
        public async Task<List<SharingDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<SharingController>/5
        [HttpGet("{id}")]
        public async Task<SharingDto> Get(int id)
        {
            return await service.GetAsyncById(id);
        }

        // POST api/<SharingController>
        [HttpPost]
        public async Task Post([FromBody] SharingDto sharing)
        {
            await service.AddItemAsync(sharing);
        }

        // PUT api/<SharingController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] SharingDto sharing)
        {
            await service.UpdateAsync(id, sharing);
        }

        // DELETE api/<SharingController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);
        }
    }
}
