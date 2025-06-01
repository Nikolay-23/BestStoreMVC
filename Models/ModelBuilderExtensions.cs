using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilde)
        {
            modelBuilde.Entity<Product>().HasData(
               
                new Product
                {
                    Id = 1,
                    Name = "ASUS ROG Zephyrus",
                    Brand = "ASUS",
                    Category = "Computers",
                    Price = 3771,
                    Description = "ASUS ROG Zephyrus G14 GA402XZ-NC009W, 14.0, WQXGA, AMD Ryzen 9 7940HS (4.0/5.2GHz, 16M), NVIDIA RTX 4080 12 GB GDDR6 DLSS 3, 32 GB, 1 TB SSD - 90NR0DH6-M000L0",
                    ImageFileName = "asus-ga402-rog-zephyrus-g14-2023-456146.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 2,
                    Name = "MSI Titan 18",
                    Brand = "MSI",
                    Category = "Computers",
                    Price = 7544,
                    Description = "MSI Titan 18 HX AI A2XWJG, 18.0, UHD+, Intel Core Ultra 9 285HX (2.8/5.5GHz, 36M), NVIDIA RTX 5090 24GB GDDR7 DLSS 4, 64 GB, 4 TB SSD - 9S7-182421-479",
                    ImageFileName = "msi-titan-18-hx-ai-a2xw-618952.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 3,
                    Name = "Acer Predator",
                    Brand = "Acer",
                    Category = "Computers",
                    Price = 2959,
                    Description = "Acer Predator Helios Neo 16S AI PHN16S-71-96YW, 16.0, WQXGA, Intel Core Ultra 9 275HX (2.7/5.4GHz, 36M), NVIDIA RTX 5070 Ti 12GB GDDR7 DLSS 4, 32 GB, 1 TB SSD - NH.QX7EX.001",
                    ImageFileName = "acer-predator-phn16s-71-helios-neo-16s-ai-628568.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 4,
                    Name = "Apple MacBook Pro 14",
                    Brand = "Apple",
                    Category = "Computers",
                    Price = 2227,
                    Description = "Apple MacBook Pro 14 2024, Silver, 14.2, 3024 x 1964, Apple M4 10C (2.89/4.4GHz, 4M), 10 ядра GPU Apple M4, 16 GB, 512 GB SSD - MW2W3ZE/A",
                    ImageFileName = "apple-macbook-pro-14-2024-m4-pro-max-588848.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 5,
                    Name = " Apple MacBook Pro 16",
                    Brand = "Apple",
                    Category = "Computers",
                    Price = 3945,
                    Description = "Apple MacBook Pro 16 2024, Space Black, 16.2, 3456 x 2234, Apple M4 Pro 14C (4.51GHz, 4M), 20 ядра GPU Apple M4 Pro, 48 GB, 512 GB SSD - MX2Y3ZE/A",
                    ImageFileName = "apple-macbook-pro-16-2024-m4-pro-max-588869.jpg",
                    CreatedAt= DateTime.Now
                },

                new Product
                {
                    Id = 6,
                    Name = "Dell XPS 16",
                    Brand = "Dell",
                    Category = "Computers",
                    Price = 4159,
                    Description = "Dell XPS 16 9640, 16.3, Full HD+, Intel Core Ultra 7 155H (0.9/4.8GHz, 24M), NVIDIA RTX 4060 8GB GDDR6 DLSS 3, 32 GB, 2 TB SSD - DIABLO_MTL_2501_1200_2TBSSDNVME",
                    ImageFileName = "dell-xps-16-9640-547400.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 7,
                    Name = "HP ZBook Power 16",
                    Brand = "HP",
                    Category = "Computers",
                    Price = 3209,
                    Description = "HP ZBook Power 16 G11, 16.0, Full HD+, Intel Core Ultra 7 155H (0.9/4.8GHz, 24M), NVIDIA RTX 2000 8GB GDDR6, 64 GB, 2 TB SSD - 98N83ET_EN_64GB_2TBSSDNVME",
                    ImageFileName = "hp-zbook-power-16-g11-576189.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 8,
                    Name = "HP Elite",
                    Brand = "HP",
                    Category = "Computers",
                    Price = 257,
                    Description = "HP Elite x360 1040 G11 2-in-1, 14.0, Full HD+, touch screen, Intel Core Ultra 7 155H (0.9/4.8GHz, 24M), Intel Arc 8 Core, 32 GB, 2 TB SSD - 9G0U6ET_EN_2TBSSDNVME",
                    ImageFileName = "hp-elite-x360-1040-g11-580353.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 9,
                    Name = "Lenovo ThinkPad",
                    Brand = "Lenovo",
                    Category = "Computers",
                    Price = 4726,
                    Description = "Lenovo ThinkPad P16 G2, 16.0, WQXGA, Intel Core i9-13980HX (1.6/5.6GHz, 36M), NVIDIA RTX 2000 8GB GDDR6, 64 GB, 1 TB SSD - 21FA000ABM_64GB",
                    ImageFileName = "lenovo-thinkpad-p16-g2-487799.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 10,
                    Name = "Logitech G PRO X 2 LIGHTSPEED",
                    Brand = "Logitech",
                    Category = "Accessories",
                    Price = 289,
                    Description = "Logitech G PRO X 2 LIGHTSPEED Wireless Headset, Black - 981-001263",
                    ImageFileName = "logitech-g-pro-x-2-lightspeed-cheren-462424 (1).jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 11,
                    Name = "Logitech G915 X LIGHTSPEED Clicky",
                    Brand = "Logitech",
                    Category = "Accessories",
                    Price = 284,
                    Description = "Logitech G915 X LIGHTSPEED Clicky Wireless Gaming Keyboard, Black - 920-012709",
                    ImageFileName = "logitech-g915-x-lightspeed-wireless-gaming-keyboar-609238.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 12,
                    Name = "Logitech Pro X Superlight",
                    Brand = "Logitech",
                    Category = "Accessories",
                    Price = 150,
                    Description = "Logitech Pro X Superlight Wireless Mouse, Black - 910-005880",
                    ImageFileName = "copy-of-logitech-pro-x-superlight-byal-307189.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 13,
                    Name = "Razer Huntsman V3 Pro",
                    Brand = "Razer",
                    Category = "Accessories",
                    Price = 341,
                    Description = "Razer Huntsman V3 Pro gaming keyboard, Black - RZ03-04970100-R3M1",
                    ImageFileName = "huntsman-v3-pro-us-layout-gaming-keyboard-analog-o-553027.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                { 
                    Id = 14,
                    Name = "Printer Brother HL-L8240CDW",
                    Brand = "Brother",
                    Category = "Printers",
                    Price = 411,
                    Description = "Printer Brother HL-L8240CDW, Electrophotographic LED, A4, 600 x 600 dpi, Wi-Fi - HLL8240CDWYJ1",
                    ImageFileName = "brother-hl-l8240cdw-515220.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 15,
                    Name = "HP LaserJet Pro 4202dn",
                    Brand = "HP",
                    Category = "Printers",
                    Price = 448,
                    Description = "HP LaserJet Pro 4202dn Printer, Laser, A4, 600 x 600 dpi, 33 ppm - 4RA87F",
                    ImageFileName = "hp-laserjet-pro-4202dn-504550.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 16,
                    Name = "Xerox B410",
                    Brand = "Xerox",
                    Category = "Printers",
                    Price = 504,
                    Description = "Xerox B410 Printer, Laser, A4, 1200 x 1200 dpi, 47 ppm - B410V_DN",
                    ImageFileName = "xerox-b410-printer-538741.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 17,
                    Name = "GoPro HERO13",
                    Brand = "GoPro",
                    Category = "Cameras",
                    Price = 788,
                    Description = "Action camera GoPro HERO13 Black Creator Edition - CHDFB-131-EU",
                    ImageFileName = "copy-of-gopro-hero13-black-577320.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 18,
                    Name = "GoPro HERO12",
                    Brand = "GoPro",
                    Category = "Cameras",
                    Price = 405,
                    Description = "Action camera GoPro HERO12 Black - CHDHX-121-RW",
                    ImageFileName = "gopro-hero12-black-488027.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 19,
                    Name = "GoPro HERO11",
                    Brand = "GoPro",
                    Category = "Cameras",
                    Price = 695,
                    Description = "Action camera GoPro HERO11 Black Creator Edition - CHDFB-111-EU",
                    ImageFileName = "copy-of-gopro-hero11-black-405256.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 20,
                    Name = "HP Professional 17.3",
                    Brand = "HP",
                    Category = "Other",
                    Price = 57,
                    Description = "HP Professional Backpack 17.3, Black - 500S6AA",
                    ImageFileName = "hp-renew-business-backpack-up-to-17-3-531400.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 21,
                    Name = "GoPro Protective Housing",
                    Brand = "GoPro",
                    Category = "Other",
                    Price = 69,
                    Description = "Waterproof GoPro Protective Housing for GoPro HERO - ADDIV-001",
                    ImageFileName = "copy-of-za-xiaomi-mi-action-camera-4k-498463.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 22,
                    Name = "Apple iPhone 16 Pro",
                    Brand = "Apple",
                    Category = "Phones",
                    Price = 1798,
                    Description = "Smartphone Apple iPhone 16 Pro, 8GB, 512GB, Black Titanium - MYNM3ZD/A",
                    ImageFileName = "apple-iphone-16-pro-578268.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 23,
                    Name = "Apple iPhone 15",
                    Brand = "Apple",
                    Category = "Phones",
                    Price = 1450,
                    Description = "Smartphone Apple iPhone 15, 6GB, 512GB, Blue - MTPG3RX/A",
                    ImageFileName = "apple-iphone-15-490283.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 24,
                    Name = "Samsung Galaxy S25+",
                    Brand = "Samsung",
                    Category = "Phones",
                    Price = 1200,
                    Description = "Smartphone Samsung Galaxy S25+, 12GB, 256GB, Icy Blue - SM-S936BLBDEUE",
                    ImageFileName = "samsung-galaxy-s25-607464.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 25,
                    Name = "Samsung Galaxy S24",
                    Brand = "Samsung",
                    Category = "Phones",
                    Price = 666,
                    Description = "Smartphone Samsung Galaxy S24, 8GB, 128GB, Amber Yellow - SM-S921BZYDEUE",
                    ImageFileName = "samsung-galaxy-s24-527754.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 26,
                    Name = "Samsung Galaxy S24 FE",
                    Brand = "Samsung",
                    Category = "Phones",
                    Price = 637,
                    Description = "Smartphone Samsung Galaxy S24 FE, 8GB, 256GB, Graphite - SM-S721BZKGEUE",
                    ImageFileName = "samsung-galaxy-s24-fe-581047.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 27,
                    Name = "Apple iPhone 16 Plus",
                    Brand = "Apple",
                    Category = "Phones",
                    Price = 1618,
                    Description = "Smartphone Apple iPhone 16 Plus, 8GB, 512GB, White - MY1X3ZD/A",
                    ImageFileName = "apple-iphone-16-plus-578510.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                { 
                    Id = 28,
                    Name = "Apple iPhone 16 Pro Max",
                    Brand = "Apple",
                    Category = "Phones",
                    Price = 2198,
                    Description = "Smartphone Apple iPhone 16 Pro Max, 8GB, 1TB, Black Titanium - MYX43ZD/A",
                    ImageFileName = "apple-iphone-16-pro-max-578288.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                { 
                    Id = 29,
                    Name = "Apple iPhone 16e",
                    Brand = "Apple",
                    Category = "Phones",
                    Price = 968,
                    Description = "Smartphone Apple iPhone 16e, 8GB, 256GB, Black - MD1T4ZD/A",
                    ImageFileName = "apple-iphone-16e-617257.jpg",
                    CreatedAt = DateTime.Now
                },

                new Product
                {
                    Id = 30,
                    Name = "Apple iPhone 14",
                    Brand = "Apple",
                    Category = "Phones",
                    Price = 742,
                    Description = "Smartphone Apple iPhone 14, 6GB, 128GB, Blue - MPVN3RX/A",
                    ImageFileName = "apple-iphone-14-plus-402808.jpg",
                    CreatedAt = DateTime.Now 
                }
            );
              
        }
    }
}
