using DevStudyAzure.API.Data;
using DevStudyAzure.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevStudyAzure.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private Context _context;
        public ClientesController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes;
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] Cliente clienteModel)
        {
            var clienteNovo = _context.Clientes.Add(clienteModel);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var filme = _context.Clientes.SingleOrDefault(filme => filme.Id == id);

            if (filme == null) return NotFound();

            _context.Remove(filme);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
