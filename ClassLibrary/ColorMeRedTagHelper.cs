// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ClassLibrary.TagHelpers
{
    [HtmlTargetElement("*")]
    public class ColorMeRedTagHelper : TagHelper
    {
        public override int Order => 0;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("style", "color: red");
        }
    }
}