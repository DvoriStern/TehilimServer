using Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tehilim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersTehilimToReadController : ControllerBase
    {
        private readonly IService<ChaptersTehilimToReadDto> service;

        public ChaptersTehilimToReadController(IService<ChaptersTehilimToReadDto> service)
        {
            this.service = service;
        }
        // GET: api/<ChaptersTehilimToReadController>
        [HttpGet]
        public async Task<List<ChaptersTehilimToReadDto>> Get()
        {
            return await service.GetAllAsync();
        }

        // GET api/<ChaptersTehilimToReadController>/5
        [HttpGet("{id}")]
        public async Task<ChaptersTehilimToReadDto> Get(int id)
        {
            return await service.GetAsyncById(id);
        }

        // POST api/<ChaptersTehilimToReadController>
        [HttpPost]
        public async Task Post([FromBody] ChaptersTehilimToReadDto chaptersTehilimToRead)
        {
            await service.AddItemAsync(chaptersTehilimToRead);
        }

        // PUT api/<ChaptersTehilimToReadController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ChaptersTehilimToReadDto chaptersTehilimToRead)
        {
            await service.UpdateAsync(id, chaptersTehilimToRead);
        }

        // DELETE api/<ChaptersTehilimToReadController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await service.DeleteAsync(id);
        }
    }
}
