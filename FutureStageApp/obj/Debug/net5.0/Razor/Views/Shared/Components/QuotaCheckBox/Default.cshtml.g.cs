#pragma checksum "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b45fe2e923f3f0cd7bfa48e5db17ce04ddf3bab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_QuotaCheckBox_Default), @"mvc.1.0.view", @"/Views/Shared/Components/QuotaCheckBox/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\FutureStageApp\FutureStageApp\Views\_ViewImports.cshtml"
using FutureStageApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FutureStageApp\FutureStageApp\Views\_ViewImports.cshtml"
using FutureStageApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FutureStageApp\FutureStageApp\Views\_ViewImports.cshtml"
using FutureStageApp.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45fe2e923f3f0cd7bfa48e5db17ce04ddf3bab0", @"/Views/Shared/Components/QuotaCheckBox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7c94eb2edd2f87ab5864ee44000515973076df", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_QuotaCheckBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FutureStageApp.ViewModels.QuotaCheckBoxVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nTesting\r\n\r\n");
#nullable restore
#line 5 "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml"
     foreach (var temp in Model)
    {
        if (temp.Selected)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml"
       Write(temp.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input checked=\"checked\" name=\"StandardSeatQuota\"");
            BeginWriteAttribute("value", " value=\"", 228, "\"", 247, 1);
#nullable restore
#line 9 "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml"
WriteAttributeValue("", 236, temp.Value, 236, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"> ");
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 10 "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml"
       Write(temp.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input name=\"StandardSeatQuota\"");
            BeginWriteAttribute("value", " value=\"", 427, "\"", 446, 1);
#nullable restore
#line 13 "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml"
WriteAttributeValue("", 435, temp.Value, 435, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"> ");
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 14 "D:\FutureStageApp\FutureStageApp\Views\Shared\Components\QuotaCheckBox\Default.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FutureStageApp.ViewModels.QuotaCheckBoxVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591