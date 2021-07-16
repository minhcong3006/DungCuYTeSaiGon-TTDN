﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webtt.Data;

namespace Webtt.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210627143529_CreatingIdentity")]
    partial class CreatingIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1951467d-3fcb-40d5-804d-ff41929e256a",
                            ConcurrencyStamp = "90d207b5-4708-46c8-ac4c-b5d77e9fba8f",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        },
                        new
                        {
                            Id = "dbd3e6b5-8299-4bb2-bdd3-6e9c7ee3c7c9",
                            ConcurrencyStamp = "2041a6f3-c154-4da5-8375-9d900770da74",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Webtt.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Dụng Cụ Chuyên Khoa"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Dụng Cụ Tập Đi"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Dụng Cụ Thẩm Mỹ"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Dụng Cụ Trị Liệu"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Dụng Cụ Y Tế INOX"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Đai Nẹp Y Tế"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Đèn Y Khoa"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Máy Móc Y Khoa"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Mẹ và Bé"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Trang Thiết Bị Y Khoa"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Vật Tư Y Tế Tiêu Hao"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "Vớ Y Khoa-Vớ Giãn Tĩnh Mạch"
                        },
                        new
                        {
                            CategoryId = 13,
                            CategoryName = "Sản Phẩm Mới"
                        });
                });

            modelBuilder.Entity("Webtt.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Webtt.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NewsContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("NewsId");

                    b.ToTable("Newss");

                    b.HasData(
                        new
                        {
                            NewsId = 1,
                            NewsContent = " Test title 1",
                            NewsImage = "chuyenkhoa.jpg",
                            NewsTitle = "Title test"
                        });
                });

            modelBuilder.Entity("Webtt.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 13,
                            Description = "Xe tiện dụng",
                            ProductImage = "xe-tiem-thuoc-30x40-2-tang1561266976.jpg",
                            ProductName = "Xe Tiêm 30*40 2 tầng hai vòng thâu",
                            ProductPrice = 500.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Máy đo thân nhiệt thế hệ mới",
                            ProductImage = "chuyenkhoa.jpg",
                            ProductName = "Máy đo thân nhiệt",
                            ProductPrice = 250.0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Dụng cụ tập đi cho những người bị tật",
                            ProductImage = "tapdi.jpg",
                            ProductName = "Xe tập đi",
                            ProductPrice = 700.0
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3,
                            Description = "Bộ trang thiết bị thẩm mỹ hiện đại nhất",
                            ProductImage = "thammy.jpg",
                            ProductName = "Máy thẩm mỹ",
                            ProductPrice = 1205.0
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            Description = "Ghế Gập Tay-Chân(Ba trong Một)",
                            ProductImage = "trịlieu.jpg",
                            ProductName = "Ghế Gập Tay-Chân",
                            ProductPrice = 2400.0
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 5,
                            Description = "Dùng để đựng dụng cụ y tế",
                            ProductImage = "inox.jpg",
                            ProductName = "Hộp đựng dụng cụ Inox",
                            ProductPrice = 50.0
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 6,
                            Description = "Đai nẹp cổ thoáng khí Breathable Neck support",
                            ProductImage = "dainep.jpg",
                            ProductName = "Đai nẹp cổ",
                            ProductPrice = 460.0
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 7,
                            Description = "Sử dụng phương pháp nhiệt đơn sắc, hỗ trợ kháng khuẩn, nấm.... ",
                            ProductImage = "den.jpg",
                            ProductName = "Đèn Hồng Ngoại y Tế",
                            ProductPrice = 390.0
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 8,
                            Description = "Giúp chẩn đoán nhanh hơn",
                            ProductImage = "maymoc.jpg",
                            ProductName = "Máy chụp CT scanner",
                            ProductPrice = 15000.0
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 9,
                            Description = "Bao gồm: Bộ hút đàm, Cặp nhiệt độ điện tử, ống hút thuốc",
                            ProductImage = "treem.jpg",
                            ProductName = "Bộ dụng cụ ý tế trẻ em",
                            ProductPrice = 350.0
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 10,
                            Description = "Khẩu trang y tế 3D kháng khuẩn 4 lớp màng lọc n95",
                            ProductImage = "trangtb.jpg",
                            ProductName = "Khẩu trang Y tế",
                            ProductPrice = 50.0
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 11,
                            Description = "Kích thước 1m8 x 0,0085/cuộn. Bịch 5 cuộn",
                            ProductImage = "tieuhao.jpg",
                            ProductName = "Băng cuộn Y tế",
                            ProductPrice = 20.0
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 12,
                            Description = "Làm giảm đường kính các tĩnh mạch ngăn máu chảy ngược xuống...",
                            ProductImage = "vo.jpg",
                            ProductName = "Vớ y khoa điều trị suy giãn tĩnh mạch",
                            ProductPrice = 380.0
                        });
                });

            modelBuilder.Entity("Webtt.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Webtt.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Webtt.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webtt.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Webtt.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Webtt.Models.Product", b =>
                {
                    b.HasOne("Webtt.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}