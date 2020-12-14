using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kinvo.Infra.Data.Migrations
{
    public partial class kinvo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataAtu = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    CategoriaProduto = table.Column<int>(nullable: false),
                    AtivoSigla = table.Column<string>(maxLength: 8, nullable: true),
                    Qtde = table.Column<int>(nullable: false),
                    Instituicao = table.Column<string>(maxLength: 30, nullable: false),
                    PrecoCompra = table.Column<decimal>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    TaxaCorretagem = table.Column<decimal>(nullable: true),
                    TaxaAnual = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");
        }
    }
}
