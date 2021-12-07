using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_API_Escola.Migrations
{
    public partial class InsertValues : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Disciplinas (Nome) VALUES('Portugues')");
            mb.Sql("INSERT INTO Disciplinas (Nome) VALUES('Matematica')");
            mb.Sql("INSERT INTO Disciplinas (Nome) VALUES('Ingles')");

            mb.Sql("INSERT INTO Alunos (Nome,Cidade,Idade,DisciplinaId) VALUES('Henrique','Colombo',24,1)");
            mb.Sql("INSERT INTO Alunos (Nome,Cidade,Idade,DisciplinaId) VALUES('Claudiane','Colombo',25,2)");
            mb.Sql("INSERT INTO Alunos (Nome,Cidade,Idade,DisciplinaId) VALUES('Elizabeth','Colombo',16,3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Disciplinas");
            mb.Sql("DELETE FROM Alunos");
        }
    }
}
