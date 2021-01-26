using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentifiedObjects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AliasName = table.Column<string>(nullable: true),
                    MRID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    RatedS = table.Column<float>(nullable: true),
                    GeneratorType = table.Column<int>(nullable: true),
                    MaxQ = table.Column<float>(nullable: true),
                    MinQ = table.Column<float>(nullable: true),
                    DirectionMethod = table.Column<int>(nullable: true),
                    MeasurementType = table.Column<int>(nullable: true),
                    SaveAdress = table.Column<string>(nullable: true),
                    MaxValue = table.Column<float>(nullable: true),
                    MinValue = table.Column<float>(nullable: true),
                    NormalValue = table.Column<float>(nullable: true),
                    Discrete_MaxValue = table.Column<int>(nullable: true),
                    Discrete_MinValue = table.Column<int>(nullable: true),
                    Discrete_NormalValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentifiedObjects", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentifiedObjects");
        }
    }
}
