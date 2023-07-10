using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webadmin.Domain.Core.Interfaces.Services;

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
                _logger.LogError(e.Message);
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
