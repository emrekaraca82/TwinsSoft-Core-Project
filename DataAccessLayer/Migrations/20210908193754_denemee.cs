using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class denemee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutContent = table.Column<long>(type: "bigint", nullable: false),
                    AboutImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    ContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentDetail = table.Column<long>(type: "bigint", nullable: false),
                    ContentKeyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentStatus = table.Column<bool>(type: "bit", nullable: false),
                    ContentOrder = table.Column<int>(type: "int", nullable: false),
                    ContentCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ContentID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpSecure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instgram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lınkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Google = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recaptha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Analystic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingID);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderLinkWriter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderOrder = table.Column<int>(type: "int", nullable: false),
                    SliderStatus = table.Column<bool>(type: "bit", nullable: false),
                    SliderCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderID);
                });

            migrationBuilder.CreateTable(
                name: "SubMenus",
                columns: table => new
                {
                    SubMenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubMenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubMenuUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubMenuIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubMenuStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenus", x => x.SubMenuID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAuthorization = table.Column<bool>(type: "bit", nullable: false),
                    UserCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuSubId = table.Column<int>(type: "int", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuStatus = table.Column<bool>(type: "bit", nullable: false),
                    SubMenuID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Menus_SubMenus_SubMenuID",
                        column: x => x.SubMenuID,
                        principalTable: "SubMenus",
                        principalColumn: "SubMenuID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_SubMenuID",
                table: "Menus",
                column: "SubMenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubMenus");
        }
    }
}
