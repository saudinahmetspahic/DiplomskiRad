#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b84e732cab4ed9cde53e41f43180c0726d1a61e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_RateProgram), @"mvc.1.0.view", @"/Views/Program/RateProgram.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
using WebApp.ViewModels.Program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b84e732cab4ed9cde53e41f43180c0726d1a61e", @"/Views/Program/RateProgram.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_RateProgram : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RateProgram_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n    <h3>Rating ");
#nullable restore
#line 6 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
          Write(Model.ProgramName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
     foreach (var item in Model.Activities)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex max-width-1200px div-align-center margin-top-50 box-shadow-black flex-flow-wrap\">\r\n            <img class=\"img-size-200\"");
            BeginWriteAttribute("src", " src=\"", 307, "\"", 347, 2);
            WriteAttributeValue("", 313, "/Images/Administration/", 313, 23, true);
#nullable restore
#line 10 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 336, item.Image, 336, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 348, "\"", 354, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <p class=\"flex-1 padding-20 padding-right-50 text-align-justify\">\r\n                ");
#nullable restore
#line 12 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
            <div class=""min-w-200 max-width-400px text-center d-flex"">
                <div class=""text-center padding-20"">
                    <p class=""background-purple text-color-white padding-10 min-w-220"">
                        Current rate:
");
#nullable restore
#line 18 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
                         for (int i = 0; i < Math.Round((decimal)item.CurrentRate, 0); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-star-fill text-color-orange\"></i>\r\n");
#nullable restore
#line 21 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
                         for (int i = 0; i < 5 - Math.Round((decimal)item.CurrentRate, 0); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-star-fill text-color-gray\"></i>\r\n");
#nullable restore
#line 25 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 1250, "\"", 1283, 2);
            WriteAttributeValue("", 1255, "given_value_", 1255, 12, true);
#nullable restore
#line 27 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 1267, item.ActivityId, 1267, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\">\r\n");
#nullable restore
#line 28 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
                         for (int i = 0; i < (int)item.GivenRate; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline-block\">\r\n                                <i class=\"bi bi-star-fill text-color-orange\"></i>\r\n                            </p>\r\n");
#nullable restore
#line 33 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <input");
            BeginWriteAttribute("oninput", " oninput=\"", 1654, "\"", 1733, 8);
            WriteAttributeValue("", 1664, "javascript:", 1664, 11, true);
            WriteAttributeValue(" ", 1675, "ChangeRate(this,", 1676, 17, true);
            WriteAttributeValue(" ", 1692, "\'", 1693, 2, true);
#nullable restore
#line 35 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 1694, Model.ProgramId, 1694, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1710, "\',", 1710, 2, true);
            WriteAttributeValue(" ", 1712, "\'", 1713, 2, true);
#nullable restore
#line 35 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 1714, item.ActivityId, 1714, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1730, "\');", 1730, 3, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"range\" name=\"rateArray\" min=\"1\" max=\"5\" value=\"1\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\RateProgram.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>
    function ChangeRate(e, program, activity) {
        $(""#given_value_"" + activity).html("""");
        for (var i = 0; i < e.value; i++) {
            var p = document.createElement(""p"");
            p.className = ""d-inline-block"";
            var li = document.createElement(""i"");
            li.className = ""bi bi-star-fill text-color-orange"";
            p.appendChild(li);
            document.getElementById(""given_value_"" + activity).appendChild(p);
        }
        $.post(""/Program/RatingProgram?ProgramId="" + program + ""&ActivityId="" + activity + ""&Rate="" + e.value);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RateProgram_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
