#pragma checksum "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "150ebf71eb6a973fcf82d8651d3ebbb9c513cb38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\_ViewImports.cshtml"
using seyahat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\_ViewImports.cshtml"
using seyahat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
using seyahat.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"150ebf71eb6a973fcf82d8651d3ebbb9c513cb38", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f4c8f4d49407c36d9c2e0fe54a62defca5f049", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Bloglar</h3>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>BAŞLIK</th>\r\n        <th>SİL</th>\r\n        <th>GÜNCELLE</th>\r\n        <th>DETAY</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
     foreach (var y in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
       Write(y.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
       Write(y.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 459, "\"", 486, 2);
            WriteAttributeValue("", 466, "/Admin/BlogSil/", 466, 15, true);
#nullable restore
#line 22 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
WriteAttributeValue("", 481, y.Id, 481, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 547, "\"", 575, 2);
            WriteAttributeValue("", 554, "/Admin/Guncelle/", 554, 16, true);
#nullable restore
#line 23 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
WriteAttributeValue("", 570, y.Id, 570, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Güncelle</a></td>\r\n        <td><a href=\"#\" class=\"btn btn-outline-dark\">Detay</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\SUDE ÇAKIR\Desktop\seyahat\seyahat\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/BlogEkle\" class=\" btn btn-info\">Yeni Blog Ekle</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
