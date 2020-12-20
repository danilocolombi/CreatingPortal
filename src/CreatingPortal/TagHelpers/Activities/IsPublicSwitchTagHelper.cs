using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("is-public-switch")]
    public class IsPublicSwitchTagHelper : TagHelper
    {
        public bool Value { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var htmlChecked = Value ? "checked" : string.Empty;

            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-4");
            output.Content.SetHtmlContent($@"<div class='form-group'>
                                            <div class='custom-control custom-switch' style='margin-top:35px;'>
                                            <input type='checkbox' class='custom-control-input' id='IsPublicSwitch' {htmlChecked}>
                                            <label class='custom-control-label' for='IsPublicSwitch' >Other people can see this activity</label>
                                            </div>
                                            </div>");
        }
    }
}
