using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Infrastructure.Database
{
    class DatabaseInit
    {
        public List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>();

            Product p1 = new Product()
            {
                ID = 1,
                Name = "iPhone 11 128GB černá",
                Description = "Mobilní telefon - 6,1\" IPS 1792 × 828, procesor Apple A13 Bionic 6jádrový, RAM 4 GB, interní paměť 128 GB," +
                            " zadní fotoaparát 12 Mpx (f/1,8) + 12 Mpx (f/2,4), přední fotoaparát 12 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, Lightning port, voděodolný dle IP68," +
                            " single SIM + eSIM, neblokovaný, rychlé nabíjení 18W, bezdrátové nabíjení, baterie 3110 mAh, iOS 13",
                Price = 14500
            };


            Product p2 = new Product()
            {
                ID = 2,
                Name = "Asus Zenfone 9 8GB/128GB černá",
                Description = "Mobilní telefon - 5,9\" AMOLED 2400 × 1080, 120Hz, procesor Qualcomm Snapdragon 8+ Gen 1 8jádrový, RAM 8 GB," +
                            " interní paměť 128,01 GB, zadní fotoaparát 50 Mpx (f/1,9) + 12 Mpx (f/2,2), přední fotoaparát 12 Mpx, optická a elektronická stabilizace, GPS, Glonass, NFC, LTE, 5G, Jack (3,5mm) a USB-C," +
                            " čtečka otisků, voděodolný dle IP68, dual SIM, neblokovaný, rychlé nabíjení 30W, baterie 4300 mAh, Android 12",
                Price = 17500
            };


            Product p3 = new Product()
            {
                ID = 3,
                Name = "iPhone 13 Pro 128GB grafitově šedá",
                Description = " Mobilní telefon - 6,1\" OLED 2532 × 1170, 120Hz, procesor Apple A15 Bionic 6jádrový, RAM 6 GB, interní paměť 128 GB," +
                            " zadní fotoaparát s optickým zoomem 12 Mpx (f/1,5) + 12 Mpx (f/2,8) + 12 Mpx (f/1,8), přední fotoaparát 12 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, 5G, Lightning port," +
                            " voděodolný dle IP68, single SIM + eSIM, neblokovaný, rychlé nabíjení 20W, bezdrátové nabíjení 15W, baterie 3095 mAh, iOS 15, EU distribuce",
                Price = 30000
            };

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return products;
        }
    }
}
