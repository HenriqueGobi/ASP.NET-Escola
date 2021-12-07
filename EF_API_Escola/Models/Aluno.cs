using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_API_Escola.Models
{
    public class Aluno
    {
        [Key()]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo nome obriagtório")]
        [StringLength(40)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo idade obrigatorio")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "Campo cidade obrigatório")]
        [StringLength(30)]
        public string Cidade { get; set; }
        [ForeignKey ("Disciplina")]
        [Required(ErrorMessage = "Por favor insira o ID da disciplina correspondente")]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}