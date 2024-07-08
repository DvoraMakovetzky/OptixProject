using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GModel = table.Column<string>(type: "text", nullable: false),
                    GPD = table.Column<int>(type: "integer", nullable: false),
                    GRNumber = table.Column<double>(type: "double precision", nullable: false),
                    GRCylinder = table.Column<double>(type: "double precision", nullable: false),
                    GRAxis = table.Column<int>(type: "integer", nullable: false),
                    GRAddition = table.Column<double>(type: "double precision", nullable: false),
                    GRPrizma = table.Column<double>(type: "double precision", nullable: false),
                    GRIndex = table.Column<double>(type: "double precision", nullable: false),
                    GLNumber = table.Column<double>(type: "double precision", nullable: false),
                    GLCylinder = table.Column<double>(type: "double precision", nullable: false),
                    GLAxis = table.Column<int>(type: "integer", nullable: false),
                    GLAddition = table.Column<double>(type: "double precision", nullable: false),
                    GLPrizma = table.Column<double>(type: "double precision", nullable: false),
                    GLIndex = table.Column<double>(type: "double precision", nullable: false),
                    RNumber = table.Column<double>(type: "double precision", nullable: false),
                    RCylinder = table.Column<double>(type: "double precision", nullable: false),
                    RAxis = table.Column<int>(type: "integer", nullable: false),
                    RBC = table.Column<double>(type: "double precision", nullable: false),
                    LNumber = table.Column<double>(type: "double precision", nullable: false),
                    LCylinder = table.Column<double>(type: "double precision", nullable: false),
                    LAxis = table.Column<int>(type: "integer", nullable: false),
                    LBC = table.Column<double>(type: "double precision", nullable: false),
                    PreGPD = table.Column<int>(type: "integer", nullable: false),
                    PreGRNumber = table.Column<double>(type: "double precision", nullable: false),
                    PreGRCylinder = table.Column<double>(type: "double precision", nullable: false),
                    PreGRAxis = table.Column<int>(type: "integer", nullable: false),
                    PreGRAddition = table.Column<double>(type: "double precision", nullable: false),
                    PreGRPrizma = table.Column<double>(type: "double precision", nullable: false),
                    PreGRIndex = table.Column<double>(type: "double precision", nullable: false),
                    PreGLNumber = table.Column<double>(type: "double precision", nullable: false),
                    PreGLCylinder = table.Column<double>(type: "double precision", nullable: false),
                    PreGLAxis = table.Column<int>(type: "integer", nullable: false),
                    PreGLAddition = table.Column<double>(type: "double precision", nullable: false),
                    PreGLPrizma = table.Column<double>(type: "double precision", nullable: false),
                    PreGLIndex = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
