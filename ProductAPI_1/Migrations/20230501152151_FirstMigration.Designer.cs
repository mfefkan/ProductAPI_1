﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderAPI.Models.Context;

#nullable disable

namespace ProductAPI_1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230501152151_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderAPI.Models.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerGSM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmonut")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderAPI.Models.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(1574),
                            Description = "Eve modi yaptı aliquid ipsam quam ex illo dolorem quis.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 701.11m
                        },
                        new
                        {
                            ID = 2,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(1886),
                            Description = "Modi praesentium teldeki ut ut gülüyorum gitti ipsa sıla velit.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 725.56m
                        },
                        new
                        {
                            ID = 3,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(1958),
                            Description = "Qui yazın dolores dicta de laboriosam öyle sit iure nemo.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 153.03m
                        },
                        new
                        {
                            ID = 4,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2025),
                            Description = "Beatae dicta sunt masaya quia dolorem anlamsız çakıl doloremque modi.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 174.05m
                        },
                        new
                        {
                            ID = 5,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2085),
                            Description = "Göze un architecto quia karşıdakine adanaya öyle sıla laboriosam umut.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 561.45m
                        },
                        new
                        {
                            ID = 6,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2186),
                            Description = "Doloremque et vitae cesurca qui vitae adipisci dağılımı eum sequi.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 957.00m
                        },
                        new
                        {
                            ID = 7,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2248),
                            Description = "Architecto için neque illo commodi quia ışık kutusu sıla şafak.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 535.77m
                        },
                        new
                        {
                            ID = 8,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2309),
                            Description = "Minima qui exercitationem ad kapının qui voluptatem batarya nesciunt quia.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 690.05m
                        },
                        new
                        {
                            ID = 9,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2375),
                            Description = "Quia aut nisi lambadaki bundan modi esse sit mıknatıslı domates.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 378.92m
                        },
                        new
                        {
                            ID = 10,
                            Category = "Electronics",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2467),
                            Description = "Aut rem lakin kapının quia magnam orta molestiae kapının koştum.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 840.88m
                        },
                        new
                        {
                            ID = 11,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2533),
                            Description = "Accusantium aliquam gidecekmiş kalemi sed quia totam değerli enim numquam.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 836.37m
                        },
                        new
                        {
                            ID = 12,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2595),
                            Description = "Domates çorba quis bilgiyasayarı mi voluptas ki vel dağılımı bahar.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 348.52m
                        },
                        new
                        {
                            ID = 13,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2656),
                            Description = "Sıradanlıktan dolor ona ad alias değerli uzattı çobanın suscipit doğru.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 574.48m
                        },
                        new
                        {
                            ID = 14,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2740),
                            Description = "Düşünüyor ea dicta çarpan quia veniam dignissimos autem voluptatem kulu.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 440.47m
                        },
                        new
                        {
                            ID = 15,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2802),
                            Description = "Un dicta dolorem vitae koşuyorlar çünkü consequatur de gitti otobüs.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 846.81m
                        },
                        new
                        {
                            ID = 16,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2860),
                            Description = "Koştum dignissimos quasi praesentium reprehenderit oldular ab gül labore voluptatem.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 628.62m
                        },
                        new
                        {
                            ID = 17,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(2926),
                            Description = "Totam telefonu odio çıktılar anlamsız ipsa sıla veniam sarmal dolor.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 333.13m
                        },
                        new
                        {
                            ID = 18,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3008),
                            Description = "Doloremque gazete dolore suscipit ratione sit eum ona açılmadan voluptatem.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 783.82m
                        },
                        new
                        {
                            ID = 19,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3073),
                            Description = "Sıfat gül eve et duyulmamış exercitationem yaptı quia eum ut.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 903.45m
                        },
                        new
                        {
                            ID = 20,
                            Category = "Books",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3133),
                            Description = "Alias hesap ışık yapacakmış dolorem qui gitti eos duyulmamış masanın.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 474.15m
                        },
                        new
                        {
                            ID = 21,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3192),
                            Description = "Domates sinema doğru ötekinden modi göze okuma layıkıyla kapının beatae.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 36.59m
                        },
                        new
                        {
                            ID = 22,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3251),
                            Description = "Voluptatem un karşıdakine koşuyorlar göze anlamsız quia doğru aut kutusu.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 514.19m
                        },
                        new
                        {
                            ID = 23,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3332),
                            Description = "Voluptas koyun kutusu sokaklarda eum labore gülüyorum quia quis consectetur.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 898.41m
                        },
                        new
                        {
                            ID = 24,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3392),
                            Description = "Magnam yaptı yapacakmış karşıdakine nesciunt odit doğru et molestiae dolore.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 249.67m
                        },
                        new
                        {
                            ID = 25,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3448),
                            Description = "Reprehenderit gitti çorba voluptatem telefonu mutlu magni filmini rem ipsam.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 381.31m
                        },
                        new
                        {
                            ID = 26,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3505),
                            Description = "Ducimus blanditiis sit okuma rem yapacakmış neque patlıcan ipsa eos.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 847.44m
                        },
                        new
                        {
                            ID = 27,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3588),
                            Description = "Otobüs labore vel yaptı duyulmamış makinesi koştum balıkhaneye ab patlıcan.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 486.15m
                        },
                        new
                        {
                            ID = 28,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3646),
                            Description = "Ex karşıdakine totam dignissimos et quasi cesurca iusto ötekinden dolayı.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 735.16m
                        },
                        new
                        {
                            ID = 29,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3704),
                            Description = "Adanaya masaya sevindi ratione çorba adresini ex mi sandalye sit.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 214.56m
                        },
                        new
                        {
                            ID = 30,
                            Category = "Clothing",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3761),
                            Description = "Ipsa öyle consectetur mi in odit eum architecto voluptatum nisi.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 248.04m
                        },
                        new
                        {
                            ID = 31,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3860),
                            Description = "Umut şafak un iure kulu dergi autem gördüm ekşili biber.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 220.10m
                        },
                        new
                        {
                            ID = 32,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3925),
                            Description = "Sıfat olduğu ona quis yapacakmış bahar velit koyun suscipit ipsam.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 675.52m
                        },
                        new
                        {
                            ID = 33,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(3982),
                            Description = "Değirmeni filmini vitae sokaklarda mutlu sed nesciunt odio amet lakin.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 343.70m
                        },
                        new
                        {
                            ID = 34,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4040),
                            Description = "Aliquid eve ab orta sed kulu filmini ut umut çünkü.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 53.10m
                        },
                        new
                        {
                            ID = 35,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4101),
                            Description = "Voluptatem qui nihil cezbelendi ekşili bundan illo nesciunt iure filmini.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 793.28m
                        },
                        new
                        {
                            ID = 36,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4189),
                            Description = "Eum ötekinden ekşili camisi domates eve qui veniam praesentium aliquid.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 234.00m
                        },
                        new
                        {
                            ID = 37,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4245),
                            Description = "Qui cezbelendi patlıcan aliquam dergi düşünüyor açılmadan voluptas sarmal layıkıyla.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 271.19m
                        },
                        new
                        {
                            ID = 38,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4302),
                            Description = "Lambadaki masanın architecto duyulmamış ullam exercitationem rem ratione modi ducimus.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 207.75m
                        },
                        new
                        {
                            ID = 39,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4358),
                            Description = "Domates magni minima et sevindi veritatis gül sunt voluptatum ötekinden.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 374.73m
                        },
                        new
                        {
                            ID = 40,
                            Category = "Beauty",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4447),
                            Description = "Sayfası aliquid kalemi magni exercitationem gitti koştum velit dicta sit.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 741.82m
                        },
                        new
                        {
                            ID = 41,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4506),
                            Description = "Tempora explicabo öyle odit odio laboriosam bundan çünkü odio yaptı.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 648.78m
                        },
                        new
                        {
                            ID = 42,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4563),
                            Description = "Non kulu dignissimos otobüs magni lambadaki consequuntur blanditiis consequatur dolayı.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 744.14m
                        },
                        new
                        {
                            ID = 43,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4619),
                            Description = "Batarya ipsum laudantium şafak sokaklarda camisi quia nihil beğendim bahar.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 150.74m
                        },
                        new
                        {
                            ID = 44,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4700),
                            Description = "Inventore filmini değirmeni şafak nemo gidecekmiş consectetur voluptate anlamsız teldeki.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 337.23m
                        },
                        new
                        {
                            ID = 45,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4762),
                            Description = "Aspernatur beatae açılmadan teldeki tv nisi nostrum quis mi odio.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 800.81m
                        },
                        new
                        {
                            ID = 46,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4819),
                            Description = "Dışarı kulu değerli çakıl çıktılar camisi consequuntur gazete gülüyorum de.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 64.95m
                        },
                        new
                        {
                            ID = 47,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4875),
                            Description = "Qui corporis incidunt un dignissimos vitae ipsum voluptatem dağılımı hesap.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 484.29m
                        },
                        new
                        {
                            ID = 48,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(4976),
                            Description = "Kapının layıkıyla quia nostrum architecto corporis incidunt doloremque yapacakmış laudantium.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 72.78m
                        },
                        new
                        {
                            ID = 49,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(5068),
                            Description = "Nisi aut laudantium ea dicta qui ut dicta ab ve.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 609.74m
                        },
                        new
                        {
                            ID = 50,
                            Category = "Toys",
                            CreatedDate = new DateTime(2023, 5, 1, 18, 21, 51, 729, DateTimeKind.Local).AddTicks(5156),
                            Description = "Dışarı non blanditiis sed quaerat rem gördüm quae odit velit.",
                            Status = 0,
                            Unit = 150,
                            UnitPrice = 367.92m
                        });
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersID")
                        .HasColumnType("int");

                    b.Property<int>("ProductsID")
                        .HasColumnType("int");

                    b.HasKey("OrdersID", "ProductsID");

                    b.HasIndex("ProductsID");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("OrderAPI.Models.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderAPI.Models.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
