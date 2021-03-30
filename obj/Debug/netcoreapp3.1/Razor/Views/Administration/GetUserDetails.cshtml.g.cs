#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca9cef967018f71453982c2f1947c429476355a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_GetUserDetails), @"mvc.1.0.view", @"/Views/Administration/GetUserDetails.cshtml")]
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
using WebApp.ViewModels.Administration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca9cef967018f71453982c2f1947c429476355a8", @"/Views/Administration/GetUserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_GetUserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerDetails_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""flex-section-row"">
    <div class=""flex-section-row-child-50 d-flex flex-column justify-content-between"">
        <table class=""table"">
            <thead class=""table-primary"">
                <tr>
                    <th>Name</th>
                    <td>");
#nullable restore
#line 10 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.CustomerDetails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Surname</th>\r\n                    <td>");
#nullable restore
#line 14 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.CustomerDetails.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Age</th>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.CustomerDetails.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Country</th>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.CustomerDetails.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>City</th>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.CustomerDetails.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Phone</th>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.CustomerDetails.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Email</th>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.CustomerDetails.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n\r\n        <table class=\"table margin-0\">\r\n            <thead class=\"table-primary\">\r\n                <tr>\r\n                    <th>Registered</th>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.DateRegistered.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Collaborate (currently)</th>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                    Write(Model.CurrentlyOnPlan ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Number of collaborations</th>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(Model.NumberOfPlansOredered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n\r\n    </div>\r\n    <div class=\"flex-section-row-child-50 d-flex flex-column justify-content-between margin-left-50px\">\r\n");
#nullable restore
#line 58 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
         if (Model.IsVIP == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""flex-section-row justify-content-center table-danger"">
                <div class=""margin-5"">
                    <h1><i class=""bi bi-star-fill text-color-yellow""></i></h1>
                </div>
                <div class=""padding-5"">
                    <h2 class=""text-color-yellow"">VIP</h2>
                    <h6 class=""text-color-white"">This client has VIP status.</h6>
                </div>
            </div>
");
#nullable restore
#line 69 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <div class=""user-select-none"">
            <div class=""d-flex justify-content-center""><h2>PROGRAMS</h2></div>
            <div class=""flex-section-row justify-content-around border-bottom border-info padding-5 margin-top-50"">
                <h3 class=""flex-section-column text-center""><i onmouseover=""javascript: ShowHoverInfo(this, 'Accepted programs');"" class=""text-color-green bi bi-check2""></i> ");
#nullable restore
#line 75 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                                                                                                                                                                         Write(Model.NumberOfPlansCreated_Accepted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h3 class=\"flex-section-column text-center\"><i onmouseover=\"javascript: ShowHoverInfo(this, \'Refused programs\');\" class=\"text-color-red bi bi-dash-circle\"></i> ");
#nullable restore
#line 76 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                                                                                                                                                                           Write(Model.NumberOfPlansCreated_Refused);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h3 class=\"flex-section-column text-center\"><i onmouseover=\"javascript: ShowHoverInfo(this, \'Programs waiting approval\');\" class=\"text-color-yellow bi bi-hourglass-split\"></i> ");
#nullable restore
#line 77 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                                                                                                                                                                                           Write(Model.NumberOfPlansCreated_OnHold);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""border-bottom border-dark d-flex justify-content-around padding-5 margin-top-50""> <h3 class=""flex-section-column text-center""><i onmouseover=""javascript: ShowHoverInfo(this, 'Created programs');"" class=""text-color-yellow bi bi-hammer""></i> ");
#nullable restore
#line 79 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                                                                                                                                                                                                                                                                   Write(Model.NumberOfPlansCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>  <h3 class=\"flex-section-column text-center\"><i onmouseover=\"javascript: ShowHoverInfo(this, \'Ordered programs\');\" class=\"text-color-green bi bi-bag-check\"></i> ");
#nullable restore
#line 79 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.NumberOfPlansOredered);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3></div>
        </div>
    </div>
</div>

<div class=""margin-top-50"">
    <table class=""table"">
        <thead class=""table-light"">
            <tr>
                <th>Title</th>
                <th>Ordered</th>
                <th>Start</th>
                <th>Finish</th>
                <th>Single/Group</th>
                <th>Finished</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 97 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
             foreach (var item in Model.PlansOrdered_Redirection)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 4460, "\"", 4533, 5);
            WriteAttributeValue("", 4470, "javascript:", 4470, 11, true);
            WriteAttributeValue(" ", 4481, "CollapseDiv(\'PlanOrdered_Description_\'", 4482, 39, true);
            WriteAttributeValue(" ", 4520, "+", 4521, 2, true);
#nullable restore
#line 99 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
WriteAttributeValue(" ", 4522, item.Id, 4523, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4531, ");", 4531, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 100 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 101 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(item.DateOrdered.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 102 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(item.DateStart.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 103 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(item.DateFinish.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 104 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                    Write(item.ForGroup == true ? "Group" : "Single");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 105 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                    Write(item.Finished == true ? "Finished" : "Active");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr");
            BeginWriteAttribute("id", " id=\"", 4977, "\"", 5014, 2);
            WriteAttributeValue("", 4982, "PlanOrdered_Description_", 4982, 24, true);
#nullable restore
#line 107 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
WriteAttributeValue("", 5006, item.Id, 5006, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 108 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 110 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div>
    <table class=""table"">
        <thead class=""table-light"">
            <tr>
                <th>Title</th>
                <th>Created</th>
                <th>Number of sells</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 125 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
             foreach (var item in Model.PlansCreated_Redirection)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 5489, "\"", 5561, 5);
            WriteAttributeValue("", 5499, "javascript:", 5499, 11, true);
            WriteAttributeValue(" ", 5510, "CollapseDiv(\'PlanCreatedDescription_\'", 5511, 38, true);
            WriteAttributeValue(" ", 5548, "+", 5549, 2, true);
#nullable restore
#line 127 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
WriteAttributeValue(" ", 5550, item.Id, 5551, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5559, ");", 5559, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 128 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 129 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(item.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 130 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
                   Write(item.NumberOfSells);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr");
            BeginWriteAttribute("id", " id=\"", 5767, "\"", 5803, 2);
            WriteAttributeValue("", 5772, "PlanCreatedDescription_", 5772, 23, true);
#nullable restore
#line 132 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
WriteAttributeValue("", 5795, item.Id, 5795, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 133 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 135 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Administration\GetUserDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerDetails_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
