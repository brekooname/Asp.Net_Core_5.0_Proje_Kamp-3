#pragma checksum "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba50f8100731183989e6855868254ecffaa0588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast10Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast10Post/Default.cshtml")]
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
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba50f8100731183989e6855868254ecffaa0588", @"/Views/Shared/Components/BlogLast10Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLast10Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Blog</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> Blog Başlığı </th>
                                <th> Blog Kategorisi </th>
                                <th> Tarih </th>
                                <th>Detaylar</th>
");
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 980, "\"", 1001, 1);
#nullable restore
#line 25 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml"
WriteAttributeValue("", 986, item.BlogImage, 986, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> ");
#nullable restore
#line 25 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml"
                                                                                        Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
            WriteLiteral("                                    <td>\r\n");
            WriteLiteral("                                    </td>\r\n                                    <td>");
#nullable restore
#line 31 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml"
                                    Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
            WriteLiteral("                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1603, "\"", 1640, 2);
            WriteAttributeValue("", 1610, "/Blog/BlogReadAll/", 1610, 18, true);
#nullable restore
#line 34 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml"
WriteAttributeValue("", 1628, item.BlogID, 1628, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Blog\'a Git</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Onur\Desktop\Windows Form Projelerim\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast10Post\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591