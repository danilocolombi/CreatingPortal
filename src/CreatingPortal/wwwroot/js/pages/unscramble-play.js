$(document).ready(function () {
    $(".sortable").sortable();
    ShowNextQuestion();
});

var _currentQuestion = 0;

function ShowNextQuestion() {

    if (_currentQuestion > 0)
        HideCurrentQuestion();

    _currentQuestion++;

    $("#title-" + _currentQuestion).show();
    $("#question-" + _currentQuestion).show();
}

function HideCurrentQuestion() {

    $("#title-" + _currentQuestion).hide();
    $("#question-" + _currentQuestion).hide();
}
