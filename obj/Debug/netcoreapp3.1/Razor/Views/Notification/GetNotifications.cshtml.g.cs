#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a82dade346f1b2cabb3a1fa17ac146e643e324b8"
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
using WebApp.ViewModels.Notification;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a82dade346f1b2cabb3a1fa17ac146e643e324b8", @"/Views/Notification/GetNotifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_GetNotifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetNotifications_VM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"padding-5 div-section-list-item\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=\"", 181, "\"", 210, 2);
            WriteAttributeValue("", 186, "NotificationDiv_", 186, 16, true);
#nullable restore
#line 10 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 202, item.Id, 202, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"border border-dark overflow-hidden margin-bottom-50 padding-0 border-radius-5\">\r\n            <div class=\"cursor background-dodgerblue text-color-white padding-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 380, "\"", 439, 4);
            WriteAttributeValue("", 390, "javascript:", 390, 11, true);
            WriteAttributeValue(" ", 401, "CollapseDiv(\'Notification_", 402, 27, true);
#nullable restore
#line 11 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 428, item.Id, 428, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 436, "\');", 436, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"bi bi-caret-down-fill text-color-white\"></i>\r\n");
            WriteLiteral("            </div>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 807, "\"", 833, 2);
            WriteAttributeValue("", 812, "Notification_", 812, 13, true);
#nullable restore
#line 17 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 825, item.Id, 825, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 18 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
                 if (item.AllowModifications)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"text-align-right\">\r\n                        <button class=\"btn-white-black padding-5 border-0\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1029, "\"", 1082, 4);
            WriteAttributeValue("", 1039, "javascript:", 1039, 11, true);
            WriteAttributeValue(" ", 1050, "RemoveNotification(\'", 1051, 21, true);
#nullable restore
#line 21 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 1071, item.Id, 1071, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1079, "\');", 1079, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-x-square\"></i></button>\r\n                    </div>\r\n");
#nullable restore
#line 23 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex flex-column margin-top-25\">\r\n                    <img class=\"w-100 max-height-300 h-auto object-fit-contain\"");
            BeginWriteAttribute("src", " src=\"", 1315, "\"", 1357, 2);
            WriteAttributeValue("", 1321, "/Images/Notification/", 1321, 21, true);
#nullable restore
#line 25 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
WriteAttributeValue("", 1342, item.ImageName, 1342, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1358, "\"", 1364, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"padding-20\">\r\n                        <h4 class=\"text-align-left\">");
#nullable restore
#line 27 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p class=\"font-size-13px text-color-gray text-align-left\">Published ");
#nullable restore
#line 28 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
                                                                                       Write(item.DateCreated.ToString("(dddd) dd MMM yyyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-align-justify text-color-darkcyan\">");
#nullable restore
#line 29 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
                                                                     Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Notification\GetNotifications.cshtml"
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
