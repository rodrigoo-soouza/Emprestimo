using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_de_Emprestimos.Data.Migrations
{
    public partial class CriacaoBanco2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aluno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Funcionario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CargoFuncionario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LivroEmprestado = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataPublicacaoLivro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimos");
        }
    }
}
