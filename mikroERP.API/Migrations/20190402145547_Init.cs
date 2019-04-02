using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mikroERP.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomNr = table.Column<int>(nullable: false),
                    FloorNr = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameOfTransport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameOfDepartment = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Wages = table.Column<double>(nullable: false),
                    DayOfEmployment = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true),
                    TransportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Transports_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 1, 1, 101 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 2, 1, 102 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 3, 1, 103 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 4, 1, 104 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 5, 1, 105 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 6, 2, 201 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 7, 2, 202 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 8, 2, 203 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 9, 2, 204 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "FloorNr", "RoomNr" },
                values: new object[] { 10, 2, 205 });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "NameOfTransport" },
                values: new object[] { 1, "Car" });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "NameOfTransport" },
                values: new object[] { 2, "Walk" });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "NameOfTransport" },
                values: new object[] { 3, "Bike" });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "NameOfTransport" },
                values: new object[] { 4, "Public Transport" });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "NameOfTransport" },
                values: new object[] { 5, "Train" });

            migrationBuilder.InsertData(
                table: "Transports",
                columns: new[] { "Id", "NameOfTransport" },
                values: new object[] { 6, "Other" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "LocationId", "NameOfDepartment" },
                values: new object[] { 1, 1, "Management" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "LocationId", "NameOfDepartment" },
                values: new object[] { 2, 2, "Logistics Department" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "LocationId", "NameOfDepartment" },
                values: new object[] { 3, 6, "Administration Department" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "LocationId", "NameOfDepartment" },
                values: new object[] { 4, 7, "Marketing department" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 6, new DateTime(1993, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "wiktor.kalafior@xx.pl", "Wiktor", "Kalafior", 678912345, "M", 3, 7500.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 9, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "martyna.pudelko@xx.pl", "Martyna", "Pudełko", 567891234, "F", 1, 5500.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 7, new DateTime(1986, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "maciej.cerata@xx.pl", "Maciej", "Cerata", 123945678, "M", 2, 6000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 4, new DateTime(1995, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "joanna.poduszka@xx.pl", "Joanna", "Poduszka", 123678945, "F", 5, 4000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 3, new DateTime(1987, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "kacper.stol@xx.pl", "Kacper", "Stół", 345126789, "M", 4, 5000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 20, new DateTime(1988, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "krzysztof.krzysztof@xx.pl", "Krzysztof", "Mastuczak", 234516789, "M", 1, 5800.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 13, new DateTime(1970, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "wioletta.popiol@xx.pl", "Wioletta", "Popiół", 456781239, "F", 1, 4400.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 10, new DateTime(1989, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "agata.kot@xx.pl", "Agata", "Kot", 156723489, "F", 1, 3300.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 2, new DateTime(1974, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "ewa.lampa@xx.pl", "Ewa", "Lampa", 123789456, "F", 6, 3000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 19, new DateTime(1988, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "klaudia.pass@xx.pl", "Klaudia", "Pass", 126789345, "F", 2, 3400.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 18, new DateTime(1984, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "anna.migawka@xx.pl", "Anna", "Migawka", 456123789, "F", 3, 2700.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 15, new DateTime(1982, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "pawel.mcree@xx.pl", "Paweł", "McRee", 678123459, "M", 4, 7400.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 12, new DateTime(1976, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "natalia.lisc@xx.pl", "Natalia", "Liść", 123784569, "F", 1, 5400.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 8, new DateTime(1997, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "marcin.brokul@xx.pl", "Marcin", "Brokuł", 456123789, "M", 6, 5000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 5, new DateTime(1997, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "wojtek.grzyb@xx.pl", "Wojtek", "Grzyb", 127893456, "M", 5, 3500.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 1, new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "adam.kowalski@xx.pl", "Adam", "Kowalski", 123456789, "M", 1, 5000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 17, new DateTime(1970, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "soap.price@xx.pl", "Soap", "Price", 127345689, "M", 1, 8000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 16, new DateTime(1968, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "jonnathan.joestar@xx.pl", "Jonnathan", "Joestar", 456789123, "M", 1, 10000.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 11, new DateTime(1989, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "karolina.butelka@xx.pl", "Karolina", "Butelka", 234516789, "F", 1, 5300.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DayOfEmployment", "DepartmentId", "Email", "FirstName", "LastName", "Phone", "Sex", "TransportId", "Wages" },
                values: new object[] { 14, new DateTime(1984, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "janusz.smith@xx.pl", "Janusz", "Smith", 123458967, "M", 1, 4100.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LocationId",
                table: "Departments",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TransportId",
                table: "Employees",
                column: "TransportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
