using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers.TicTacToes
{
    [HtmlTargetElement("tic-tac-toe-square-input")]
    public class TicTacToeSquareInputTagHelper : TagHelper
    {
        public int Position { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-4");
            output.Content.SetHtmlContent(@$"<div class='form-group'>
                                            <label for='inputSquare{Position}'>Square {Position}</label>
                                            <input type='text' class='form-control tic-tac-toe-square-input' id='inputSquare{Position}'>
                                            </div>");
        }
    }
}
