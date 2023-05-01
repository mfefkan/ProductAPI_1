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
                    { 1, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8196), null, "Deleniti umut architecto quam alias quae sit aspernatur voluptatum otobüs.", 0, 150, 615.20m, null },
                    { 2, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8479), null, "Dolores dağılımı non eaque gülüyorum cezbelendi autem exercitationem sayfası masaya.", 0, 150, 787.87m, null },
                    { 3, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8586), null, "Değerli commodi ut eos bilgisayarı aut consequuntur gazete voluptas cezbelendi.", 0, 150, 156.13m, null },
                    { 4, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8652), null, "Eos orta deleniti çakıl yazın çıktılar ratione inventore laudantium doğru.", 0, 150, 367.94m, null },
                    { 5, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8717), null, "Voluptatum dergi voluptate tempora odio umut illo rem doğru ki.", 0, 150, 755.30m, null },
                    { 6, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8778), null, "Çorba bilgiyasayarı aliquam qui masaya sıradanlıktan karşıdakine quae qui architecto.", 0, 150, 546.47m, null },
                    { 7, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8883), null, "Veritatis ea salladı ea ad ea gitti ekşili yazın lambadaki.", 0, 150, 663.50m, null },
                    { 8, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(8953), null, "Layıkıyla adipisci koştum sevindi anlamsız quis quia sıfat quasi un.", 0, 150, 732.46m, null },
                    { 9, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9018), null, "Kapının doloremque qui un sıradanlıktan rem açılmadan layıkıyla camisi olduğu.", 0, 150, 323.47m, null },
                    { 10, "Electronics", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9077), null, "Voluptate oldular değirmeni sarmal et ut cesurca sinema labore ve.", 0, 150, 700.06m, null },
                    { 11, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9161), null, "Değirmeni ki doloremque öyle lakin ratione eos in dolor voluptate.", 0, 150, 469.07m, null },
                    { 12, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9223), null, "Quis sevindi umut aliquam in bilgisayarı esse consectetur domates orta.", 0, 150, 596.66m, null },
                    { 13, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9279), null, "Quae enim layıkıyla değirmeni quia çakıl telefonu sit quasi bilgisayarı.", 0, 150, 571.86m, null },
                    { 14, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9337), null, "Rem sokaklarda domates totam magni accusantium praesentium kapının ratione bilgisayarı.", 0, 150, 86.45m, null },
                    { 15, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9394), null, "Ut öyle qui magni salladı çakıl balıkhaneye voluptatem lambadaki biber.", 0, 150, 383.93m, null },
                    { 16, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9475), null, "Için enim layıkıyla çarpan odio açılmadan balıkhaneye aperiam quia dolayı.", 0, 150, 541.47m, null },
                    { 17, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9531), null, "Sunt nesciunt sed yapacakmış kapının masanın quia domates vitae uzattı.", 0, 150, 368.67m, null },
                    { 18, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9590), null, "Doloremque şafak veniam duyulmamış explicabo sarmal çünkü voluptatem eum ışık.", 0, 150, 885.62m, null },
                    { 19, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9653), null, "Okuma laudantium un numquam quia aut ullam bilgiyasayarı mutlu makinesi.", 0, 150, 200.78m, null },
                    { 20, "Books", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9750), null, "Tempora aliquid düşünüyor layıkıyla odit odit bilgiyasayarı doloremque sevindi bundan.", 0, 150, 884.13m, null },
                    { 21, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9816), null, "Perferendis adanaya sequi öyle iure deleniti türemiş sit telefonu eos.", 0, 150, 958.66m, null },
                    { 22, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9873), null, "Quis filmini voluptas quae uzattı dolore masaya bahar doloremque consectetur.", 0, 150, 949.57m, null },
                    { 23, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 329, DateTimeKind.Local).AddTicks(9929), null, "Voluptatum aliquid velit enim dolayı yaptı oldular duyulmamış gülüyorum bilgiyasayarı.", 0, 150, 118.57m, null },
                    { 24, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(8), null, "Vel labore anlamsız sokaklarda consectetur nesciunt bundan aliquam ut ex.", 0, 150, 22.13m, null },
                    { 25, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(65), null, "Makinesi alias ut voluptate salladı sevindi mıknatıslı mutlu quia odit.", 0, 150, 837.33m, null },
                    { 26, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(120), null, "Perferendis iusto dolores nemo nisi odio açılmadan ki yaptı beatae.", 0, 150, 246.52m, null },
                    { 27, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(177), null, "Dicta exercitationem çünkü yapacakmış voluptatum bilgiyasayarı quia adresini autem sıfat.", 0, 150, 602.52m, null },
                    { 28, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(254), null, "Umut vel gidecekmiş aut consectetur bilgisayarı telefonu için et göze.", 0, 150, 390.95m, null },
                    { 29, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(315), null, "Aut dolor lakin bahar aut velit odio aut incidunt perferendis.", 0, 150, 286.08m, null },
                    { 30, "Clothing", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(369), null, "Şafak eve bilgisayarı sokaklarda türemiş kutusu et magnam aperiam koyun.", 0, 150, 27.59m, null },
                    { 31, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(431), null, "Voluptatem modi eum velit quasi dolorem sarmal bundan magnam vitae.", 0, 150, 706.93m, null },
                    { 32, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(485), null, "Layıkıyla accusantium ipsum blanditiis sokaklarda sayfası suscipit iure rem reprehenderit.", 0, 150, 763.90m, null },
                    { 33, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(570), null, "Sed ex orta lakin eaque mi adipisci teldeki sequi uzattı.", 0, 150, 641.69m, null },
                    { 34, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(626), null, "Et umut mıknatıslı voluptatem quaerat karşıdakine çünkü odit odio sayfası.", 0, 150, 373.73m, null },
                    { 35, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(681), null, "Nostrum voluptas kalemi enim ut eve dicta açılmadan architecto quis.", 0, 150, 987.39m, null },
                    { 36, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(736), null, "Balıkhaneye consequatur domates fugit masanın mi sokaklarda sıfat camisi eum.", 0, 150, 32.81m, null },
                    { 37, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(817), null, "Gördüm accusantium rem ut şafak sequi gördüm için dergi anlamsız.", 0, 150, 709.54m, null },
                    { 38, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(871), null, "Doğru bilgiyasayarı gazete in dağılımı göze lakin sayfası filmini fugit.", 0, 150, 199.26m, null },
                    { 39, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(923), null, "Quia layıkıyla eius quia numquam makinesi kutusu uzattı minima çakıl.", 0, 150, 669.42m, null },
                    { 40, "Beauty", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(978), null, "Laudantium beğendim çıktılar beatae veniam uzattı telefonu velit perferendis consequatur.", 0, 150, 14.92m, null },
                    { 41, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1056), null, "Doğru totam lakin dolayı esse yazın dağılımı eum şafak odio.", 0, 150, 390.57m, null },
                    { 42, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1111), null, "Beatae beatae corporis balıkhaneye ea quaerat consequatur ki kapının quis.", 0, 150, 392.25m, null },
                    { 43, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1167), null, "Ut voluptatem non göze aut velit deleniti quasi quam dolayı.", 0, 150, 388.17m, null },
                    { 44, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1220), null, "Masanın aliquam domates veritatis ekşili çünkü molestiae cesurca biber eius.", 0, 150, 684.79m, null },
                    { 45, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1298), null, "Domates batarya sokaklarda voluptate quia filmini inventore commodi makinesi beatae.", 0, 150, 662.86m, null },
                    { 46, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1354), null, "Bundan koyun velit modi nisi ipsa mi doloremque ullam iure.", 0, 150, 652.61m, null },
                    { 47, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1407), null, "Perferendis de molestiae öyle gül reprehenderit adipisci quis voluptas aspernatur.", 0, 150, 177.06m, null },
                    { 48, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1461), null, "Consequatur bilgiyasayarı aut dolayı labore ratione şafak sevindi mi explicabo.", 0, 150, 538.08m, null },
                    { 49, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1535), null, "Vel praesentium consectetur eve tempora aperiam magni velit quia sarmal.", 0, 150, 522.34m, null },
                    { 50, "Toys", new DateTime(2023, 5, 1, 19, 57, 8, 330, DateTimeKind.Local).AddTicks(1591), null, "Ducimus patlıcan amet sed dolores sokaklarda oldular laudantium sequi voluptatem.", 0, 150, 180.61m, null }
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
