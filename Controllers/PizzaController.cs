using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzariaWebApp.Data;
using PizzariaWebApp.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzariaWebApp.Controllers
{
    // Controller para gerenciar entidades Pizza
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        // Repositório para acesso aos dados
        private readonly IPizzaRepository _pizzaRepository;

        // Injeção de dependência
        public PizzaController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        // GET: Retorna todas as pizzas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pizza>>> GetPizzas()
        {
            var pizzas = await _pizzaRepository.GetAll();
            return Ok(pizzas);
        }

        // GET por ID:
        [HttpGet("{id}")]
        public async Task<ActionResult<Pizza>> GetPizzaById(int id)
        {
            var pizza = await _pizzaRepository.GetById(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

        // POST: Adiciona uma nova pizza
        [HttpPost]
        public async Task<ActionResult<Pizza>> AddPizza(Pizza pizza)
        {
            await _pizzaRepository.Add(pizza);

            return CreatedAtAction(nameof(GetPizzaById), new { id = pizza.Id }, pizza);
        }

        // PUT: Atualiza uma pizza
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePizza(int id, Pizza pizza)
        {
            var existingPizza = await _pizzaRepository.GetById(id);

            if (existingPizza == null)
                return NotFound();

            existingPizza.Nome = pizza.Nome;
            existingPizza.Ingredientes = pizza.Ingredientes;
            existingPizza.Preco = pizza.Preco;

            await _pizzaRepository.Update(existingPizza);

            return NoContent();
        }

        // DELETE: Exclui uma pizza
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePizza(int id)
        {
            var pizza = await _pizzaRepository.GetById(id);

            if (pizza == null)
                return NotFound();

            await _pizzaRepository.Delete(id);

            return NoContent();
        }
    }

    public interface IPizzaRepository
    {
        Task<IEnumerable<Pizza>> GetAll();
        Task<Pizza> GetById(int id);
        Task Add(Pizza pizza);
        Task Update(Pizza pizza);
        Task Delete(int id);
    }
}