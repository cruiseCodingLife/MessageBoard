#pragma checksum "C:\Users\USER\Desktop\MessageBoard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33cdff6b3dcff97018dcb8236dd938bdb25520cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\USER\Desktop\MessageBoard\Views\_ViewImports.cshtml"
using MessageBoard;

#line default
#line hidden
#line 2 "C:\Users\USER\Desktop\MessageBoard\Views\_ViewImports.cshtml"
using MessageBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33cdff6b3dcff97018dcb8236dd938bdb25520cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b696d81999c192a07425bb3ea5d238089969ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MessageBoard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\USER\Desktop\MessageBoard\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(72, 353, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1>TEST MESSAGE BOARD </h1>
    <div>&nbsp;</div>
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">MessageTime</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Content</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 18 "C:\Users\USER\Desktop\MessageBoard\Views\Home\Index.cshtml"
             if (Model != null)
            {
                if (Model.Count() > 0)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(604, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(667, 20, false);
#line 25 "C:\Users\USER\Desktop\MessageBoard\Views\Home\Index.cshtml"
                           Write(item.MessageDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(687, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(727, 9, false);
#line 26 "C:\Users\USER\Desktop\MessageBoard\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(736, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(776, 12, false);
#line 27 "C:\Users\USER\Desktop\MessageBoard\Views\Home\Index.cshtml"
                           Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(788, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\USER\Desktop\MessageBoard\Views\Home\Index.cshtml"
                    }
                }
            }

#line default
#line hidden
            BeginContext(883, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MessageBoard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
