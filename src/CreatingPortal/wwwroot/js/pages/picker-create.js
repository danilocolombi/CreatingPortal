const NUMBER_OF_ITEMS_IN_A_LINE = 2;
const MAX_NUMBER_OF_ITEMS = 20;

$(".add-button").click(function () {

    AddQuestion();
});

function AddQuestion() {

    var numberOfItemsElements = $('.picker-item-input').length;

    if (numberOfItemsElements >= MAX_NUMBER_OF_ITEMS) {

        Swal.fire(
            "Sorry!",
            "The maximum number of itens is:  " + MAX_NUMBER_OF_ITEMS,
            "warning"
        )

        return;
    }

    var html = CreateQuestionHtml(numberOfItemsElements);
    $(".picker-itens").append(html);
}

function CreateQuestionHtml(numberOfExistentItens) {

    var htmlNewItens = '';

    for (var i = 0; i < NUMBER_OF_ITEMS_IN_A_LINE; i++) {

        numberOfExistentItens++;

        htmlNewItens += '<div class="col-md-6">\
            <div class="form-group">\
            <label for="inputItem' + numberOfExistentItens + '">Item ' + numberOfExistentItens + '</label>\
            <input type="text" class="form-control picker-item-input" id="inputItem' + numberOfExistentItens + '">\
            </div>\
            </div>';
    }

    return htmlNewItens;
}