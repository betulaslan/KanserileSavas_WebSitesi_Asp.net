#pragma checksum "C:\Proje\Proje\Views\YonetimUye\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cffb0a1a82495b6351ca590fb63e5a40671279f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YonetimUye_Index), @"mvc.1.0.view", @"/Views/YonetimUye/Index.cshtml")]
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
#line 1 "C:\Proje\Proje\Views\_ViewImports.cshtml"
using Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proje\Proje\Views\_ViewImports.cshtml"
using Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Proje\Proje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cffb0a1a82495b6351ca590fb63e5a40671279f4", @"/Views/YonetimUye/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4d6e9ae5bb4ac04ddea7af4d30995aed0e6bd6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_YonetimUye_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YonetimUye>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Proje\Proje\Views\YonetimUye\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container"">
            <h2 class=""title"">Erken Tanı Hayat Kurtarır </h2>
            <ul class=""breadcrumbs-custom-path mt-2"">
                <li><a href=""/AnaSayfa/Index/"">Ana Sayfa</a></li>
                <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Yönetim Kurulu Üyeleri </li>
            </ul>
        </div>
    </div>
</section>
<br />

<section class=""grids-1 py-5"">
    <div class=""grids py-lg-5 py-md-4"">
        <div class=""container"">
            <h3 class=""hny-title mb-5"">Yönetim Kurulu Üyeleri</h3>
            <div class=""row"">
");
#nullable restore
#line 25 "C:\Proje\Proje\Views\YonetimUye\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-4 col-6\">\r\n                        <div class=\"column\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1056, "\"", 1073, 1);
#nullable restore
#line 29 "C:\Proje\Proje\Views\YonetimUye\Index.cshtml"
WriteAttributeValue("", 1062, item.Resim, 1062, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1074, "\"", 1080, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" style=\"width:200px; height:200px;\">\r\n                            <div class=\"info\">\r\n                                <h4><a href=\"blog-single.html\">");
#nullable restore
#line 31 "C:\Proje\Proje\Views\YonetimUye\Index.cshtml"
                                                          Write(item.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <div class=\"dst-btm\">\r\n                                    <h6");
            BeginWriteAttribute("class", " class=\"", 1366, "\"", 1374, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Proje\Proje\Views\YonetimUye\Index.cshtml"
                                            Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Proje\Proje\Views\YonetimUye\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<YonetimUye>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591