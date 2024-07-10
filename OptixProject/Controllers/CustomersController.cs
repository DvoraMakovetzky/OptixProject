using DAL.Dtos;
using DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

namespace OptixProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomer _dbCustomer;
        public CustomersController(ICustomer dbCustomer)
        {
            _dbCustomer = dbCustomer;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDto value)
        {
            bool created = await _dbCustomer.CreateCustomer(value);
            if (created)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            bool deleted=await _dbCustomer.DeleteCustomer(id);
            if(deleted)
                return Ok();
            return BadRequest();
        }
        [HttpGet("{id}")]
        public async Task<Customer> Get(long id)
        {
            Customer get=await _dbCustomer.GetCustomer(id);
            return get;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id,[FromBody] CustomerDto value)
        {
            bool update=await _dbCustomer.UpdateCustomer(id, value);
            if (update)
                return Ok();
            return BadRequest();
        }

    }
}
