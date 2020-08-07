using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers.Activities
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("add-button")]
    public class AddButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-12 text-right text-white");
            output.Content.SetHtmlContent(@"<a class='btn btn-primary btn-sm add-button'><i class='fas fa-plus'></i></a>");
        }
    }
}
