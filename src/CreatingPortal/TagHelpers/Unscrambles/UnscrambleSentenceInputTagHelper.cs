using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("unscramble-sentence-input")]
    public class UnscrambleSentenceInputTagHelper : TagHelper
    {
        public int Position { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-6");
            output.Content.SetHtmlContent(@$"<div class='form-group'>
                                            <label for='inputSentence{Position}'>Sentence {Position}</label>
                                            <input type='text' class='form-control unscramble-sentence-input' id='inputSentence{Position}'>
                                            </div>");
        }
    }
}
