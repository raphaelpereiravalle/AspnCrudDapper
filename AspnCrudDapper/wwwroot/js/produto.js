// Carregar configurações do datatables
$(document).ready(function () {
    renderizarDesignDataTables('dtProduto', true);
});

// Carregar modal
function modal(id_acao, cod) {
    $.ajax({
        url: criarURL('Produto', controle(id_acao)),
        type: 'GET',
        dataType: 'HTML',
        data: { cod: cod === null ? null : cod },
        success: function (response) {
            if (!($('.modal.in').length)) {
                $('.modal-dialog').css({
                    top: 85,
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

// Manter (incluir e altualizar) produto
function manterProduto(cod) {
    $('#frmProduto').validate({
        errorClass: 'help-block text-right animated fadeInDown',
        errorElement: 'div',
           errorPlacement: function (error, e) {
            jQuery(e).parents('.form-group > div').append(error);
        },
        highlight: function (e) {
            jQuery(e).closest('.error').removeClass('has-error').addClass('has-error');
            jQuery(e).closest('.help-block').remove();
        },
        success: function (e) {
            jQuery(e).closest('.error').removeClass('has-error');
            jQuery(e).closest('.help-block').remove();
        },
        rules: {
            'Nome': {
                required: true,
                minlength: 3,
                maxlength: 100
            },
            'CodProduto': {
                required: true
            },
            'Estoque': {
                required: true
            },
            'Preco': {
                required: true
            }
        },
        messages: {
            'Nome': {
                required: 'Preencha o nome do Produto!',
                minlength: 'Por favor, indique no mínino 3 caracteres.',
                maxlength: 'Por favor, indique não mais do que 100 caracteres.'
            },
            'CodProduto': {
                required: 'Preencha o código!'
            },
            'Estoque': {
                required: 'Preencha o estoque!'
            },
            'Preco': {
                required: 'Preencha o preço!'
            }
        },
        submitHandler: function (form) {

            var formData = new FormData();
            formData.append('ProdutoId', cod);
            formData.append('CodProduto', $('#CodProduto').val());
            formData.append('Nome', $('#Nome').val());
            formData.append('Estoque', $('#Estoque').val());
            formData.append('Preco', $('#Preco').val());

            $.ajax({
                url: criarURL('Produto', cod === null ? 'Add' : 'Edit'),
                type: cod === null ? 'POST' : 'PUT',
                dataType: 'JSON',
                data: formData,
                async: true,
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response.success) {
                        atualizarDesignDataTables('Produto', 'ListarProduto', 'idGridProduto', 'dtProduto', 0, 'modal-produto', null);
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

// Excluir produto
function excluirProduto(cod) {
    $.ajax({
        url: criarURL('Produto', 'Delete'),
        type: 'DELETE',
        dataType: 'JSON',
        data: { cod: cod },
        async: true,
        contentType: false,
        processData: false,
        cache: false,
        success: function (response) {
            if (response.success) {
                atualizarDesignDataTables('Produto', 'ListarProduto', 'idGridProduto', 'dtProduto', 0, 'modal-produto', null);
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

