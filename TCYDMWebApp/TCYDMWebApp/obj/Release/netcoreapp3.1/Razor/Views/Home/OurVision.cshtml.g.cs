#pragma checksum "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\OurVision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f953169fb007dd41dcefdc7ab039f1180e48be54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OurVision), @"mvc.1.0.view", @"/Views/Home/OurVision.cshtml")]
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
#line 8 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\OurVision.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\OurVision.cshtml"
using TCYDMWebApp.Repositories.Lang;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f953169fb007dd41dcefdc7ab039f1180e48be54", @"/Views/Home/OurVision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5866596ec13e4519aef38c38ddae7f71c770eb70", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OurVision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TCYDMWebApp.DTO.VMVDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("<div class=\"contact\">\n    <h4 style=\"color:#212529\">");
#nullable restore
#line 13 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\OurVision.cshtml"
                         Write(SharedLocalizer["Our Vision"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <div class=\"contact-text\">\n        ");
#nullable restore
#line 15 "C:\Users\hasan\Desktop\SCFFR-master\TCYDMWebApp\TCYDMWebApp\Views\Home\OurVision.cshtml"
   Write(Html.Raw(Model?.Vision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TCYDMWebApp.DTO.VMVDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
