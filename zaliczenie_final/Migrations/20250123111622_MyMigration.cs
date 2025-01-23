using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zaliczenie_final.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    country_name = table.Column<string>(type: "TEXT", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ranking_system",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    system_name = table.Column<string>(type: "TEXT", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ranking_system", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "university",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    country_id = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    university_name = table.Column<string>(type: "TEXT", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_university", x => x.id);
                    table.ForeignKey(
                        name: "FK_university_country_country_id",
                        column: x => x.country_id,
                        principalTable: "country",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ranking_criteria",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false),
                    ranking_system_id = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    criteria_name = table.Column<string>(type: "TEXT", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ranking_criteria", x => x.id);
                    table.ForeignKey(
                        name: "FK_ranking_criteria_ranking_system_ranking_system_id",
                        column: x => x.ranking_system_id,
                        principalTable: "ranking_system",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "university_year",
                columns: table => new
                {
                    university_id = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    year = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    num_students = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    student_staff_ratio = table.Column<double>(type: "REAL", nullable: true, defaultValueSql: "NULL"),
                    pct_international_students = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    pct_female_students = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_university_year_university_university_id",
                        column: x => x.university_id,
                        principalTable: "university",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "university_ranking_year",
                columns: table => new
                {
                    university_id = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    ranking_criteria_id = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    year = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL"),
                    score = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_university_ranking_year_ranking_criteria_ranking_criteria_id",
                        column: x => x.ranking_criteria_id,
                        principalTable: "ranking_criteria",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_university_ranking_year_university_university_id",
                        column: x => x.university_id,
                        principalTable: "university",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ranking_criteria_ranking_system_id",
                table: "ranking_criteria",
                column: "ranking_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_university_country_id",
                table: "university",
                column: "country_id");

            migrationBuilder.CreateIndex(
                name: "IX_university_ranking_year_ranking_criteria_id",
                table: "university_ranking_year",
                column: "ranking_criteria_id");

            migrationBuilder.CreateIndex(
                name: "IX_university_ranking_year_university_id",
                table: "university_ranking_year",
                column: "university_id");

            migrationBuilder.CreateIndex(
                name: "IX_university_year_university_id",
                table: "university_year",
                column: "university_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "university_ranking_year");

            migrationBuilder.DropTable(
                name: "university_year");

            migrationBuilder.DropTable(
                name: "ranking_criteria");

            migrationBuilder.DropTable(
                name: "university");

            migrationBuilder.DropTable(
                name: "ranking_system");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
