using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory_Shop.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "UserData",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserData", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
               name: "Materials",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   ShortDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   LongDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Price = table.Column<int>(type: "int", nullable: false),
                   Available = table.Column<bool>(type: "bit", nullable: false),
                   MaterialID = table.Column<int>(type: "int", nullable: false),
                   CategoryId = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Materials", x => x.Id);
                   table.ForeignKey(
                       name: "FK_Materials_Category_CategoryId",
                       column: x => x.CategoryId,
                       principalTable: "Category",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CategoryId",
                table: "Materials",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Category");

            //migrationBuilder.DropTable(
            //   name: "UserData");
        }
    }
}
