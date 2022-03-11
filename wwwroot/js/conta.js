$(document).ready(function () {

    //Obter os dados do formulario
    function ObterDadosFormulario() {
        var conta = new Object();
        conta.Nome = $("#Nome").val();
        conta.QtdParcela = $("#QtdParcelas").val();
        conta.Valor = $("#Valor").val();
        conta.DataVencimento = $("#Vencimento").val();

        return conta;
    }

    //fim

    //Ao clicar no Botao cadastrar, enviar os dados da tela para a controller realizar o cadastro
    $("#Cadastrar").on("click", function () {
        var dadosFormulario = ObterDadosFormulario();

        //Enviar para cadastro
        $.ajax({
            type: "POST", //Metodo de envio -> POST para enviar algo e GET para obter algo
            url: "../Conta/CadastrarFatura", //Endereço para onde enviaremos os dados ou obteremos algo
            data: dadosFormulario, //Variavel dos dados que queremos enviar, quando for GET não precisa
            success: function (resulto) {
                //codifivamos aqui o que precisa ser feito após conclusão da requisição caso de sucesso
                console.log("Deu tudo certo");
            },
            error: function (erro) {
                //codifivamos aqui o que precisa ser feito após conclusão da requisição caso de erro
                console.log("Deu tudo errado");
            }
        });
        //fim cadastro

    });
    //Fim ação do botão cadastrar
})