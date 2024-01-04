using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSettingsController : ControllerBase
    {
        private readonly IGenericService<ProductSettings> _productSettingsService;

        public ProductSettingsController(IGenericService<ProductSettings> productSettingsService)
        {
            _productSettingsService = productSettingsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductSettings()
        {
            try
            {
                var productSettings = await _productSettingsService.GetEntitiesAsync();
                return Ok(productSettings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductSettings([FromBody] ProductSettings productSettings)
        {
            try
            {
                await _productSettingsService.CreateEntityAsync(productSettings);
                return Ok("ProductSetting created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProductSettings(int id)
        {
            try
            {
                var productSettings = await _productSettingsService.GetByIdEntityAsync(id);

                if (productSettings == null)
                {
                    return NotFound();
                }

                return Ok(productSettings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductSettings(int id, [FromBody] ProductSettings productSettings)
        {
            try
            {
                await _productSettingsService.UpdateEntityAsync(productSettings);
                return Ok("ProductSetting updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductSettings(int id)
        {
            try
            {
                await _productSettingsService.DeleteEntityAsync(id);
                return Ok("ProductSetting deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
