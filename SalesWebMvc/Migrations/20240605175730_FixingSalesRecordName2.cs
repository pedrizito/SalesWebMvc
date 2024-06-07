using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class FixingSalesRecordName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Seller_SellerId",
                table: "SalesRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecords",
                table: "SalesRecords");

            migrationBuilder.RenameTable(
                name: "SalesRecords",
                newName: "salesrecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecords_SellerId",
                table: "salesrecord",
                newName: "IX_salesrecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesrecord",
                table: "salesrecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_salesrecord_Seller_SellerId",
                table: "salesrecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salesrecord_Seller_SellerId",
                table: "salesrecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_salesrecord",
                table: "salesrecord");

            migrationBuilder.RenameTable(
                name: "salesrecord",
                newName: "SalesRecords");

            migrationBuilder.RenameIndex(
                name: "IX_salesrecord_SellerId",
                table: "SalesRecords",
                newName: "IX_SalesRecords_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecords",
                table: "SalesRecords",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Seller_SellerId",
                table: "SalesRecords",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
