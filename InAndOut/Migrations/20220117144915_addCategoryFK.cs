using Microsoft.EntityFrameworkCore.Migrations;

namespace InAndOut.Migrations
{
    public partial class addCategoryFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExpensesCategoriesId",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpensesCategoriesId",
                table: "Expenses",
                column: "ExpensesCategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpensesCategories_ExpensesCategoriesId",
                table: "Expenses",
                column: "ExpensesCategoriesId",
                principalTable: "ExpensesCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpensesCategories_ExpensesCategoriesId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ExpensesCategoriesId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ExpensesCategoriesId",
                table: "Expenses");
        }
    }
}
