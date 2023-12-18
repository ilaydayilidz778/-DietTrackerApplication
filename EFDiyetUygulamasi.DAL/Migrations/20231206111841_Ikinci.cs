using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyetUygulamasi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Ikinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgunBilgiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunId = table.Column<int>(type: "int", nullable: false),
                    TarihId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunBilgiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgunBilgiler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunBilgiler_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunBilgiler_Tarihler_TarihId",
                        column: x => x.TarihId,
                        principalTable: "Tarihler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesinOgunBilgisi",
                columns: table => new
                {
                    BesinlerId = table.Column<int>(type: "int", nullable: false),
                    OgunBilgilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinOgunBilgisi", x => new { x.BesinlerId, x.OgunBilgilerId });
                    table.ForeignKey(
                        name: "FK_BesinOgunBilgisi_Besinler_BesinlerId",
                        column: x => x.BesinlerId,
                        principalTable: "Besinler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesinOgunBilgisi_OgunBilgiler_OgunBilgilerId",
                        column: x => x.OgunBilgilerId,
                        principalTable: "OgunBilgiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgunBilgisi_OgunBilgilerId",
                table: "BesinOgunBilgisi",
                column: "OgunBilgilerId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunBilgiler_KullaniciId",
                table: "OgunBilgiler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunBilgiler_OgunId",
                table: "OgunBilgiler",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunBilgiler_TarihId",
                table: "OgunBilgiler",
                column: "TarihId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BesinOgunBilgisi");

            migrationBuilder.DropTable(
                name: "OgunBilgiler");
        }
    }
}
