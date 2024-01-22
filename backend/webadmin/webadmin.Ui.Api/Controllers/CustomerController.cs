using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using webadmin.Domain.Core.Interfaces.Services;
using webadmin.Domain.Entities;
using webadmin.Ui.Api.Dtos;

namespace webadmin.Ui.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(IMapper mapper, 
                                  ICustomerService customerService, 
                                  ILogger<CustomerController> logger)
        {
            _mapper = mapper;
            _customerService = customerService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            try
            {
                _logger.LogInformation("Entrou no get");

                var _customer = await _customerService.GetAllAsync();
                return new OkObjectResult(_customer);
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(Guid id)
        {
            try
            {
                _logger.LogInformation("Entrou no get by id");

                var _customer = await _customerService.GetByIdAsync(id);
                return new OkObjectResult(_customer);
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDto customerDto)
        {
            _logger.LogInformation("Entrou no post");

            if (customerDto == null)
                    return BadRequest();

            var _customerDto = _mapper.Map<Customer>(customerDto);
            await _customerService.AddRangeAsync(_customerDto);

            return Created("/", "Created");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] CustomerDto customerDto)
        {
            try
            {
                var _customer = _mapper.Map<Customer>(customerDto);
                await _customerService.UpdateAsync(_customer);

                return Ok(customerDto);
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message + " | " + e.InnerException.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromUri] Guid id)
        {
            try
            {
                var _customer = await _customerService.GetByIdAsync(id);

                if (_customer != null)
                {
                    await _customerService.DeleteAsync(_customer);
                }

                return Ok();
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
