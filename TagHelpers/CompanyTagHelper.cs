﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppTagHelper.TagHelpers
{
    [HtmlTargetElement("company")]
    public class CompanyTagHelper : TagHelper
    {
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string preContent = @"
                <div class='panel panel-default' style='padding: 20px'>
                    <div class='panel-heading' style='margin-bottom: 50px;'>
                        <img src='/images/{0}.png' height='20' >
                    </div>
            ";

            string postContent = @"
                </div>
            ";


            output.TagName = "div";
            output.PreContent.SetHtmlContent(
                string.Format(preContent, Name));
            output.PostContent.SetHtmlContent(postContent);

            //context.Items["CompanyName"] = Name;
        }
    }
}
