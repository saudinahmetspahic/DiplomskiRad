#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd37a890fcc827bf2524494331858afa8edcd0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_GetNotifications), @"mvc.1.0.view", @"/Views/Notification/GetNotifications.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
using WebApp.ViewModels.Notification;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd37a890fcc827bf2524494331858afa8edcd0d", @"/Views/Notification/GetNotifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_GetNotifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetNotifications_VM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"padding-5 div-section-list-item\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=\"", 181, "\"", 210, 2);
            WriteAttributeValue("", 186, "NotificationDiv_", 186, 16, true);
#nullable restore
#line 10 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 202, item.Id, 202, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"border border-dark overflow-hidden margin-bottom-50 padding-0 border-radius-5 max-width-1000px\">\r\n            <div class=\"cursor background-purple text-color-white padding-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 393, "\"", 452, 4);
            WriteAttributeValue("", 403, "javascript:", 403, 11, true);
            WriteAttributeValue(" ", 414, "CollapseDiv(\'Notification_", 415, 27, true);
#nullable restore
#line 11 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 441, item.Id, 441, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 449, "\');", 449, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"bi bi-caret-down-fill text-color-white\"></i>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 564, "\"", 590, 2);
            WriteAttributeValue("", 569, "Notification_", 569, 13, true);
#nullable restore
#line 14 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 582, item.Id, 582, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 15 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
                 if (item.AllowModifications)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"text-align-right\">\r\n                        <button class=\"btn-white-black padding-5 border-0\"");
            BeginWriteAttribute("onclick", " onclick=\"", 786, "\"", 839, 4);
            WriteAttributeValue("", 796, "javascript:", 796, 11, true);
            WriteAttributeValue(" ", 807, "RemoveNotification(\'", 808, 21, true);
#nullable restore
#line 18 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 828, item.Id, 828, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 836, "\');", 836, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-x-square remove-button\"></i></button>\r\n                    </div>\r\n");
#nullable restore
#line 20 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex flex-column margin-top-25\">\r\n");
#nullable restore
#line 22 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
                       var image = string.IsNullOrEmpty(item.ImageName) ? "/Embedded/notifications.png" : "/Notification/" + item.ImageName; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img class=\"w-100 max-height-300 h-auto object-fit-contain\"");
            BeginWriteAttribute("src", " src=\"", 1230, "\"", 1250, 2);
            WriteAttributeValue("", 1236, "/Images/", 1236, 8, true);
#nullable restore
#line 23 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 1244, image, 1244, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1251, "\"", 1257, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"padding-20 background-purple text-color-white\">\r\n                        <h4 class=\"text-align-left\">");
#nullable restore
#line 25 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p class=\"font-size-13px text-color-lightgray text-align-left\">Published ");
#nullable restore
#line 26 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
                                                                                            Write(item.DateCreated.ToString("(dddd) dd MMM yyyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-align-justify text-color-white padding-50\">");
#nullable restore
#line 27 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
                                                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Notification\GetNotifications.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>



<script>
    function RemoveNotification(NotificationId) {
        $.post(""/Notification/RemoveNotification?NotificationId="" + NotificationId, function (result, status) {
            if (status == ""success"") {
                $(""#NotificationDiv_"" + NotificationId).remove();
                Message(""Notification successfully removed."");
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetNotifications_VM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
