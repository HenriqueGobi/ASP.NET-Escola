using EF_API_Escola.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EF_API_Escola.contex
{
    public class AlunoContex: IdentityDbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public AlunoContex(DbContextOptions<AlunoContex> options): base(options) { }
    }
}