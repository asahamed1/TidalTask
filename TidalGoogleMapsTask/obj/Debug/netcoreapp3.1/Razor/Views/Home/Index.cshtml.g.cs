#pragma checksum "C:\Users\DELL\source\repos\TidalGoogleMapsTask\TidalGoogleMapsTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544dedeb114c005b2f949538c05b1a97a194b0a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\TidalGoogleMapsTask\TidalGoogleMapsTask\Views\_ViewImports.cshtml"
using TidalGoogleMapsTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\TidalGoogleMapsTask\TidalGoogleMapsTask\Views\_ViewImports.cshtml"
using TidalGoogleMapsTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544dedeb114c005b2f949538c05b1a97a194b0a8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637e0c1059d284b7a4fb2602f783f34ef431e54d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DELL\source\repos\TidalGoogleMapsTask\TidalGoogleMapsTask\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://developers.google.com/maps/documentation"">Google Maps Select Location</a>.</p>
</div>


<div id=""map"" style=""height:600px;width:100%""></div>
<p class=""text-danger"" id=""errorLocationMsg""></p>
<button class=""btn btn-primary"" id=""savelocationBtn"" onclick=""SaveUserLoaction()"">Save Location</button>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n <script");
                BeginWriteAttribute("src", " src=\"", 486, "\"", 574, 3);
                WriteAttributeValue("", 492, "https://maps.googleapis.com/maps/api/js?key=", 492, 44, true);
#nullable restore
#line 18 "C:\Users\DELL\source\repos\TidalGoogleMapsTask\TidalGoogleMapsTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 536, ViewBag.Key, 536, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 548, "&callback=initMap&v=weekly", 548, 26, true);
                EndWriteAttribute();
                WriteLiteral("\r\n            async></script>\r\n\r\n\r\n");
            }
            );
            WriteLiteral("<!-- Async script executes immediately and must be after any DOM elements used in callback. -->\r\n\r\n\r\n");
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
