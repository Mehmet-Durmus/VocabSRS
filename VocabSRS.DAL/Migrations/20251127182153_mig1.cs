using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VocabSRS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeOfMeanings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfMeanings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KnownWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnownWords_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudiedWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoxNumber = table.Column<int>(type: "int", nullable: false),
                    WordId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiedWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudiedWords_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phrases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhraseText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudiedWordId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phrases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phrases_StudiedWords_StudiedWordId",
                        column: x => x.StudiedWordId,
                        principalTable: "StudiedWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WordMeanings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meaning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudiedWordId = table.Column<int>(type: "int", nullable: false),
                    TypeOfMeaningId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordMeanings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordMeanings_StudiedWords_StudiedWordId",
                        column: x => x.StudiedWordId,
                        principalTable: "StudiedWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WordMeanings_TypeOfMeanings_TypeOfMeaningId",
                        column: x => x.TypeOfMeaningId,
                        principalTable: "TypeOfMeanings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhraseMeanings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meaning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhraseId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhraseMeanings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhraseMeanings_Phrases_PhraseId",
                        column: x => x.PhraseId,
                        principalTable: "Phrases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WordSentences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sentence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WordMeaningId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordSentences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordSentences_WordMeanings_WordMeaningId",
                        column: x => x.WordMeaningId,
                        principalTable: "WordMeanings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhraseSentences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sentence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhraseMeaningId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatesAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhraseSentences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhraseSentences_PhraseMeanings_PhraseMeaningId",
                        column: x => x.PhraseMeaningId,
                        principalTable: "PhraseMeanings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KnownWords_WordId",
                table: "KnownWords",
                column: "WordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhraseMeanings_PhraseId",
                table: "PhraseMeanings",
                column: "PhraseId");

            migrationBuilder.CreateIndex(
                name: "IX_Phrases_StudiedWordId",
                table: "Phrases",
                column: "StudiedWordId");

            migrationBuilder.CreateIndex(
                name: "IX_PhraseSentences_PhraseMeaningId",
                table: "PhraseSentences",
                column: "PhraseMeaningId");

            migrationBuilder.CreateIndex(
                name: "IX_StudiedWords_WordId",
                table: "StudiedWords",
                column: "WordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WordMeanings_StudiedWordId",
                table: "WordMeanings",
                column: "StudiedWordId");

            migrationBuilder.CreateIndex(
                name: "IX_WordMeanings_TypeOfMeaningId",
                table: "WordMeanings",
                column: "TypeOfMeaningId");

            migrationBuilder.CreateIndex(
                name: "IX_WordSentences_WordMeaningId",
                table: "WordSentences",
                column: "WordMeaningId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnownWords");

            migrationBuilder.DropTable(
                name: "PhraseSentences");

            migrationBuilder.DropTable(
                name: "WordSentences");

            migrationBuilder.DropTable(
                name: "PhraseMeanings");

            migrationBuilder.DropTable(
                name: "WordMeanings");

            migrationBuilder.DropTable(
                name: "Phrases");

            migrationBuilder.DropTable(
                name: "TypeOfMeanings");

            migrationBuilder.DropTable(
                name: "StudiedWords");

            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
