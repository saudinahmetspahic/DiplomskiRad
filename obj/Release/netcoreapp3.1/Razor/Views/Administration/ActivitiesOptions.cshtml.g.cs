#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a57ea15e9277bdadff65fc126544a968f23c39f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ActivitiesOptions), @"mvc.1.0.view", @"/Views/Administration/ActivitiesOptions.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
using WebApp.ViewModels.Administration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a57ea15e9277bdadff65fc126544a968f23c39f", @"/Views/Administration/ActivitiesOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ActivitiesOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ActivityOptions_VM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<table class=""table m-auto"">
    <thead class=""table-primary"">
        <tr>
            <th class=""padding-5"">Title</th>
            <th class=""padding-5"">Number of available attachments</th>
            <th class=""padding-5"">Max. expected price</th>
            <th class=""padding-5"">Number of appearances in plans</th>
            <th class=""padding-5"">Customer rating</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"focus-border\"");
            BeginWriteAttribute("onclick", " onclick=\"", 589, "\"", 679, 5);
            WriteAttributeValue("", 599, "location.href", 599, 13, true);
            WriteAttributeValue(" ", 612, "=", 613, 2, true);
            WriteAttributeValue(" ", 614, "\'/Administration/GetActivityDetails?ActivityId=", 615, 48, true);
#nullable restore
#line 18 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
WriteAttributeValue("", 662, item.ActivityId, 662, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 678, "\'", 678, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td class=\"padding-5 text-align-left\">");
#nullable restore
#line 19 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"padding-5\">");
#nullable restore
#line 20 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
                                 Write(item.NumberOfAttachments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"padding-5\">");
#nullable restore
#line 21 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
                                 Write(item.ExpectedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"padding-5\">");
#nullable restore
#line 22 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
                                 Write(item.NumberOfAppInPlans);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"padding-5\">");
#nullable restore
#line 23 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
                                 Write(Math.Round((item.Rating ?? 0.0) / 1, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Administration\ActivitiesOptions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"text-center margin-top-25\">\r\n    <p class=\"border-bottom focus-hover d-inline-block cursor padding-5\" onclick=\"location.href = \'/Administration/CreateNewActivity\'\">CREATE NEW ACTIVITY</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ActivityOptions_VM>> Html { get; private set; }
    }
}
#pragma warning restore 1591