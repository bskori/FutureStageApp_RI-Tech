#pragma checksum "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\StandardFees\StandardCreateList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e146f06276bd1c3ea88df397f8ef923266257bbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Schools_Views_StandardFees_StandardCreateList), @"mvc.1.0.view", @"/Areas/Schools/Views/StandardFees/StandardCreateList.cshtml")]
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
#line 2 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\_ViewImports.cshtml"
using FutureStageApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\_ViewImports.cshtml"
using FutureStageApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e146f06276bd1c3ea88df397f8ef923266257bbf", @"/Areas/Schools/Views/StandardFees/StandardCreateList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68a10a4ca716c87b61aef5fcdbdae7cbbdf2491", @"/Areas/Schools/Views/_ViewImports.cshtml")]
    public class Areas_Schools_Views_StandardFees_StandardCreateList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StandardFees>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div id=""PlaceHolderHere""></div>

<table class=""table table-striped table-hover"">
    <tr>
        <th>Select Class</th>
        <th>Select FeeHead</th>
        <th>Enter Fees</th>
        <th>Intake Capacity</th>
        <th></th>
    </tr>
");
#nullable restore
#line 15 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\StandardFees\StandardCreateList.cshtml"
     foreach(var temp in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\StandardFees\StandardCreateList.cshtml"
                   Write(temp.SchoolStandardID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    <td>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 629, "\"", 729, 4);
            WriteAttributeValue("", 639, "showInPopup(\'", 639, 13, true);
#nullable restore
#line 23 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\StandardFees\StandardCreateList.cshtml"
WriteAttributeValue("", 652, Url.Action("Create","StandardFees",null,Context.Request.Scheme), 652, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 716, "\',\'Add", 716, 6, true);
            WriteAttributeValue(" ", 722, "Fees\')", 723, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Add Fees</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\StandardFees\StandardCreateList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StandardFees>> Html { get; private set; }
    }
}
#pragma warning restore 1591
