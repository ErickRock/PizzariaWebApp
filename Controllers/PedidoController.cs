using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzariaWebApp.Data;
using PizzariaWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pedido
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            // Retorna todos os pedidos do banco de dados, incluindo as pizzas relacionadas a cada pedido.
            return await _context.Pedidos.Include(p => p.Pizzas).ToListAsync();
        }

        // GET: api/Pedido/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            // Procura um pedido específico no banco de dados com base no ID fornecido.
            var pedido = await _context.Pedidos.FindAsync(id);

            if (pedido == null)
            {
                // Se o pedido não for encontrado, retorna um erro 404 - Not Found.
                return NotFound();
            }

            // Retorna o pedido encontrado.
            return pedido;
        }

        // POST: api/Pedido
        [HttpPost]
        public async Task<ActionResult<Pedido>> CreatePedido(Pedido pedido)
        {
            // Adiciona o novo pedido ao contexto do banco de dados.
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();

            // Retorna um código de status 201 - Created, juntamente com o pedido criado.
            return CreatedAtAction(nameof(GetPedido), new { id = pedido.Id }, pedido);
        }

        // PUT: api/Pedido/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePedido(int id, Pedido pedido)
        {
            if (id != pedido.Id)
            {
                // Se o ID fornecido não corresponder ao ID do pedido, retorna um erro 400 - Bad Request.
                return BadRequest();
            }

            // Define o estado do pedido como modificado para que o Entity Framework possa atualizá-lo no banco de dados.
            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
                {
                    // Se o pedido não existir no banco de dados, retorna um erro 404 - Not Found.
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // Retorna um código de status 204 - No Content para indicar que o pedido foi atualizado com sucesso.
            return NoContent();
        }

        // DELETE: api/Pedido/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            // Procura o pedido no banco de dados com base no ID fornecido.
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                // Se o pedido não for encontrado, retorna um erro 404 - Not Found.
                return NotFound();
            }

            // Remove o pedido do contexto do banco de dados.
            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();

            // Retorna um código de status 204 - No Content para indicar que o pedido foi excluído com sucesso.
            return NoContent();
        }

        private bool PedidoExists(int id)
        {
            // Verifica se um pedido com o ID fornecido existe no banco de dados.
            return _context.Pedidos.Any(p => p.Id == id);
        }
    }
}