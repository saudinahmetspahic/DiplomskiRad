#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21ac9d0a0b4202f7af744017c5001adc60be1fab"
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
using WebApp.ViewModels.Program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ac9d0a0b4202f7af744017c5001adc60be1fab", @"/Views/Program/RateProgram.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_RateProgram : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RateProgram_VM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RatingProgram", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Program", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n    <h3>Rating ");
#nullable restore
#line 6 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
          Write(Model.ProgramName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21ac9d0a0b4202f7af744017c5001adc60be1fab4420", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21ac9d0a0b4202f7af744017c5001adc60be1fab4686", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 9 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProgramId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
         foreach (var item in Model.Activities)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"d-flex margin-top-50\">\r\n                <input hidden name=\"programId\"");
                BeginWriteAttribute("value", " value=\"", 374, "\"", 398, 1);
#nullable restore
#line 13 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 382, Model.ProgramId, 382, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <img class=\"img-size-200\"");
                BeginWriteAttribute("src", " src=\"", 445, "\"", 485, 2);
                WriteAttributeValue("", 451, "/Images/Administration/", 451, 23, true);
#nullable restore
#line 14 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 474, item.Image, 474, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 486, "\"", 492, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <p class=\"padding-left-50 padding-right-50 text-align-justify\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                <div class=\"w-50 min-w-200 text-center\">\r\n                    <p>\r\n                        Current rate: \r\n");
#nullable restore
#line 21 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
                         for (int i = 0; i < Math.Round((decimal)item.CurrentRate, 0); i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <i class=\"bi bi-star-fill text-color-orange\"></i>\r\n");
#nullable restore
#line 24 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
                         for (int i = 0; i < 5 - Math.Round((decimal)item.CurrentRate, 0); i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <i class=\"bi bi-star-fill text-color-gray\"></i>\r\n");
#nullable restore
#line 28 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </p>\r\n\r\n                    <div class=\"d-flex\">\r\n                        <input type=\"number\" name=\"activities\"");
                BeginWriteAttribute("value", " value=\"", 1349, "\"", 1373, 1);
#nullable restore
#line 32 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 1357, item.ActivityId, 1357, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n                        <input");
                BeginWriteAttribute("oninput", " oninput=\"", 1416, "\"", 1475, 5);
                WriteAttributeValue("", 1426, "javascript:", 1426, 11, true);
                WriteAttributeValue(" ", 1437, "ChangeRate(this,", 1438, 17, true);
                WriteAttributeValue(" ", 1454, "\'", 1455, 2, true);
#nullable restore
#line 33 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 1456, item.ActivityId, 1456, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1472, "\');", 1472, 3, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"range\" name=\"rateArray\" min=\"1\" max=\"5\" value=\"1\" />\r\n                        <div");
                BeginWriteAttribute("id", " id=\"", 1565, "\"", 1598, 2);
                WriteAttributeValue("", 1570, "given_value_", 1570, 12, true);
#nullable restore
#line 34 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
WriteAttributeValue("", 1582, item.ActivityId, 1582, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"w-100\">\r\n");
#nullable restore
#line 35 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
                             for (int i = 0; i < (int)item.GivenRate; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"d-inline-block\">\r\n                                    <i class=\"bi bi-star-fill text-color-orange\"></i>\r\n                                </p>\r\n");
#nullable restore
#line 40 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div> \r\n");
#nullable restore
#line 46 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\RateProgram.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button type=\"submit\" class=\"btn btn-primary w-100px d-block div-align-center\">Rate</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script>
    function ChangeRate(e, id) {
        $(""#given_value_"" + id).html("""");
        for (var i = 0; i < e.value; i++) {
            var p = document.createElement(""p"");
            p.className = ""d-inline-block"";
            var li = document.createElement(""i"");
            li.className = ""bi bi-star-fill text-color-orange"";
            p.appendChild(li);
            document.getElementById(""given_value_"" + id).appendChild(p);
        }
        //$(""#given_value_"" + id).html(e.value);
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
