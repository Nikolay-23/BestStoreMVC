using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BestStoreMVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "CreatedAt", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "ASUS", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7009), "ASUS ROG Zephyrus G14 GA402XZ-NC009W, 14.0, WQXGA, AMD Ryzen 9 7940HS (4.0/5.2GHz, 16M), NVIDIA RTX 4080 12 GB GDDR6 DLSS 3, 32 GB, 1 TB SSD - 90NR0DH6-M000L0", "asus-ga402-rog-zephyrus-g14-2023-456146.jpg", "ASUS ROG Zephyrus", 3771m },
                    { 2, "MSI", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7066), "MSI Titan 18 HX AI A2XWJG, 18.0, UHD+, Intel Core Ultra 9 285HX (2.8/5.5GHz, 36M), NVIDIA RTX 5090 24GB GDDR7 DLSS 4, 64 GB, 4 TB SSD - 9S7-182421-479", "msi-titan-18-hx-ai-a2xw-618952.jpg", "MSI Titan 18", 7544m },
                    { 3, "Acer", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7068), "Acer Predator Helios Neo 16S AI PHN16S-71-96YW, 16.0, WQXGA, Intel Core Ultra 9 275HX (2.7/5.4GHz, 36M), NVIDIA RTX 5070 Ti 12GB GDDR7 DLSS 4, 32 GB, 1 TB SSD - NH.QX7EX.001", "acer-predator-phn16s-71-helios-neo-16s-ai-628568.jpg", "Acer Predator", 2959m },
                    { 4, "Apple", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7071), "Apple MacBook Pro 14 2024, Silver, 14.2, 3024 x 1964, Apple M4 10C (2.89/4.4GHz, 4M), 10 ядра GPU Apple M4, 16 GB, 512 GB SSD - MW2W3ZE/A", "apple-macbook-pro-14-2024-m4-pro-max-588848.jpg", "Apple MacBook Pro 14", 2227m },
                    { 5, "Apple", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7073), "Apple MacBook Pro 16 2024, Space Black, 16.2, 3456 x 2234, Apple M4 Pro 14C (4.51GHz, 4M), 20 ядра GPU Apple M4 Pro, 48 GB, 512 GB SSD - MX2Y3ZE/A", "apple-macbook-pro-16-2024-m4-pro-max-588869.jpg", " Apple MacBook Pro 16", 3945m },
                    { 6, "Dell", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7075), "Dell XPS 16 9640, 16.3, Full HD+, Intel Core Ultra 7 155H (0.9/4.8GHz, 24M), NVIDIA RTX 4060 8GB GDDR6 DLSS 3, 32 GB, 2 TB SSD - DIABLO_MTL_2501_1200_2TBSSDNVME", "dell-xps-16-9640-547400.jpg", "Dell XPS 16", 4159m },
                    { 7, "HP", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7078), "HP ZBook Power 16 G11, 16.0, Full HD+, Intel Core Ultra 7 155H (0.9/4.8GHz, 24M), NVIDIA RTX 2000 8GB GDDR6, 64 GB, 2 TB SSD - 98N83ET_EN_64GB_2TBSSDNVME", "hp-zbook-power-16-g11-576189.jpg", "HP ZBook Power 16", 3209m },
                    { 8, "HP", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7080), "HP Elite x360 1040 G11 2-in-1, 14.0, Full HD+, touch screen, Intel Core Ultra 7 155H (0.9/4.8GHz, 24M), Intel Arc 8 Core, 32 GB, 2 TB SSD - 9G0U6ET_EN_2TBSSDNVME", "hp-elite-x360-1040-g11-580353.jpg", "HP Elite", 257m },
                    { 9, "Lenovo", "Computers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7082), "Lenovo ThinkPad P16 G2, 16.0, WQXGA, Intel Core i9-13980HX (1.6/5.6GHz, 36M), NVIDIA RTX 2000 8GB GDDR6, 64 GB, 1 TB SSD - 21FA000ABM_64GB", "lenovo-thinkpad-p16-g2-487799.jpg", "Lenovo ThinkPad", 4726m },
                    { 10, "Logitech", "Accessories", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7084), "Logitech G PRO X 2 LIGHTSPEED Wireless Headset, Black - 981-001263", "logitech-g-pro-x-2-lightspeed-cheren-462424 (1).jpg", "Logitech G PRO X 2 LIGHTSPEED", 289m },
                    { 11, "Logitech", "Accessories", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7086), "Logitech G915 X LIGHTSPEED Clicky Wireless Gaming Keyboard, Black - 920-012709", "logitech-g915-x-lightspeed-wireless-gaming-keyboar-609238.jpg", "Logitech G915 X LIGHTSPEED Clicky", 284m },
                    { 12, "Logitech", "Accessories", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7088), "Logitech Pro X Superlight Wireless Mouse, Black - 910-005880", "copy-of-logitech-pro-x-superlight-byal-307189.jpg", "Logitech Pro X Superlight", 150m },
                    { 13, "Razer", "Accessories", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7092), "Razer Huntsman V3 Pro gaming keyboard, Black - RZ03-04970100-R3M1", "huntsman-v3-pro-us-layout-gaming-keyboard-analog-o-553027.jpg", "Razer Huntsman V3 Pro", 341m },
                    { 14, "Brother", "Printers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7094), "Printer Brother HL-L8240CDW, Electrophotographic LED, A4, 600 x 600 dpi, Wi-Fi - HLL8240CDWYJ1", "brother-hl-l8240cdw-515220.jpg", "Printer Brother HL-L8240CDW", 411m },
                    { 15, "HP", "Printers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7096), "HP LaserJet Pro 4202dn Printer, Laser, A4, 600 x 600 dpi, 33 ppm - 4RA87F", "hp-laserjet-pro-4202dn-504550.jpg", "HP LaserJet Pro 4202dn", 448m },
                    { 16, "Xerox", "Printers", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7098), "Xerox B410 Printer, Laser, A4, 1200 x 1200 dpi, 47 ppm - B410V_DN", "xerox-b410-printer-538741.jpg", "Xerox B410", 504m },
                    { 17, "GoPro", "Cameras", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7100), "Action camera GoPro HERO13 Black Creator Edition - CHDFB-131-EU", "copy-of-gopro-hero13-black-577320.jpg", "GoPro HERO13", 788m },
                    { 18, "GoPro", "Cameras", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7102), "Action camera GoPro HERO12 Black - CHDHX-121-RW", "gopro-hero12-black-488027.jpg", "GoPro HERO12", 405m },
                    { 19, "GoPro", "Cameras", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7104), "Action camera GoPro HERO11 Black Creator Edition - CHDFB-111-EU", "copy-of-gopro-hero11-black-405256.jpg", "GoPro HERO11", 695m },
                    { 20, "HP", "Other", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7106), "HP Professional Backpack 17.3, Black - 500S6AA", "hp-renew-business-backpack-up-to-17-3-531400.jpg", "HP Professional 17.3", 57m },
                    { 21, "GoPro", "Other", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7110), "Waterproof GoPro Protective Housing for GoPro HERO - ADDIV-001", "copy-of-za-xiaomi-mi-action-camera-4k-498463.jpg", "GoPro Protective Housing", 69m },
                    { 22, "Apple", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7112), "Smartphone Apple iPhone 16 Pro, 8GB, 512GB, Black Titanium - MYNM3ZD/A", "apple-iphone-16-pro-578268.jpg", "Apple iPhone 16 Pro", 1798m },
                    { 23, "Apple", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7114), "Smartphone Apple iPhone 15, 6GB, 512GB, Blue - MTPG3RX/A", "apple-iphone-15-490283.jpg", "Apple iPhone 15", 1450m },
                    { 24, "Samsung", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7116), "Smartphone Samsung Galaxy S25+, 12GB, 256GB, Icy Blue - SM-S936BLBDEUE", "samsung-galaxy-s25-607464.jpg", "Samsung Galaxy S25+", 1200m },
                    { 25, "Samsung", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7118), "Smartphone Samsung Galaxy S24, 8GB, 128GB, Amber Yellow - SM-S921BZYDEUE", "samsung-galaxy-s24-527754.jpg", "Samsung Galaxy S24", 666m },
                    { 26, "Samsung", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7120), "Smartphone Samsung Galaxy S24 FE, 8GB, 256GB, Graphite - SM-S721BZKGEUE", "samsung-galaxy-s24-fe-581047.jpg", "Samsung Galaxy S24 FE", 637m },
                    { 27, "Apple", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7122), "Smartphone Apple iPhone 16 Plus, 8GB, 512GB, White - MY1X3ZD/A", "apple-iphone-16-plus-578510.jpg", "Apple iPhone 16 Plus", 1618m },
                    { 28, "Apple", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7124), "Smartphone Apple iPhone 16 Pro Max, 8GB, 1TB, Black Titanium - MYX43ZD/A", "apple-iphone-16-pro-max-578288.jpg", "Apple iPhone 16 Pro Max", 2198m },
                    { 29, "Apple", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7126), "Smartphone Apple iPhone 16e, 8GB, 256GB, Black - MD1T4ZD/A", "apple-iphone-16e-617257.jpg", "Apple iPhone 16e", 968m },
                    { 30, "Apple", "Phones", new DateTime(2025, 6, 1, 19, 50, 51, 734, DateTimeKind.Local).AddTicks(7128), "Smartphone Apple iPhone 14, 6GB, 128GB, Blue - MPVN3RX/A", "apple-iphone-14-plus-402808.jpg", "Apple iPhone 14", 742m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
