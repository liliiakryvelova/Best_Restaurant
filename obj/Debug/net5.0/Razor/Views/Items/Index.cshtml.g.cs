#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cea49f3519f90d560d7fb2708f3eb01f6d9c1121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
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
#line 5 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cea49f3519f90d560d7fb2708f3eb01f6d9c1121", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoList.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Items</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml"
   foreach(Item item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 13 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml"
   Write(Html.ActionLink($"{item.Description}", "Details", new { id = item.ItemId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p>");
#nullable restore
#line 17 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml"
Write(Html.ActionLink("Add new item", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 18 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoList.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591