using System.ComponentModel.DataAnnotations;

namespace PizzariaWebApp.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string Telefone { get; set; }
    }
}
