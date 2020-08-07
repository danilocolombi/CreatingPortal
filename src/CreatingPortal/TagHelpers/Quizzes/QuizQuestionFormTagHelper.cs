using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace CreatingPortal.TagHelpers.Quizzes
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("quiz-question-form")]
    public class QuizQuestionFormTagHelper : TagHelper
    {
        public int QuestionNumber { get; set; }

        private readonly char[] ALTERNATIVE_LETTERS = { 'A', 'B', 'C', 'D' };
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "row question-row");

            var htmlQuestionForm = new StringBuilder();

            htmlQuestionForm.Append(CreateQuestionDescriptionHtml());

            foreach (var letter in ALTERNATIVE_LETTERS)
                htmlQuestionForm.Append(CreateAlternativeHtml(letter));

            output.Content.SetHtmlContent(htmlQuestionForm.ToString());
        }

        private string CreateQuestionDescriptionHtml()
        {
            return @$"<div class='col-md-12'>
                            <div class='form-group'>
                            <label for='inputQuestion{QuestionNumber}'>Question {QuestionNumber}</label>
                            <input type='text' class='form-control question-input' id='inputQuestion{QuestionNumber}'>
                        </div>
                    </div>";
        }

        private string CreateAlternativeHtml(char letter)
        {
            return @$"<div class='col-md-6'>
                            <div class='form-group'>
                            <label for='inputQuestion{QuestionNumber}Alternative{letter}'>Alternative {letter}</label>
                            <input type='text' class='form-control' id='inputQuestion{QuestionNumber}Alternative{letter}'>
                        </div>
                    </div>";
        }
    }
}
