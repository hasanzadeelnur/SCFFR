#pragma checksum "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ef2092d177b2443136ce2f24ea5b747ebe6643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserLogin), @"mvc.1.0.view", @"/Views/Users/UserLogin.cshtml")]
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
#nullable restore
#line 7 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
using TCYDMWebApp.Repositories.Lang;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ef2092d177b2443136ce2f24ea5b747ebe6643", @"/Views/Users/UserLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5866596ec13e4519aef38c38ddae7f71c770eb70", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_UserLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCYDMWebApp.ViewModels.UserLoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mainlayout/logo/user-line.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("password-field"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forget"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ForgotPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-transform:capitalize"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserLoginData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
  
    TempData["Title"] = "UserLogin";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("<div class=\"sign-up\" style=\"        background-color: #dc1018;\">\n    <div class=\"row\">\n        <div class=\"col-lg-12 col-md-12 d-flex justify-content-center\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1ef2092d177b2443136ce2f24ea5b747ebe66439809", async() => {
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
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-lg-4\"></div>\n        <div class=\"col-lg-4\">\n            <div class=\"first-a-tag mr-5\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 631, "\"", 638, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn-login\" style=\"text-transform:capitalize\">");
#nullable restore
#line 22 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                                                       Write(SharedLocalizer["Sign in"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                <!-- <hr class=\"first-line\"> -->\n\n            </div>\n            <div class=\"second-a-tag ml-5\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 852, "\"", 859, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn-register\" style=\"text-transform:capitalize\">");
#nullable restore
#line 27 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                                                          Write(SharedLocalizer["Registration"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                <!-- <hr class=\"second-line\"> -->\n");
#nullable restore
#line 29 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                 if (TempData["ServerResponseError"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"p-red-box servererror\" style=\"position:absolute;left:5%;top:40%;z-index:2;display:none;\">\n                        <p style=\"color:white\">");
#nullable restore
#line 32 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                          Write(TempData["ServerResponseError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n                    </div>\n");
#nullable restore
#line 35 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n        <div class=\"col-lg-4\"></div>\n    </div>\n");
#nullable restore
#line 40 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
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
#line 46 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                                                      Write(SharedLocalizer["Confirmation needed"]);

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
#line 52 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                   Write(TempData["SuccessResponse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"modal-footer\">\n                       \n                        <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\" >");
#nullable restore
#line 56 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                                                                       Write(SharedLocalizer["Understood"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 61 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <div class=""container"">
        <!-- REGISTER FORM -->

        <div class=""row d-none"" id=""register-form"">
            <div class=""col-lg-4"">
            </div>
            <div class=""col-lg-8"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        ");
#nullable restore
#line 74 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                   Write(await Component.InvokeAsync("Registration"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n            <div class=\"col-lg-2\">\n            </div>\n        </div>\n        <!-- REGISTER FORM -->\n        <!-- LOGIN FORM -->\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1ef2092d177b2443136ce2f24ea5b747ebe664316620", async() => {
                WriteLiteral("\n            <div class=\"row mt-2\" id=\"login-form\">\n                <div class=\"col-lg-4\">\n\n                </div>\n                <div class=\"col-lg-4\">\n                    <div class=\"col-lg-12 col-md-12\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1ef2092d177b2443136ce2f24ea5b747ebe664317124", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 90 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Identification);

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
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1ef2092d177b2443136ce2f24ea5b747ebe664319040", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 91 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Identification);

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
                WriteLiteral("\n                    </div>\n                    <div class=\"col-lg-12 col-md-12\">\n\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1ef2092d177b2443136ce2f24ea5b747ebe664320815", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 95 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

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
                WriteLiteral("\n                        <span class=\"fa fa-fw fa-eye field-icon toggle-password\"></span>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1ef2092d177b2443136ce2f24ea5b747ebe664322904", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 97 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
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
                WriteLiteral("\n                    </div>\n\n                    <div class=\"col-lg-12 col-md-12\">\n                        <button type=\"submit\" class=\"button-sign\" style=\"text-transform:capitalize\">");
#nullable restore
#line 101 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                                                                               Write(SharedLocalizer["Login"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</button>
                    </div>
                    <div class=""col-lg-12 col-md-12"">
                        <div class=""row"">
                            <div class=""col-5"">
                                <label class=""form-check-label"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1ef2092d177b2443136ce2f24ea5b747ebe664325381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 107 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberMe);

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
                WriteLiteral(" ");
#nullable restore
#line 107 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                                              Write(Html.DisplayNameFor(model => model.RememberMe));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </label>\n                            </div>\n                            <div class=\"col-7 text-right\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1ef2092d177b2443136ce2f24ea5b747ebe664327376", async() => {
#nullable restore
#line 111 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
                                                                                                           Write(SharedLocalizer["Forgot Password"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ?");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                            </div>\n                        </div>\n                    </div>\n                </div>\n                <div class=\"col-lg-4\">\n\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <!-- LOGIN FORM -->\n</div>\n\n\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 130 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
     if (TempData["ServerResponseError"] != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\n            $(\".servererror\").fadeIn(function () {\n                setTimeout(function () {\n                    $(\".servererror\").fadeOut();\n                }, 2000);\n            })\n        </script>\n");
#nullable restore
#line 139 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
     if (TempData["SuccessResponse"] is object)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\n            $(\"#exampleModalCenter\").modal(\"show\");\n        </script>\n");
#nullable restore
#line 146 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $(document).ready(function () {
            const togglePassword = document.querySelector('.toggle-password');
            const password = document.querySelector('#password-field');
            togglePassword.addEventListener('click', function (e) {
                // toggle the type attribute
                const type = password.getAttribute('type') === 'password' ? 'text' : 'password';
                password.setAttribute('type', type);
                // toggle the eye slash icon
                this.classList.toggle('fa-eye-slash');
            });


        })
    </script>
");
#nullable restore
#line 162 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Users\UserLogin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCYDMWebApp.ViewModels.UserLoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
