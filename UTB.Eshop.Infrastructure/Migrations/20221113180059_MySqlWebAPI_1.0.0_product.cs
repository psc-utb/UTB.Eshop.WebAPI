using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTB.Eshop.Infrastructure.Migrations
{
    public partial class MySqlWebAPI_100_product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Description", "Name", "Price" },
                values: new object[] { 1, "Mobilní telefon - 6,1\" IPS 1792 × 828, procesor Apple A13 Bionic 6jádrový, RAM 4 GB, interní paměť 128 GB, zadní fotoaparát 12 Mpx (f/1,8) + 12 Mpx (f/2,4), přední fotoaparát 12 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, Lightning port, voděodolný dle IP68, single SIM + eSIM, neblokovaný, rychlé nabíjení 18W, bezdrátové nabíjení, baterie 3110 mAh, iOS 13", "iPhone 11 128GB černá", 14500.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Description", "Name", "Price" },
                values: new object[] { 2, "Mobilní telefon - 5,9\" AMOLED 2400 × 1080, 120Hz, procesor Qualcomm Snapdragon 8+ Gen 1 8jádrový, RAM 8 GB, interní paměť 128,01 GB, zadní fotoaparát 50 Mpx (f/1,9) + 12 Mpx (f/2,2), přední fotoaparát 12 Mpx, optická a elektronická stabilizace, GPS, Glonass, NFC, LTE, 5G, Jack (3,5mm) a USB-C, čtečka otisků, voděodolný dle IP68, dual SIM, neblokovaný, rychlé nabíjení 30W, baterie 4300 mAh, Android 12", "Asus Zenfone 9 8GB/128GB černá", 17500.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Description", "Name", "Price" },
                values: new object[] { 3, " Mobilní telefon - 6,1\" OLED 2532 × 1170, 120Hz, procesor Apple A15 Bionic 6jádrový, RAM 6 GB, interní paměť 128 GB, zadní fotoaparát s optickým zoomem 12 Mpx (f/1,5) + 12 Mpx (f/2,8) + 12 Mpx (f/1,8), přední fotoaparát 12 Mpx, optická stabilizace, GPS, Glonass, NFC, LTE, 5G, Lightning port, voděodolný dle IP68, single SIM + eSIM, neblokovaný, rychlé nabíjení 20W, bezdrátové nabíjení 15W, baterie 3095 mAh, iOS 15, EU distribuce", "iPhone 13 Pro 128GB grafitově šedá", 30000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
