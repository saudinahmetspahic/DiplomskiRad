#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityDetailsAjax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1c4cd238313247d6741402fd3ec581ab3e08be0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_GetActivityDetailsAjax), @"mvc.1.0.view", @"/Views/Program/GetActivityDetailsAjax.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityDetailsAjax.cshtml"
using WebApp.ViewModels.Program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1c4cd238313247d6741402fd3ec581ab3e08be0", @"/Views/Program/GetActivityDetailsAjax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_GetActivityDetailsAjax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetActivityDetails_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 4 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityDetailsAjax.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p> \r\n\r\n    <button class=\"btn-primary w-100 padding-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 161, "\"", 241, 8);
            WriteAttributeValue("", 171, "javascript:", 171, 11, true);
            WriteAttributeValue(" ", 182, "AddActivityToDay(this,", 183, 23, true);
            WriteAttributeValue(" ", 205, "\'", 206, 2, true);
#nullable restore
#line 7 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityDetailsAjax.cshtml"
WriteAttributeValue("", 207, Model.Id, 207, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 216, "\',", 216, 2, true);
            WriteAttributeValue(" ", 218, "\'", 219, 2, true);
#nullable restore
#line 7 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityDetailsAjax.cshtml"
WriteAttributeValue("", 220, Model.Description, 220, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 238, "\');", 238, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Add this activity</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetActivityDetails_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
