using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace QuasarWebAppAPI.Migrations
{
    /**
     * This migration creates the tables for the database 
    **/

    /// <inheritdoc />
    public partial class Initialize_Database_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blendflag",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blendflag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "deltav_sys",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deltav_sys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "deltaz_sys",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deltaz_sys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ew_err_obs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ew_err_obs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ew_obs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ew_obs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fwhm",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fwhm", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gradeflag",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gradeflag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lambda_obs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lambda_obs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lambda_vac",
                columns: table => new
                {
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "lya_flag",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    _10257 = table.Column<float>(name: "1025.7", type: "real", nullable: false),
                    _12157 = table.Column<float>(name: "1215.7", type: "real", nullable: false),
                    _12388 = table.Column<float>(name: "1238.8", type: "real", nullable: false),
                    _12604 = table.Column<float>(name: "1260.4", type: "real", nullable: false),
                    _13022 = table.Column<float>(name: "1302.2", type: "real", nullable: false),
                    _13044 = table.Column<float>(name: "1304.4", type: "real", nullable: false),
                    _13345 = table.Column<float>(name: "1334.5", type: "real", nullable: false),
                    _13938 = table.Column<float>(name: "1393.8", type: "real", nullable: false),
                    _14028 = table.Column<float>(name: "1402.8", type: "real", nullable: false),
                    _15267 = table.Column<float>(name: "1526.7", type: "real", nullable: false),
                    _15482 = table.Column<float>(name: "1548.2", type: "real", nullable: false),
                    _15508 = table.Column<float>(name: "1550.8", type: "real", nullable: false),
                    _16085 = table.Column<float>(name: "1608.5", type: "real", nullable: false),
                    _16569 = table.Column<float>(name: "1656.9", type: "real", nullable: false),
                    _16708 = table.Column<float>(name: "1670.8", type: "real", nullable: false),
                    _18547 = table.Column<float>(name: "1854.7", type: "real", nullable: false),
                    _18628 = table.Column<float>(name: "1862.8", type: "real", nullable: false),
                    _20261 = table.Column<float>(name: "2026.1", type: "real", nullable: false),
                    _20563 = table.Column<float>(name: "2056.3", type: "real", nullable: false),
                    _22608 = table.Column<float>(name: "2260.8", type: "real", nullable: false),
                    _23745 = table.Column<float>(name: "2374.5", type: "real", nullable: false),
                    _23828 = table.Column<float>(name: "2382.8", type: "real", nullable: false),
                    _25867 = table.Column<float>(name: "2586.7", type: "real", nullable: false),
                    _25945 = table.Column<float>(name: "2594.5", type: "real", nullable: false),
                    _26002 = table.Column<float>(name: "2600.2", type: "real", nullable: false),
                    _27964 = table.Column<float>(name: "2796.4", type: "real", nullable: false),
                    _28035 = table.Column<float>(name: "2803.5", type: "real", nullable: false),
                    _28530 = table.Column<float>(name: "2853.0", type: "real", nullable: false),
                    _32429 = table.Column<float>(name: "3242.9", type: "real", nullable: false),
                    _39348 = table.Column<float>(name: "3934.8", type: "real", nullable: false),
                    _39696 = table.Column<float>(name: "3969.6", type: "real", nullable: false),
                    _58915 = table.Column<float>(name: "5891.5", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lya_flag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "quasar_catalog",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    plate = table.Column<int>(type: "integer", nullable: false),
                    fiber = table.Column<int>(type: "integer", nullable: false),
                    mjd = table.Column<int>(type: "integer", nullable: false),
                    z_qso = table.Column<float>(type: "real", nullable: false),
                    imag = table.Column<float>(type: "real", nullable: false),
                    bal_flag = table.Column<int>(type: "integer", nullable: false),
                    bal_flag2 = table.Column<int>(type: "integer", nullable: false),
                    _20cm_flux = table.Column<float>(name: "20cm_flux", type: "real", nullable: false),
                    _20cm_snr = table.Column<float>(name: "20cm_snr", type: "real", nullable: false),
                    target_first = table.Column<int>(type: "integer", nullable: false),
                    sep_first = table.Column<float>(type: "real", nullable: false),
                    iabmag = table.Column<float>(type: "real", nullable: false),
                    z_fgal = table.Column<float>(type: "real", nullable: false),
                    spec_avesnr = table.Column<float>(type: "real", nullable: false),
                    spec_medsnr = table.Column<float>(type: "real", nullable: false),
                    spec_avesnr_red = table.Column<float>(type: "real", nullable: false),
                    spec_medsnr_red = table.Column<float>(type: "real", nullable: false),
                    ra_hex = table.Column<float>(type: "real", nullable: false),
                    dec_hex = table.Column<float>(type: "real", nullable: false),
                    ra_deg = table.Column<float>(type: "real", nullable: false),
                    dec_deg = table.Column<float>(type: "real", nullable: false),
                    run_date = table.Column<string>(type: "text", nullable: false),
                    avesnr_spec = table.Column<float>(type: "real", nullable: false),
                    num_5sigma_unided_inlya = table.Column<int>(type: "integer", nullable: false),
                    num_5sigma_unided_notinlya = table.Column<int>(type: "integer", nullable: false),
                    z_abs = table.Column<float>(type: "real", nullable: false),
                    grade = table.Column<string>(type: "text", nullable: false),
                    type = table.Column<string>(type: "text", nullable: false),
                    sys_num = table.Column<int>(type: "integer", nullable: false),
                    beta = table.Column<float>(type: "real", nullable: false),
                    dla_zabs_nd2013 = table.Column<float>(type: "real", nullable: false),
                    dla_flag_nd2013 = table.Column<float>(type: "real", nullable: false),
                    dla_lognhi_nd2013 = table.Column<float>(type: "real", nullable: false),
                    mgii_class_score = table.Column<float>(type: "real", nullable: false),
                    civ_class_score = table.Column<float>(type: "real", nullable: false),
                    other_class_score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quasar_catalog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "w_limits",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    col0 = table.Column<float>(type: "real", nullable: false),
                    col1 = table.Column<float>(type: "real", nullable: false),
                    col2 = table.Column<float>(type: "real", nullable: false),
                    col3 = table.Column<float>(type: "real", nullable: false),
                    col4 = table.Column<float>(type: "real", nullable: false),
                    col5 = table.Column<float>(type: "real", nullable: false),
                    col6 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_w_limits", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blendflag");

            migrationBuilder.DropTable(
                name: "deltav_sys");

            migrationBuilder.DropTable(
                name: "deltaz_sys");

            migrationBuilder.DropTable(
                name: "ew_err_obs");

            migrationBuilder.DropTable(
                name: "ew_obs");

            migrationBuilder.DropTable(
                name: "fwhm");

            migrationBuilder.DropTable(
                name: "gradeflag");

            migrationBuilder.DropTable(
                name: "lambda_obs");

            migrationBuilder.DropTable(
                name: "lambda_vac");

            migrationBuilder.DropTable(
                name: "lya_flag");

            migrationBuilder.DropTable(
                name: "quasar_catalog");

            migrationBuilder.DropTable(
                name: "w_limits");
        }
    }
}
