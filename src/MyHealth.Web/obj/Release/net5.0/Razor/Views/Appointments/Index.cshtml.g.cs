#pragma checksum "/src/src/MyHealth.Web/Views/Appointments/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d6d08d16f68e38b682bcdf40f39940e41337870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_Index), @"mvc.1.0.view", @"/Views/Appointments/Index.cshtml")]
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
#line 1 "/src/src/MyHealth.Web/Views/_ViewImports.cshtml"
using MyHealth.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/src/src/MyHealth.Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6d08d16f68e38b682bcdf40f39940e41337870", @"/Views/Appointments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661f0b2bb2de7f1ff803c1bd2838ce2e52727a83", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/src/src/MyHealth.Web/Views/Appointments/Index.cshtml"
  
    ViewData["Title"] = "HealthClinic.biz";
    Layout = "_LayoutAppointments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"app\">\n    ");
#nullable restore
#line 7 "/src/src/MyHealth.Web/Views/Appointments/Index.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    ");
#nullable restore
#line 9 "/src/src/MyHealth.Web/Views/Appointments/Index.cshtml"
Write(await Html.PartialAsync("_Content"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    ");
#nullable restore
#line 11 "/src/src/MyHealth.Web/Views/Appointments/Index.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
