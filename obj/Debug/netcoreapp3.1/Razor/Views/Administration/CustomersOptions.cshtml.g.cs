#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "591c823ff744182f66011d0e273e31eec9d91406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_CustomersOptions), @"mvc.1.0.view", @"/Views/Administration/CustomersOptions.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
using WebApp.ViewModels.Administration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"591c823ff744182f66011d0e273e31eec9d91406", @"/Views/Administration/CustomersOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_CustomersOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CustomersOptions_VM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <h5>Users</h5>
    <p>
        List of registered users. Click to see more details.
    </p>

    <table class=""table table-responsive-xl margin-top-25"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Surname</th>
                <th>Age</th>
                <th>Country</th>
                <th>City</th>
                <th>Phone</th>
                <th>Email</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"cursor focus-border\"");
            BeginWriteAttribute("onclick", " onclick=\"", 658, "\"", 732, 5);
            WriteAttributeValue("", 668, "location.href", 668, 13, true);
            WriteAttributeValue(" ", 681, "=", 682, 2, true);
            WriteAttributeValue(" ", 683, "\'/Administration/GetUserDetails?UserId=", 684, 40, true);
#nullable restore
#line 24 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
WriteAttributeValue("", 723, user.Id, 723, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 731, "\'", 731, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
                   Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
                   Write(user.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
                   Write(user.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
                   Write(user.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
                   Write(user.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\CustomersOptions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CustomersOptions_VM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
