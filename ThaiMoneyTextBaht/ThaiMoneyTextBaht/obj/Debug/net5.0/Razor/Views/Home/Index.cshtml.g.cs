#pragma checksum "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79af02e431a9e8c0effaf65e6d9fb4fee089b869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\_ViewImports.cshtml"
using ThaiMoneyTextBaht;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\_ViewImports.cshtml"
using ThaiMoneyTextBaht.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79af02e431a9e8c0effaf65e6d9fb4fee089b869", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5dc9592769b16984d50c7e1111f82b81d5aa29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive-lg py-5"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Money</th>
                <th scope=""col"">Text</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 15 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\Home\Index.cshtml"
              
                if (ViewData["Money"] != null)
                {
                    int r = 0;
                    foreach (var i in (IEnumerable<MoneyModel>)ViewData["Money"])
                    {
                        r += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 23 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\Home\Index.cshtml"
                                       Write(r);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td class=\"text-right\">\r\n                                ");
#nullable restore
#line 25 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\Home\Index.cshtml"
                           Write(i.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ฿\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 27 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\Home\Index.cshtml"
                           Write(i.MoneyText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 29 "C:\MYSTART-UP2020\GitHub\Thai-Money-Text-Baht\ThaiMoneyTextBaht\ThaiMoneyTextBaht\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
