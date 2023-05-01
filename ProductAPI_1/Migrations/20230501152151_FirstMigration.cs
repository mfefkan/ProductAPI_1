using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductAPI_1.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerGSM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmonut = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersID = table.Column<int>(type: "int", nullable: false),
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Category", "CreatedDate", "DeletedDate", "Description", "Status", "Unit", "UnitPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(1574), null, "Eve modi yaptı aliquid ipsam quam ex illo dolorem quis.", 0, 150, 701.11m, null },
                    { 2, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(1886), null, "Modi praesentium teldeki ut ut gülüyorum gitti ipsa sıla velit.", 0, 150, 725.56m, null },
                    { 3, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(1958), null, "Qui yazın dolores dicta de laboriosam öyle sit iure nemo.", 0, 150, 153.03m, null },
                    { 4, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2025), null, "Beatae dicta sunt masaya quia dolorem anlamsız çakıl doloremque modi.", 0, 150, 174.05m, null },
                    { 5, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2085), null, "Göze un architecto quia karşıdakine adanaya öyle sıla laboriosam umut.", 0, 150, 561.45m, null },
                    { 6, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2186), null, "Doloremque et vitae cesurca qui vitae adipisci dağılımı eum sequi.", 0, 150, 957.00m, null },
                    { 7, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2248), null, "Architecto için neque illo commodi quia ışık kutusu sıla şafak.", 0, 150, 535.77m, null },
                    { 8, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2309), null, "Minima qui exercitationem ad kapının qui voluptatem batarya nesciunt quia.", 0, 150, 690.05m, null },
                    { 9, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2375), null, "Quia aut nisi lambadaki bundan modi esse sit mıknatıslı domates.", 0, 150, 378.92m, null },
                    { 10, "Electronics", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2467), null, "Aut rem lakin kapının quia magnam orta molestiae kapının koştum.", 0, 150, 840.88m, null },
                    { 11, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2533), null, "Accusantium aliquam gidecekmiş kalemi sed quia totam değerli enim numquam.", 0, 150, 836.37m, null },
                    { 12, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2595), null, "Domates çorba quis bilgiyasayarı mi voluptas ki vel dağılımı bahar.", 0, 150, 348.52m, null },
                    { 13, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2656), null, "Sıradanlıktan dolor ona ad alias değerli uzattı çobanın suscipit doğru.", 0, 150, 574.48m, null },
                    { 14, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2740), null, "Düşünüyor ea dicta çarpan quia veniam dignissimos autem voluptatem kulu.", 0, 150, 440.47m, null },
                    { 15, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2802), null, "Un dicta dolorem vitae koşuyorlar çünkü consequatur de gitti otobüs.", 0, 150, 846.81m, null },
                    { 16, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2860), null, "Koştum dignissimos quasi praesentium reprehenderit oldular ab gül labore voluptatem.", 0, 150, 628.62m, null },
                    { 17, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2926), null, "Totam telefonu odio çıktılar anlamsız ipsa sıla veniam sarmal dolor.", 0, 150, 333.13m, null },
                    { 18, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3008), null, "Doloremque gazete dolore suscipit ratione sit eum ona açılmadan voluptatem.", 0, 150, 783.82m, null },
                    { 19, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3073), null, "Sıfat gül eve et duyulmamış exercitationem yaptı quia eum ut.", 0, 150, 903.45m, null },
                    { 20, "Books", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3133), null, "Alias hesap ışık yapacakmış dolorem qui gitti eos duyulmamış masanın.", 0, 150, 474.15m, null },
                    { 21, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3192), null, "Domates sinema doğru ötekinden modi göze okuma layıkıyla kapının beatae.", 0, 150, 36.59m, null },
                    { 22, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3251), null, "Voluptatem un karşıdakine koşuyorlar göze anlamsız quia doğru aut kutusu.", 0, 150, 514.19m, null },
                    { 23, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3332), null, "Voluptas koyun kutusu sokaklarda eum labore gülüyorum quia quis consectetur.", 0, 150, 898.41m, null },
                    { 24, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3392), null, "Magnam yaptı yapacakmış karşıdakine nesciunt odit doğru et molestiae dolore.", 0, 150, 249.67m, null },
                    { 25, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3448), null, "Reprehenderit gitti çorba voluptatem telefonu mutlu magni filmini rem ipsam.", 0, 150, 381.31m, null },
                    { 26, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3505), null, "Ducimus blanditiis sit okuma rem yapacakmış neque patlıcan ipsa eos.", 0, 150, 847.44m, null },
                    { 27, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3588), null, "Otobüs labore vel yaptı duyulmamış makinesi koştum balıkhaneye ab patlıcan.", 0, 150, 486.15m, null },
                    { 28, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3646), null, "Ex karşıdakine totam dignissimos et quasi cesurca iusto ötekinden dolayı.", 0, 150, 735.16m, null },
                    { 29, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3704), null, "Adanaya masaya sevindi ratione çorba adresini ex mi sandalye sit.", 0, 150, 214.56m, null },
                    { 30, "Clothing", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3761), null, "Ipsa öyle consectetur mi in odit eum architecto voluptatum nisi.", 0, 150, 248.04m, null },
                    { 31, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3860), null, "Umut şafak un iure kulu dergi autem gördüm ekşili biber.", 0, 150, 220.10m, null },
                    { 32, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3925), null, "Sıfat olduğu ona quis yapacakmış bahar velit koyun suscipit ipsam.", 0, 150, 675.52m, null },
                    { 33, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3982), null, "Değirmeni filmini vitae sokaklarda mutlu sed nesciunt odio amet lakin.", 0, 150, 343.70m, null },
                    { 34, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4040), null, "Aliquid eve ab orta sed kulu filmini ut umut çünkü.", 0, 150, 53.10m, null },
                    { 35, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4101), null, "Voluptatem qui nihil cezbelendi ekşili bundan illo nesciunt iure filmini.", 0, 150, 793.28m, null },
                    { 36, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4189), null, "Eum ötekinden ekşili camisi domates eve qui veniam praesentium aliquid.", 0, 150, 234.00m, null },
                    { 37, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4245), null, "Qui cezbelendi patlıcan aliquam dergi düşünüyor açılmadan voluptas sarmal layıkıyla.", 0, 150, 271.19m, null },
                    { 38, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4302), null, "Lambadaki masanın architecto duyulmamış ullam exercitationem rem ratione modi ducimus.", 0, 150, 207.75m, null },
                    { 39, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4358), null, "Domates magni minima et sevindi veritatis gül sunt voluptatum ötekinden.", 0, 150, 374.73m, null },
                    { 40, "Beauty", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4447), null, "Sayfası aliquid kalemi magni exercitationem gitti koştum velit dicta sit.", 0, 150, 741.82m, null },
                    { 41, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4506), null, "Tempora explicabo öyle odit odio laboriosam bundan çünkü odio yaptı.", 0, 150, 648.78m, null },
                    { 42, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4563), null, "Non kulu dignissimos otobüs magni lambadaki consequuntur blanditiis consequatur dolayı.", 0, 150, 744.14m, null },
                    { 43, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4619), null, "Batarya ipsum laudantium şafak sokaklarda camisi quia nihil beğendim bahar.", 0, 150, 150.74m, null },
                    { 44, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4700), null, "Inventore filmini değirmeni şafak nemo gidecekmiş consectetur voluptate anlamsız teldeki.", 0, 150, 337.23m, null },
                    { 45, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4762), null, "Aspernatur beatae açılmadan teldeki tv nisi nostrum quis mi odio.", 0, 150, 800.81m, null },
                    { 46, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4819), null, "Dışarı kulu değerli çakıl çıktılar camisi consequuntur gazete gülüyorum de.", 0, 150, 64.95m, null },
                    { 47, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4875), null, "Qui corporis incidunt un dignissimos vitae ipsum voluptatem dağılımı hesap.", 0, 150, 484.29m, null },
                    { 48, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4976), null, "Kapının layıkıyla quia nostrum architecto corporis incidunt doloremque yapacakmış laudantium.", 0, 150, 72.78m, null },
                    { 49, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(5068), null, "Nisi aut laudantium ea dicta qui ut dicta ab ve.", 0, 150, 609.74m, null },
                    { 50, "Toys", new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(5156), null, "Dışarı non blanditiis sed quaerat rem gördüm quae odit velit.", 0, 150, 367.92m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsID",
                table: "OrderProduct",
                column: "ProductsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
