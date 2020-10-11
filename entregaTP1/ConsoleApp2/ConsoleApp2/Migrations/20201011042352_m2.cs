using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Usuario",
                newName: "nUsuario");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuario",
                newName: "pass");

            migrationBuilder.RenameColumn(
                name: "UsuarioPK",
                table: "Usuario",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Vencimiento",
                table: "Tarea",
                newName: "vencimiento");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Tarea",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Estimacion",
                table: "Tarea",
                newName: "estimacion");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Tarea",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tarea",
                newName: "taskId");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Recurso",
                newName: "nRecurso");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Recurso",
                newName: "recId");

            migrationBuilder.AlterColumn<string>(
                name: "nUsuario",
                table: "Usuario",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pass",
                table: "Usuario",
                type: "varchar(12)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(20)");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Tarea",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "estimacion",
                table: "Tarea",
                type: "int(2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "Tarea",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nRecurso",
                table: "Recurso",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    detId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    tiempo = table.Column<int>(type: "int(5)", nullable: false),
                    RecursoId = table.Column<int>(nullable: false),
                    TareaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.detId);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recurso",
                        principalColumn: "recId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_TareaId",
                        column: x => x.TareaId,
                        principalTable: "Tarea",
                        principalColumn: "taskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_RecursoId",
                table: "Detalle",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_TareaId",
                table: "Detalle",
                column: "TareaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.RenameColumn(
                name: "nUsuario",
                table: "Usuario",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "pass",
                table: "Usuario",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Usuario",
                newName: "UsuarioPK");

            migrationBuilder.RenameColumn(
                name: "vencimiento",
                table: "Tarea",
                newName: "Vencimiento");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Tarea",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "estimacion",
                table: "Tarea",
                newName: "Estimacion");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Tarea",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "taskId",
                table: "Tarea",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nRecurso",
                table: "Recurso",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "recId",
                table: "Recurso",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuario",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Usuario",
                type: "char(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(12)");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioPK",
                table: "Usuario",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tarea",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "Estimacion",
                table: "Tarea",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(2)");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Tarea",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Recurso",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
