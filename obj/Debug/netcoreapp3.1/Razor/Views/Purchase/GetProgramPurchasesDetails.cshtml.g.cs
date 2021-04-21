#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91da0f9e96f90c61dbedd1598f10f1b10ecf069c"
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
using WebApp.ViewModels.Purchase;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91da0f9e96f90c61dbedd1598f10f1b10ecf069c", @"/Views/Purchase/GetProgramPurchasesDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_GetProgramPurchasesDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetProgramPurchasesDetails_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section class=\"d-flex justify-content-around margin-bottom-50\">\r\n    <div>\r\n        <h5 class=\"h5-tag-style\">Created</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 7 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                  Write(Model.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div>\r\n        <h5 class=\"h5-tag-style\">Creator</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 10 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                  Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div>\r\n        <h5 class=\"h5-tag-style\">Title</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 13 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                Write(Model.ProgramName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n    <div>\r\n        <h5 class=\"h5-tag-style\">Participants</h5> <h6 class=\"text-center margin-bottom-20\">");
#nullable restore
#line 16 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
                                                                                       Write(Model.Participants.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
    </div>
</section>

<p>In table down bellow are listed all participants for this purchase. If you want to add new one click 'Add participant'</p>
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
#line 32 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
         foreach (var participant in Model.Participants)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1219, "\"", 1255, 2);
            WriteAttributeValue("", 1224, "User_", 1224, 5, true);
#nullable restore
#line 34 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 1229, participant.ParticipantId, 1229, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 35 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
               Write(participant.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"cursor w-50px text-center\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1490, "\"", 1613, 7);
            WriteAttributeValue("", 1500, "location.href", 1500, 13, true);
            WriteAttributeValue(" ", 1513, "=", 1514, 2, true);
            WriteAttributeValue(" ", 1515, "\'/Purchase/RemoveUserFromPurchase?PurchaseId=", 1516, 46, true);
#nullable restore
#line 39 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 1561, Model.PurchaseId, 1561, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1578, "&UserId=", 1578, 8, true);
#nullable restore
#line 39 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 1586, participant.ParticipantId, 1586, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1612, "\'", 1612, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-x-square text-color-red\"></i></td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"text-center margin-top-25\">\r\n    <p class=\"border-bottom focus-hover d-inline-block cursor padding-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1957, "\"", 2048, 7);
            WriteAttributeValue("", 1967, "javascript:", 1967, 11, true);
            WriteAttributeValue(" ", 1978, "AddNewPurchaseParticipant(\'", 1979, 28, true);
#nullable restore
#line 47 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2006, Model.ProgramName, 2006, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2024, "\',", 2024, 2, true);
            WriteAttributeValue(" ", 2026, "\'", 2027, 2, true);
#nullable restore
#line 47 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2028, Model.PurchaseId, 2028, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2045, "\');", 2045, 3, true);
            EndWriteAttribute();
            WriteLiteral(">ADD PARTICIPANT</p>\r\n</div>\r\n\r\n<div class=\"d-flex flex-row\">\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2123, "\"", 2204, 5);
            WriteAttributeValue("", 2133, "location.href", 2133, 13, true);
            WriteAttributeValue(" ", 2146, "=", 2147, 2, true);
            WriteAttributeValue(" ", 2148, "\'/Purchase/IssueAnInvoice?PurchaseId=", 2149, 38, true);
#nullable restore
#line 51 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Purchase\GetProgramPurchasesDetails.cshtml"
WriteAttributeValue("", 2186, Model.PurchaseId, 2186, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2203, "\'", 2203, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100 padding-20 btn-danger\"><i class=\"bi bi-receipt\"></i> Issue an invoice</button>\r\n");
            WriteLiteral(@"</div>



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
            $.get(""/Purchase/GetUsersToAddToPurchase?PurchaseId="" + PurchaseId + ""&SearchValue="" + input.value, function (result, statu");
            WriteLiteral(@"s) {
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
