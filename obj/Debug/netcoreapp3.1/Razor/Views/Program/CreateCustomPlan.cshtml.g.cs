#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d1eb70171c370d626bd373d6e846d466bda0d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_CreateCustomPlan), @"mvc.1.0.view", @"/Views/Program/CreateCustomPlan.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml"
using WebApp.ViewModels.Program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d1eb70171c370d626bd373d6e846d466bda0d0", @"/Views/Program/CreateCustomPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_CreateCustomPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateCustomProgram_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""padding-bottom-50"">
    <div id=""CreateProgramDiv"">
        <h3 class=""margin-0"">Create new program</h3>
        <p>
            Here you can design completely new program for yourself. You can pick places you want to visit, things you want to do, food you want to eat. Build your own
            experience while visiting Bosnia and Herzegovina.
        </p>

        <h5>Start by giving a title to your program</h5>
        <input placeholder=""My program"" id=""ProgramName"" type=""text"" />
        <h6 id=""ProgramNameWarning"" class=""text-color-red hidden"">This program name is not valid or is already in use.</h6>

        <p class=""margin-top-25"">Program you create will be private by default.</p>
        <button onclick=""javascript: CreateProgram();"" class=""btn-primary padding-5"">START CREATING PROGRAM</button>

        <div class=""flex-section-row justify-content-between align-items-center sectionMargin"">
            <div class=""horizontal-line w-15""></div>
            <h6 class=""padd");
            WriteLiteral(@"ing-5"">or</h6>
            <div class=""horizontal-line w-75""></div>
        </div>

        <p>
            You can keep modifying your previous programs. You can only modify programs that are not yet accepted by administration. Otherwise conntact administration
            and demand to allow you to do that by changeing program status. Once you change program it will demand administration approval again.
        </p>

        <table class=""table"">
            <thead class=""table-primary"">
                <tr>
                    <th>Title</th>
                    <th>Created</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 38 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml"
                 foreach (var program in Model.OldPrograms)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"cursor focus-border\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1888, "\"", 1986, 10);
            WriteAttributeValue("", 1898, "javascript:", 1898, 11, true);
            WriteAttributeValue(" ", 1909, "LoadProgram(\'", 1910, 14, true);
#nullable restore
#line 40 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml"
WriteAttributeValue("", 1923, program.Id, 1923, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1934, "\',", 1934, 2, true);
            WriteAttributeValue(" ", 1936, "\'", 1937, 2, true);
#nullable restore
#line 40 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml"
WriteAttributeValue("", 1938, program.Title, 1938, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1952, "\',", 1952, 2, true);
            WriteAttributeValue(" ", 1954, "\'BuildProgramDiv\',", 1955, 19, true);
            WriteAttributeValue(" ", 1973, "true,", 1974, 6, true);
            WriteAttributeValue(" ", 1979, "true);", 1980, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml"
                       Write(program.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml"
                       Write(program.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\CreateCustomPlan.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n    <div id=\"BuildProgramDiv\" class=\"hidden margin-bottom-20\">\r\n");
            WriteLiteral(@"
        <!--<div class=""div-section-list-item focus-border"">
        <div class=""d-flex justify-content-around"">
                <div class=""row d-flex flex-column"">
                    <input placeholder=""Search.."" onclick=""javascript: SearchActivites('Day_1_ActivitiesAjax');"" />
                    <div id=""Day_1_ActivitiesAjax"" class=""div-section-list-item"">
                        <p>1</p>
                        <p>2</p>
                        <p>3</p>
                    </div>
                </div>
                <div class=""row flex-section-column justify-content-between"">
                    <div id=""Day_1_ActivityDetailsAjax"">
                        <p>test</p>
                    </div>
                    <button>Add this acitvity</button>
                </div>
            </div>-->
        <!--<div class=""d-flex row justify-content-between margin-side-10 border-bottom cursor"" onclick=""javascript: CollapseDiv('DayID_1_Activity_Attachments');"">
            <h6>Activity 1</h");
            WriteLiteral(@"6>
            <input type=""time"" value=""12:00"" />
        </div>
        <div class=""d-flex row justify-content-around overflow-hidden padding-0"" id=""DayID_1_Activity_Attachments"">
            <p>Description</p>
            <div class=""div-section-list-item"">-->
");
            WriteLiteral("        <!--<input placeholder=\"Search..\" />\r\n            <div id=\"AttachmentIdAjax\" class=\"h-50 scroll-allow\">\r\n                <p>1</p>\r\n                <p>2</p>\r\n                <p>3</p>\r\n            </div>\r\n        </div>\r\n        <div>-->\r\n");
            WriteLiteral("        <!--<div class=\"div-section-list-item\">\r\n                    <p>Attch 1 10BAM</p>\r\n                    <p>Attch 2 12BAM</p>\r\n                    <p>Attch 3 29BAM</p>\r\n                </div>\r\n            </div>\r\n        </div>-->\r\n");
            WriteLiteral(@"
    </div>



    <div>
        <button id=""AddDayButtonID"" onclick=""javascript: AddDay(0, true);"" class=""btn-danger w-50 div-align-center padding-5 margin-0 hidden""><i class=""bi bi-plus-circle-fill""></i> ADD NEW DAY</button>
        <section class=""margin-top-50 border-top border-dark"">
            <p>You are done and happy with how your program is built. Click button and order program for yourself or group.</p>
            <button class=""btn-primary padding-5 w-50 div-align-center d-block margin-0"" onclick=""location.href = '/Purchase/PurchaseProgram'"">Purchase</button>
        </section>
    </div>

</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateCustomProgram_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
