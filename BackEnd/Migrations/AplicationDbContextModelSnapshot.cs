﻿// <auto-generated />
using BackEnd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEnd.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BackEnd.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("IdentificacionCliente")
                        .IsRequired()
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("TipoIdentificacion")
                        .IsRequired()
                        .HasColumnType("Varchar(5)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BackEnd.Models.Despacho", b =>
                {
                    b.Property<int>("IdDespacho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("FechaEntrega")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("FechaRegistro")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdLugarEntrega")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoEnvio")
                        .HasColumnType("int");

                    b.Property<string>("NumeroGuia")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("NumeroTransporte")
                        .IsRequired()
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("Precio")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.HasKey("IdDespacho");

                    b.ToTable("Despacho");
                });

            modelBuilder.Entity("BackEnd.Models.LugarEntrega", b =>
                {
                    b.Property<int>("IdLugarEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.HasKey("IdLugarEntrega");

                    b.ToTable("LugarEntrega");
                });

            modelBuilder.Entity("BackEnd.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionProducto")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Precio")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("TipoProducto")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.HasKey("IdProducto");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("BackEnd.Models.TipoEnvio", b =>
                {
                    b.Property<int>("IdTipoEnvio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionTipoProducto")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.HasKey("IdTipoEnvio");

                    b.ToTable("TipoEnvio");
                });
#pragma warning restore 612, 618
        }
    }
}
