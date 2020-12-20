using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers.Base
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("save-button")]
    public class SaveButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-12");
            output.Content.SetHtmlContent("<button type='button' class='btn btn-primary save-button'>Save</button>");
        }
    }
}
