#pragma checksum "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "616d5fbefdc8622beceaf1e4ee77c2410d73137e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Services_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using TCYDMWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using TCYDMWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\_ViewImports.cshtml"
using TCYDMWebApp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"616d5fbefdc8622beceaf1e4ee77c2410d73137e", @"/Areas/Admin/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b6a4fda3b3cc13f3694c06c6c145161e13168af", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TCYDMWebApp.DTO.ServiceInfoApp>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""right_col"" role=""main"" style=""min-height: 1661px;"">
    <div class=""col-md-12 col-sm-12 "">
        <div class=""x_panel"">
            <div class=""x_title"">
                <h2>Services</h2>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "616d5fbefdc8622beceaf1e4ee77c2410d73137e5919", async() => {
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
            WriteLiteral("\r\n                                        </p>\r\n                                        <p>");
#nullable restore
#line 26 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                      Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <table id=""demo"" class=""table table-striped table-bordered dataTable no-footer"" role=""grid"" aria-describedby=""datatable_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""datatable"" rowspan=""1"" colspan=""1"" aria-label=""Salary: activate to sort column ascending"" style=""width: 156px;"">");
#nullable restore
#line 30 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 31 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 32 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.ServiceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 33 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                                                                                                                                                                               Write(Html.DisplayNameFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <th class=\"sorting\" tabindex=\"0\" aria-controls=\"datatable\" rowspan=\"1\" colspan=\"1\" aria-label=\"Salary: activate to sort column ascending\" style=\"width: 156px;\">");
#nullable restore
#line 34 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
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
#line 39 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 43 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 46 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 49 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.ServiceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 52 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 55 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 4639, "\"", 4699, 4);
            WriteAttributeValue("", 4646, "/Admin/Services/Edit/", 4646, 21, true);
#nullable restore
#line 58 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
WriteAttributeValue("", 4667, item.ServiceId, 4667, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4682, "/", 4682, 1, true);
#nullable restore
#line 58 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
WriteAttributeValue("", 4683, item.LanguageId, 4683, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                <i class=\"fas fa-pencil-alt\"></i>\r\n                                                            </a>\r\n\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 4932, "\"", 4994, 4);
            WriteAttributeValue("", 4939, "/Admin/Services/Delete/", 4939, 23, true);
#nullable restore
#line 62 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
WriteAttributeValue("", 4962, item.ServiceId, 4962, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4977, "/", 4977, 1, true);
#nullable restore
#line 62 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
WriteAttributeValue("", 4978, item.LanguageId, 4978, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-danger sweet-delete"">
                                                                <i class=""fas fa-trash""></i>
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 67 "C:\Users\hasan\Desktop\Working Area\SCFFR\SCFFR\TCYDMWebApp\TCYDMWebApp\Areas\Admin\Views\Services\Index.cshtml"
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
            col_1: 'select',
            col_2: 'select',
            col_4: 'select',
            alternate_rows: t");
                WriteLiteral(@"rue,
            rows_counter: true,
            btn_reset: true,
            loader: true,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TCYDMWebApp.DTO.ServiceInfoApp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
