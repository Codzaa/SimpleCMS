﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cms.Data;

#nullable disable

namespace cms.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("cms.Data.CustomPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<string>("PageHeading")
                        .HasColumnType("text");

                    b.Property<string>("PageName")
                        .HasColumnType("text");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CustomPages");
                });

            modelBuilder.Entity("cms.Data.CustomSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<string>("SiteDescription")
                        .HasColumnType("text");

                    b.Property<string>("SiteName")
                        .HasColumnType("text");

                    b.Property<string>("SiteUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CustomSites");
                });

            modelBuilder.Entity("cms.Data.CustomUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserNickName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CustomUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
