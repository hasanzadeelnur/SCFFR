#pragma checksum "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6bff48fc52e3ef3b6950e95083f47d1706adedd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6bff48fc52e3ef3b6950e95083f47d1706adedd", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d2ae4e1f9f96dd3c35f47851c3c0119ed7f1b0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TCYDMWebApp.DTO.OurServicesDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mainlayout/img/support-center-folyo-foreks.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mainlayout/img/support-center-folyo-foreks.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
 if (Model.Count == 0)
{
    return;
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-4 col-md-12 services-center\">\r\n");
#nullable restore
#line 12 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
          var count = Model.Count / 3; 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"info-ul\">\r\n");
#nullable restore
#line 14 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
             for (int i = 0; i < count + 1; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                 if (Model.Count > i)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a style=\"color:white;\"");
            BeginWriteAttribute("href", " href=\"", 402, "\"", 444, 2);
            WriteAttributeValue("", 409, "/home/services/", 409, 15, true);
#nullable restore
#line 18 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 424, Model?[i].ServiceId, 424, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">* ");
#nullable restore
#line 18 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                                                                                        Write(Model?[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 19 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </div>\r\n    <div class=\"col-lg-4 col-md-12 services-center \">\r\n        <ul class=\"info-ul\">\r\n");
#nullable restore
#line 26 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
             for (int i = count + 1; i < (count + 1) * 2; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                 if (Model.Count > i)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a style=\"color:white\"");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 847, 2);
            WriteAttributeValue("", 812, "/home/services/", 812, 15, true);
#nullable restore
#line 30 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 827, Model?[i].ServiceId, 827, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">* ");
#nullable restore
#line 30 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                                                                                       Write(Model?[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 31 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-lg-4 col-md-12 services-center\">\r\n        <ul class=\"info-ul\">\r\n");
#nullable restore
#line 38 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
             for (int i = (count + 1) * 2; i <= count * 3; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                 if (Model.Count > i)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a style=\"color:white;\"");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1251, 2);
            WriteAttributeValue("", 1216, "/home/services/", 1216, 15, true);
#nullable restore
#line 42 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1231, Model?[i].ServiceId, 1231, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">* ");
#nullable restore
#line 42 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                                                                                        Write(Model?[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 43 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div id=\"services-img\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6bff48fc52e3ef3b6950e95083f47d1706adedd12224", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6bff48fc52e3ef3b6950e95083f47d1706adedd12441", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\hasan\Desktop\New folder (2)\SCFFR\TCYDMWebApp\TCYDMWebApp\Views\Shared\Components\Footer\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TCYDMWebApp.DTO.OurServicesDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
