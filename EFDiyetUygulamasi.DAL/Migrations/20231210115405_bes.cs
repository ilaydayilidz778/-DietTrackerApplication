using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDiyetUygulamasi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class bes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResimYolu",
                table: "Kategoriler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "ResimYolu",
                value: "Image\\Et Yemekleri.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "ResimYolu",
                value: "Image\\Etli Sebze Yemekleri.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "ResimYolu",
                value: "Image\\Tahıllı Yemekler.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "ResimYolu",
                value: "Image\\Zeytin Yağlı Sebze Yemekleri.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "ResimYolu",
                value: "Image\\Çorbalar.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "ResimYolu",
                value: "Image\\Tatlılar.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "ResimYolu",
                value: "Image\\Salatalar.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Ad", "ResimYolu" },
                values: new object[] { "Meyveler", "Image\\Meyveler.png" });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 9,
                column: "ResimYolu",
                value: "Image\\Kahvaltılıklar.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 10,
                column: "ResimYolu",
                value: "Image\\Süt ve Süt Ürünleri.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 11,
                column: "ResimYolu",
                value: "Image\\Soğuk İçecekler.png");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 12,
                column: "ResimYolu",
                value: "Image\\Sıcak İçecekler.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResimYolu",
                table: "Kategoriler");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8,
                column: "Ad",
                value: "Meyvelar");
        }
    }
}
