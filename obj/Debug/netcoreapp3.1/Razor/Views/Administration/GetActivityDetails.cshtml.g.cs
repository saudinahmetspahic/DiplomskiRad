#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcc611413173fddcb0213659e9f805e4de6851a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_GetActivityDetails), @"mvc.1.0.view", @"/Views/Administration/GetActivityDetails.cshtml")]
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
using WebApp.ViewModels.Administration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcc611413173fddcb0213659e9f805e4de6851a2", @"/Views/Administration/GetActivityDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_GetActivityDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetActivityDetails_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"flex-section-row align-content-around border border-secondary\">\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 160, "\"", 191, 2);
            WriteAttributeValue("", 165, "Activity_", 165, 9, true);
#nullable restore
#line 6 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 174, Model.ActivityId, 174, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-50 position-relative d-flex align-items-center min-h-200\">\r\n        <img class=\"w-100 h-auto\"");
            BeginWriteAttribute("src", " src=\"", 295, "\"", 316, 1);
#nullable restore
#line 7 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 301, Model.ImageSrc, 301, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" />\r\n        <div");
            BeginWriteAttribute("onclick", " onclick=\"", 346, "\"", 446, 9);
            WriteAttributeValue("", 356, "javascript:", 356, 11, true);
            WriteAttributeValue(" ", 367, "AddNewPhoto(\'Activity_", 368, 23, true);
#nullable restore
#line 8 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 390, Model.ActivityId, 390, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 407, "\',", 407, 2, true);
            WriteAttributeValue(" ", 409, "\'Activity\',", 410, 12, true);
            WriteAttributeValue(" ", 421, "\'", 422, 2, true);
#nullable restore
#line 8 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 423, Model.ActivityId, 423, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 440, "\',", 440, 2, true);
            WriteAttributeValue(" ", 442, "0);", 443, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""position-absolute left0 bottom0 w-100 h-100 show-on-hover cursor text-black-50 font-weight-bold text-uppercase d-flex justify-content-center align-items-center""><p class=""padding-5 background-dark text-white"">Add new image</p></div>
    </div>
    <div class=""w-50 padding-5"">
        <div class=""flex-section-row justify-content-between"">
            <h3>");
#nullable restore
#line 12 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h2 class=\"cursor\"");
            BeginWriteAttribute("onclick", " onclick=\"", 864, "\"", 951, 5);
            WriteAttributeValue("", 874, "location.href", 874, 13, true);
            WriteAttributeValue(" ", 887, "=", 888, 2, true);
            WriteAttributeValue(" ", 889, "\'/Administration/RemoveActivity?ActivityId=", 890, 44, true);
#nullable restore
#line 13 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 933, Model.ActivityId, 933, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 950, "\'", 950, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-trash\"></i></h2>\r\n        </div>\r\n        <p class=\"padding-5 h-200 scroll-auto\">");
#nullable restore
#line 15 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
                                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h6 class=\"border-top border-secondary padding-5\">Number of available attachments: ");
