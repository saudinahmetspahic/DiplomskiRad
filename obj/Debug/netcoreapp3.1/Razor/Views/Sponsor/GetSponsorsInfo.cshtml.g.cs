#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Sponsor\GetSponsorsInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0586df1c183931de1da6e688ff0bd385c602b8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sponsor_GetSponsorsInfo), @"mvc.1.0.view", @"/Views/Sponsor/GetSponsorsInfo.cshtml")]
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Sponsor\GetSponsorsInfo.cshtml"
using WebApp.ViewModels.Sponsor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0586df1c183931de1da6e688ff0bd385c602b8d", @"/Views/Sponsor/GetSponsorsInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sponsor_GetSponsorsInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SponsorOptions_VM.AddedSponsor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Sponsor\GetSponsorsInfo.cshtml"
 foreach (var sponsor in Model)
{   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"margin-50 text-center\">\r\n        <img class=\"img-size-200 object-fit-contain\"");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 259, 2);
            WriteAttributeValue("", 224, "/Images/Sponsors/", 224, 17, true);
#nullable restore
#line 9 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Sponsor\GetSponsorsInfo.cshtml"
WriteAttributeValue("", 241, sponsor.ImageName, 241, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 260, "\"", 266, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <h2>");
#nullable restore
#line 10 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Sponsor\GetSponsorsInfo.cshtml"
       Write(sponsor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h6>");
#nullable restore
#line 11 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Sponsor\GetSponsorsInfo.cshtml"
       Write(sponsor.AreaOfInterest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Sponsor\GetSponsorsInfo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SponsorOptions_VM.AddedSponsor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
