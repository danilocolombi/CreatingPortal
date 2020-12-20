const NUMBER_OF_INPUT_UNSCRAMBLE_IN_A_LINE = 2;
const MAX_NUMBER_OF_SENTENCES = 20;

$(".add-button").click(function () {

    AddQuestion();
});

function AddQuestion() {

    var elementsSentence = $('.unscramble-sentence-input').length;

    if (elementsSentence >= MAX_NUMBER_OF_SENTENCES) {

        Swal.fire(
            "Sorry!",
            "The maximum number of senteces is:  " + MAX_NUMBER_OF_SENTENCES,
            "warning"
        )

        return;
    }

    var html = CreateHtmlLineInputsUnscrambleSentece(elementsSentence);
    $(".unscramble-senteces").append(html);
}

function CreateHtmlLineInputsUnscrambleSentece(numberOfExistentSenteces) {

    var htmlNewSentences = '';

    for (var i = 0; i < NUMBER_OF_INPUT_UNSCRAMBLE_IN_A_LINE; i++) {

        numberOfExistentSenteces++;

        htmlNewSentences += '<div class="col-md-6">\
            <div class="form-group">\
            <label for="inputSentence' + numberOfExistentSenteces + '">Sentence ' + numberOfExistentSenteces + '</label>\
            <input type="text" class="form-control unscramble-sentence-input" id="inputSentence' + numberOfExistentSenteces + '">\
            </div>\
            </div>';
    }

    return htmlNewSentences;
}

function CreateObjectUnscramble() {

    var isPublicElement = $("#IsPublicSwitch");

    var unscramble = {
        "UserId": 1,
        "Title": $("#inputTitle").val(),
        "IsPublic": isPublicElement[0].checked,
        "Exercises": CreateQuestionsObject()
    }

    return unscramble;
}

function CreateQuestionsObject() {

    var sentences = [];
    var position = 1;

    $('.unscramble-sentence-input').each(function () {

        var idInput = $(this).attr('id');

        sentences.push({
            "Description": $('#' + idInput).val(),
            "Position": position
        });

        position++;
    });

    return sentences;
}

function ValidateUnscramble(unscramble) {

    if (unscramble.Title === null || unscramble.Title === undefined || unscramble.Title === "") {
        Swal.fire("Sorry!", "Invalid Title", "warning");
        return false;
    }

    return true;
}
