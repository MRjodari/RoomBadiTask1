﻿// <auto-generated />
using System;
using Hermes.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hermes.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hermes.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DeviceIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a2b8fc54-1e16-4bff-bf68-7f9aef177796"),
                            DeviceIdentifier = new Guid("1fc1571d-3890-43ed-9392-fe14a721c8f0"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2366),
                            UserName = "Mora"
                        },
                        new
                        {
                            Id = new Guid("c3b4483e-96b8-412d-b892-f2a0b22aee67"),
                            DeviceIdentifier = new Guid("cc2d6986-5d65-47ff-ac28-b03e5ecddd49"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2384),
                            UserName = "Ali"
                        },
                        new
                        {
                            Id = new Guid("35227a66-40f5-4c85-b11e-934b55e23117"),
                            DeviceIdentifier = new Guid("f7eacefa-39aa-4a3e-9cb6-76bec7fa4dff"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2386),
                            UserName = "Mehran"
                        },
                        new
                        {
                            Id = new Guid("6bae5770-fdd9-4c66-85f2-c0dadd4ab6aa"),
                            DeviceIdentifier = new Guid("829e3cdc-78a3-4a3d-b1b5-c86a7f901fa4"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2389),
                            UserName = "Babak"
                        },
                        new
                        {
                            Id = new Guid("e7943c96-8efb-4913-b50b-bf22b6f80f6c"),
                            DeviceIdentifier = new Guid("e9dc547c-7ea8-4113-a0b2-560c7de8d564"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2391),
                            UserName = "Sara"
                        },
                        new
                        {
                            Id = new Guid("0cde848b-ca31-4710-b30e-886a94957a87"),
                            DeviceIdentifier = new Guid("1d9e9ea6-1e63-4553-95ac-efea8fba263c"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2399),
                            UserName = "Ahad"
                        },
                        new
                        {
                            Id = new Guid("ae7e5565-74a7-46af-931c-3919b31a26d7"),
                            DeviceIdentifier = new Guid("e8f8c794-415d-426f-a264-90623f5a61f8"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2401),
                            UserName = "Reza"
                        },
                        new
                        {
                            Id = new Guid("ea75c306-b19b-4b54-88e2-d25d500bc2a2"),
                            DeviceIdentifier = new Guid("fdbbcb91-2761-44db-ac06-e95c49ec0ba5"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2403),
                            UserName = "Maryam"
                        },
                        new
                        {
                            Id = new Guid("af09f8e0-328a-4663-a250-1584831f3e82"),
                            DeviceIdentifier = new Guid("00a3cad7-fb9f-4d11-a40d-2ea84b856a70"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2405),
                            UserName = "Saeid"
                        },
                        new
                        {
                            Id = new Guid("b9f8fb7a-8c45-4f20-8eb6-92a7920eb043"),
                            DeviceIdentifier = new Guid("9eda87ba-a33d-4354-a362-7da220780f7e"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2407),
                            UserName = "Saman"
                        },
                        new
                        {
                            Id = new Guid("66621e0a-63b5-488d-8bab-d1940b3e5e4a"),
                            DeviceIdentifier = new Guid("f53e964d-5aa2-47b6-a67c-6900b49ea78c"),
                            IsActive = true,
                            IsDeleted = false,
                            RegisterDate = new DateTime(2022, 12, 22, 15, 18, 0, 64, DateTimeKind.Local).AddTicks(2409),
                            UserName = "Aidin"
                        });
                });

            modelBuilder.Entity("Hermes.Domain.Entities.UserMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserMessages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b0d608dd-cc8a-4849-b546-92c400d9a8e1"),
                            UserId = new Guid("1fc1571d-3890-43ed-9392-fe14a721c8f0")
                        },
                        new
                        {
                            Id = new Guid("e44327fc-3b8e-4be3-b437-846685f4e056"),
                            UserId = new Guid("cc2d6986-5d65-47ff-ac28-b03e5ecddd49")
                        },
                        new
                        {
                            Id = new Guid("37af754e-a853-4100-a40a-430659614e74"),
                            UserId = new Guid("f7eacefa-39aa-4a3e-9cb6-76bec7fa4dff")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}