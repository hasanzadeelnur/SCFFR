#pragma checksum "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "486159fb8616a80ca00d93e6ad61f93c16b81359"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserInfo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserInfo/Default.cshtml")]
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
#line 1 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486159fb8616a80ca00d93e6ad61f93c16b81359", @"/Views/Shared/Components/UserInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5866596ec13e4519aef38c38ddae7f71c770eb70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCYDMWebApp.DTO.UserDataDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"form-group\">\n    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 216, "\"", 238, 1);
#nullable restore
#line 8 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 224, Model?.Region, 224, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n</div>\n<div class=\"form-group\">\n    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 374, "\"", 397, 1);
#nullable restore
#line 11 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 382, Model?.Country, 382, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n</div>\n<div class=\"form-group\">\n    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 533, "\"", 553, 1);
#nullable restore
#line 14 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 541, Model?.Name, 541, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n</div>\n<div class=\"form-group\">\n    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 689, "\"", 712, 1);
#nullable restore
#line 17 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 697, Model?.Surname, 697, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n</div>\n\n\n<div class=\"row\">\n    <div class=\"col-6\">\n        <div class=\"form-group\">\n            <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 908, "\"", 955, 1);
#nullable restore
#line 24 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 916, Model?.BornYear.ToString("yyyy-mm-dd"), 916, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n        </div>\n    </div>\n    <div class=\"col-6\">\n        <div class=\"form-group\">\n            <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1150, "\"", 1169, 1);
#nullable restore
#line 29 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 1158, Model?.Sex, 1158, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n        </div>\n    </div>\n\n</div>\n<div class=\"form-group\">\n    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1332, "\"", 1352, 1);
#nullable restore
#line 35 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 1340, Model?.TcNo, 1340, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n</div>\n<div class=\"form-group\">\n    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1488, "\"", 1509, 1);
#nullable restore
#line 38 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 1496, Model?.Email, 1496, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n</div>\n<div class=\"form-group\">\n    <input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1645, "\"", 1666, 1);
#nullable restore
#line 41 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\UserInfo\Default.cshtml"
WriteAttributeValue("", 1653, Model?.Phone, 1653, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Data\">\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCYDMWebApp.DTO.UserDataDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
