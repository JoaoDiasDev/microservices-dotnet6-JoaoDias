using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopJoaoDias.ProductAPI.Migrations
{
    public partial class SeedProductsAdjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/11_mars.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/3_vader.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/4_storm_tropper.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/5_100_gamer.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/6_spacex.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/7_coffee.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/9_neil.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/10_milennium_falcon.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/11_mars.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/12_gnu_linux.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/13_dragon_ball.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L,
                column: "image_url",
                value: "https://github.com/JoaoDiasDev/microservices-dotnet6-JoaoDias/blob/master/ShopJoaoDias/ShoppingImages/11_mars.jpg");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg");
        }
    }
}
