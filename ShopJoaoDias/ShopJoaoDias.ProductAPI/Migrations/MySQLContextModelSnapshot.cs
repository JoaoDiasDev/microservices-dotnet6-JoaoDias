﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopJoaoDias.ProductAPI.Model.Context;

#nullable disable

namespace ShopJoaoDias.ProductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShopJoaoDias.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/11_mars.jpg?raw=true",
                            Name = "Darth Vader Star Wars",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Action Figure",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/3_vader.jpg?raw=true",
                            Name = "Capacete Darth Vader Star Wars Black Series",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Action Figure",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/4_storm_tropper.jpg?raw=true",
                            Name = "Star Wars The Black Series Hasbro - Stormtrooper Imperial",
                            Price = 189.99m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/5_100_gamer.jpg?raw=true",
                            Name = "T-Shirt Gamer",
                            Price = 69.99m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/6_spacex.jpg?raw=true",
                            Name = "T-Shirt SpaceX",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/7_coffee.jpg?raw=true",
                            Name = "T-Shirt Coffee Benefits",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 8L,
                            CategoryName = "Sweatshirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true",
                            Name = "Hood Cobra Kai",
                            Price = 159.9m
                        },
                        new
                        {
                            Id = 9L,
                            CategoryName = "Book",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/9_neil.jpg?raw=true",
                            Name = "Book Star Talk – Neil DeGrasse Tyson",
                            Price = 49.9m
                        },
                        new
                        {
                            Id = 10L,
                            CategoryName = "Action Figure",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                            Name = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                            Price = 359.99m
                        },
                        new
                        {
                            Id = 11L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/11_mars.jpg?raw=true",
                            Name = "Camiseta Elon Musk Spacex Marte Occupy Mars",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = 12L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/12_gnu_linux.jpg?raw=true",
                            Name = "Camiseta GNU Linux Programador Masculina",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = 13L,
                            CategoryName = "T-shirt",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                            ImageURL = "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/13_dragon_ball.jpg",
                            Name = "Camiseta Goku Fases",
                            Price = 59.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
