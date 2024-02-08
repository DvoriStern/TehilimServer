using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tehilim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameForPrayerController : ControllerBase
    {
        private readonly IService<NameForPrayerDto> service;

        public NameForPrayerController(IService<NameForPrayerDto> service)
        {
            this.service = service;
        }
        // GET: api/<NameForPrayerController>
        [HttpGet]
        public async Task<List<NameForPrayerDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<NameForPrayerController>/5
        [HttpGet("{id}")]
        public async Task<NameForPrayerDto> Get(int id)
        {
            return await service.GetAsyncById(id);
        }

        // POST api/<NameForPrayerController>
        [HttpPost]
        public async Task Post([FromBody] NameForPrayerDto nameForPrayer)
        {
            await service.AddItemAsync(nameForPrayer);
        }

        // PUT api/<NameForPrayerController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] NameForPrayerDto nameForPrayer)
        {
            await service.UpdateAsync(id, nameForPrayer);
        }

        // DELETE api/<NameForPrayerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);
        }
    }
}
