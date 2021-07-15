#pragma checksum "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2929e8b53b665ac07deb5d082e119548fd1104f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments__Content), @"mvc.1.0.view", @"/Views/Appointments/_Content.cshtml")]
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
#line 1 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/_ViewImports.cshtml"
using MyHealth.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2929e8b53b665ac07deb5d082e119548fd1104f", @"/Views/Appointments/_Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661f0b2bb2de7f1ff803c1bd2838ce2e52727a83", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments__Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyHealth.Model.ClinicAppointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
  
  const string DateFormat = "MMM dd, yyyy";
  const string TimeFormat = "h:mm tt";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""col-xs-12 col-lg-offset-1 col-lg-10 content-container"">
    <div class=""content-container-inner container-fluid"">
        <div class=""row margin-bottom-15"">
            <div class=""pull-left button button-white button-action"">
                <input type=""checkbox"" id=""selectAll"">
                <label for=""selectAll"">Select all</label>
            </div>
            <button class=""pull-left margin-left-15 button button-white button-action ng-hide"">
                <span class=""icon-btn_delete margin-right-10""></span> Delete
            </button>
            <button class=""pull-right button button-pink button-action"">
                <span class=""icon-btn_new margin-right-10""></span> New Appointment
            </button>
        </div>

        <div class=""row grid"">
            <div class=""grid-header"">
                <div class=""grid-col-15""></div>
                <div class=""grid-col-15"">Patient name </div>
                <div class=""grid-col-10"">Date </div>
                <div class=""grid");
            WriteLiteral("-col-10\">Hour </div>\n                <div class=\"grid-col-10\">Room number </div>\n                <div class=\"grid-col-30\">Description </div>\n                <div class=\"grid-col-10\"></div>\n            </div>\n            <div class=\"grid-body\">\n\n");
#nullable restore
#line 33 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"grid-row\">\n                        <div class=\"grid-col-15 grid-col-center\">\n                            <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1632, "\"", 1656, 1);
#nullable restore
#line 37 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 1637, item.AppointmentId, 1637, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <label");
            BeginWriteAttribute("for", " for=\"", 1693, "\"", 1718, 1);
#nullable restore
#line 38 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 1699, item.AppointmentId, 1699, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\n");
#nullable restore
#line 39 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                              
                                var base64 = Convert.ToBase64String(item.Patient.Picture);
                                var imgSrc = $"data:image/gif;base64,{base64}";
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"grid-image\"");
            BeginWriteAttribute("src", " src=\"", 2012, "\"", 2025, 1);
#nullable restore
#line 43 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 2018, imgSrc, 2018, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2026, "\"", 2050, 1);
#nullable restore
#line 43 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 2032, item.Patient.Name, 2032, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        </div>\n                        <div class=\"grid-col-15\"");
            BeginWriteAttribute("title", " title=\"", 2132, "\"", 2158, 1);
#nullable restore
#line 45 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 2140, item.Patient.Name, 2140, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
#nullable restore
#line 46 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Patient.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"grid-col-10\"");
            BeginWriteAttribute("title", " title=\"", 2317, "\"", 2360, 1);
#nullable restore
#line 48 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 2325, item.DateTime.ToString(DateFormat), 2325, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <time>");
#nullable restore
#line 49 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                             Write(item.DateTime.ToString(DateFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\n                        </div>\n                        <div class=\"grid-col-10\"");
            BeginWriteAttribute("title", " title=\"", 2519, "\"", 2581, 1);
#nullable restore
#line 51 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 2527, item.DateTime.ToString(TimeFormat).ToLowerInvariant(), 2527, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <time>");
#nullable restore
#line 52 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                             Write(item.DateTime.ToString(TimeFormat).ToLowerInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\n                        </div>\n                        <div class=\"grid-col-10\"");
            BeginWriteAttribute("title", " title=\"", 2759, "\"", 2783, 1);
#nullable restore
#line 54 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 2767, item.RoomNumber, 2767, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
#nullable restore
#line 55 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RoomNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"grid-col-30\"");
            BeginWriteAttribute("title", " title=\"", 2940, "\"", 2965, 1);
#nullable restore
#line 57 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
WriteAttributeValue("", 2948, item.Description, 2948, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
#nullable restore
#line 58 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""grid-col-10 grid-col-center"">
                            <span class=""grid-row-action icon-btn_edit"" title=""Edit""></span>
                            <span class=""grid-row-action icon-btn_delete"" title=""Delete""></span>
                        </div>
                    </div>
");
#nullable restore
#line 65 "/Users/alfredobenaute/work/docker/Docker/src/MyHealth.Web/Views/Appointments/_Content.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n\n    </div>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyHealth.Model.ClinicAppointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
