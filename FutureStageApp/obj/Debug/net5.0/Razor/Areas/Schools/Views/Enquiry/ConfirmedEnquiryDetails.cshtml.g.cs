#pragma checksum "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\Enquiry\ConfirmedEnquiryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63e41f981aa03573ccea448fcc2ef1ed25bb3c13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Schools_Views_Enquiry_ConfirmedEnquiryDetails), @"mvc.1.0.view", @"/Areas/Schools/Views/Enquiry/ConfirmedEnquiryDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63e41f981aa03573ccea448fcc2ef1ed25bb3c13", @"/Areas/Schools/Views/Enquiry/ConfirmedEnquiryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68a10a4ca716c87b61aef5fcdbdae7cbbdf2491", @"/Areas/Schools/Views/_ViewImports.cshtml")]
    public class Areas_Schools_Views_Enquiry_ConfirmedEnquiryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddmissionConfirmation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\Enquiry\ConfirmedEnquiryDetails.cshtml"
  
    ViewData["Title"] = "ConfirmedEnquiryDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h4 class=\"text-center bg-info\" style=\"padding:10px\">Confirmed Enquiry Details</h4>\r\n<br />\r\n<br />\r\n<table class=\"table table-light\">\r\n    <tr>\r\n        <td><h5>Admission Enquiry ID  </h5></td>\r\n        <td>:</td>\r\n        <td>");
#nullable restore
#line 13 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\Enquiry\ConfirmedEnquiryDetails.cshtml"
       Write(Model.AddmissionEnquiryID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td><h5>Enquiry Description</h5></td>\r\n        <td>:</td>\r\n        <td>");
#nullable restore
#line 18 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\Enquiry\ConfirmedEnquiryDetails.cshtml"
       Write(Model.AddmissionEnquiry.EnquiryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><h5>Confirmation Date</h5></td>\r\n        <td>:</td>\r\n        <td>");
#nullable restore
#line 23 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\Enquiry\ConfirmedEnquiryDetails.cshtml"
       Write(Model.ConfirmationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><h5>Remark</h5></td>\r\n        <td>:</td>\r\n        <td>");
#nullable restore
#line 28 "D:\FutureStageApp\FutureStageApp\Areas\Schools\Views\Enquiry\ConfirmedEnquiryDetails.cshtml"
       Write(Model.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddmissionConfirmation> Html { get; private set; }
    }
}
#pragma warning restore 1591
