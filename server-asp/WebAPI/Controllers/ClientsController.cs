using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IGenericService<Clients> _clientsService;

        public ClientsController(IGenericService<Clients> clientsService)
        {
            _clientsService = clientsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClients()
        {
            try
            {
                var clients = await _clientsService.GetEntitiesAsync();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateClients([FromBody] Clients clients)
        {
            try
            {
                await _clientsService.CreateEntityAsync(clients);
                return Ok("Client created successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdClients(int id)
        {
            try
            {
                var clients = await _clientsService.GetByIdEntityAsync(id);

                if (clients == null)
                {
                    return NotFound();
                }

                return Ok(clients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClients(int id, [FromBody] Clients clients)
        {
            try
            {
                await _clientsService.UpdateEntityAsync(clients);
                return Ok("Client updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClients(int id)
        {
            try
            {
                await _clientsService.DeleteEntityAsync(id);
                return Ok("Client deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
