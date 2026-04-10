using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOMNT24BLL.Interfaces;

namespace SOMNT24API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterController : ControllerBase
    {
        private readonly IParameterService _service;

        public ParameterController(IParameterService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("category/{businessUnit}")]
        public async Task<IActionResult> GetCategory(string businessUnit)
        {
            var data = await _service.GetByIdAsync(businessUnit, 1);
            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpGet("module/{businessUnit}")]
        public async Task<IActionResult> GetModule(string businessUnit)
        {
            var data = await _service.GetByIdAsync(businessUnit, 4);
            if (data == null)
                return NotFound();

            return Ok(data);
        }
    }
}
