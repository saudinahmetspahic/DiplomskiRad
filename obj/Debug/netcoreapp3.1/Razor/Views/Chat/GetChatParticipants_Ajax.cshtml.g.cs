#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Chat\GetChatParticipants_Ajax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23285921a97d5a3b11c040a703015328f5948b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_GetChatParticipants_Ajax), @"mvc.1.0.view", @"/Views/Chat/GetChatParticipants_Ajax.cshtml")]
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Chat\GetChatParticipants_Ajax.cshtml"
using WebApp.ViewModels.Chat;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23285921a97d5a3b11c040a703015328f5948b16", @"/Views/Chat/GetChatParticipants_Ajax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_GetChatParticipants_Ajax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChatParticipants_VM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Chat\GetChatParticipants_Ajax.cshtml"
 foreach (var i in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"border-bottom cursor text-align-left\"");
            BeginWriteAttribute("onclick", " onclick=\"", 150, "\"", 221, 6);
            WriteAttributeValue("", 160, "javascript:", 160, 11, true);
            WriteAttributeValue(" ", 171, "GetChatInfo(", 172, 13, true);
#nullable restore
#line 7 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Chat\GetChatParticipants_Ajax.cshtml"
WriteAttributeValue("", 184, i.UserId, 184, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 193, ",", 193, 1, true);
#nullable restore
#line 7 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Chat\GetChatParticipants_Ajax.cshtml"
WriteAttributeValue(" ", 194, ViewData["IsGroupChat"], 195, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 219, ");", 219, 2, true);
            EndWriteAttribute();
            WriteLiteral("><a class=\"text-decoration-none text-secondary\" >");
#nullable restore
#line 7 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Chat\GetChatParticipants_Ajax.cshtml"
                                                                                                                                                                       Write(i.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
#nullable restore
#line 8 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Chat\GetChatParticipants_Ajax.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ChatParticipants_VM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
