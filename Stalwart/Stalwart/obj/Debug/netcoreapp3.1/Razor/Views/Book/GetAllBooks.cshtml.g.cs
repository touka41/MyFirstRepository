#pragma checksum "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dabe5f7e41b4000dfd3b9f66484e7a2e28777b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dabe5f7e41b4000dfd3b9f66484e7a2e28777b3", @"/Views/Book/GetAllBooks.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Stalwart.Models.BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All book list</h1>\r\n<button>Click me</button>\r\n");
#nullable restore
#line 8 "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml"
Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 9 "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml"
 if (ViewBag.datas != null)
{
    foreach (var items in ViewBag.datas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"list-group\">\r\n            <li class=\"list-group-item\">");
#nullable restore
#line 14 "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml"
                                   Write(items.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">");
#nullable restore
#line 15 "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml"
                                   Write(items.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item\">");
#nullable restore
#line 16 "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml"
                                   Write(items.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n");
#nullable restore
#line 18 "C:\Users\pmendoza\Desktop\ASPNETCORE\GitHub\Stalwart\Stalwart\Views\Book\GetAllBooks.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            //alert(\'sample\');\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Stalwart.Models.BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
