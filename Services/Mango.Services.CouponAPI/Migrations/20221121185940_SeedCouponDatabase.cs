using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.CouponAPI.Migrations
{
    public partial class SeedCouponDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "CouponCode", "DiscountAmount" },
                values: new object[] { new Guid("0522128e-41a0-4799-94a9-6ffd35395b43"), "10OFF", 10.0 });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "CouponCode", "DiscountAmount" },
                values: new object[] { new Guid("73a22c3b-7009-4578-8e2b-c7951c0b16c4"), "20OFF", 20.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("0522128e-41a0-4799-94a9-6ffd35395b43"));

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: new Guid("73a22c3b-7009-4578-8e2b-c7951c0b16c4"));
        }
    }
}
