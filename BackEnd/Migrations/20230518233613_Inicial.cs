using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion = table.Column<string>(type: "Varchar(5)", nullable: false),
                    IdentificacionCliente = table.Column<string>(type: "Varchar(30)", nullable: false),
                    NombreCliente = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Direccion = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Telefono = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Despacho",
                columns: table => new
                {
                    IdDespacho = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    IdProducto = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<string>(type: "Varchar(10)", nullable: false),
                    FechaEntrega = table.Column<string>(type: "Varchar(10)", nullable: false),
                    Precio = table.Column<string>(type: "Varchar(20)", nullable: false),
                    NumeroTransporte = table.Column<string>(type: "Varchar(10)", nullable: false),
                    NumeroGuia = table.Column<string>(type: "Varchar(10)", nullable: false),
                    IdTipoEnvio = table.Column<int>(nullable: false),
                    IdLugarEntrega = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despacho", x => x.IdDespacho);
                });

            migrationBuilder.CreateTable(
                name: "LugarEntrega",
                columns: table => new
                {
                    IdLugarEntrega = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lugar = table.Column<string>(type: "Varchar(20)", nullable: false),
                    Descripcion = table.Column<string>(type: "Varchar(150)", nullable: false),
                    Direccion = table.Column<string>(type: "Varchar(150)", nullable: false),
                    Telefono = table.Column<string>(type: "Varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LugarEntrega", x => x.IdLugarEntrega);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionProducto = table.Column<string>(type: "Varchar(100)", nullable: false),
                    TipoProducto = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Precio = table.Column<string>(type: "Varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "TipoEnvio",
                columns: table => new
                {
                    IdTipoEnvio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionTipoProducto = table.Column<string>(type: "Varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEnvio", x => x.IdTipoEnvio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Despacho");

            migrationBuilder.DropTable(
                name: "LugarEntrega");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "TipoEnvio");
        }
    }
}
