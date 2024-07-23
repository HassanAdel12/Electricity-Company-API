using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityCompany.EF.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    Channel_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Channel_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Channel_Key);
                });

            migrationBuilder.CreateTable(
                name: "Cutting_Down_Ignoreds",
                columns: table => new
                {
                    Cutting_Down_Incident_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualCreatetDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SynchCreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Cabel_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cabin_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutting_Down_Ignoreds", x => x.Cutting_Down_Incident_ID);
                });

            migrationBuilder.CreateTable(
                name: "Governrates",
                columns: table => new
                {
                    Governrate_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Governrate_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governrates", x => x.Governrate_Key);
                });

            migrationBuilder.CreateTable(
                name: "Netwrok_Element_Hierarchy_Paths",
                columns: table => new
                {
                    Network_Element_Hierarchy_Path_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Netwrok_Element_Hierarchy_Path_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Netwrok_Element_Hierarchy_Paths", x => x.Network_Element_Hierarchy_Path_Key);
                });

            migrationBuilder.CreateTable(
                name: "Problem_Types",
                columns: table => new
                {
                    Problem_Type_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    problem_Type_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problem_Types", x => x.Problem_Type_Key);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Sector_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sector_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Governrate_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Sector_Key);
                    table.ForeignKey(
                        name: "FK_Sectors_Governrates_Governrate_Key",
                        column: x => x.Governrate_Key,
                        principalTable: "Governrates",
                        principalColumn: "Governrate_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Netwrok_Element_Types",
                columns: table => new
                {
                    Nework_Element_Type_key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Network_Element_Type_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Network_Element_Hierarchy_Path_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Netwrok_Element_Types", x => x.Nework_Element_Type_key);
                    table.ForeignKey(
                        name: "FK_Netwrok_Element_Types_Netwrok_Element_Hierarchy_Paths_Network_Element_Hierarchy_Path_Key",
                        column: x => x.Network_Element_Hierarchy_Path_Key,
                        principalTable: "Netwrok_Element_Hierarchy_Paths",
                        principalColumn: "Network_Element_Hierarchy_Path_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cutting_Down_As",
                columns: table => new
                {
                    Cutting_Down_A_Incident_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cutting_Down_Cabin_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Problem_Type_Key = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsPlanned = table.Column<bool>(type: "bit", nullable: false),
                    IsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    PlannedStartDTS = table.Column<DateOnly>(type: "date", nullable: false),
                    PlannedEndDTS = table.Column<DateOnly>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutting_Down_As", x => x.Cutting_Down_A_Incident_ID);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_As_Problem_Types_Problem_Type_Key",
                        column: x => x.Problem_Type_Key,
                        principalTable: "Problem_Types",
                        principalColumn: "Problem_Type_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cutting_Down_Bs",
                columns: table => new
                {
                    Cutting_Down_B_Incident_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cutting_Down_Cable_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Problem_Type_Key = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsPlanned = table.Column<bool>(type: "bit", nullable: false),
                    IsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    PlannedStartDTS = table.Column<DateOnly>(type: "date", nullable: false),
                    PlannedEndDTS = table.Column<DateOnly>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutting_Down_Bs", x => x.Cutting_Down_B_Incident_ID);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_Bs_Problem_Types_Problem_Type_Key",
                        column: x => x.Problem_Type_Key,
                        principalTable: "Problem_Types",
                        principalColumn: "Problem_Type_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cutting_Down_Headers",
                columns: table => new
                {
                    Cutting_Down_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cutting_Down_Incident_ID = table.Column<int>(type: "int", nullable: false),
                    Channel_Key = table.Column<int>(type: "int", nullable: false),
                    Cutting_Down_Problem_Type_Key = table.Column<int>(type: "int", nullable: false),
                    ActualCreatetDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SynchCreateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SynchUpdateDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ActualEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsPlanned = table.Column<bool>(type: "bit", nullable: false),
                    IsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    PlannedStartDTS = table.Column<DateOnly>(type: "date", nullable: false),
                    PlannedEndDTS = table.Column<DateOnly>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateSystemUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateSystemUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutting_Down_Headers", x => x.Cutting_Down_Key);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_Headers_Channels_Channel_Key",
                        column: x => x.Channel_Key,
                        principalTable: "Channels",
                        principalColumn: "Channel_Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_Headers_Cutting_Down_Ignoreds_Cutting_Down_Incident_ID",
                        column: x => x.Cutting_Down_Incident_ID,
                        principalTable: "Cutting_Down_Ignoreds",
                        principalColumn: "Cutting_Down_Incident_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_Headers_Problem_Types_Cutting_Down_Problem_Type_Key",
                        column: x => x.Cutting_Down_Problem_Type_Key,
                        principalTable: "Problem_Types",
                        principalColumn: "Problem_Type_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Zone_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zone_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Zone_Key);
                    table.ForeignKey(
                        name: "FK_Zones_Sectors_Sector_Key",
                        column: x => x.Sector_Key,
                        principalTable: "Sectors",
                        principalColumn: "Sector_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Network_Elements",
                columns: table => new
                {
                    Network_Element_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Network_Element_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nework_Element_Type_key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Network_Elements", x => x.Network_Element_Key);
                    table.ForeignKey(
                        name: "FK_Network_Elements_Netwrok_Element_Types_Nework_Element_Type_key",
                        column: x => x.Nework_Element_Type_key,
                        principalTable: "Netwrok_Element_Types",
                        principalColumn: "Nework_Element_Type_key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    City_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.City_Key);
                    table.ForeignKey(
                        name: "FK_Cities_Zones_Zone_Key",
                        column: x => x.Zone_Key,
                        principalTable: "Zones",
                        principalColumn: "Zone_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cutting_Down_Details",
                columns: table => new
                {
                    Cutting_Down_Detail_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cutting_Down_Key = table.Column<int>(type: "int", nullable: false),
                    Network_Element_Key = table.Column<int>(type: "int", nullable: false),
                    ActualCreatetDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ActualEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ImpactedCustomers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutting_Down_Details", x => x.Cutting_Down_Detail_Key);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_Details_Cutting_Down_Headers_Cutting_Down_Key",
                        column: x => x.Cutting_Down_Key,
                        principalTable: "Cutting_Down_Headers",
                        principalColumn: "Cutting_Down_Key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_Details_Network_Elements_Network_Element_Key",
                        column: x => x.Network_Element_Key,
                        principalTable: "Network_Elements",
                        principalColumn: "Network_Element_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Station_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Station_Key);
                    table.ForeignKey(
                        name: "FK_Stations_Cities_City_Key",
                        column: x => x.City_Key,
                        principalTable: "Cities",
                        principalColumn: "City_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Towers",
                columns: table => new
                {
                    Tower_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tower_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Station_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towers", x => x.Tower_Key);
                    table.ForeignKey(
                        name: "FK_Towers_Stations_Station_Key",
                        column: x => x.Station_Key,
                        principalTable: "Stations",
                        principalColumn: "Station_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cabins",
                columns: table => new
                {
                    Cabin_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cabin_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tower_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabins", x => x.Cabin_Key);
                    table.ForeignKey(
                        name: "FK_Cabins_Towers_Tower_Key",
                        column: x => x.Tower_Key,
                        principalTable: "Towers",
                        principalColumn: "Tower_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cables",
                columns: table => new
                {
                    Cable_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cable_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cabin_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cables", x => x.Cable_Key);
                    table.ForeignKey(
                        name: "FK_Cables_Cabins_Cabin_Key",
                        column: x => x.Cabin_Key,
                        principalTable: "Cabins",
                        principalColumn: "Cabin_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Block_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Block_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cable_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Block_Key);
                    table.ForeignKey(
                        name: "FK_Blocks_Cables_Cable_Key",
                        column: x => x.Cable_Key,
                        principalTable: "Cables",
                        principalColumn: "Cable_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Building_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Block_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Building_Key);
                    table.ForeignKey(
                        name: "FK_Buildings_Blocks_Block_Key",
                        column: x => x.Block_Key,
                        principalTable: "Blocks",
                        principalColumn: "Block_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    Flat_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.Flat_Key);
                    table.ForeignKey(
                        name: "FK_Flats_Buildings_Building_Key",
                        column: x => x.Building_Key,
                        principalTable: "Buildings",
                        principalColumn: "Building_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Subscription_Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flat_Key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Subscription_Key);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Flats_Flat_Key",
                        column: x => x.Flat_Key,
                        principalTable: "Flats",
                        principalColumn: "Flat_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blocks_Cable_Key",
                table: "Blocks",
                column: "Cable_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_Block_Key",
                table: "Buildings",
                column: "Block_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cabins_Tower_Key",
                table: "Cabins",
                column: "Tower_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_Cabin_Key",
                table: "Cables",
                column: "Cabin_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Zone_Key",
                table: "Cities",
                column: "Zone_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_As_Problem_Type_Key",
                table: "Cutting_Down_As",
                column: "Problem_Type_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Bs_Problem_Type_Key",
                table: "Cutting_Down_Bs",
                column: "Problem_Type_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Details_Cutting_Down_Key",
                table: "Cutting_Down_Details",
                column: "Cutting_Down_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Details_Network_Element_Key",
                table: "Cutting_Down_Details",
                column: "Network_Element_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Headers_Channel_Key",
                table: "Cutting_Down_Headers",
                column: "Channel_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Headers_Cutting_Down_Incident_ID",
                table: "Cutting_Down_Headers",
                column: "Cutting_Down_Incident_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_Headers_Cutting_Down_Problem_Type_Key",
                table: "Cutting_Down_Headers",
                column: "Cutting_Down_Problem_Type_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_Building_Key",
                table: "Flats",
                column: "Building_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Network_Elements_Nework_Element_Type_key",
                table: "Network_Elements",
                column: "Nework_Element_Type_key");

            migrationBuilder.CreateIndex(
                name: "IX_Netwrok_Element_Types_Network_Element_Hierarchy_Path_Key",
                table: "Netwrok_Element_Types",
                column: "Network_Element_Hierarchy_Path_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_Governrate_Key",
                table: "Sectors",
                column: "Governrate_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_City_Key",
                table: "Stations",
                column: "City_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_Flat_Key",
                table: "Subscriptions",
                column: "Flat_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Towers_Station_Key",
                table: "Towers",
                column: "Station_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_Sector_Key",
                table: "Zones",
                column: "Sector_Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cutting_Down_As");

            migrationBuilder.DropTable(
                name: "Cutting_Down_Bs");

            migrationBuilder.DropTable(
                name: "Cutting_Down_Details");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cutting_Down_Headers");

            migrationBuilder.DropTable(
                name: "Network_Elements");

            migrationBuilder.DropTable(
                name: "Flats");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "Cutting_Down_Ignoreds");

            migrationBuilder.DropTable(
                name: "Problem_Types");

            migrationBuilder.DropTable(
                name: "Netwrok_Element_Types");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Netwrok_Element_Hierarchy_Paths");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Cables");

            migrationBuilder.DropTable(
                name: "Cabins");

            migrationBuilder.DropTable(
                name: "Towers");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Governrates");
        }
    }
}
