using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestLoadApp.Api.Dal.Migrations
{
    public partial class AddOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Items = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1270a71c-6c48-4ff2-b5cf-7d2282b69ebc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21edce5e-097c-45ba-a59b-3ef6e2c95372", "AQAAAAEAACcQAAAAEPZecA8CvWcpy0HmAARQmA/xX05F6lazebFRDqCyP7AqyPenNjkZ/N6KdL7NNsQJSQ==", "7fdb0a2a-1fe3-4140-bed7-2b67e9cf3017" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e42c4a0-a872-47a4-abc9-b3cc69b923a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d0a6f53-4a7d-45eb-8dcb-27c91a5a1e3e", "AQAAAAEAACcQAAAAEP/Pn46YZA45joPsTB5cTTQyHGm6CCeUyd1g4gMT0yWqCpOUCQdHgoB47EF7Uc5cIA==", "b51685a8-bd12-4ecf-8c01-2b007d5d4ea6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c4e8205-72ad-431e-921a-ed4599bfa427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "993212a6-7cc3-49a5-9570-d217ea14653c", "AQAAAAEAACcQAAAAEGuGFF4KTjQVL1+TAXJHwr1jeCfjsZr2OiBxed2p/0BCGpAoHW6okkwEzplS/CSIBQ==", "3fe91335-526b-46bf-ba1c-d654a409b6f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57266d27-1262-4be5-b765-f5674d41300a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d9517e0-469d-4fe5-a5b1-e2c09a5070aa", "AQAAAAEAACcQAAAAEPvnaNV6tfiH9xMTLLzfZ06fvFhCy1otqSSn5KqYOSC7JBOS8drs/DZSupDbCnkFmA==", "0024159c-3616-42cf-9b87-aca8161746f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fa2d163-79bd-4580-abf5-8b6536f239c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "851886a4-f0f4-4a6c-83c3-d4ae767853fd", "AQAAAAEAACcQAAAAEHo1SauT4HQLFxf+dbLOetVtX4lTkZTzfxRTmnUKx2mUqkLTsTQE2thkdMoDKjpR+g==", "f6070ab2-d189-456e-865b-1b7820d01716" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8598ab52-ed4c-4c48-8ea6-28f560cd66a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "834b961e-331f-46de-afaa-fca844a1cc62", "AQAAAAEAACcQAAAAEJ+uLkUIVaeBU9KhqEPRF9DHSGiuus0RljA9/2OXqckwZdUy/xEyZl3OMcCkd2GvZA==", "2d0b3d3a-3d5e-4217-bdf2-d72d3dc5bbad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4852bde-7e11-4950-b4e7-f612138df5bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1ef29ed-88cd-464b-9a60-a07c249cfa83", "AQAAAAEAACcQAAAAEK8ZOn1nT1iBa67xfS8q3qhpto17YX45JpvBBUBrQH6acZ7NiMLZ+FiC3b5IjAyL7A==", "fdb78b1a-e2fb-4487-9120-5884e9d5b1b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c589cf61-a6ee-4b5f-93ed-7fc027e9cc95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb9d35d-2e11-4b99-8bcb-ba113a200151", "AQAAAAEAACcQAAAAEG0CCPnj7QFptbCYltCDGT40gagzsedw1wxhObWqSzsNT+uC9SSTPOpRtLKb5Kec5Q==", "b63e4239-584f-4f08-863a-93ae41b6d980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea20d4bd-431e-4ccf-b61d-b20db06cf362",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a35abf4e-d842-48df-a8a5-56f4605da33f", "AQAAAAEAACcQAAAAELm60pFnkktWmrWsxXgrFrPK5ycwEFS85Ai4bNwQ82D6SkL0WsM0z7Ioq7ejPBIK/Q==", "a2ddb3ac-bae0-4af7-932b-8dd2438c06e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc007b46-551a-44e5-b26f-ed5070a184ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e321f766-d92d-4467-b104-592e87f03fd6", "AQAAAAEAACcQAAAAEL5RgvHJx2LeWc9CtvCuuuf0iFV9mV/AsVnzJifsrkdUxeeWObRKRRgWtCEsU007zw==", "7fb5dc62-5ef2-4e43-8c46-070a6cb1fb00" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1270a71c-6c48-4ff2-b5cf-7d2282b69ebc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13f61e9d-c081-47b4-8830-21699d654c12", "AQAAAAEAACcQAAAAEBPvd3usAEWWcOpxAwrKYexOAuM2WiYdXYBK8AHpy8BIffYxAWD7JU0HaVxDM2okhQ==", "f086c395-41bb-4b5d-b289-8ebffcd85bdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e42c4a0-a872-47a4-abc9-b3cc69b923a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9468e829-476f-4796-80c2-9383bea8741a", "AQAAAAEAACcQAAAAELwDk9gERAgTFQolN5qL5ppFRqFxqmIoRSD27XJbpfwanEnBhQ64VoTAlG3g9z7puw==", "adb69999-e7ef-46b9-a5ca-3833550c5cb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c4e8205-72ad-431e-921a-ed4599bfa427",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c29a25b-a7f5-4a65-b71c-584f43852c85", "AQAAAAEAACcQAAAAEAineP3sN8Wi6E9YiYYwrhZD8oOjYgK0gTFscNItEJCcngZHnVFneiduwN0xoUQGtA==", "1a5da283-7c6f-458f-8705-7ad4e3b713de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57266d27-1262-4be5-b765-f5674d41300a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62579bb0-ccde-47b4-8fd7-23a784c83a7c", "AQAAAAEAACcQAAAAEM+SLoB6vc4vlRYg2UTwKQHss2wSsBaVR+kCD6Ku6b8JZbSRODLSa4WBrEhFkrW9iw==", "3545fddb-2624-437b-a855-32961ac4d9ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fa2d163-79bd-4580-abf5-8b6536f239c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cafcbd60-813d-40d2-9dcb-e8bada5925d9", "AQAAAAEAACcQAAAAELCmsckckUt9nro3au7T7VEMZ7Nl7woYZpsWaz0fsv7fJjgn6SC6KYnqhQSvpiIj1g==", "3885e338-4ade-4c3b-bc2f-4002fb551029" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8598ab52-ed4c-4c48-8ea6-28f560cd66a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c2e5be-ef29-4514-8019-cc4c93678f3e", "AQAAAAEAACcQAAAAEHlnf64xqGQezRojGBzigmruXGtaksm13WP3lMrBJ8XdJue5xHZWeyPElomCRPQgmg==", "d2c374e6-54c1-4d18-ac0e-39b24d2f9cdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4852bde-7e11-4950-b4e7-f612138df5bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8120b60b-5b82-4349-8331-b4afaa56c414", "AQAAAAEAACcQAAAAEKLM4ZLsbTtqEoWpqck1sEkttg3fUtb/edaA9XnRl4ALQPHt7dQkim1Ka+Njx30zRw==", "190a189e-f851-4000-ad38-d04633eea415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c589cf61-a6ee-4b5f-93ed-7fc027e9cc95",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a804e90-1b1c-4227-a31c-80ce2e61b55a", "AQAAAAEAACcQAAAAECxaUE59SzyJtqnnb9vnoGmN7aaBs6ZexTStxkKvG20JyjWzRyeh0KlQ2vcYCb8Rtg==", "0fafc8b8-792e-4e2d-ad64-9ec9ddd6a3df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea20d4bd-431e-4ccf-b61d-b20db06cf362",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0c6668e-d674-493e-92e1-5fa6fc9cad6b", "AQAAAAEAACcQAAAAEDzlErB0jM3Vf5YH1DAYaqeHnIit4Pucp6nkku5oCw4GJu3UYTtLAUZBiqOOiO/gMg==", "1e58fc22-9a69-4dbe-ab57-fba7901ef5ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc007b46-551a-44e5-b26f-ed5070a184ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "085d98fb-376d-47c9-a86c-91dd2820c946", "AQAAAAEAACcQAAAAEEf4vKktwVeCNsCkPQy8za+oMXW6tpTN5vH2/zgHDHl98oD5d3WPOHx+Cmc3MiAJZA==", "9109dbbf-e01a-406d-876c-69f459629721" });
        }
    }
}
