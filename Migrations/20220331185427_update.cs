using Microsoft.EntityFrameworkCore.Migrations;

namespace EventMarketplace.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Nome, Endereco) VALUES('LaCasa', 'Al. Solitude 33, Barueri, SP, 06455-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Nome, Endereco) VALUES('Music venue', 'Av. Lindóméia 3456, Barueri, SP, 34324-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Nome, Endereco) VALUES('Leal Santos', 'R. Inventando sem Criatividade 331, Barueri, SP, 43242-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Nome, Endereco) VALUES('Bautizo Lorenita', 'R. Araguaia 454, Barueri, SP, 32344-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Nome, Endereco) VALUES('Casa Petra', 'R. Sebastião Branco 200, Barueri, SP, 45345-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Nome, Endereco) VALUES('Mango Eventos', 'R. São bento do Carui 146, Barueri, SP, 65666-000')");
            migrationBuilder.Sql("INSERT INTO CasaDeShows(Nome, Endereco) VALUES('Pancadão do Melão', 'Av. Tiradentes 323, Barueri, SP, 43433-550')");

            migrationBuilder.Sql("INSERT INTO Eventos(Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('Cover LinkinPark', '01.jpg', '2022-12-17 12:00:00', 200.00, 1000, 1, '2')");
            migrationBuilder.Sql("INSERT INTO Eventos(Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('Cover Beatles', '02.jpg', '2022-05-17 12:00:00', '200.00', 1200, 2 ,'2')");
            migrationBuilder.Sql("INSERT INTO Eventos(Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('Foo Fighters', '03.jpg', '2022-04-17 12:00:00', '200.00', 1300, 3, '3')");
            migrationBuilder.Sql("INSERT INTO Eventos(Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('Funk Aleatório', '04.jpg', '2022-03-17 12:00:00', '200.00', 900, 4, '4')");
            migrationBuilder.Sql("INSERT INTO Eventos(Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('Zéca Pagordinho', '05.jpg', '2022-02-17 12:00:00', '200.00', 1100, 5,'0')");
            migrationBuilder.Sql("INSERT INTO Eventos(Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('Eletro Day', '06.jpg', '2022-09-17 12:00:00', '200.00', 1000, 6,'6')");
            migrationBuilder.Sql("INSERT INTO Eventos(Nome, Imagem, Data, ValorDoTicket, Ingresso, CasaDeShowId, Genero) VALUES('Só mais um aleatório', '07.jpg', '2022-11-17 12:00:00', '200.00', 1500, 2,'5')");


            migrationBuilder.Sql("INSERT INTO Vendas(Data, EventoId, ValorDaVenda, QuantidadeIngresso, Status) VALUES('2022-02-17 12:00:00', 1, 200.00, 1, true)");
            migrationBuilder.Sql("INSERT INTO Vendas(Data, EventoId, ValorDaVenda, QuantidadeIngresso, Status) VALUES('2022-05-17 12:00:00', 2, 200.00, 1, true)");
            migrationBuilder.Sql("INSERT INTO Vendas(Data, EventoId, ValorDaVenda, QuantidadeIngresso, Status) VALUES('2022-11-17 12:00:00', 3, 200.00, 1, true)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
