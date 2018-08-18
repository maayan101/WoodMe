using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WoodMe.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    ImageLink = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    ExperationMonth = table.Column<int>(nullable: false),
                    ExperationYear = table.Column<int>(nullable: false),
                    CVV = table.Column<string>(nullable: true),
                    DiscountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_OrderId",
                table: "Product",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_DiscountId",
                table: "Order",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Order_OrderId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Product_OrderId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Product");
        }
    }
}
