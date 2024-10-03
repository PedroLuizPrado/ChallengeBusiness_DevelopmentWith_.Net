using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeSprint01.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table_odontoprev",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    name_odon = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    email_odon = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    password_odon = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    cpf_odon = table.Column<string>(type: "NVARCHAR2(11)", maxLength: 11, nullable: false),
                    tratamento_odon = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    status_active_odon = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    role_pb = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    avatar_odon = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_odontoprev", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_odontoprev");
        }
    }
}
