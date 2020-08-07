const MAX_NUMBER_OF_QUESTIONS = 20;
const ALTERNATIVE_LETTERS = ["A", "B", "C", "D"];

$(".add-button").click(function () {

    AddQuestion();
});

function AddQuestion() {

    var numberOfQuestionElements = $('.question-input').length;

    if (numberOfQuestionElements >= MAX_NUMBER_OF_QUESTIONS) {

        Swal.fire(
            "Sorry!",
            "The maximum number of questions is:  " + MAX_NUMBER_OF_QUESTIONS,
            "warning"
        )

        return;
    }

    var nextQuestionNumber = numberOfQuestionElements + 1;

    var html = CreateQuestionHtml(nextQuestionNumber);
    $(".questions-container").append(html);
}

function CreateQuestionHtml(questionNumber) {

    var newQuestionHtml = '<div class="row question-row">'; 

    newQuestionHtml += CreateQuestionDescriptionHtml(questionNumber);

    for (var i = 0; i < ALTERNATIVE_LETTERS.length; i++)
        newQuestionHtml += CreateAlternativeHtml(questionNumber, ALTERNATIVE_LETTERS[i]);

    return newQuestionHtml + "</div>";
}

function CreateQuestionDescriptionHtml(questionNumber) {

    var inputId = 'inputQuestion' + questionNumber;

    return '<div class="col-md-12">\
            <div class="form-group">\
            <label for="' + inputId + '">Question ' + questionNumber + '</label>\
            <input type="text" class="form-control question-input" id="' + inputId + '">\
            </div>\
            </div>';
}

function CreateAlternativeHtml(questionNumber, letter) {

    var inputId = 'inputQuestion' + questionNumber + 'Alternative' + letter;

    return '<div class="col-md-6">\
            <div class="form-group">\
            <label for="' + inputId + '">Alternative ' + letter + '</label>\
            <input type="text" class="form-control" id="' + inputId + '">\
             </div>\
            </div>';
}