/**
 * Cadastro de Vendas
 */

var linkApi = "https://localhost:5001/api/"
//var linkApi = "https://localhost:44399/api/"
var listaDeProdutos = [];


$("#btnAddItem").click(function () {

    var idProduto = $("#Produtos option:selected").val();
    var ProdutoText = $("#Produtos option:selected").html();
    var Produtos_Quantidade = $("#Produtos_Quantidade").val();
    var Produtos_Preco = $("#Produtos_Preco").val();


    //Valida se algum produto foi selecionado
    if ($("#Produtos option:selected").index() == 0) {
        alert("Nenhum produto selecionado! Verifique, por favor.");
        return false;
    }
    //Valida se a quantidade foi definida
    if (Produtos_Quantidade == "") {
        alert("Quantidade não definida! Verifique, por favor.");
        return false;
    }

    //Valida se o preço foi definido
    if (Produtos_Preco == "") {
        alert("Preço não definido! Verifique, por favor.");
        return false;
    }

    //Cria um objeto VendaItem
    let vendaItem = {
        ProdutosProdutoId: idProduto,
        Quantidade: Produtos_Quantidade,
        Preco: Produtos_Preco
    };

    //Coloca esse objeto na listaDeProdutos
    listaDeProdutos.push(vendaItem);

    //Cria na tela uma nova TR na tabela com os dados do item.
    $("#tblItensBody").append(`
    <tr>
        <td>${ProdutoText}</td>
        <td>${Produtos_Quantidade}</td>
        <td>${Produtos_Preco}</td>
    </tr>`);

    //Limpa os campos para a inserção de novos..
    limparFormVendaParcialProdutos();
});

/**
 *Envio do formulário de venda 
 */
$("#frmVenda").on("submit", function (event) {
    event.preventDefault();
   // $("#btnFinalizarVenda").attr("disabled", true)

    var idCliente = $("#idCliente option:selected").val();
    var idFuncionario = $("#idFuncionario option:selected").val();

    var venda = {
        ClienteId: idCliente,
        FuncionarioId: idFuncionario,
        VendasItem: listaDeProdutos
    };

    //Validações
    if (venda.idCliente == "") {
        alert("Cliente não definido! Verifique, por favor.");
        $("#btnFinalizarVenda").attr("disabled", false);
        return false;
    }
    if (venda.idFuncionario == "") {
        alert("Funcionário não definido! Verifique, por favor.");
        $("#btnFinalizarVenda").attr("disabled", false);
        return false;
    }
    if (listaDeProdutos.length == 0) {
        alert("Nenhum produto foi adicionado à venda!");
        $("#btnFinalizarVenda").attr("disabled", false);
        return false;
    }

    $.ajax({
        type: "post",
        url: `${linkApi}Venda`,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(venda),
        success: function (dados) {
            alert("Venda realizada com sucesso!")
            limparFormVenda();
        },
        error: function (dados) {
            alert(dados.responseJSON.msg)
        }
    });

    $("#btnEnviarRequisicao").attr("disabled", false)
});

function limparFormVendaParcialProdutos() {
    $('#Produtos').prop("selectedIndex", 0).change();
    $("#Produtos_Quantidade").val("");
    $("#Produtos_Preco").val("");
}

function limparFormVenda() {
    listaDeProdutos = [];
    $('#idCliente').prop("selectedIndex", 0).change();
    $('#idFuncionario').prop("selectedIndex", 0).change();
    $('#Produtos').prop("selectedIndex", 0).change();
    $("#Produtos_Quantidade").val("");
    $("#Produtos_Preco").val("");
    $("#tblItensBody").empty();
}