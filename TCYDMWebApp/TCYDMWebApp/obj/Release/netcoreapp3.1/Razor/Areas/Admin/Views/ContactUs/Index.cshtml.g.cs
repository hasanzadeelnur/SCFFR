#pragma checksum "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63b5f1b9f39802d70532569e1f9ccd09d0de8202"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
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
#line 1 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using TCYDMWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using TCYDMWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using TCYDMWebApp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63b5f1b9f39802d70532569e1f9ccd09d0de8202", @"/Areas/Admin/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f088e5538d3b41d8dacb81792478a01cf52457b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TCYDMWebApp.DTO.ContactUsAppDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ContactUs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger sweet-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""right_col row"" role=""main"" style=""min-height: 1661px;"">
    <div class=""col-md-12 col-sm-12 "">
        <div class=""x_panel"">
            <div class=""x_title"">
                <h2>Contact Us</h2>
                <ul class=""nav navbar-right panel_toolbox"">
                </ul>
                <div class=""clearfix""></div>
            </div>
            <div class=""x_content"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card-box table-responsive"">

                            <div id=""datatable_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap no-footer"">
                                <div class=""row"">
                                    <div class=""col-sm-12"">
                                        <p>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b5f1b9f39802d70532569e1f9ccd09d0de82026815", async() => {
                WriteLiteral("New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </p>\n                                        <p>");
#nullable restore
#line 26 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                      Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <table id=""demo"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 156px;"">");
#nullable restore
#line 30 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 31 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 32 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 33 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 34 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 35 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.LandLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 36 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 156px;""></th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 41 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\" class=\"odd\">\n                                                        <td>\n                                                            ");
#nullable restore
#line 45 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>\n                                                        <td>\n                                                            ");
#nullable restore
#line 48 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>\n                                                        <td>\n                                                            ");
#nullable restore
#line 51 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>\n                                                        <td>\n                                                            ");
#nullable restore
#line 54 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>\n                                                        <td>\n                                                            ");
#nullable restore
#line 57 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>                                           \n                                                        <td>\n                                                            ");
#nullable restore
#line 60 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.LandLine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>\n                                                        <td>\n                                                            ");
#nullable restore
#line 63 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>\n                                                        <td>\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b5f1b9f39802d70532569e1f9ccd09d0de820218461", async() => {
                WriteLiteral("\n                                                                <i class=\"fas fa-pencil-alt\"></i>\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63b5f1b9f39802d70532569e1f9ccd09d0de820220893", async() => {
                WriteLiteral("\n                                                                <i class=\"fas fa-trash\"></i>\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                        </td>\n                                                    </tr>\n");
#nullable restore
#line 75 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\ContactUs\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("javascript", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".sweet-delete"").click(function (event) {
                event.preventDefault();
                var sweet = $(this);
                swal({
                    title: ""Eminsiniz?"",
                    text: ""Melumatlariniz Silinecek"",
                    icon: ""warning"",
                    buttons: true,
                    dangerMode: true,
                }).then((willDelete) => {
                    if (willDelete) {
                        window.location = $(this).attr('href');
                    } else {
                        swal(""Hata!"");
                    }
                });
            });
        });
        var filtersConfig = {
            // instruct TableFilter location to import ressources from
            base_path: 'https://unpkg.com/tablefilter@latest/dist/tablefilter/',
            col_6: 'select',
            alternate_rows: true,
            rows_counter: true,
            btn_reset: true,
            loader: t");
                WriteLiteral(@"rue,
            mark_active_columns: true,
            highlight_keywords: true,
            no_results_message: true,
            col_types: [
                'string', 'string', 'number',
                'number', 'number', 'number',
                'number', 'number', 'number'
            ],
            extensions: [{
                name: 'sort',
                images_path: 'https://unpkg.com/tablefilter@latest/dist/tablefilter/style/themes/'
            }]
        };

        var tf = new TableFilter('demo', filtersConfig);
        tf.init();
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TCYDMWebApp.DTO.ContactUsAppDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
