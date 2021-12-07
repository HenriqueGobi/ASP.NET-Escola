using System.ComponentModel.DataAnnotations;

namespace EF_API_Escola.Models
{
    public class Disciplina
    {
        [Key()]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}