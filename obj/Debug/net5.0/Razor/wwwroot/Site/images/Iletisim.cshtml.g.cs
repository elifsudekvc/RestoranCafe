#pragma checksum "C:\Users\eskvc\source\repos\restoran\restoran\wwwroot\Site\images\Iletisim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "278363e67e782df61c97c227a03c2655ffbbc3b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Site_images_Iletisim), @"mvc.1.0.view", @"/wwwroot/Site/images/Iletisim.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"278363e67e782df61c97c227a03c2655ffbbc3b8", @"/wwwroot/Site/images/Iletisim.cshtml")]
    public class wwwroot_Site_images_Iletisim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<restoran.Models.Iletisim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eskvc\source\repos\restoran\restoran\wwwroot\Site\images\Iletisim.cshtml"
  
    ViewData["Title"] = "Iletisim";
    Layout = "~/Views/Shared/_ALayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Title Page -->
<section class=""bg-title-page flex-c-m p-t-160 p-b-80 p-l-15 p-r-15"" style=""background-image: url(/Site/images/cafe27.jpg);"">
    <h2 class=""tit6 t-center"">
        İLETİŞİM
    </h2>
</section>



<!-- Contact form -->
<section class=""section-contact bg1-pattern p-t-90 p-b-113"">
    <!-- Map -->
    <div class=""container"">
        <div class=""map  bo-rad-10 of-hidden"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3113.8202758574644!2d35.53048451463426!3d38.698972430665876!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x152b0d59b2e2528b%3A0xea5b0f5c6abccfd1!2sK%C3%B6%C5%9Fk%2C%20Talas%20Blv.%20No%3A65%2C%2038030%20Melikgazi%2FKayseri!5e0!3m2!1str!2str!4v1687513468395!5m2!1str!2str"" width=""1170"" height=""550"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 933, "\"", 951, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
        </div>
    </div>

    <div class=""container"">
        <h3 class=""tit7 t-center p-b-62 p-t-105"">
            Bize Mesaj Bırakın.
        </h3>

        <form class=""wrap-form-reservation size22 m-l-r-auto"" asp-action=""Iletisim"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger"">   </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <!-- Name -->
                    <span class=""txt9"">
                        İsim Soyisim
                    </span>

                    <div class=""wrap-inputname size12 bo2 bo-rad-10 m-t-3 m-b-23"">
                        <input class=""bo-rad-10 sizefull txt10 p-l-20"" type=""text"" asp-for=""Isim"" placeholder=""İsim Soyisim"">
                        <span asp-validation-for=""Isim"">  </span>
                    </div>
                </div>

                <div class=""col-md-4"">
                    <!-- Email -->
");
            WriteLiteral(@"                    <span class=""txt9"">
                        Email
                    </span>

                    <div class=""wrap-inputemail size12 bo2 bo-rad-10 m-t-3 m-b-23"">
                        <input class=""bo-rad-10 sizefull txt10 p-l-20"" type=""text"" asp-for=""Email"" placeholder=""Email"">
                        <span asp-validation-for=""Email"">  </span>
                    </div>
                </div>

                <div class=""col-md-4"">
                    <!-- Phone -->
                    <span class=""txt9"">
                        Telefon Numarası
                    </span>

                    <div class=""wrap-inputphone size12 bo2 bo-rad-10 m-t-3 m-b-23"">
                        <input class=""bo-rad-10 sizefull txt10 p-l-20"" type=""text"" asp-for=""TelNo"" placeholder=""0500 000 00 00"">
                        <span asp-validation-for=""TelNo"">  </span>
                    </div>
                </div>

                <div class=""col-12"">
                    <!-- Mes");
            WriteLiteral(@"sage -->
                    <span class=""txt9"">
                        Mesaj
                    </span>
                    <textarea class=""bo-rad-10 size35 bo2 txt10 p-l-20 p-t-15 m-b-10 m-t-3"" asp-for=""Mesaj"" placeholder=""Mesajınızı yazın.""></textarea>
                    <span asp-validation-for=""Mesaj"">  </span>
                </div>
            </div>

            <div class=""wrap-btn-booking flex-c-m m-t-13"">
                <!-- Button3 -->
                <button type=""submit"" class=""btn3 flex-c-m size36 txt11 trans-0-4"">
                    Gönder
                </button>
            </div>
        </form>


    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\eskvc\source\repos\restoran\restoran\wwwroot\Site\images\Iletisim.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<restoran.Models.Iletisim> Html { get; private set; }
    }
}
#pragma warning restore 1591
