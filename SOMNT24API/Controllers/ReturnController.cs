using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOMNT24BLL.Interfaces;
using SOMNT24DOMAIN.Models;

namespace SOMNT24API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnController : ControllerBase
    {
        private readonly IReturnService _service;

        public ReturnController(IReturnService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }


        [HttpGet("grid")]
        public async Task<IActionResult> GetGrid([FromQuery] string? search, [FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var data = await _service.GetByIdAsync("1");
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var data = await _service.GetByIdAsync(id);
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReturnType model)
        {
            model.ProcessingRequired = "A";
            model.TimeStamp = new byte[8];

            await _service.CreateAsync(model);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ReturnType model)
        {
            await _service.UpdateAsync(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
