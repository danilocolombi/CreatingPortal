using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("title-input")]
    public class TitleInputTagHelper : TagHelper
    {
        public string value { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-8");
            output.Content.SetHtmlContent(@"<div class='form-group'>
                                            <label for='inputTitle'>Title</label>
                                            <input type='text' class='form-control' id='inputTitle' placeholder='Enter Title'>
                                            </div>");
        }
    }
}
