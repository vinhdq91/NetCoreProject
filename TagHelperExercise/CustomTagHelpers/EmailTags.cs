using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperExercise.CustomTagHelpers
{
    public class EmailTags : TagHelper
    {
        public string Email { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", $"mailto: {Email}");
            if (output.Attributes.ContainsName("class"))
            {
                var classes = output.Attributes["class"].Value.ToString();
                output.Attributes.SetAttribute("class", classes += " btn btn-success");
            }
            else
            {
                output.Attributes.SetAttribute("class", "btn btn-success");
            }
        }
    }
}
