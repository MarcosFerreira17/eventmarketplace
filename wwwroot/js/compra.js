/* Variáveis */
var enderecoEvento = "https://localhost:5001/Evento/Evento/";
var enderecoVenda = "https://localhost:5001/Venda/GerarVenda";
var evento;
var __totalVenda__;
var compra = [];
var _venda;

/* Inicio */

function atualizarTotal()
{
    $("#totalVenda").html(__totalVenda__); 
}

function preencherModal(dadosEvento, q){

    var eventoTemp = {}    
    Object.assign(eventoTemp, evento);

    _venda = {evento: eventoTemp, quantidadeIngresso: q, valorDaVenda: __totalVenda__};

    $("#nomeEvento").val(dadosEvento.nome);
    $("#nomeCasaDeShow").val(dadosEvento.casaDeShow.nome);
    $("#dataHorario").val(dadosEvento.data);
    $("#qtdIngressosDisponiveis").val(dadosEvento.ingresso);
    $("#valorDoIngresso").val(dadosEvento.valorDoTicket.toFixed(2));
    $("#qtdIngressoCompra").val(1);
    $("#totalVenda").val(__totalVenda__);
    atualizarTotal();
}

function zerarModal(){
    $("#nomeEvento").val("");
    $("#nomeCasaDeShow").val("");
    $("#dataHorario").val("");
    $("#qtdIngressosDisponiveis").val("");
    $("#valorDoIngresso").val("");
    $("#qtdIngressoCompra").val("");
    $("#totalVenda").val("");
}

$("#confirmaIngresso").click(function(event){

    event.preventDefault();
    var eventoParaModal = evento;

    var qtd = $("#qtdIngressoCompra").val();
    if(qtd == 0) {
        alert("Você deve inserir uma quantidade de ingressos maior que 0");
    }
    __totalVenda__ = evento.valorDoTicket * qtd;
    $("#totalVenda").val(__totalVenda__.toFixed(2));
    
    preencherModal(eventoParaModal, qtd);
    
    compra.push(_venda);
    
});


/* AJAX */
$("#pesquisar").click(function() {
    var codEvento = $("#codEvento").val();
    var enderecoTemporario = enderecoEvento + codEvento;
    $.post(enderecoTemporario, function(dados){
        evento = dados;
        preencherModal(evento);

    }).fail(function(){
        alert("Evento Inválido, confirme o id do evento e tente novamente.");
        document.location.reload(true);
    });
});

$("#finalizarVendaBTN").click(function(){
    if (__totalVenda__ <= 0 || __totalVenda__ == null) {
        alert("Compra inválida, nenhum ingresso adicionado.");
        return; 
    };

    compra.forEach(elemento => {
        elemento.evento = elemento.evento.id;
    });

    $.ajax({
        type: "POST",
        url: enderecoVenda,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(_venda),
        success: function(data){
            console.log("Dados enviados com sucesso.");
            console.log(data);
        }
    });

    alert("Infelizmente este método não esta funcionando, estamos trabalhando nisto");
});