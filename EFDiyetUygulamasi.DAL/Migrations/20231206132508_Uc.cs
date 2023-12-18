using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyetUygulamasi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Uc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgunBilgiler_Tarihler_TarihId",
                table: "OgunBilgiler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogunler_Kullanicilar_KullaniciId",
                table: "Ogunler");

            migrationBuilder.DropTable(
                name: "BesinOgun");

            migrationBuilder.DropTable(
                name: "BesinOgunBilgisi");

            migrationBuilder.DropTable(
                name: "OgunTarih");

            migrationBuilder.DropTable(
                name: "Tarihler");

            migrationBuilder.DropIndex(
                name: "IX_Ogunler_KullaniciId",
                table: "Ogunler");

            migrationBuilder.DropIndex(
                name: "IX_OgunBilgiler_TarihId",
                table: "OgunBilgiler");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "Porsiyon",
                table: "Besinler");

            migrationBuilder.RenameColumn(
                name: "TarihId",
                table: "OgunBilgiler",
                newName: "Porsiyon");

            migrationBuilder.AddColumn<int>(
                name: "BesinId",
                table: "OgunBilgiler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "OgunBilgiler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_OgunBilgiler_BesinId",
                table: "OgunBilgiler",
                column: "BesinId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgunBilgiler_Besinler_BesinId",
                table: "OgunBilgiler",
                column: "BesinId",
                principalTable: "Besinler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgunBilgiler_Besinler_BesinId",
                table: "OgunBilgiler");

            migrationBuilder.DropIndex(
                name: "IX_OgunBilgiler_BesinId",
                table: "OgunBilgiler");

            migrationBuilder.DropColumn(
                name: "BesinId",
                table: "OgunBilgiler");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "OgunBilgiler");

            migrationBuilder.RenameColumn(
                name: "Porsiyon",
                table: "OgunBilgiler",
                newName: "TarihId");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Ogunler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Porsiyon",
                table: "Besinler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BesinOgun",
                columns: table => new
                {
                    BesinlerId = table.Column<int>(type: "int", nullable: false),
                    OgunlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinOgun", x => new { x.BesinlerId, x.OgunlerId });
                    table.ForeignKey(
                        name: "FK_BesinOgun_Besinler_BesinlerId",
                        column: x => x.BesinlerId,
                        principalTable: "Besinler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesinOgun_Ogunler_OgunlerId",
                        column: x => x.OgunlerId,
                        principalTable: "Ogunler",
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

            migrationBuilder.CreateTable(
                name: "Tarihler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarihler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgunTarih",
                columns: table => new
                {
                    OgunlerId = table.Column<int>(type: "int", nullable: false),
                    TarihlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunTarih", x => new { x.OgunlerId, x.TarihlerId });
                    table.ForeignKey(
                        name: "FK_OgunTarih_Ogunler_OgunlerId",
                        column: x => x.OgunlerId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunTarih_Tarihler_TarihlerId",
                        column: x => x.TarihlerId,
                        principalTable: "Tarihler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 2,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 3,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 4,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 5,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 6,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 7,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 8,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 9,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 10,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 11,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 12,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 13,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 14,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 15,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 16,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 17,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 18,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 19,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 20,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 21,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 22,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 23,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 24,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 25,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 26,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 27,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 28,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 29,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 30,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 31,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 32,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 33,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 34,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 35,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 36,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 37,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 38,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 39,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 40,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 41,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 42,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 43,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 44,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 45,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 46,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 47,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 48,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 49,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 50,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 51,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 52,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 53,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 54,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 55,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 56,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 57,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 58,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 59,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 60,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 71,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 72,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 73,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 74,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 75,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 76,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 77,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 78,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 79,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 80,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 81,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 82,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 83,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 84,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 85,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 86,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 87,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 88,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 89,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 90,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 92,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 93,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 94,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 95,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 96,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 97,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 98,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 99,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 100,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 101,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 102,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 103,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 104,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 105,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 106,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 107,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 108,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 109,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 110,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 111,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 112,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 115,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 116,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 117,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 118,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 119,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 120,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 121,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 122,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 123,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "Id",
                keyValue: 124,
                column: "Porsiyon",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 1,
                column: "KullaniciId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 2,
                column: "KullaniciId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 3,
                column: "KullaniciId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ogunler",
                keyColumn: "Id",
                keyValue: 4,
                column: "KullaniciId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_KullaniciId",
                table: "Ogunler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunBilgiler_TarihId",
                table: "OgunBilgiler",
                column: "TarihId");

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgun_OgunlerId",
                table: "BesinOgun",
                column: "OgunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgunBilgisi_OgunBilgilerId",
                table: "BesinOgunBilgisi",
                column: "OgunBilgilerId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunTarih_TarihlerId",
                table: "OgunTarih",
                column: "TarihlerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgunBilgiler_Tarihler_TarihId",
                table: "OgunBilgiler",
                column: "TarihId",
                principalTable: "Tarihler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogunler_Kullanicilar_KullaniciId",
                table: "Ogunler",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "Id");
        }
    }
}
