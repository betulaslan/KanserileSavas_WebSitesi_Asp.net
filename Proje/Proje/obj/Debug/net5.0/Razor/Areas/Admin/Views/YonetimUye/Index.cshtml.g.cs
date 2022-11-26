#pragma checksum "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f830d332558cb1442e806c79efcc973666f9e5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_YonetimUye_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/YonetimUye/Index.cshtml")]
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
#line 1 "C:\Proje\Proje\Areas\Admin\Views\_ViewImports.cshtml"
using Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proje\Proje\Areas\Admin\Views\_ViewImports.cshtml"
using Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f830d332558cb1442e806c79efcc973666f9e5c", @"/Areas/Admin/Views/YonetimUye/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4d6e9ae5bb4ac04ddea7af4d30995aed0e6bd6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_YonetimUye_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YonetimUye>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yönetim Kurulu Üyeleri</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Ad Soyad</th>\r\n        <th>Resim</th>\r\n        <th>Açıklama</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
           Write(item.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
           Write(item.Resim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
           Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 548, "\"", 608, 2);
            WriteAttributeValue("", 555, "/Admin/YonetimUye/DeleteYonetimUye/", 555, 35, true);
#nullable restore
#line 23 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
WriteAttributeValue("", 590, item.YonetimUyeID, 590, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 733, 2);
            WriteAttributeValue("", 680, "/Admin/YonetimUye/UpdateYonetimUye/", 680, 35, true);
#nullable restore
#line 24 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
WriteAttributeValue("", 715, item.YonetimUyeID, 715, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Proje\Proje\Areas\Admin\Views\YonetimUye\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/YonetimUye/AddYonetimUye\" class=\"btn btn-outline-primary\">Yeni Yönetim Kurulu Üyesi</a>\r\n\r\n");
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
