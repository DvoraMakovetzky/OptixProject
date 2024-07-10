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
                    GRNumber = table.Column<string>(type: "text", nullable: false),
                    GRCylinder = table.Column<string>(type: "text", nullable: false),
                    GRAxis = table.Column<int>(type: "integer", nullable: false),
                    GRAddition = table.Column<string>(type: "text", nullable: false),
                    GRPrizma = table.Column<string>(type: "text", nullable: false),
                    GRIndex = table.Column<double>(type: "double precision", nullable: false),
                    GLNumber = table.Column<string>(type: "text", nullable: false),
                    GLCylinder = table.Column<string>(type: "text", nullable: false),
                    GLAxis = table.Column<int>(type: "integer", nullable: false),
                    GLAddition = table.Column<string>(type: "text", nullable: false),
                    GLPrizma = table.Column<string>(type: "text", nullable: false),
                    GLIndex = table.Column<double>(type: "double precision", nullable: false),
                    RNumber = table.Column<string>(type: "text", nullable: false),
                    RCylinder = table.Column<string>(type: "text", nullable: false),
                    RAxis = table.Column<int>(type: "integer", nullable: false),
                    RBC = table.Column<double>(type: "double precision", nullable: false),
                    LNumber = table.Column<string>(type: "text", nullable: false),
                    LCylinder = table.Column<string>(type: "text", nullable: false),
                    LAxis = table.Column<int>(type: "integer", nullable: false),
                    LBC = table.Column<double>(type: "double precision", nullable: false),
                    PreGPD = table.Column<int>(type: "integer", nullable: false),
                    PreGRNumber = table.Column<string>(type: "text", nullable: false),
                    PreGRCylinder = table.Column<string>(type: "text", nullable: false),
                    PreGRAxis = table.Column<int>(type: "integer", nullable: false),
                    PreGRAddition = table.Column<string>(type: "text", nullable: false),
                    PreGRPrizma = table.Column<string>(type: "text", nullable: false),
                    PreGRIndex = table.Column<double>(type: "double precision", nullable: false),
                    PreGLNumber = table.Column<string>(type: "text", nullable: false),
                    PreGLCylinder = table.Column<string>(type: "text", nullable: false),
                    PreGLAxis = table.Column<int>(type: "integer", nullable: false),
                    PreGLAddition = table.Column<string>(type: "text", nullable: false),
                    PreGLPrizma = table.Column<string>(type: "text", nullable: false),
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
