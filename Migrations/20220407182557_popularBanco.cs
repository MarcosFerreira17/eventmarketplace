using Microsoft.EntityFrameworkCore.Migrations;

namespace EventMarketplace.Migrations
{
    public partial class popularBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "QuantidadeIngresso",
                table: "Vendas",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.Sql("INSERT INTO CasaDeShows(Id, Nome, Endereco) VALUES('1','LaCasa', 'Al. Solitude 33, Barueri, SP, 06455-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Id, Nome, Endereco) VALUES('2','Music venue', 'Av. Lindóméia 3456, Barueri, SP, 34324-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Id, Nome, Endereco) VALUES('3','Leal Santos', 'R. Inventando sem Criatividade 331, Barueri, SP, 43242-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Id, Nome, Endereco) VALUES('4','Bautizo Lorenita', 'R. Araguaia 454, Barueri, SP, 32344-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Id, Nome, Endereco) VALUES('5','Casa Petra', 'R. Sebastião Branco 200, Barueri, SP, 45345-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Id, Nome, Endereco) VALUES('6','Mango Eventos', 'R. São bento do Carui 146, Barueri, SP, 65666-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Id, Nome, Endereco) VALUES('7','Pancadão do Melão', 'Av. Tiradentes 323, Barueri, SP, 43433-550')");

            migrationBuilder.Sql("INSERT INTO Eventos(Id, Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('1','Show do LinkinPark', '01.jpg', '2022-12-20 12:30:00', 200.00, 1000, 1, '2')");
            migrationBuilder.Sql("INSERT INTO Eventos(Id, Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('2','Show do Beatles', '02.jpg', '2022-05-14 19:50:00', '300.00', 1200, 2 ,'2')");
            migrationBuilder.Sql("INSERT INTO Eventos(Id, Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('3','Show do Foo Fighters', '03.jpg', '2022-04-12 21:00:00', '400.00', 1300, 3, '2')");
            migrationBuilder.Sql("INSERT INTO Eventos(Id, Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('4','Show do Funk Aleatório', '04.jpg', '2023-03-23 22:10:00', '500.00', 900, 4, '1')");
            migrationBuilder.Sql("INSERT INTO Eventos(Id, Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('5','Show do Zéca Pagordinho', '05.jpg', '2022-02-25 22:00:00', '600.00', 1100, 5,'0')");
            migrationBuilder.Sql("INSERT INTO Eventos(Id, Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('6','Show Electro Day', '06.jpg', '2023-09-10 17:20:00', '700.00', 1000, 6,'4')");
            migrationBuilder.Sql("INSERT INTO Eventos(Id, Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('7','Show do aleatório', '07.jpg', '2022-11-11 12:50:00', '800.00', 1500, 2,'5')");

            migrationBuilder.Sql("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES(1, 'root@gft.com', 'ROOT@GFT.COM', 'root@gft.com', 'ROOT@GFT.COM', 1, 'AQAAAAEAACcQAAAAEDKKGwIr3/sZNA+TZYwi+tJZsJNjbChDOBLh8GQk5c+75qNr5WWvksnDH1CNSlsTVg==', 'KQAJSBHXX4526X3BH4QCXMYYU5EVS45R', '423900e1-b412-4b55-ba31-9ae68b09c2a4', NULL, 0, 0, NULL, 1, 0)");
            migrationBuilder.Sql("INSERT INTO AspNetUserClaims(Id, UserId, ClaimType, ClaimValue) VALUES(1, '1', 'Admin', 'root')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "QuantidadeIngresso",
                table: "Vendas",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
