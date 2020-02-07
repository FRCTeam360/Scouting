using Microsoft.EntityFrameworkCore.Migrations;

namespace Scouting_v2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionId = table.Column<string>(nullable: true),
                    Match = table.Column<int>(nullable: false),
                    Team = table.Column<int>(nullable: false),
                    Baseline = table.Column<decimal>(nullable: false),
                    AutoBalls_LVL_1 = table.Column<decimal>(nullable: false),
                    AutoBalls_LVL_2 = table.Column<decimal>(nullable: false),
                    AutoBalls_LVL_3 = table.Column<decimal>(nullable: false),
                    TeleopBalls_LVL_1 = table.Column<decimal>(nullable: false), 
                    TeleopBalls_LVL_2 = table.Column<decimal>(nullable: false),
                    TeleopBalls_LVL_3 = table.Column<decimal>(nullable: false),
                    Spinner_Number = table.Column<decimal>(nullable: false),
                    Spinner_Colour = table.Column<decimal>(nullable: false),
                    Climbed = table.Column<decimal>(nullable: false),
                    Climb_HI = table.Column<decimal>(nullable: false),
                    Climb_MI = table.Column<decimal>(nullable: false),
                    Climb_LO = table.Column<decimal>(nullable: false),
                    Balanced = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");
        }
    }
}
