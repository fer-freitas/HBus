using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UBus.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PrimeiroNome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    UltimoNome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rotas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Origem = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Destino = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Inicio = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    Fim = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    Valor = table.Column<decimal>(type: "numeric(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Marca = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viagens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Latitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Longitude = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Hora = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    RotaId = table.Column<Guid>(nullable: false),
                    VeiculoId = table.Column<Guid>(nullable: false),
                    FuncionarioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itinerarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Local = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Hora = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    RotaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Itinerarios_Rotas_RotaId",
                        column: x => x.RotaId,
                        principalTable: "Rotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemAdicional",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    VeiculoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAdicional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAdicional_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemAdicional_VeiculoId",
                table: "ItemAdicional",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Itinerarios_RotaId",
                table: "Itinerarios",
                column: "RotaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "ItemAdicional");

            migrationBuilder.DropTable(
                name: "Itinerarios");

            migrationBuilder.DropTable(
                name: "Viagens");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Rotas");
        }
    }
}
