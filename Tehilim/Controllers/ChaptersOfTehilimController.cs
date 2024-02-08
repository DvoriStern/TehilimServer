using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tehilim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersOfTehilimController : ControllerBase
    {
        private readonly IService<ChaptersOfTehilimDto> service;

        public ChaptersOfTehilimController(IService<ChaptersOfTehilimDto> service)
        {
            this.service = service;
        }
        // GET: api/<ChaptersOfTehilimController>
        [HttpGet]
        public async Task<List<ChaptersOfTehilimDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<ChaptersOfTehilimController>/5
        [HttpGet("{id}")]
        public async Task<ChaptersOfTehilimDto> Get(int id)
        {
            return await service.GetAsyncById(id);
        }

        // POST api/<ChaptersOfTehilimController>
        [HttpPost]
        public async Task Post([FromBody] ChaptersOfTehilimDto chaptersOfTehilim)
        {
            await service.AddItemAsync(chaptersOfTehilim);
        }

        // PUT api/<ChaptersOfTehilimController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ChaptersOfTehilimDto chaptersOfTehilim)
        {
            await service.UpdateAsync(id, chaptersOfTehilim);
        }

        // DELETE api/<ChaptersOfTehilimController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);
        }
    
    }
}
