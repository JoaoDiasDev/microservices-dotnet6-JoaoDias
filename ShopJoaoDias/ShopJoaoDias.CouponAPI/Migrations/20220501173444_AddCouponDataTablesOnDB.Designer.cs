// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopJoaoDias.CouponAPI.Model.Context;

#nullable disable

namespace ShopJoaoDias.CouponAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20220501173444_AddCouponDataTablesOnDB")]
    partial class AddCouponDataTablesOnDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShopJoaoDias.CouponAPI.Model.Coupon", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("coupon_code");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("discount_amount");

                    b.HasKey("Id");

                    b.ToTable("coupon");
                });
#pragma warning restore 612, 618
        }
    }
}
