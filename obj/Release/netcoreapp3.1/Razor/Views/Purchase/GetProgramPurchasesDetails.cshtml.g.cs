#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2627aaf82b934a32da2e6943b1ecf22bb1627676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_GetProgramPurchasesDetails), @"mvc.1.0.view", @"/Views/Purchase/GetProgramPurchasesDetails.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
using WebApp.ViewModels.Purchase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
using WebApp.EntityModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
using WebApp.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2627aaf82b934a32da2e6943b1ecf22bb1627676", @"/Views/Purchase/GetProgramPurchasesDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_GetProgramPurchasesDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetProgramPurchasesDetails_VM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rate-star"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RateProgram", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Program", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetInvoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger margin-side-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IssueAnInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary margin-side-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
  
    UserAccount account = Context.GetLoggedUser();
    var isAdmin = account.Role == UserRole.Admin;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"d-flex justify-content-around margin-bottom-50 from-row-to-column\">\r\n    <div>\r\n        <h5 class=\"h5-tag-style\">Created</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 13 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                  Write(Model.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div>\r\n        <h5 class=\"h5-tag-style\">Creator</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 16 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                  Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div class=\"position-relative\">\r\n        <h5 class=\"h5-tag-style\">Title</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 19 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                Write(Model.ProgramName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2627aaf82b934a32da2e6943b1ecf22bb16276768291", async() => {
                WriteLiteral("<i class=\"bi bi-star-fill text-color-orange\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProgramId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                                                                                                                        WriteLiteral(Model.ProgramId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProgramId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProgramId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProgramId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n    </div>\r\n    <div>\r\n        <h5 class=\"h5-tag-style\">Participants</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 22 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                       Write(Model.Participants.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
 if (isAdmin)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"margin-bottom-20\">\r\n        <p>To create an invoice for this program click on this button.</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2627aaf82b934a32da2e6943b1ecf22bb162767611863", async() => {
                WriteLiteral("<i class=\"bi bi-receipt\"></i> Issue an invoice");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
} 

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
 if (Model.InvoiceId > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"margin-bottom-20\">\r\n        <p>This program has invoice attached to it.</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2627aaf82b934a32da2e6943b1ecf22bb162767613914", async() => {
                WriteLiteral("<i class=\"bi bi-receipt\"></i> Show invoice details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-InvoiceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                          WriteLiteral(Model.InvoiceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["InvoiceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-InvoiceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["InvoiceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 40 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p>All participants for this purchase are listed in table down bellow. If you want to add new one click 'Add participant'</p>
<table class=""table"">
    <thead class=""table-primary "">
        <tr>
            <th>Name</th>
            <th>Coutry</th>
            <th>City</th>
            <th>Age</th>
            <th class=""w-50px"">Remove</th>
        </tr>
    </thead>
    <tbody id=""UserTable"">
");
#nullable restore
#line 53 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
         foreach (var participant in Model.Participants)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 2227, "\"", 2263, 2);
            WriteAttributeValue("", 2232, "User_", 2232, 5, true);
#nullable restore
#line 55 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2237, participant.ParticipantId, 2237, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 56 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"cursor w-50px text-center\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2498, "\"", 2621, 7);
            WriteAttributeValue("", 2508, "location.href", 2508, 13, true);
            WriteAttributeValue(" ", 2521, "=", 2522, 2, true);
            WriteAttributeValue(" ", 2523, "\'/Purchase/RemoveUserFromPurchase?PurchaseId=", 2524, 46, true);
#nullable restore
#line 60 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2569, Model.PurchaseId, 2569, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2586, "&UserId=", 2586, 8, true);
#nullable restore
#line 60 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2594, participant.ParticipantId, 2594, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2620, "\'", 2620, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-x-square text-color-red\"></i></td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"text-center margin-top-25\">\r\n    <p class=\"border-bottom focus-hover d-inline-block cursor padding-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2844, "\"", 2935, 7);
            WriteAttributeValue("", 2854, "javascript:", 2854, 11, true);
            WriteAttributeValue(" ", 2865, "AddNewPurchaseParticipant(\'", 2866, 28, true);
#nullable restore
#line 67 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2893, Model.ProgramName, 2893, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2911, "\',", 2911, 2, true);
            WriteAttributeValue(" ", 2913, "\'", 2914, 2, true);
#nullable restore
#line 67 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2915, Model.PurchaseId, 2915, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2932, "\');", 2932, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">ADD PARTICIPANT</p>
</div>



<script>
    function AddUserToPurchase(e, UserId) {
        var PurchaseId = e.parentNode.id.substr(e.parentNode.id.length - 1, 1);
        $.get(""/Purchase/AddUserToPurchase?PurchaseId="" + PurchaseId + ""&UserId="" + UserId, function (result, status) {
            if (status == ""success"") {
                Message(""User successfully added to purchase."");
            }
        });

    }

    function AddNewPurchaseParticipant(Title, PurchaseId) {

        var content = document.createElement(""div"");

        var h4 = document.createElement(""h4"");
        h4.textContent = ""Add registered user"";

        var input = document.createElement(""input"");
        input.className = ""w-100"";
        var searchinput = document.createElement(""div"");
        searchinput.id = ""Purchase_"" + PurchaseId;
        input.addEventListener(""input"", function () {
            $.get(""/Purchase/GetUsersToAddToPurchase?PurchaseId="" + PurchaseId + ""&SearchValue="" + input.value, f");
            WriteLiteral(@"unction (result, status) {
                if (status == ""success"") {
                    searchinput.innerHTML = result;
                }
            });
        });

        var formdiv = document.createElement(""div"");
        formdiv.className = ""border-top border-dark padding-5 margin-top-25"";
        $.get(""/Login/AddParticipantForm"", function (result, status) {
            if (status == ""success"") {
                formdiv.innerHTML = result;
            }
        });
        content.appendChild(h4);
        content.appendChild(input);
        content.appendChild(searchinput);
        content.appendChild(formdiv);

        MakeCustomModal(Title + "" purchase participants"", content, false, function () { });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetProgramPurchasesDetails_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
