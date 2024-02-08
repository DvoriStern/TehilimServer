using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tehilim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestPrayerController : ControllerBase
    {
        private readonly IService<RequestPrayerDto> service;

        public RequestPrayerController(IService<RequestPrayerDto> service)
        {
            this.service = service;
        }
        // GET: api/<RequestPrayerController>
        [HttpGet]
        public async Task<List<RequestPrayerDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<RequestPrayerController>/5
        [HttpGet("{id}")]
        public async Task<RequestPrayerDto> Get(int id)
        {
            return await service.GetAsyncById(id);
        }

        // POST api/<RequestPrayerController>
        [HttpPost]
        public async Task Post([FromBody] RequestPrayerDto requestPrayer)
        {
            await service.AddItemAsync(requestPrayer);
        }

        // PUT api/<RequestPrayerController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] RequestPrayerDto requestPrayer)
        {
            await service.UpdateAsync(id, requestPrayer);
        }

        // DELETE api/<RequestPrayerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);
        }
    }
}
