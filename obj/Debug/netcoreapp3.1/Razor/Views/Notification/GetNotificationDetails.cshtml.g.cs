#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8adfce99d5ffe81c742e184744386fed473e0f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_GetNotificationDetails), @"mvc.1.0.view", @"/Views/Notification/GetNotificationDetails.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml"
using WebApp.ViewModels.Notification;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8adfce99d5ffe81c742e184744386fed473e0f0", @"/Views/Notification/GetNotificationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_GetNotificationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetNotifications_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"notif-details\">\r\n");
#nullable restore
#line 5 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml"
       var image = string.IsNullOrEmpty(Model.ImageName) ? "/Embedded/notifications.png" : "/Notification/" + Model.ImageName; 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img class=\"img-blur-5px\"");
            BeginWriteAttribute("src", " src=\"", 257, "\"", 277, 2);
            WriteAttributeValue("", 263, "/Images/", 263, 8, true);
#nullable restore
#line 6 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml"
WriteAttributeValue("", 271, image, 271, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 278, "\"", 284, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div>\r\n        <h3 class=\"text-color-orange\">");
#nullable restore
#line 8 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h6>");
#nullable restore
#line 9 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml"
       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>");
#nullable restore
#line 10 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml"
       Write(Model.DateCreated.ToString("dd. MMM yyyy. HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <p class=\"padding-10\">");
#nullable restore
#line 12 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotificationDetails.cshtml"
                     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetNotifications_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
