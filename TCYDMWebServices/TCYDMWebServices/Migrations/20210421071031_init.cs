using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCYDMWebServices.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admintables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admintables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contactuss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactuss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "homepage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homepage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LangluageName = table.Column<string>(maxLength: 50, nullable: false),
                    ValueKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "serviceinfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Info = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceinfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 300, nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    NeedsAdittion = table.Column<int>(nullable: false),
                    NeedsPayment = table.Column<int>(nullable: false),
                    IsLocal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "visionmissionvalues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Vision = table.Column<string>(nullable: true),
                    Mission = table.Column<string>(nullable: true),
                    Values = table.Column<string>(nullable: true),
                    LangId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visionmissionvalues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "whatwedos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whatwedos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "whoweares",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_whoweares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 1000, nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_regions_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "serviceadditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServiceId = table.Column<int>(nullable: true),
                    InputId = table.Column<int>(nullable: false),
                    PlaceHolder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceadditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_serviceadditions_services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Surname = table.Column<string>(maxLength: 200, nullable: false),
                    TCNo = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    SexId = table.Column<int>(nullable: false),
                    BornYear = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    Token = table.Column<string>(maxLength: 200, nullable: true),
                    PKey = table.Column<string>(nullable: true),
                    IsConfirmed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "onlinequeries",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServiceId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ServiceDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Info = table.Column<string>(nullable: true),
                    IsSeen = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_onlinequeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_onlinequeries_services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_onlinequeries_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pdfbase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PDFName = table.Column<string>(nullable: true),
                    OnlineQueryId = table.Column<long>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pdfbase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pdfbase_onlinequeries_OnlineQueryId",
                        column: x => x.OnlineQueryId,
                        principalTable: "onlinequeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "serviceadditionfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OnlineQueryId = table.Column<long>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceadditionfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_serviceadditionfile_onlinequeries_OnlineQueryId",
                        column: x => x.OnlineQueryId,
                        principalTable: "onlinequeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "serviceadditionnumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OnlineQueryId = table.Column<long>(nullable: true),
                    Content = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceadditionnumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_serviceadditionnumber_onlinequeries_OnlineQueryId",
                        column: x => x.OnlineQueryId,
                        principalTable: "onlinequeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "serviceadditiontext",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OnlineQueryId = table.Column<long>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceadditiontext", x => x.Id);
                    table.ForeignKey(
                        name: "FK_serviceadditiontext_onlinequeries_OnlineQueryId",
                        column: x => x.OnlineQueryId,
                        principalTable: "onlinequeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_onlinequeries_ServiceId",
                table: "onlinequeries",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_onlinequeries_UserId",
                table: "onlinequeries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_pdfbase_OnlineQueryId",
                table: "pdfbase",
                column: "OnlineQueryId");

            migrationBuilder.CreateIndex(
                name: "IX_regions_CountryId",
                table: "regions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceadditionfile_OnlineQueryId",
                table: "serviceadditionfile",
                column: "OnlineQueryId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceadditionnumber_OnlineQueryId",
                table: "serviceadditionnumber",
                column: "OnlineQueryId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceadditions_ServiceId",
                table: "serviceadditions",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceadditiontext_OnlineQueryId",
                table: "serviceadditiontext",
                column: "OnlineQueryId");

            migrationBuilder.CreateIndex(
                name: "IX_users_CountryId",
                table: "users",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_users_RegionId",
                table: "users",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admintables");

            migrationBuilder.DropTable(
                name: "contactuss");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropTable(
                name: "homepage");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "pdfbase");

            migrationBuilder.DropTable(
                name: "serviceadditionfile");

            migrationBuilder.DropTable(
                name: "serviceadditionnumber");

            migrationBuilder.DropTable(
                name: "serviceadditions");

            migrationBuilder.DropTable(
                name: "serviceadditiontext");

            migrationBuilder.DropTable(
                name: "serviceinfos");

            migrationBuilder.DropTable(
                name: "visionmissionvalues");

            migrationBuilder.DropTable(
                name: "whatwedos");

            migrationBuilder.DropTable(
                name: "whoweares");

            migrationBuilder.DropTable(
                name: "onlinequeries");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
