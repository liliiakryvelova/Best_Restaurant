#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df2f679192760a52e99ebd2e10ae880c4758573f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
#line 5 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2f679192760a52e99ebd2e10ae880c4758573f", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoList.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Categories</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml"
   foreach(Category category in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 13 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml"
   Write(Html.ActionLink($"{category.Name}", "Details", new { id = category.CategoryId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p>");
#nullable restore
#line 17 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml"
Write(Html.ActionLink("Add new CATEGORY", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 18 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Categories\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoList.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
