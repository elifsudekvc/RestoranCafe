#pragma checksum "C:\Users\eskvc\source\repos\restoran\restoran\Areas\Musteri\Views\Home\Hakkimizda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37762f7dcf85f2283c8051d5555713ec5191388e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Musteri_Views_Home_Hakkimizda), @"mvc.1.0.view", @"/Areas/Musteri/Views/Home/Hakkimizda.cshtml")]
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
#line 1 "C:\Users\eskvc\source\repos\restoran\restoran\Areas\Musteri\Views\_ViewImports.cshtml"
using restoran;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eskvc\source\repos\restoran\restoran\Areas\Musteri\Views\_ViewImports.cshtml"
using restoran.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37762f7dcf85f2283c8051d5555713ec5191388e", @"/Areas/Musteri/Views/Home/Hakkimizda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0d8bed61875c14c1ae58d435d0a996c36a561d", @"/Areas/Musteri/Views/_ViewImports.cshtml")]
    public class Areas_Musteri_Views_Home_Hakkimizda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<restoran.Models.Hakkimizda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eskvc\source\repos\restoran\restoran\Areas\Musteri\Views\Home\Hakkimizda.cshtml"
  
    ViewData["Title"] = "Hakkimizda";
    Layout = "~/Views/Shared/_ALayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Title Page -->
<section class=""bg-title-page flex-c-m p-t-160 p-b-80 p-l-15 p-r-15"" style=""background-image: url(/Site/images/cafe27.jpg);"">
    <h2 class=""tit6 t-center"">
        HAKKIMIZDA
    </h2>
</section>


<!-- Our Story -->
<section class=""bg2-pattern p-t-116 p-b-110 t-center p-l-15 p-r-15"">
    <span class=""tit2 t-center"">
        Elisa Cafe & Restoran
    </span>

    <h3 class="" t-center m-b-35 m-t-5"">
        <strong>HAKKIMIZDA</strong>
    </h3>

");
#nullable restore
#line 25 "C:\Users\eskvc\source\repos\restoran\restoran\Areas\Musteri\Views\Home\Hakkimizda.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"t-center size32 m-l-r-auto\">\r\n            ");
#nullable restore
#line 28 "C:\Users\eskvc\source\repos\restoran\restoran\Areas\Musteri\Views\Home\Hakkimizda.cshtml"
       Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <br />\r\n        </p>\r\n");
#nullable restore
#line 32 "C:\Users\eskvc\source\repos\restoran\restoran\Areas\Musteri\Views\Home\Hakkimizda.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br />
    <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/ZRnIn8IS2JA"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" allowfullscreen></iframe>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<restoran.Models.Hakkimizda>> Html { get; private set; }
    }
}
#pragma warning restore 1591