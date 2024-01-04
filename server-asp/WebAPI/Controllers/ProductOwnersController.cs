using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOwnersController : ControllerBase
    {
        private readonly IGenericService<ProductOwners> _productOwnersService;

        public ProductOwnersController(IGenericService<ProductOwners> productOwnersService)
        {
            _productOwnersService = productOwnersService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductOwners()
        {
            try
            {
                var productOwners = await _productOwnersService.GetEntitiesAsync();
                return Ok(productOwners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductOwners([FromBody] ProductOwners productOwners)
        {
            try
            {
                await _productOwnersService.CreateEntityAsync(productOwners);
                return Ok("ProductOwner created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProductOwners(int id)
        {
            try
            {
                var productOwners = await _productOwnersService.GetByIdEntityAsync(id);

                if (productOwners == null)
                {
                    return NotFound();
                }

                return Ok(productOwners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductOwners(int id, [FromBody] ProductOwners productOwners)
        {
            try
            {
                await _productOwnersService.UpdateEntityAsync(productOwners);
                return Ok("ProductOwner updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductOwners(int id)
        {
            try
            {
                await _productOwnersService.DeleteEntityAsync(id);
                return Ok("ProductOwner deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
