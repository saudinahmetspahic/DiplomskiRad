#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845c31d5caef1d3d054c937dee6060dc627ab133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_Index), @"mvc.1.0.view", @"/Views/Purchase/Index.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
using WebApp.ViewModels.Purchase;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845c31d5caef1d3d054c937dee6060dc627ab133", @"/Views/Purchase/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetPurchases_VM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead class=""table-primary"">
            <tr>
                <th>Created</th>
                <th>Creator</th>
                <th>Program</th>
                <th>Participants</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"focus-border cursor\"");
            BeginWriteAttribute("onclick", " onclick=\"", 477, "\"", 558, 5);
            WriteAttributeValue("", 487, "location.href", 487, 13, true);
            WriteAttributeValue(" ", 500, "=", 501, 2, true);
            WriteAttributeValue(" ", 502, "\'/Purchase/GetProgramPurchasesDetails?PurchaseId=", 503, 50, true);
#nullable restore
#line 19 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
WriteAttributeValue("", 552, p.Id, 552, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 557, "\'", 557, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
                   Write(p.Created.ToString("dd. MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
                   Write(p.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
                   Write(p.ProgramTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
                   Write(p.Participants);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 28 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-center\">There are no purchases.</h4>\r\n");
#nullable restore
#line 32 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetPurchases_VM>> Html { get; private set; }
    }
}
#pragma warning restore 1591