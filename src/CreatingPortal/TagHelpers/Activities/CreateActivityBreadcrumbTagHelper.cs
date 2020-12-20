using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("create-activity-breadcrumb")]
    public class CreateActivityBreadcrumbTagHelper : TagHelper
    {
        public string ActivityName { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-5");
            output.Content.SetHtmlContent(@$"<ol class='breadcrumb'>
                                            <li class='breadcrumb-item'><a href='/home'>Home</a></li>
                                            <li class='breadcrumb-item'><a href='/my-activities/create'>Create Templates</a></li>
                                            <li class='breadcrumb-item active'>Create {ActivityName}</li>
                                            </ol>");
        }
    }
}
