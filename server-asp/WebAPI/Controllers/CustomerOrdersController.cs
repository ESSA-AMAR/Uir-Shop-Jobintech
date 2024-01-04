using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrdersController : ControllerBase
    {
        private readonly IGenericService<CustomerOrders> _customerOrdersService;

        public CustomerOrdersController(IGenericService<CustomerOrders> customerOrdersService)
        {
            _customerOrdersService = customerOrdersService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomerOrders()
        {
            try
            {
                var customerOrders = await _customerOrdersService.GetEntitiesAsync();
                return Ok(customerOrders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerOrders([FromBody] CustomerOrders customerOrders)
        {
            try
            {
                await _customerOrdersService.CreateEntityAsync(customerOrders);
                return Ok("CustomerOrder created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCustomerOrders(int id)
        {
            try
            {
                var customerOrders = await _customerOrdersService.GetByIdEntityAsync(id);

                if (customerOrders == null)
                {
                    return NotFound();
                }

                return Ok(customerOrders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerOrders(int id, [FromBody] CustomerOrders customerOrders)
        {
            try
            {
                await _customerOrdersService.UpdateEntityAsync(customerOrders);
                return Ok("CustomerOrder updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerOrders(int id)
        {
            try
            {
                await _customerOrdersService.DeleteEntityAsync(id);
                return Ok("CustomerOrder deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
