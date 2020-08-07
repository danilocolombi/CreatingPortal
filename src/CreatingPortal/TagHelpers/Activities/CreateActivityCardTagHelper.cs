using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CreatingPortal.TagHelpers.Activities
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("create-activity-card")]
    public class CreateActivityCardTagHelper : TagHelper
    {
        public string ActivityName { get; set; }
        public string Description { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "col-md-3");

            var activityNameWithoutSpaces = ActivityName.Replace(" ", "");

            output.Content.SetHtmlContent(@$"<div class='card border-primary mb-3' style='max-width: 20rem; '>
                                            <div class='card-header'>{ActivityName}</div>
                                            <div class='card-body'>
                                            <div style='height:70px !important'>
                                            <p class='card-text'>{Description}</p>
                                            </div>
                                            <a type = 'button' class='btn btn-primary' href='/{activityNameWithoutSpaces}/Create'>Create</a>
                                            </div>
                                            </div>");
        }
    }
}
