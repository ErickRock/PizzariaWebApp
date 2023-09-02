using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzariaWebApp.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        // Relação um-para-muitos com a classe Pizza
        public List<Pizza> Pizzas { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
