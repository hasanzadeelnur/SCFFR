#pragma checksum "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56ac92c39ccc1a8c5a24a716ccea816909962f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_ChangePassword), @"mvc.1.0.view", @"/Views/Users/ChangePassword.cshtml")]
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
#line 1 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\_ViewImports.cshtml"
using TCYDMWebApp.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
using TCYDMWebApp.Repositories.Lang;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56ac92c39ccc1a8c5a24a716ccea816909962f5", @"/Views/Users/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d2ae4e1f9f96dd3c35f47851c3c0119ed7f1b0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCYDMWebApp.DTO.ChangePassword>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mainlayout/logo/user-line.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePasswordData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
  
    TempData["Title"] = "UserLogin";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<div class=\"sign-up\" style=\"background: #dc1018;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 col-md-12 d-flex justify-content-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f56ac92c39ccc1a8c5a24a716ccea816909962f58086", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"test\">\r\n        <div class=\"row\">\r\n            <div class=\"col-7 first-a-tag\">\r\n                <a style=\"text-transform:capitalize;color:white\">");
#nullable restore
#line 31 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                                                            Write(SharedLocalizer["Change Password"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 32 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                 if (TempData["ServerResponseError"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"p-red-box servererror\" style=\"position:absolute;left:5%;top:40%;z-index:2;display:none;\">\r\n                        <p style=\"color:white\">");
#nullable restore
#line 35 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                                          Write(TempData["ServerResponseError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
     if (TempData["SuccessResponse"] is object)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLongTitle"">");
#nullable restore
#line 51 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                                                                      Write(SharedLocalizer["Email sended"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
#nullable restore
#line 57 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                   Write(TempData["SuccessResponse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n\r\n                        <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\">");
#nullable restore
#line 61 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                                                                                      Write(SharedLocalizer["Understood"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 66 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"container\">\r\n\r\n        <!-- LOGIN FORM -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f56ac92c39ccc1a8c5a24a716ccea816909962f513432", async() => {
                WriteLiteral("\r\n            <div class=\"row mt-2\" id=\"login-form\">\r\n                <div class=\"col-lg-4\">\r\n\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <div class=\"col-lg-12 col-md-12\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f56ac92c39ccc1a8c5a24a716ccea816909962f513950", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 80 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f56ac92c39ccc1a8c5a24a716ccea816909962f515879", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 81 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-lg-12 col-md-12\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f56ac92c39ccc1a8c5a24a716ccea816909962f517669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 84 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password_Compare);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f56ac92c39ccc1a8c5a24a716ccea816909962f519606", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 85 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password_Compare);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f56ac92c39ccc1a8c5a24a716ccea816909962f521341", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                                    WriteLiteral(TempData["uk"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 87 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.uk);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                    <div class=\"col-lg-12 col-md-12\">\r\n                        <button type=\"submit\" class=\"button-sign\" style=\"text-transform:capitalize\">");
#nullable restore
#line 91 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
                                                                                               Write(SharedLocalizer["Change Password"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <!-- LOGIN FORM -->\r\n</div>\r\n\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
     if (TempData["ServerResponseError"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            $(\".servererror\").fadeIn(function () {\r\n                setTimeout(function () {\r\n                    $(\".servererror\").fadeOut();\r\n                }, 2000);\r\n            })\r\n        </script>\r\n");
#nullable restore
#line 119 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
     if (TempData["SuccessResponse"] is object)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n            $(\"#exampleModalCenter\").modal(\"show\");\r\n        </script>\r\n");
#nullable restore
#line 126 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\Users\hasan\Desktop\New folder (2)\TCYDMPROJ\TCYDMWebApp\TCYDMWebApp\Views\Users\ChangePassword.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCYDMWebApp.DTO.ChangePassword> Html { get; private set; }
    }
}
#pragma warning restore 1591
