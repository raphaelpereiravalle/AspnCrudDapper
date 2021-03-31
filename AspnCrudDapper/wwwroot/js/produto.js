﻿// Carrega o modal
//$('#btnCadastroProduto').click(function () {
//    $.ajax({
//        url: criarURL('Produto', 'ManderProduto'),
//        type: 'GET',
//        dataType: 'HTML',
//        success: function (response) {
//            if (!($('.modal.in').length)) {
//                $('.modal-dialog').css({
//                    top: 60,
//                    left: 0
//                });
//            }
//            $('#modalProduto').html('');
//            $('#modalProduto').html(response);
//            $('#modal-produto').modal('show');
//        },
//        error: function (e) {
//            console.log(e)
//        }
//    })
//});

function controle(acao) {
    if (acao == 0) {
        'Add'
    } else if (acao == 1) {
        'Edit'
    } else {
        'Delete'
    }
}

function metodo(acao) {
    $.ajax({
        url: criarURL(controller(acao), 'ManderProduto'),
        type: 'GET',
        dataType: 'HTML',
        success: function (response) {
            if (!($('.modal.in').length)) {
                $('.modal-dialog').css({
                    top: 60,
                    left: 0
                });
            }
            $('#modalProduto').html('');
            $('#modalProduto').html(response);
            $('#modal-produto').modal('show');
        },
        error: function (e) {
            console.log(e)
        }
    })
}

function manterProduto(cod) {
    $("#frmProduto").validate({
        errorClass: 'help-block text-right animated fadeInDown',
        errorElement: 'div',
           errorPlacement: function (error, e) {
            jQuery(e).parents('.form-group > div').append(error);
        },
        highlight: function (e) {
            jQuery(e).closest(".error").removeClass('has-error').addClass('has-error');
            jQuery(e).closest('.help-block').remove();
        },
        success: function (e) {
            jQuery(e).closest('.error').removeClass('has-error');
            jQuery(e).closest('.help-block').remove();
        },
        rules: {
            "Nome": {
                required: true,
                minlength: 3,
                maxlength: 100
            },
            "Estoque": {
                required: true
            },
            "Preco": {
                required: true
            }
        },
        messages: {
            "Nome": {
                required: "Preencha o nome do Produto!",
                minlength: "Por favor, indique no mínino 3 caracteres.",
                maxlength: "Por favor, indique não mais do que 100 caracteres."
            },
            "Estoque": {
                required: "Preencha o estoque!"
            },
            "Preco": {
                required: "Preencha o preço!"
            }
        },
        submitHandler: function (form) {

            var formData = new FormData();
            formData.append("ProdutoId", cod);
            formData.append("Nome", $("#Nome").val());
            formData.append("Estoque", $("#Estoque").val());
            formData.append("Preco", $("#Preco").val());

            $.ajax({
                url: criarURL("Produto", cod === null ? "Add" : "Edit"),
                type: cod === null ? "POST" : "PUT",
                dataType: 'JSON',
                data: formData,
               // async: true,
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response.success) {
                        //atualizarDesignDataTables("Cliente", "GridCliente", "idGridCliente", "dtCliente", 0, "modal-cliente", null);
                        notificacao('success', 'Sucesso', response.message);
                    } else {
                        notificacao('danger', 'Erro', response.message);
                    }
                },
                error: function (e) {
                    console.log(e);
                }
            });
        }
    });
}

