using EFDiyetUygulamasi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.DAL.Context
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciProfil> KullaniciProfiller { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<OgunBilgisi> OgunBilgiler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server=.;database=EFDiyetUygulamasi;TrustServerCertificate=True;trusted_connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
             new Kategori { Id = 1, Ad = "Et Yemekleri", ResimYolu = @"Image\Et Yemekleri.png" },
             new Kategori { Id = 2, Ad = "Etli Sebze Yemekleri", ResimYolu = @"Image\Etli Sebze Yemekleri.png" },
             new Kategori { Id = 3, Ad = "Tahıllı Yemekler", ResimYolu = @"Image\Tahıllı Yemekler.png" },
             new Kategori { Id = 4, Ad = "Zeytin Yağlı Sebze Yemekleri", ResimYolu = @"Image\Zeytin Yağlı Sebze Yemekleri.png" },
             new Kategori { Id = 5, Ad = "Çorbalar", ResimYolu = @"Image\Çorbalar.png" },
             new Kategori { Id = 6, Ad = "Tatlılar", ResimYolu = @"Image\Tatlılar.png" },
             new Kategori { Id = 7, Ad = "Salatalar", ResimYolu = @"Image\Salatalar.png" },
             new Kategori { Id = 8, Ad = "Meyveler", ResimYolu = @"Image\Meyveler.png" },
             new Kategori { Id = 9, Ad = "Kahvaltılıklar", ResimYolu = @"Image\Kahvaltılıklar.png" },
             new Kategori { Id = 10, Ad = "Süt ve Süt Ürünleri", ResimYolu = @"Image\Süt ve Süt Ürünleri.png" },
             new Kategori { Id = 11, Ad = "Soğuk İçecekler", ResimYolu = @"Image\Soğuk İçecekler.png" },
             new Kategori { Id = 12, Ad = "Sıcak İçecekler", ResimYolu = @"Image\Sıcak İçecekler.png" }
             );

            modelBuilder.Entity<Besin>().HasData(
            new Besin { Id = 1, Ad = "Terbiyeli Köfte", Kalori = 231, Protein = 20.5m, Yag = 15.3m, Karbonhidrat = 5.7m, KategoriId = 1 },
            new Besin { Id = 2, Ad = "İzmir Köfte", Kalori = 343, Protein = 18.2m, Yag = 28.4m, Karbonhidrat = 3.7m, KategoriId = 1 },
            new Besin { Id = 3, Ad = "Fırın Tavuk", Kalori = 275, Protein = 24.8m, Yag = 17.2m, Karbonhidrat = 1.8m, KategoriId = 1 },
            new Besin { Id = 4, Ad = "Kuzu Tandır", Kalori = 420, Protein = 29.5m, Yag = 34.8m, Karbonhidrat = 0.9m, KategoriId = 1 },
            new Besin { Id = 5, Ad = "Köfte Izgara", Kalori = 310, Protein = 22.1m, Yag = 23.7m, Karbonhidrat = 2.4m, KategoriId = 1 },
            new Besin { Id = 6, Ad = "Beyti", Kalori = 489, Protein = 24.8m, Yag = 23.2m, Karbonhidrat = 26.8m, KategoriId = 1 },
            new Besin { Id = 7, Ad = "Patlıcan Kebabı", Kalori = 265, Protein = 9.4m, Yag = 20.1m, Karbonhidrat = 12.7m, KategoriId = 1 },
            new Besin { Id = 8, Ad = "Hünkar Beğendi", Kalori = 380, Protein = 22.5m, Yag = 28.6m, Karbonhidrat = 8.3m, KategoriId = 1 },
            new Besin { Id = 9, Ad = "Cızlak Kebap", Kalori = 310, Protein = 17.8m, Yag = 24.5m, Karbonhidrat = 3.2m, KategoriId = 1 },
            new Besin { Id = 10, Ad = "Ciğer Sote", Kalori = 280, Protein = 18.6m, Yag = 21.4m, Karbonhidrat = 3.8m, KategoriId = 1 },
            new Besin { Id = 11, Ad = "Tavuklu Pilav", Kalori = 320, Protein = 20.2m, Yag = 12.5m, Karbonhidrat = 28.1m, KategoriId = 1 },
            new Besin { Id = 12, Ad = "Fırın Mantarlı Tavuk", Kalori = 290, Protein = 26.8m, Yag = 19.3m, Karbonhidrat = 3.7m, KategoriId = 1 },
            new Besin { Id = 13, Ad = "Dana Kavurma", Kalori = 360, Protein = 22.3m, Yag = 29.8m, Karbonhidrat = 0.9m, KategoriId = 1 },
            new Besin { Id = 14, Ad = "Zeytinyağlı Yaprak Sarma", Kalori = 180, Protein = 3.5m, Yag = 9.2m, Karbonhidrat = 22.8m, KategoriId = 1 },
            new Besin { Id = 15, Ad = "Kuzu İncik", Kalori = 450, Protein = 30.7m, Yag = 36.2m, Karbonhidrat = 1.2m, KategoriId = 1 },
            new Besin { Id = 16, Ad = "Balık Tava", Kalori = 260, Protein = 24.1m, Yag = 17.8m, Karbonhidrat = 0.6m, KategoriId = 1 },
            new Besin { Id = 17, Ad = "Kağıt Kebabı", Kalori = 310, Protein = 22.5m, Yag = 23.7m, Karbonhidrat = 2.4m, KategoriId = 1 },
            new Besin { Id = 18, Ad = "Tavuk Kapama", Kalori = 280, Protein = 19.3m, Yag = 20.1m, Karbonhidrat = 3.8m, KategoriId = 1 },
            new Besin { Id = 19, Ad = "Ali Nazik Kebabı", Kalori = 340, Protein = 21.7m, Yag = 25.2m, Karbonhidrat = 6.3m, KategoriId = 1 },
            new Besin { Id = 20, Ad = "Kuzu Güveç", Kalori = 390, Protein = 28.2m, Yag = 31.6m, Karbonhidrat = 0.9m, KategoriId = 1 },
            new Besin { Id = 21, Ad = "İskender", Kalori = 480, Protein = 26.7m, Yag = 33.2m, Karbonhidrat = 18.4m, KategoriId = 1 },
            new Besin { Id = 22, Ad = "Fırın Tavuk But", Kalori = 310, Protein = 24.5m, Yag = 21.2m, Karbonhidrat = 0.8m, KategoriId = 1 },
            new Besin { Id = 23, Ad = "Tavuklu Karnabahar", Kalori = 240, Protein = 18.2m, Yag = 16.9m, Karbonhidrat = 5.7m, KategoriId = 1 },
            new Besin { Id = 24, Ad = "Balıklı Pilav", Kalori = 360, Protein = 25.6m, Yag = 14.8m, Karbonhidrat = 27.9m, KategoriId = 1 },
            new Besin { Id = 25, Ad = "Hamsili Ekmek", Kalori = 280, Protein = 20.3m, Yag = 18.9m, Karbonhidrat = 7.1m, KategoriId = 1 },
            new Besin { Id = 26, Ad = "Fırın Mantarlı Tavuk", Kalori = 290, Protein = 26.8m, Yag = 19.3m, Karbonhidrat = 3.7m, KategoriId = 1 },
            new Besin { Id = 27, Ad = "Peynirli Kuzu Kuyma", Kalori = 420, Protein = 30.5m, Yag = 34.1m, Karbonhidrat = 1.9m, KategoriId = 1 },
            new Besin { Id = 28, Ad = "Cevizli Kuzu Güveç", Kalori = 380, Protein = 25.2m, Yag = 29.7m, Karbonhidrat = 5.3m, KategoriId = 1 },
            new Besin { Id = 29, Ad = "Fırın Tavuk Kanat", Kalori = 270, Protein = 23.4m, Yag = 18.1m, Karbonhidrat = 0.6m, KategoriId = 1 },
            new Besin { Id = 30, Ad = "Yogurtlu Tavuk Şiş", Kalori = 320, Protein = 22.8m, Yag = 24.5m, Karbonhidrat = 3.2m, KategoriId = 1 },
            new Besin { Id = 31, Ad = "Fırın Karnabahar Kızartması", Kalori = 180, Protein = 6.7m, Yag = 12.4m, Karbonhidrat = 15.8m, KategoriId = 2 },
            new Besin { Id = 32, Ad = "Patlıcanlı Kıymalı Güveç", Kalori = 250, Protein = 14.3m, Yag = 18.6m, Karbonhidrat = 7.9m, KategoriId = 2 },
            new Besin { Id = 33, Ad = "Kuzu Kapama", Kalori = 320, Protein = 22.5m, Yag = 25.1m, Karbonhidrat = 2.8m, KategoriId = 2 },
            new Besin { Id = 34, Ad = "Zeytinyağlı Pırasa", Kalori = 150, Protein = 4.6m, Yag = 10.2m, Karbonhidrat = 11.8m, KategoriId = 2 },
            new Besin { Id = 35, Ad = "Taze Fasulye Türlü", Kalori = 200, Protein = 9.8m, Yag = 12.7m, Karbonhidrat = 13.5m, KategoriId = 2 },
            new Besin { Id = 36, Ad = "Kabak Karnabahar Graten", Kalori = 280, Protein = 13.6m, Yag = 19.3m, Karbonhidrat = 16.8m, KategoriId = 2 },
            new Besin { Id = 37, Ad = "Sebzeli Kıymalı Börek", Kalori = 320, Protein = 18.7m, Yag = 24.5m, Karbonhidrat = 7.2m, KategoriId = 2 },
            new Besin { Id = 38, Ad = "Zeytinyağlı Enginar", Kalori = 180, Protein = 4.2m, Yag = 13.8m, Karbonhidrat = 11.5m, KategoriId = 2 },
            new Besin { Id = 39, Ad = "Kırmızı Mercimek Koftesi", Kalori = 240, Protein = 12.3m, Yag = 18.9m, Karbonhidrat = 6.5m, KategoriId = 2 },
            new Besin { Id = 40, Ad = "Karnabahar Köftesi", Kalori = 210, Protein = 8.5m, Yag = 14.2m, Karbonhidrat = 16.7m, KategoriId = 2 },
            new Besin { Id = 41, Ad = "Quinoa Salatası", Kalori = 180, Protein = 6.5m, Yag = 9.2m, Karbonhidrat = 19.8m, KategoriId = 3 },
            new Besin { Id = 42, Ad = "Cevizli Kabak Tarator", Kalori = 220, Protein = 5.8m, Yag = 17.1m, Karbonhidrat = 11.3m, KategoriId = 3 },
            new Besin { Id = 43, Ad = "Karnabahar Kuskusu", Kalori = 250, Protein = 7.3m, Yag = 12.9m, Karbonhidrat = 28.4m, KategoriId = 3 },
            new Besin { Id = 44, Ad = "Bulgur Pilavı", Kalori = 290, Protein = 6.7m, Yag = 1.5m, Karbonhidrat = 61.2m, KategoriId = 3 },
            new Besin { Id = 45, Ad = "İncirli Armut Pilavı", Kalori = 310, Protein = 8.2m, Yag = 4.6m, Karbonhidrat = 66.5m, KategoriId = 3 },
            new Besin { Id = 46, Ad = "Yulaf Ezmesi", Kalori = 180, Protein = 5.4m, Yag = 3.2m, Karbonhidrat = 33.5m, KategoriId = 3 },
            new Besin { Id = 47, Ad = "Pirinç Pilavı", Kalori = 320, Protein = 6.9m, Yag = 1.8m, Karbonhidrat = 69.4m, KategoriId = 3 },
            new Besin { Id = 48, Ad = "Fasulye Pilavı", Kalori = 250, Protein = 7.8m, Yag = 3.5m, Karbonhidrat = 47.2m, KategoriId = 3 },
            new Besin { Id = 49, Ad = "Beyaz Nohut Pilavı", Kalori = 280, Protein = 10.1m, Yag = 4.7m, Karbonhidrat = 53.8m, KategoriId = 3 },
            new Besin { Id = 50, Ad = "Kabaklı Bulgur Pilavı", Kalori = 210, Protein = 5.9m, Yag = 2.1m, Karbonhidrat = 43.7m, KategoriId = 3 },
            new Besin { Id = 51, Ad = "Zeytinyağlı Yaprak Sarma", Kalori = 180, Protein = 3.5m, Yag = 12.6m, Karbonhidrat = 15.2m, KategoriId = 4 },
            new Besin { Id = 52, Ad = "Zeytinyağlı Kabak Dolması", Kalori = 150, Protein = 2.8m, Yag = 10.3m, Karbonhidrat = 12.4m, KategoriId = 4 },
            new Besin { Id = 53, Ad = "Zeytinyağlı Pırasa", Kalori = 120, Protein = 2.4m, Yag = 8.1m, Karbonhidrat = 9.7m, KategoriId = 4 },
            new Besin { Id = 54, Ad = "Zeytinyağlı Taze Fasulye", Kalori = 140, Protein = 3.1m, Yag = 8.8m, Karbonhidrat = 11.5m, KategoriId = 4 },
            new Besin { Id = 55, Ad = "Zeytinyağlı Enginar", Kalori = 200, Protein = 4.6m, Yag = 15.4m, Karbonhidrat = 14.7m, KategoriId = 4 },
            new Besin { Id = 56, Ad = "Zeytinyağlı Karnabahar", Kalori = 160, Protein = 3.2m, Yag = 11.5m, Karbonhidrat = 12.9m, KategoriId = 4 },
            new Besin { Id = 57, Ad = "Zeytinyağlı Bamya", Kalori = 130, Protein = 2.9m, Yag = 8.6m, Karbonhidrat = 10.7m, KategoriId = 4 },
            new Besin { Id = 58, Ad = "Zeytinyağlı Ispanak", Kalori = 110, Protein = 2.1m, Yag = 7.2m, Karbonhidrat = 9.4m, KategoriId = 4 },
            new Besin { Id = 59, Ad = "Zeytinyağlı Pırasa Yemeği", Kalori = 140, Protein = 3.3m, Yag = 9.2m, Karbonhidrat = 11.8m, KategoriId = 4 },
            new Besin { Id = 60, Ad = "Zeytinyağlı Taze Fasulye Pilaki", Kalori = 150, Protein = 3.7m, Yag = 9.8m, Karbonhidrat = 12.5m, KategoriId = 4 },
            new Besin { Id = 71, Ad = "Mercimek Çorbası", Kalori = 150, Protein = 9.5m, Yag = 3.2m, Karbonhidrat = 21.8m, KategoriId = 5 },
            new Besin { Id = 72, Ad = "Tarator Çorbası", Kalori = 120, Protein = 7.8m, Yag = 5.1m, Karbonhidrat = 12.6m, KategoriId = 5 },
            new Besin { Id = 73, Ad = "Domates Çorbası", Kalori = 110, Protein = 4.2m, Yag = 2.8m, Karbonhidrat = 18.5m, KategoriId = 5 },
            new Besin { Id = 74, Ad = "Tavuklu Şehriye Çorbası", Kalori = 180, Protein = 12.3m, Yag = 4.6m, Karbonhidrat = 23.7m, KategoriId = 5 },
            new Besin { Id = 75, Ad = "Ezogelin Çorbası", Kalori = 160, Protein = 8.9m, Yag = 3.5m, Karbonhidrat = 24.2m, KategoriId = 5 },
            new Besin { Id = 76, Ad = "Yoğurtlu Çorba", Kalori = 140, Protein = 7.4m, Yag = 6.8m, Karbonhidrat = 15.9m, KategoriId = 5 },
            new Besin { Id = 77, Ad = "Kremalı Mantar Çorbası", Kalori = 220, Protein = 5.6m, Yag = 18.3m, Karbonhidrat = 9.7m, KategoriId = 5 },
            new Besin { Id = 78, Ad = "Kabak Çorbası", Kalori = 130, Protein = 3.7m, Yag = 7.2m, Karbonhidrat = 14.8m, KategoriId = 5 },
            new Besin { Id = 79, Ad = "Kırmızı Mercimek Çorbası", Kalori = 160, Protein = 9.8m, Yag = 2.6m, Karbonhidrat = 25.4m, KategoriId = 5 },
            new Besin { Id = 80, Ad = "İrmik Helvası", Kalori = 528, Protein = 7.6m, Yag = 29.8m, Karbonhidrat = 63.3m, KategoriId = 6 },
            new Besin { Id = 81, Ad = "Sütlaç", Kalori = 347, Protein = 8.2m, Yag = 7.2m, Karbonhidrat = 67.2m, KategoriId = 6 },
            new Besin { Id = 82, Ad = "Baklava", Kalori = 450, Protein = 7.5m, Yag = 29.5m, Karbonhidrat = 40.2m, KategoriId = 6 },
            new Besin { Id = 83, Ad = "Kazandibi", Kalori = 280, Protein = 5.8m, Yag = 12.6m, Karbonhidrat = 35.2m, KategoriId = 6 },
            new Besin { Id = 84, Ad = "Revani", Kalori = 315, Protein = 6.2m, Yag = 15.8m, Karbonhidrat = 38.1m, KategoriId = 6 },
            new Besin { Id = 85, Ad = "Dondurma", Kalori = 207, Protein = 5.4m, Yag = 11.2m, Karbonhidrat = 22.6m, KategoriId = 6 },
            new Besin { Id = 86, Ad = "Domates Salatası", Kalori = 127, Protein = 2.5m, Yag = 8.4m, Karbonhidrat = 11.6m, KategoriId = 7 },
            new Besin { Id = 87, Ad = "Cacık", Kalori = 75, Protein = 3.2m, Yag = 5.6m, Karbonhidrat = 3.9m, KategoriId = 7 },
            new Besin { Id = 88, Ad = "Roka Salatası", Kalori = 64, Protein = 3.9m, Yag = 4.7m, Karbonhidrat = 2.9m, KategoriId = 7 },
            new Besin { Id = 89, Ad = "Ceasar Salatası", Kalori = 184, Protein = 4.8m, Yag = 16.7m, Karbonhidrat = 3.2m, KategoriId = 7 },
            new Besin { Id = 90, Ad = "Mevsim Salatası", Kalori = 95, Protein = 3.1m, Yag = 6.4m, Karbonhidrat = 7.6m, KategoriId = 7 },
            new Besin { Id = 92, Ad = "Kayısı", Kalori = 63, Protein = 1.0m, Yag = 0.2m, Karbonhidrat = 15.3m, KategoriId = 8 },
            new Besin { Id = 93, Ad = "Muz", Kalori = 96, Protein = 1.3m, Yag = 0.3m, Karbonhidrat = 25.0m, KategoriId = 8 },
            new Besin { Id = 94, Ad = "Kiraz", Kalori = 63, Protein = 1.1m, Yag = 0.2m, Karbonhidrat = 16.0m, KategoriId = 8 },
            new Besin { Id = 95, Ad = "Üzüm", Kalori = 69, Protein = 0.7m, Yag = 0.2m, Karbonhidrat = 17.5m, KategoriId = 8 },
            new Besin { Id = 96, Ad = "Kavun", Kalori = 73, Protein = 0.9m, Yag = 0.2m, Karbonhidrat = 18.0m, KategoriId = 8 },
            new Besin { Id = 97, Ad = "Karpuz", Kalori = 30, Protein = 0.6m, Yag = 0.2m, Karbonhidrat = 8.0m, KategoriId = 8 },
            new Besin { Id = 98, Ad = "Portakal", Kalori = 43, Protein = 1.0m, Yag = 0.2m, Karbonhidrat = 8.3m, KategoriId = 8 },
            new Besin { Id = 99, Ad = "Mandalina", Kalori = 70, Protein = 0.8m, Yag = 0.2m, Karbonhidrat = 13.5m, KategoriId = 8 },
            new Besin { Id = 100, Ad = "Malta eriği", Kalori = 38, Protein = 0.9m, Yag = 0.2m, Karbonhidrat = 9.6m, KategoriId = 8 },
            new Besin { Id = 101, Ad = "Elma", Kalori = 52, Protein = 0.3m, Yag = 0.2m, Karbonhidrat = 14.0m, KategoriId = 8 },
            new Besin { Id = 102, Ad = "Toz Şeker", Kalori = 76, Protein = 0.0m, Yag = 0.0m, Karbonhidrat = 20.0m, KategoriId = 9 },
            new Besin { Id = 103, Ad = "Peynir (Kaşar)", Kalori = 121, Protein = 6.0m, Yag = 10.0m, Karbonhidrat = 1.0m, KategoriId = 9 },
            new Besin { Id = 104, Ad = "Peynir(Beyaz)", Kalori = 87, Protein = 7.0m, Yag = 6.0m, Karbonhidrat = 1.0m, KategoriId = 9 },
            new Besin { Id = 105, Ad = "Reçel", Kalori = 96, Protein = 0.3m, Yag = 0.1m, Karbonhidrat = 25.0m, KategoriId = 9 },
            new Besin { Id = 106, Ad = "Yağ(Margarin)", Kalori = 221, Protein = 0.3m, Yag = 24.0m, Karbonhidrat = 0.0m, KategoriId = 9 },
            new Besin { Id = 107, Ad = "Yumurta", Kalori = 80, Protein = 6.0m, Yag = 5.0m, Karbonhidrat = 1.0m, KategoriId = 9 },
            new Besin { Id = 108, Ad = "Zeytin(Yeşil)", Kalori = 43, Protein = 0.5m, Yag = 4.0m, Karbonhidrat = 0.0m, KategoriId = 9 },
            new Besin { Id = 109, Ad = "Zeytin(Siyah)", Kalori = 62, Protein = 0.5m, Yag = 6.0m, Karbonhidrat = 1.0m, KategoriId = 9 },
            new Besin { Id = 110, Ad = "Ekmek", Kalori = 276, Protein = 9.0m, Yag = 1.0m, Karbonhidrat = 56.0m, KategoriId = 9 },
            new Besin { Id = 111, Ad = "İnek Sütü", Kalori = 61, Protein = 3.0m, Yag = 3.0m, Karbonhidrat = 5.0m, KategoriId = 10 },
            new Besin { Id = 112, Ad = "Yoğurt", Kalori = 63, Protein = 4.0m, Yag = 3.0m, Karbonhidrat = 4.0m, KategoriId = 10 },
            new Besin { Id = 115, Ad = "Kola", Kalori = 140, Protein = 0.0m, Yag = 0.0m, Karbonhidrat = 39.0m, KategoriId = 11 },
            new Besin { Id = 116, Ad = "Portakal Suyu", Kalori = 110, Protein = 2.0m, Yag = 0.5m, Karbonhidrat = 26.0m, KategoriId = 11 },
            new Besin { Id = 117, Ad = "Limonata", Kalori = 120, Protein = 0.5m, Yag = 0.0m, Karbonhidrat = 30.0m, KategoriId = 11 },
            new Besin { Id = 118, Ad = "Gazoz", Kalori = 90, Protein = 0.0m, Yag = 0.0m, Karbonhidrat = 24.0m, KategoriId = 11 },
            new Besin { Id = 119, Ad = "Meyve Smoothie", Kalori = 200, Protein = 2.5m, Yag = 1.0m, Karbonhidrat = 45.0m, KategoriId = 11 },
            new Besin { Id = 120, Ad = "Türk Kahvesi", Kalori = 5, Protein = 0.5m, Yag = 0.2m, Karbonhidrat = 0.0m, KategoriId = 12 },
            new Besin { Id = 121, Ad = "Siyah Çay", Kalori = 2, Protein = 0.1m, Yag = 0.0m, Karbonhidrat = 0.5m, KategoriId = 12 },
            new Besin { Id = 122, Ad = "Yeşil Çay", Kalori = 0, Protein = 0.0m, Yag = 0.0m, Karbonhidrat = 0.0m, KategoriId = 12 },
            new Besin { Id = 123, Ad = "Nane Limon Çayı", Kalori = 4, Protein = 0.1m, Yag = 0.0m, Karbonhidrat = 0.8m, KategoriId = 12 },
            new Besin { Id = 124, Ad = "Salep", Kalori = 150, Protein = 1.5m, Yag = 2.0m, Karbonhidrat = 30.0m, KategoriId = 12 }
            );

            modelBuilder.Entity<Ogun>().HasData(
                new Ogun { Id = 1, Ad = "Kahvaltı" },
                new Ogun { Id = 2, Ad = "Ara Öğünler" },
                new Ogun { Id = 3, Ad = "Öğle Yemeği" },
                new Ogun { Id = 4, Ad = "Akşam Yemeği" }
            );
        }
    }
}
