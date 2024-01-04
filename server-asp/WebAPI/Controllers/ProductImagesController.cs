using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IGenericService<ProductImages> _productImagesService;

        public ProductImagesController(IGenericService<ProductImages> productImagesService)
        {
            _productImagesService = productImagesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductImages()
        {
            try
            {
                var productImages = await _productImagesService.GetEntitiesAsync();
                return Ok(productImages);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImages([FromBody] ProductImages productImages)
        {
            try
            {
                await _productImagesService.CreateEntityAsync(productImages);
                return Ok("ProductImage created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProductImages(int id)
        {
            try
            {
                var productImages = await _productImagesService.GetByIdEntityAsync(id);

                if (productImages == null)
                {
                    return NotFound();
                }

                return Ok(productImages);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductImages(int id, [FromBody] ProductImages productImages)
        {
            try
            {
                await _productImagesService.UpdateEntityAsync(productImages);
                return Ok("ProductImage updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductImages(int id)
        {
            try
            {
                await _productImagesService.DeleteEntityAsync(id);
                return Ok("ProductImage deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
