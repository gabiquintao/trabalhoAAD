using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trabalhoAAD.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__marca__3213E83F2A79F4C7", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "morada",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    numero = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    cp1 = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false),
                    cp2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__morada__3213E83FB4A30983", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "modelo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    tipo_combustivel = table.Column<byte>(type: "tinyint", nullable: false),
                    id_marca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__modelo__3213E83F575CF627", x => x.id);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca",
                        column: x => x.id_marca,
                        principalTable: "marca",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "atendente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    id_morada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__atendent__3213E83FA8A520A8", x => x.id);
                    table.ForeignKey(
                        name: "FK_Atendente_Morada",
                        column: x => x.id_morada,
                        principalTable: "morada",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    tipo = table.Column<bool>(type: "bit", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    telefone = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    id_morada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cliente__3213E83FC787D08F", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cliente_Morada",
                        column: x => x.id_morada,
                        principalTable: "morada",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    telefone = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    id_morada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__forneced__3213E83FE5C44664", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Morada",
                        column: x => x.id_morada,
                        principalTable: "morada",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "mecanico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    especialidade = table.Column<byte>(type: "tinyint", nullable: false),
                    telefone = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    id_morada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__mecanico__3213E83FF83DEFE3", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mecanico_Morada",
                        column: x => x.id_morada,
                        principalTable: "morada",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "atendimento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateOnly>(type: "date", nullable: false),
                    motivo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    id_atendente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__atendime__3213E83F17D305BE", x => x.id);
                    table.ForeignKey(
                        name: "FK_Atendimento_Atendente",
                        column: x => x.id_atendente,
                        principalTable: "atendente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Atendimento_Cliente",
                        column: x => x.id_cliente,
                        principalTable: "cliente",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "veiculo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    matricula = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    mes = table.Column<byte>(type: "tinyint", nullable: false),
                    ano = table.Column<short>(type: "smallint", nullable: false),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    id_modelo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__veiculo__3213E83F2041EC44", x => x.id);
                    table.ForeignKey(
                        name: "FK_Veiculo_Cliente",
                        column: x => x.id_cliente,
                        principalTable: "cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Veiculo_Modelo",
                        column: x => x.id_modelo,
                        principalTable: "modelo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "material",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    valor = table.Column<int>(type: "int", nullable: false),
                    id_fornecedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__material__3213E83F4C64C0A1", x => x.id);
                    table.ForeignKey(
                        name: "FK_Material_Fornecedor",
                        column: x => x.id_fornecedor,
                        principalTable: "fornecedor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "servico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<byte>(type: "tinyint", nullable: false),
                    data_inicio = table.Column<DateOnly>(type: "date", nullable: false),
                    data_fim = table.Column<DateOnly>(type: "date", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    id_mecanico = table.Column<int>(type: "int", nullable: false),
                    id_veiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__servico__3213E83F8B436043", x => x.id);
                    table.ForeignKey(
                        name: "FK_Servico_Mecanico",
                        column: x => x.id_mecanico,
                        principalTable: "mecanico",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Servico_Veiculo",
                        column: x => x.id_veiculo,
                        principalTable: "veiculo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "orcamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<int>(type: "int", nullable: false),
                    id_servico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__orcament__3213E83FC0BA61E7", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orcamento_Servico",
                        column: x => x.id_servico,
                        principalTable: "servico",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "relatorio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<byte>(type: "tinyint", nullable: false),
                    texto = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    data = table.Column<DateOnly>(type: "date", nullable: false),
                    id_servico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__relatori__3213E83F935DEFD9", x => x.id);
                    table.ForeignKey(
                        name: "FK_Relatorio_Servico",
                        column: x => x.id_servico,
                        principalTable: "servico",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "servico_material",
                columns: table => new
                {
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    id_servico = table.Column<int>(type: "int", nullable: false),
                    id_material = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ServicoMaterial_Material",
                        column: x => x.id_material,
                        principalTable: "material",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ServicoMaterial_Servico",
                        column: x => x.id_servico,
                        principalTable: "servico",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pagamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateOnly>(type: "date", nullable: false),
                    metodo = table.Column<byte>(type: "tinyint", nullable: false),
                    id_orcamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pagament__3213E83F8AC1A597", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pagamento_Orcamento",
                        column: x => x.id_orcamento,
                        principalTable: "orcamento",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_atendente_id_morada",
                table: "atendente",
                column: "id_morada");

            migrationBuilder.CreateIndex(
                name: "IX_atendimento_id_atendente",
                table: "atendimento",
                column: "id_atendente");

            migrationBuilder.CreateIndex(
                name: "IX_atendimento_id_cliente",
                table: "atendimento",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_id_morada",
                table: "cliente",
                column: "id_morada");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_id_morada",
                table: "fornecedor",
                column: "id_morada");

            migrationBuilder.CreateIndex(
                name: "IX_material_id_fornecedor",
                table: "material",
                column: "id_fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_mecanico_id_morada",
                table: "mecanico",
                column: "id_morada");

            migrationBuilder.CreateIndex(
                name: "IX_modelo_id_marca",
                table: "modelo",
                column: "id_marca");

            migrationBuilder.CreateIndex(
                name: "IX_orcamento_id_servico",
                table: "orcamento",
                column: "id_servico");

            migrationBuilder.CreateIndex(
                name: "IX_pagamento_id_orcamento",
                table: "pagamento",
                column: "id_orcamento");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_id_servico",
                table: "relatorio",
                column: "id_servico");

            migrationBuilder.CreateIndex(
                name: "IX_servico_id_mecanico",
                table: "servico",
                column: "id_mecanico");

            migrationBuilder.CreateIndex(
                name: "IX_servico_id_veiculo",
                table: "servico",
                column: "id_veiculo");

            migrationBuilder.CreateIndex(
                name: "IX_servico_material_id_material",
                table: "servico_material",
                column: "id_material");

            migrationBuilder.CreateIndex(
                name: "IX_servico_material_id_servico",
                table: "servico_material",
                column: "id_servico");

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_id_cliente",
                table: "veiculo",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_veiculo_id_modelo",
                table: "veiculo",
                column: "id_modelo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "atendimento");

            migrationBuilder.DropTable(
                name: "pagamento");

            migrationBuilder.DropTable(
                name: "relatorio");

            migrationBuilder.DropTable(
                name: "servico_material");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "atendente");

            migrationBuilder.DropTable(
                name: "orcamento");

            migrationBuilder.DropTable(
                name: "material");

            migrationBuilder.DropTable(
                name: "servico");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "mecanico");

            migrationBuilder.DropTable(
                name: "veiculo");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "modelo");

            migrationBuilder.DropTable(
                name: "morada");

            migrationBuilder.DropTable(
                name: "marca");
        }
    }
}
