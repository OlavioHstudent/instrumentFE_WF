using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace instrumentFE_WF.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "instruments",
                columns: table => new
                {
                    instrumentName = table.Column<string>(type: "TEXT", nullable: false),
                    serialNumber = table.Column<string>(type: "TEXT", nullable: false),
                    registerDate = table.Column<string>(type: "TEXT", nullable: false),
                    signalType = table.Column<string>(type: "TEXT", nullable: false),
                    measureType = table.Column<string>(type: "TEXT", nullable: false),
                    options = table.Column<string>(type: "TEXT", nullable: false),
                    lrv = table.Column<string>(type: "TEXT", nullable: false),
                    urv = table.Column<string>(type: "TEXT", nullable: false),
                    comment = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instruments", x => x.instrumentName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "instruments");
        }
    }
}
