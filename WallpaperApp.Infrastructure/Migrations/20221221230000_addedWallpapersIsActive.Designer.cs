﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WallpaperApp.Infrastructure.Data;

#nullable disable

namespace WallpaperApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221221230000_addedWallpapersIsActive")]
    partial class addedWallpapersIsActive
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d96e1102-e109-4c09-9b70-c242f1a5cc0f",
                            Email = "wauser@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "wauser@mail.com",
                            NormalizedUserName = "wauser",
                            PasswordHash = "AQAAAAEAACcQAAAAEPR1K731xdYW+svqjd6pTSY1k1SVItXeypNZttNc9gVmkbcf/Zo/hNmlWKggGjrEsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8d71b6f9-fc17-4343-a8e0-fa09aa0d083b",
                            TwoFactorEnabled = false,
                            UserName = "wauser"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bbde95c2-e3a2-4313-a5ce-5a5b99012288",
                            Email = "wauser2@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "wauser2@mail.com",
                            NormalizedUserName = "wauser2",
                            PasswordHash = "AQAAAAEAACcQAAAAEP1lSwkYVt21STJzZ3JDdEwyyKRWmEGR/peRjj25QSso82S2se886BzxeK2UWeQMbA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3dbd1a89-1001-4bba-90b1-fa4ecd476ec3",
                            TwoFactorEnabled = false,
                            UserName = "wauser2"
                        });
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nature"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Animals"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Minimalist"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cars"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Design"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Food"
                        });
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WallpaperId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WallpaperId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Favorite", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WallpaperId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "WallpaperId");

                    b.HasIndex("WallpaperId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Like", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WallpaperId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("UserId", "WallpaperId");

                    b.HasIndex("WallpaperId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Resolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Resolutions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Size = "1280x720"
                        },
                        new
                        {
                            Id = 2,
                            Size = "1600x900"
                        },
                        new
                        {
                            Id = 3,
                            Size = "1920x1080"
                        },
                        new
                        {
                            Id = 4,
                            Size = "2560x1440"
                        },
                        new
                        {
                            Id = 5,
                            Size = "3840x2160"
                        });
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Wallpaper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Camera")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ResolutionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ResolutionId");

                    b.HasIndex("UserId");

                    b.ToTable("Wallpapers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Camera = "Samsung S20",
                            CategoryId = 3,
                            Date = new DateTime(2022, 12, 22, 0, 59, 59, 900, DateTimeKind.Local).AddTicks(2110),
                            ImageUrl = "https://images5.alphacoders.com/438/438463.png",
                            IsActive = true,
                            ResolutionId = 3,
                            Title = "City",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new
                        {
                            Id = 2,
                            Camera = "IPhone 12",
                            CategoryId = 1,
                            Date = new DateTime(2022, 12, 22, 0, 59, 59, 900, DateTimeKind.Local).AddTicks(2152),
                            ImageUrl = "https://images.hdqwalls.com/download/nature-background-2560x1440.jpg",
                            IsActive = true,
                            ResolutionId = 4,
                            Title = "Mountains",
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        },
                        new
                        {
                            Id = 3,
                            Camera = "SONY FDR-AX43",
                            CategoryId = 4,
                            Date = new DateTime(2022, 12, 22, 0, 59, 59, 900, DateTimeKind.Local).AddTicks(2156),
                            ImageUrl = "https://wallpaperaccess.com/full/42412.jpg",
                            IsActive = true,
                            ResolutionId = 5,
                            Title = "Koenigsegg",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        });
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
                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", null)
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

                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Comment", b =>
                {
                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WallpaperApp.Infrastructure.Data.Wallpaper", "Wallpaper")
                        .WithMany("Comments")
                        .HasForeignKey("WallpaperId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Wallpaper");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Favorite", b =>
                {
                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WallpaperApp.Infrastructure.Data.Wallpaper", "Wallpaper")
                        .WithMany("Favorites")
                        .HasForeignKey("WallpaperId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Wallpaper");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Like", b =>
                {
                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WallpaperApp.Infrastructure.Data.Wallpaper", "Wallpaper")
                        .WithMany("Likes")
                        .HasForeignKey("WallpaperId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Wallpaper");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Wallpaper", b =>
                {
                    b.HasOne("WallpaperApp.Infrastructure.Data.Category", "Category")
                        .WithMany("Wallpapers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WallpaperApp.Infrastructure.Data.Resolution", "Resolution")
                        .WithMany("Wallpapers")
                        .HasForeignKey("ResolutionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WallpaperApp.Infrastructure.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Resolution");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favorites");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Category", b =>
                {
                    b.Navigation("Wallpapers");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Resolution", b =>
                {
                    b.Navigation("Wallpapers");
                });

            modelBuilder.Entity("WallpaperApp.Infrastructure.Data.Wallpaper", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favorites");

                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
