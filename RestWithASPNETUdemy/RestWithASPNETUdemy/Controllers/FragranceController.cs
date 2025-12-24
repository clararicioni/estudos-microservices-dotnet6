using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Services.Implementations;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FragranceController : ControllerBase
    {
        private readonly ILogger<FragranceController> _logger;
        private IFragranceService _fragranceService;

        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        public FragranceController(ILogger<FragranceController> logger, IFragranceService fragranceService)
        {
            _logger = logger;
            _fragranceService = fragranceService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_fragranceService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var fragrance = _fragranceService.FindByID(id);
            if (fragrance == null) return NotFound();
            return Ok(fragrance);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Fragrance fragrance)
        {
            if (fragrance == null) return BadRequest();
            return Ok(_fragranceService.Create(fragrance));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Fragrance fragrance)
        {
            if (fragrance == null) return BadRequest();
            return Ok(_fragranceService.Update(fragrance));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _fragranceService.Delete(id);
            return NoContent();
        }
    }
}
