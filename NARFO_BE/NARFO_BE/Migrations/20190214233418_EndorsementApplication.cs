using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NARFO_BE.Migrations
{
    public partial class EndorsementApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EndorsementApplication",
                columns: table => new
                {
                    EndorsAppID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    DedicatedStatus = table.Column<bool>(nullable: false),
                    ApplicationType = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    FireArmType = table.Column<string>(nullable: true),
                    ActionType = table.Column<string>(nullable: true),
                    Caliber = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    ApprovalDate = table.Column<DateTime>(nullable: true),
                    Motivation = table.Column<string>(nullable: true),
                    Declaration = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndorsementApplication", x => x.EndorsAppID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EndorsementApplication");
        }
    }
}
