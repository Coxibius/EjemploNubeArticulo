using Microsoft.AspNetCore.Mvc;
using simple.Data;
using simple.Models;
using Microsoft.EntityFrameworkCore;

namespace simple.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SistemasComputadoraController : ControllerBase
    {
        private readonly simpleContext _context;

        // Inyección de dependencias (Conectamos con la BD)
        public SistemasComputadoraController(simpleContext context)
        {
            _context = context;
        }

        // Endpoint POST: Para crear una nueva computadora
        [HttpPost]
        public async Task<IActionResult> CrearComputadora([FromBody] SistemasComputadora pc)
        {
            if (pc == null)
            {
                return BadRequest("No enviaste datos.");
            }

            // Guardamos en la Base de Datos
            _context.SistemasComputadoras.Add(pc);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Computadora guardada exitosamente", id = pc.Id });
        }
    }
}