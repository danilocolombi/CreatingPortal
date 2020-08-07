using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers.Pickers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("picker-item-input")]
    public class PickerItemInputTagHelper : TagHelper
    {
        public int Position { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-6");
            output.Content.SetHtmlContent(@$"<div class='form-group'>
                                            <label for='inputItem{Position}'>Item {Position}</label>
                                            <input type='text' class='form-control picker-item-input' id='inputItem{Position}'>
                                            </div>");
        }
    }
}