#nullable restore
#line 16 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
                                                                                      Write(Model.Attachments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div>\r\n");
#nullable restore
#line 22 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
     foreach (var item in Model.Attachments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"border border-secondary margin-top-5\">\r\n            <div class=\"flex-section-row justify-content-around w-100 align-items-center padding-5\">\r\n                <div class=\"font-weight-bold flex-grow-1 padding-5\">");
#nullable restore
#line 26 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"font-weight-bold flex-grow-1 padding-5\">");
#nullable restore
#line 27 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
                                                               Write(item.TypeOfAttachment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"font-weight-bold flex-grow-2 padding-5 d-flex flex-row justify-content-center align-items-center\"><i");
            BeginWriteAttribute("onclick", " onclick=\"", 1756, "\"", 1811, 4);
            WriteAttributeValue("", 1766, "javascript:", 1766, 11, true);
            WriteAttributeValue(" ", 1777, "ChagePrice(\'", 1778, 13, true);
#nullable restore
#line 28 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 1790, item.AttachmentId, 1790, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1808, "\');", 1808, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"bi bi-pencil-square cursor margin-right-5\"></i><p");
            BeginWriteAttribute("id", " id=\"", 1869, "\"", 1908, 2);
            WriteAttributeValue("", 1874, "AttachmentPrice_", 1874, 16, true);
#nullable restore
#line 28 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 1890, item.AttachmentId, 1890, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"margin-0\">");
#nullable restore
#line 28 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
                                                                                                                                                                                                                                                                                                       Write(Math.Round(item.PriceToVisit, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (BAM) - ");
#nullable restore
#line 28 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
                                                                                                                                                                                                                                                                                                                                                   Write(Math.Round(item.PriceToVisit / 1.95, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (€)</p></div>\r\n                <div class=\"font-weight-bold flex-grow-1 cursor text-align-right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2110, "\"", 2210, 5);
            WriteAttributeValue("", 2120, "location.href", 2120, 13, true);
            WriteAttributeValue(" ", 2133, "=", 2134, 2, true);
            WriteAttributeValue(" ", 2135, "\'/Administration/RemoveActivityAttachment?AttachmentId=", 2136, 56, true);
#nullable restore
#line 29 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 2191, item.AttachmentId, 2191, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2209, "\'", 2209, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-trash\"></i></div>\r\n            </div>\r\n            <div class=\"border-top border-info padding-5 flex-section-row\">\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 2364, "\"", 2398, 2);
            WriteAttributeValue("", 2369, "Attachment_", 2369, 11, true);
#nullable restore
#line 32 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 2380, item.AttachmentId, 2380, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"flex-section-row-child-50 padding-5 w-50 position-relative d-flex align-items-center min-h-200\">\r\n                    <img class=\"w-100 h-auto\"");
            BeginWriteAttribute("src", " src=\"", 2550, "\"", 2570, 1);
#nullable restore
#line 33 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 2556, item.ImageSrc, 2556, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2571, "\"", 2577, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2607, "\"", 2731, 11);
            WriteAttributeValue("", 2617, "javascript:", 2617, 11, true);
            WriteAttributeValue(" ", 2628, "AddNewPhoto(\'Attachment_", 2629, 25, true);
#nullable restore
#line 34 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 2653, item.AttachmentId, 2653, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2671, "\',", 2671, 2, true);
            WriteAttributeValue(" ", 2673, "\'Attachment\',", 2674, 14, true);
            WriteAttributeValue(" ", 2687, "\'", 2688, 2, true);
#nullable restore
#line 34 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 2689, Model.ActivityId, 2689, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2706, "\',", 2706, 2, true);
            WriteAttributeValue(" ", 2708, "\'", 2709, 2, true);
#nullable restore
#line 34 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
WriteAttributeValue("", 2710, item.AttachmentId, 2710, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2728, "\');", 2728, 3, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""position-absolute left0 bottom0 w-100 h-100 show-on-hover cursor text-black-50 font-weight-bold text-uppercase d-flex justify-content-center align-items-center""><p class=""padding-5 background-dark text-white"">Add new image</p></div>
                </div>
                <div class=""flex-section-row-child-50 padding-5"">
                    ");
#nullable restore
#line 37 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div id=""CreateNewActivityAttachment_AjaxDiv""></div>
<div class=""text-center margin-top-25"">
    <p class=""border-bottom focus-hover d-inline-block cursor padding-5"" onclick=""javascript: CreateNewActivityAttachment();"">CREATE NEW ATTACHMENT</p>
</div>

<script>
    function ChagePrice(AttachmentId) {
        var p = document.getElementById('AttachmentPrice_' + AttachmentId);
        p.innerHTML = """";

        var input = document.createElement(""input"");
        input.placeholder = ""Enter new price (BAM)"";
        input.type = ""number"";
        var button = document.createElement(""button"");
        button.textContent = ""Chage"";
        button.classList = ""btn-primary"";
        button.style.padding = ""2px 5px"";
        button.addEventListener(""click"", function () {
            $.post(""/Administration/SetNewAttachmentPrice?AttachmentId="" + AttachmentId + ""&Price="" + input.value, function (result, status) {
                if (status == ""success"") {
                    p.innerHTML = ");
            WriteLiteral(@""""";
                    var newp = document.createElement(""p"");
                    newp.innerHTML = (parseFloat(input.value)).toFixed(2) + "" (BAM) - "" + (input.value / 1.95).toFixed(2) + "" (EUR)"";
                    newp.className = ""margin-0 text-wrap"";
                    newp.id = ""AttachmentPrice_"" + AttachmentId;
                    p.appendChild(newp);
                    Message(""Attachment price is changed successfully to "" + input.value + "" BAM."");
                }
            });
        });

        p.appendChild(input);
        p.appendChild(button);
    }

    function CreateNewActivityAttachment() {
        $.get(""/Administration/CreateNewActivityAttachment?ActivityId="" + ");
#nullable restore
#line 80 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetActivityDetails.cshtml"
                                                                     Write(Model.ActivityId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", function (result, status) {
            if (status == ""success"") {
                $(""#CreateNewActivityAttachment_AjaxDiv"").html(result);
            }
        });
    }

    function AddNewPhoto(id, Option, ActivityId, AttachmentId) {
        var action = ""/Administration/AddNewImageTo"" + Option + ""?ActivityId="" + ActivityId + ""&AttachmentId="" + AttachmentId;
        $.get(action, function (result, status) {
            if (status == ""success"") {
                $(""#"" + id).html(result);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetActivityDetails_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
