#pragma checksum "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\ServiceInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f3eb90a5949ca5fea910c24f0c702659b73d7cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServiceInfo), @"mvc.1.0.view", @"/Views/Home/ServiceInfo.cshtml")]
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
#line 6 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\ServiceInfo.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\ServiceInfo.cshtml"
using TCYDMWebApp.Repositories.Lang;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f3eb90a5949ca5fea910c24f0c702659b73d7cc", @"/Views/Home/ServiceInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5866596ec13e4519aef38c38ddae7f71c770eb70", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServiceInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCYDMWebApp.ViewModels.ServiceInfoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            WriteLiteral("<div class=\"our-service\">\n    <div class=\"banner-content\">\n        <a href=\"/\" style=\"text-transform:capitalize\" >");
#nullable restore
#line 14 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\ServiceInfo.cshtml"
                                                  Write(SharedLocalizer["Our Services"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fas fa-angle-right\"></i></a>\n        <p>");
#nullable restore
#line 15 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\ServiceInfo.cshtml"
      Write(Model?.ServiceParams?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n    <div class=\"info-service\">\n        <div class=\"text\">\n            <h4>");
#nullable restore
#line 19 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\ServiceInfo.cshtml"
           Write(Model?.ServiceInfo?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                ");
#nullable restore
#line 20 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\ServiceInfo.cshtml"
           Write(Html.Raw(@Model?.ServiceInfo?.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCYDMWebApp.ViewModels.ServiceInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
