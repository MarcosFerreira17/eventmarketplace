/* Variáveis */
var enderecoEvento = "https://localhost:5001/Evento/Evento/";
var enderecoVenda = "https://localhost:5001/Venda/";
var evento;
var __totalVenda__;

/* Inicio */
$("#totalVenda").html(__totalVenda__);

function preencherFormulario(dadosEvento){
    $("#nomeEvento").val(dadosEvento.nome);
    $("#nomeCasaDeShow").val(dadosEvento.casaDeShow.nome);
    $("#dataHorario").val(dadosEvento.data);
    $("#qtdIngressosDisponiveis").val(dadosEvento.ingresso);
    $("#valorDoIngresso").val(dadosEvento.valorDoTicket.toFixed(2));
    $("#qtdIngressoCompra").val(1);
    
}


$("#confirmaIngresso").click(function(event){
    event.preventDefault();

    var qtd = $("#qtdIngressoCompra").val();
    if(qtd == 0) {
        alert("Você deve inserir uma quantidade de ingressos maior que 0");
    }
    __totalVenda__ = evento.valorDoTicket * qtd;
    $("#totalVenda").val(__totalVenda__.toFixed(2));
})

/* AJAX */
$("#pesquisar").click(function() {
    var codEvento = $("#codEvento").val();
    var enderecoTemporario = enderecoEvento + codEvento;
    $.post(enderecoTemporario, function(dados, status){
        evento = dados;
        console.log(evento);
        preencherFormulario(evento);

    }).fail(function(){
        alert("Evento Inválido, confirme o id do evento e tente novamente.");
    });
});