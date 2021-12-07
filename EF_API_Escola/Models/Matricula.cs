using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_API_Escola.Models
{
    public class Matricula
    {
        [Key()]
        public int Id { get; set; }
        [ForeignKey ("Aluno")]
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public bool Status { get; set; }
    }
}