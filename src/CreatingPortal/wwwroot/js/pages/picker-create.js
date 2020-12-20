const NUMBER_OF_ITEMS_IN_A_LINE = 2;
const MAX_NUMBER_OF_ITEMS = 20;

$(".add-button").click(function () {

    AddTopic();
});

$(".save-button").click(function () {

    Create();
});


function AddTopic() {

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

function Create() {

    var picker = CreatePickerObject();

    if (!ValidatePicker(picker))
        return;

    $.ajax({
        url: "/Picker/Create",
        type: "POST",
        data: JSON.stringify(picker),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response.error) {
                Swal.fire("Ops!", "There was an error while creating your activity. Details: " + response.message, "error");
            }
            else {
                Swal.fire({
                    title: "Good job!", text: "Your unscramble was successfully created", icon: "success"
                }).then(okay => {
                    window.location.href = "/MyActivities";
                });
            }
        }
    });
}

function CreatePickerObject() {

    var isPublicElement = $("#IsPublicSwitch");

    var picker = {
        "UserId": 1,
        "Title": $("#inputTitle").val(),
        "IsPublic": isPublicElement[0].checked,
        "Topics": CreateTopicsObject()
    }

    return picker;
}

function CreateTopicsObject() {

    var topics = [];

    $('.picker-item-input').each(function () {

        var idInput = $(this).attr('id');

        topics.push({
            "Description": $('#' + idInput).val(),
        });
    });

    return topics;
}

function ValidatePicker(picker) {

    if (picker.Title === null || picker.Title === undefined || picker.Title === "") {
        Swal.fire("Sorry!", "Invalid Title", "warning");
        return false;
    }

    return true;
}
