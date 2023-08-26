using System.ComponentModel.DataAnnotations;

namespace PizzariaWebApp.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sabor { get; set; }

        [Required]
        public decimal Preco { get; set; }
    }
}
