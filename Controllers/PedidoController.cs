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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            return await _context.Pedidos.Include(p => p.Pizzas).ToListAsync();
        }

        // Implemente os demais métodos CRUD (POST, PUT, DELETE) para a entidade Pedido
    }
}
