using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestLoadApp.Api.Dal.Migrations
{
    public partial class AddUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1270a71c-6c48-4ff2-b5cf-7d2282b69ebc", 0, "13f61e9d-c081-47b4-8830-21699d654c12", "JacquelineHowarth@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEBPvd3usAEWWcOpxAwrKYexOAuM2WiYdXYBK8AHpy8BIffYxAWD7JU0HaVxDM2okhQ==", "1234567894", false, "f086c395-41bb-4b5d-b289-8ebffcd85bdd", false, "JacquelineHowarth" },
                    { "3e42c4a0-a872-47a4-abc9-b3cc69b923a9", 0, "9468e829-476f-4796-80c2-9383bea8741a", "AnnabelleRowe@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELwDk9gERAgTFQolN5qL5ppFRqFxqmIoRSD27XJbpfwanEnBhQ64VoTAlG3g9z7puw==", "1234567898", false, "adb69999-e7ef-46b9-a5ca-3833550c5cb0", false, "AnnabelleRowe" },
                    { "4c4e8205-72ad-431e-921a-ed4599bfa427", 0, "1c29a25b-a7f5-4a65-b71c-584f43852c85", "AmeerahYoung@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEAineP3sN8Wi6E9YiYYwrhZD8oOjYgK0gTFscNItEJCcngZHnVFneiduwN0xoUQGtA==", "1234567895", false, "1a5da283-7c6f-458f-8705-7ad4e3b713de", false, "AmeerahYoung" },
                    { "57266d27-1262-4be5-b765-f5674d41300a", 0, "62579bb0-ccde-47b4-8fd7-23a784c83a7c", "ShereenRutledge@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEM+SLoB6vc4vlRYg2UTwKQHss2wSsBaVR+kCD6Ku6b8JZbSRODLSa4WBrEhFkrW9iw==", "1234567897", false, "3545fddb-2624-437b-a855-32961ac4d9ac", false, "ShereenRutledge" },
                    { "5fa2d163-79bd-4580-abf5-8b6536f239c3", 0, "cafcbd60-813d-40d2-9dcb-e8bada5925d9", "LibertyDuffy@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELCmsckckUt9nro3au7T7VEMZ7Nl7woYZpsWaz0fsv7fJjgn6SC6KYnqhQSvpiIj1g==", "1234567896", false, "3885e338-4ade-4c3b-bc2f-4002fb551029", false, "LibertyDuffy" },
                    { "8598ab52-ed4c-4c48-8ea6-28f560cd66a8", 0, "13c2e5be-ef29-4514-8019-cc4c93678f3e", "RhiannanPittman@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEHlnf64xqGQezRojGBzigmruXGtaksm13WP3lMrBJ8XdJue5xHZWeyPElomCRPQgmg==", "1234567899", false, "d2c374e6-54c1-4d18-ac0e-39b24d2f9cdf", false, "RhiannanPittman" },
                    { "b4852bde-7e11-4950-b4e7-f612138df5bd", 0, "8120b60b-5b82-4349-8331-b4afaa56c414", "MaisyClements@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEKLM4ZLsbTtqEoWpqck1sEkttg3fUtb/edaA9XnRl4ALQPHt7dQkim1Ka+Njx30zRw==", "1234567893", false, "190a189e-f851-4000-ad38-d04633eea415", false, "MaisyClements" },
                    { "c589cf61-a6ee-4b5f-93ed-7fc027e9cc95", 0, "7a804e90-1b1c-4227-a31c-80ce2e61b55a", "FerneChung@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAECxaUE59SzyJtqnnb9vnoGmN7aaBs6ZexTStxkKvG20JyjWzRyeh0KlQ2vcYCb8Rtg==", "1234567891", false, "0fafc8b8-792e-4e2d-ad64-9ec9ddd6a3df", false, "FerneChung" },
                    { "ea20d4bd-431e-4ccf-b61d-b20db06cf362", 0, "d0c6668e-d674-493e-92e1-5fa6fc9cad6b", "BillieRigby@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDzlErB0jM3Vf5YH1DAYaqeHnIit4Pucp6nkku5oCw4GJu3UYTtLAUZBiqOOiO/gMg==", "1234567890", false, "1e58fc22-9a69-4dbe-ab57-fba7901ef5ae", false, "BillieRigby" },
                    { "fc007b46-551a-44e5-b26f-ed5070a184ba", 0, "085d98fb-376d-47c9-a86c-91dd2820c946", "YolandaPaine@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEEf4vKktwVeCNsCkPQy8za+oMXW6tpTN5vH2/zgHDHl98oD5d3WPOHx+Cmc3MiAJZA==", "1234567892", false, "9109dbbf-e01a-406d-876c-69f459629721", false, "YolandaPaine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1270a71c-6c48-4ff2-b5cf-7d2282b69ebc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e42c4a0-a872-47a4-abc9-b3cc69b923a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c4e8205-72ad-431e-921a-ed4599bfa427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57266d27-1262-4be5-b765-f5674d41300a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fa2d163-79bd-4580-abf5-8b6536f239c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8598ab52-ed4c-4c48-8ea6-28f560cd66a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4852bde-7e11-4950-b4e7-f612138df5bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c589cf61-a6ee-4b5f-93ed-7fc027e9cc95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea20d4bd-431e-4ccf-b61d-b20db06cf362");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc007b46-551a-44e5-b26f-ed5070a184ba");
        }
    }
}
