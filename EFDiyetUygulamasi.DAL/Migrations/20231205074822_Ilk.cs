using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFDiyetUygulamasi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
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
                name: "Besinler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<decimal>(type: "decimal(5,1)", precision: 5, scale: 1, nullable: false),
                    Yag = table.Column<decimal>(type: "decimal(5,1)", precision: 5, scale: 1, nullable: false),
                    Karbonhidrat = table.Column<decimal>(type: "decimal(5,1)", precision: 5, scale: 1, nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    Porsiyon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Besinler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciProfiller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciProfiller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciProfiller_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogunler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Et Yemekleri" },
                    { 2, "Etli Sebze Yemekleri" },
                    { 3, "Tahıllı Yemekler" },
                    { 4, "Zeytin Yağlı Sebze Yemekleri" },
                    { 5, "Çorbalar" },
                    { 6, "Tatlılar" },
                    { 7, "Salatalar" },
                    { 8, "Meyvelar" },
                    { 9, "Kahvaltılıklar" },
                    { 10, "Süt ve Süt Ürünleri" },
                    { 11, "Soğuk İçecekler" },
                    { 12, "Sıcak İçecekler" }
                });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "Ad", "KullaniciId" },
                values: new object[,]
                {
                    { 1, "Kahvaltı", null },
                    { 2, "Ara Öğünler", null },
                    { 3, "Öğle Yemeği", null },
                    { 4, "Akşam Yemeği", null }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "Id", "Ad", "Kalori", "Karbonhidrat", "KategoriId", "Porsiyon", "Protein", "Yag" },
                values: new object[,]
                {
                    { 1, "Terbiyeli Köfte", 231, 5.7m, 1, 0, 20.5m, 15.3m },
                    { 2, "İzmir Köfte", 343, 3.7m, 1, 0, 18.2m, 28.4m },
                    { 3, "Fırın Tavuk", 275, 1.8m, 1, 0, 24.8m, 17.2m },
                    { 4, "Kuzu Tandır", 420, 0.9m, 1, 0, 29.5m, 34.8m },
                    { 5, "Köfte Izgara", 310, 2.4m, 1, 0, 22.1m, 23.7m },
                    { 6, "Beyti", 489, 26.8m, 1, 0, 24.8m, 23.2m },
                    { 7, "Patlıcan Kebabı", 265, 12.7m, 1, 0, 9.4m, 20.1m },
                    { 8, "Hünkar Beğendi", 380, 8.3m, 1, 0, 22.5m, 28.6m },
                    { 9, "Cızlak Kebap", 310, 3.2m, 1, 0, 17.8m, 24.5m },
                    { 10, "Ciğer Sote", 280, 3.8m, 1, 0, 18.6m, 21.4m },
                    { 11, "Tavuklu Pilav", 320, 28.1m, 1, 0, 20.2m, 12.5m },
                    { 12, "Fırın Mantarlı Tavuk", 290, 3.7m, 1, 0, 26.8m, 19.3m },
                    { 13, "Dana Kavurma", 360, 0.9m, 1, 0, 22.3m, 29.8m },
                    { 14, "Zeytinyağlı Yaprak Sarma", 180, 22.8m, 1, 0, 3.5m, 9.2m },
                    { 15, "Kuzu İncik", 450, 1.2m, 1, 0, 30.7m, 36.2m },
                    { 16, "Balık Tava", 260, 0.6m, 1, 0, 24.1m, 17.8m },
                    { 17, "Kağıt Kebabı", 310, 2.4m, 1, 0, 22.5m, 23.7m },
                    { 18, "Tavuk Kapama", 280, 3.8m, 1, 0, 19.3m, 20.1m },
                    { 19, "Ali Nazik Kebabı", 340, 6.3m, 1, 0, 21.7m, 25.2m },
                    { 20, "Kuzu Güveç", 390, 0.9m, 1, 0, 28.2m, 31.6m },
                    { 21, "İskender", 480, 18.4m, 1, 0, 26.7m, 33.2m },
                    { 22, "Fırın Tavuk But", 310, 0.8m, 1, 0, 24.5m, 21.2m },
                    { 23, "Tavuklu Karnabahar", 240, 5.7m, 1, 0, 18.2m, 16.9m },
                    { 24, "Balıklı Pilav", 360, 27.9m, 1, 0, 25.6m, 14.8m },
                    { 25, "Hamsili Ekmek", 280, 7.1m, 1, 0, 20.3m, 18.9m },
                    { 26, "Fırın Mantarlı Tavuk", 290, 3.7m, 1, 0, 26.8m, 19.3m },
                    { 27, "Peynirli Kuzu Kuyma", 420, 1.9m, 1, 0, 30.5m, 34.1m },
                    { 28, "Cevizli Kuzu Güveç", 380, 5.3m, 1, 0, 25.2m, 29.7m },
                    { 29, "Fırın Tavuk Kanat", 270, 0.6m, 1, 0, 23.4m, 18.1m },
                    { 30, "Yogurtlu Tavuk Şiş", 320, 3.2m, 1, 0, 22.8m, 24.5m },
                    { 31, "Fırın Karnabahar Kızartması", 180, 15.8m, 2, 0, 6.7m, 12.4m },
                    { 32, "Patlıcanlı Kıymalı Güveç", 250, 7.9m, 2, 0, 14.3m, 18.6m },
                    { 33, "Kuzu Kapama", 320, 2.8m, 2, 0, 22.5m, 25.1m },
                    { 34, "Zeytinyağlı Pırasa", 150, 11.8m, 2, 0, 4.6m, 10.2m },
                    { 35, "Taze Fasulye Türlü", 200, 13.5m, 2, 0, 9.8m, 12.7m },
                    { 36, "Kabak Karnabahar Graten", 280, 16.8m, 2, 0, 13.6m, 19.3m },
                    { 37, "Sebzeli Kıymalı Börek", 320, 7.2m, 2, 0, 18.7m, 24.5m },
                    { 38, "Zeytinyağlı Enginar", 180, 11.5m, 2, 0, 4.2m, 13.8m },
                    { 39, "Kırmızı Mercimek Koftesi", 240, 6.5m, 2, 0, 12.3m, 18.9m },
                    { 40, "Karnabahar Köftesi", 210, 16.7m, 2, 0, 8.5m, 14.2m },
                    { 41, "Quinoa Salatası", 180, 19.8m, 3, 0, 6.5m, 9.2m },
                    { 42, "Cevizli Kabak Tarator", 220, 11.3m, 3, 0, 5.8m, 17.1m },
                    { 43, "Karnabahar Kuskusu", 250, 28.4m, 3, 0, 7.3m, 12.9m },
                    { 44, "Bulgur Pilavı", 290, 61.2m, 3, 0, 6.7m, 1.5m },
                    { 45, "İncirli Armut Pilavı", 310, 66.5m, 3, 0, 8.2m, 4.6m },
                    { 46, "Yulaf Ezmesi", 180, 33.5m, 3, 0, 5.4m, 3.2m },
                    { 47, "Pirinç Pilavı", 320, 69.4m, 3, 0, 6.9m, 1.8m },
                    { 48, "Fasulye Pilavı", 250, 47.2m, 3, 0, 7.8m, 3.5m },
                    { 49, "Beyaz Nohut Pilavı", 280, 53.8m, 3, 0, 10.1m, 4.7m },
                    { 50, "Kabaklı Bulgur Pilavı", 210, 43.7m, 3, 0, 5.9m, 2.1m },
                    { 51, "Zeytinyağlı Yaprak Sarma", 180, 15.2m, 4, 0, 3.5m, 12.6m },
                    { 52, "Zeytinyağlı Kabak Dolması", 150, 12.4m, 4, 0, 2.8m, 10.3m },
                    { 53, "Zeytinyağlı Pırasa", 120, 9.7m, 4, 0, 2.4m, 8.1m },
                    { 54, "Zeytinyağlı Taze Fasulye", 140, 11.5m, 4, 0, 3.1m, 8.8m },
                    { 55, "Zeytinyağlı Enginar", 200, 14.7m, 4, 0, 4.6m, 15.4m },
                    { 56, "Zeytinyağlı Karnabahar", 160, 12.9m, 4, 0, 3.2m, 11.5m },
                    { 57, "Zeytinyağlı Bamya", 130, 10.7m, 4, 0, 2.9m, 8.6m },
                    { 58, "Zeytinyağlı Ispanak", 110, 9.4m, 4, 0, 2.1m, 7.2m },
                    { 59, "Zeytinyağlı Pırasa Yemeği", 140, 11.8m, 4, 0, 3.3m, 9.2m },
                    { 60, "Zeytinyağlı Taze Fasulye Pilaki", 150, 12.5m, 4, 0, 3.7m, 9.8m },
                    { 71, "Mercimek Çorbası", 150, 21.8m, 5, 0, 9.5m, 3.2m },
                    { 72, "Tarator Çorbası", 120, 12.6m, 5, 0, 7.8m, 5.1m },
                    { 73, "Domates Çorbası", 110, 18.5m, 5, 0, 4.2m, 2.8m },
                    { 74, "Tavuklu Şehriye Çorbası", 180, 23.7m, 5, 0, 12.3m, 4.6m },
                    { 75, "Ezogelin Çorbası", 160, 24.2m, 5, 0, 8.9m, 3.5m },
                    { 76, "Yoğurtlu Çorba", 140, 15.9m, 5, 0, 7.4m, 6.8m },
                    { 77, "Kremalı Mantar Çorbası", 220, 9.7m, 5, 0, 5.6m, 18.3m },
                    { 78, "Kabak Çorbası", 130, 14.8m, 5, 0, 3.7m, 7.2m },
                    { 79, "Kırmızı Mercimek Çorbası", 160, 25.4m, 5, 0, 9.8m, 2.6m },
                    { 80, "İrmik Helvası", 528, 63.3m, 6, 0, 7.6m, 29.8m },
                    { 81, "Sütlaç", 347, 67.2m, 6, 0, 8.2m, 7.2m },
                    { 82, "Baklava", 450, 40.2m, 6, 0, 7.5m, 29.5m },
                    { 83, "Kazandibi", 280, 35.2m, 6, 0, 5.8m, 12.6m },
                    { 84, "Revani", 315, 38.1m, 6, 0, 6.2m, 15.8m },
                    { 85, "Dondurma", 207, 22.6m, 6, 0, 5.4m, 11.2m },
                    { 86, "Domates Salatası", 127, 11.6m, 7, 0, 2.5m, 8.4m },
                    { 87, "Cacık", 75, 3.9m, 7, 0, 3.2m, 5.6m },
                    { 88, "Roka Salatası", 64, 2.9m, 7, 0, 3.9m, 4.7m },
                    { 89, "Ceasar Salatası", 184, 3.2m, 7, 0, 4.8m, 16.7m },
                    { 90, "Mevsim Salatası", 95, 7.6m, 7, 0, 3.1m, 6.4m },
                    { 92, "Kayısı", 63, 15.3m, 8, 0, 1.0m, 0.2m },
                    { 93, "Muz", 96, 25.0m, 8, 0, 1.3m, 0.3m },
                    { 94, "Kiraz", 63, 16.0m, 8, 0, 1.1m, 0.2m },
                    { 95, "Üzüm", 69, 17.5m, 8, 0, 0.7m, 0.2m },
                    { 96, "Kavun", 73, 18.0m, 8, 0, 0.9m, 0.2m },
                    { 97, "Karpuz", 30, 8.0m, 8, 0, 0.6m, 0.2m },
                    { 98, "Portakal", 43, 8.3m, 8, 0, 1.0m, 0.2m },
                    { 99, "Mandalina", 70, 13.5m, 8, 0, 0.8m, 0.2m },
                    { 100, "Malta eriği", 38, 9.6m, 8, 0, 0.9m, 0.2m },
                    { 101, "Elma", 52, 14.0m, 8, 0, 0.3m, 0.2m },
                    { 102, "Toz Şeker", 76, 20.0m, 9, 0, 0.0m, 0.0m },
                    { 103, "Peynir (Kaşar)", 121, 1.0m, 9, 0, 6.0m, 10.0m },
                    { 104, "Peynir(Beyaz)", 87, 1.0m, 9, 0, 7.0m, 6.0m },
                    { 105, "Reçel", 96, 25.0m, 9, 0, 0.3m, 0.1m },
                    { 106, "Yağ(Margarin)", 221, 0.0m, 9, 0, 0.3m, 24.0m },
                    { 107, "Yumurta", 80, 1.0m, 9, 0, 6.0m, 5.0m },
                    { 108, "Zeytin(Yeşil)", 43, 0.0m, 9, 0, 0.5m, 4.0m },
                    { 109, "Zeytin(Siyah)", 62, 1.0m, 9, 0, 0.5m, 6.0m },
                    { 110, "Ekmek", 276, 56.0m, 9, 0, 9.0m, 1.0m },
                    { 111, "İnek Sütü", 61, 5.0m, 10, 0, 3.0m, 3.0m },
                    { 112, "Yoğurt", 63, 4.0m, 10, 0, 4.0m, 3.0m },
                    { 115, "Kola", 140, 39.0m, 11, 0, 0.0m, 0.0m },
                    { 116, "Portakal Suyu", 110, 26.0m, 11, 0, 2.0m, 0.5m },
                    { 117, "Limonata", 120, 30.0m, 11, 0, 0.5m, 0.0m },
                    { 118, "Gazoz", 90, 24.0m, 11, 0, 0.0m, 0.0m },
                    { 119, "Meyve Smoothie", 200, 45.0m, 11, 0, 2.5m, 1.0m },
                    { 120, "Türk Kahvesi", 5, 0.0m, 12, 0, 0.5m, 0.2m },
                    { 121, "Siyah Çay", 2, 0.5m, 12, 0, 0.1m, 0.0m },
                    { 122, "Yeşil Çay", 0, 0.0m, 12, 0, 0.0m, 0.0m },
                    { 123, "Nane Limon Çayı", 4, 0.8m, 12, 0, 0.1m, 0.0m },
                    { 124, "Salep", 150, 30.0m, 12, 0, 1.5m, 2.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_KategoriId",
                table: "Besinler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgun_OgunlerId",
                table: "BesinOgun",
                column: "OgunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciProfiller_KullaniciId",
                table: "KullaniciProfiller",
                column: "KullaniciId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogunler_KullaniciId",
                table: "Ogunler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunTarih_TarihlerId",
                table: "OgunTarih",
                column: "TarihlerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BesinOgun");

            migrationBuilder.DropTable(
                name: "KullaniciProfiller");

            migrationBuilder.DropTable(
                name: "OgunTarih");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Tarihler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
