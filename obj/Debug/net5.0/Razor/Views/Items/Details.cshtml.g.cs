#pragma checksum "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7fff2ca48edebec70996c7d898c0b0ea322d545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7fff2ca48edebec70996c7d898c0b0ea322d545", @"/Views/Items/Details.cshtml")]
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Item Details</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>\r\n<p>");
#nullable restore
#line 10 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 11 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Details.cshtml"
Write(Html.ActionLink("Edit Item", "Edit", new { id = Model.ItemId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 12 "C:\Users\lilia\Epicodus\ASP.NET\MySQL_ToDoList\MySQL_ToDoList\ToDoList\Views\Items\Details.cshtml"
Write(Html.ActionLink("Delete Item", "Delete", new { id = Model.ItemId }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
