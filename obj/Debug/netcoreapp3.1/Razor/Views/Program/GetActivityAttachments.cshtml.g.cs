#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "650fddd588e0a1b3e0cba9398d28e39c10be076d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_GetActivityAttachments), @"mvc.1.0.view", @"/Views/Program/GetActivityAttachments.cshtml")]
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
#line 1 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
using WebApp.ViewModels.Program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"650fddd588e0a1b3e0cba9398d28e39c10be076d", @"/Views/Program/GetActivityAttachments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_GetActivityAttachments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetActivityAttachments_VM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 h-100 object-fit-cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<div class=""position-relative d-flex flex-wrap justify-content-center w-100 border-size-3 border-color-custom"">
    <button onclick=""javascript: ClearAttachments(this);"" class=""border-0 padding-5 position-absolute right0 top0 w-auto h-auto zIndexUp margin-0 background-color-custom text-color-white""><i class=""bi bi-x""></i></button>

");
#nullable restore
#line 10 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
     foreach (var attachment in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card w-300px h-300px cursor overflow-hidden position-relative\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "650fddd588e0a1b3e0cba9398d28e39c10be076d4774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 622, "~/Images/Administration/", 622, 24, true);
#nullable restore
#line 13 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
AddHtmlAttributeValue("", 646, attachment.ImageName, 646, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <h6 class=\"text-align-left text-white padding-5 position-absolute left0 top0\">Price: ");
#nullable restore
#line 15 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
                                                                                            Write(Math.Round(attachment.PriceToVisit, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" BAM (");
#nullable restore
#line 15 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
                                                                                                                                          Write(Math.Round(attachment.PriceToVisit / 1.95, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €)</h6>\r\n            <div class=\"position-absolute padding-5 left0 bottom0\">\r\n                <h6 class=\"text-align-left text-white\">");
#nullable restore
#line 17 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
                                                  Write(attachment.TypeOfAttachment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h3 class=\"text-align-left text-white\">");
#nullable restore
#line 18 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
                                                  Write(attachment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <button class=\"btn-transparent position-absolute top0 left0 w-100 h-100 btn-white-black padding-5 background-animation-3\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1265, "\"", 1374, 10);
            WriteAttributeValue("", 1275, "javascript:", 1275, 11, true);
            WriteAttributeValue(" ", 1286, "AddAttachmentToActivity(\'", 1287, 26, true);
#nullable restore
#line 20 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1312, attachment.Id, 1312, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1326, "\',", 1326, 2, true);
            WriteAttributeValue(" ", 1328, "\'", 1329, 2, true);
#nullable restore
#line 20 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1330, attachment.ActivityId, 1330, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1352, "\',", 1352, 2, true);
            WriteAttributeValue(" ", 1354, "\'", 1355, 2, true);
#nullable restore
#line 20 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1356, attachment.Day, 1356, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1371, "\');", 1371, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-plus font-size-100px\"></i></button>\r\n            <div class=\"btn-transparent position-absolute bottom0 right0 btn-white-black padding-5 zIndexUp\"");
            BeginWriteAttribute("onmouseover", " onmouseover=\"", 1537, "\"", 1595, 3);
            WriteAttributeValue("", 1551, "ShowHoverInfo(this,", 1551, 19, true);
            WriteAttributeValue(" ", 1570, "\'", 1571, 2, true);
#nullable restore
#line 21 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1572, attachment.Description, 1572, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-info-circle-fill font-size-20px\"></i></div>\r\n");
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 40 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\GetActivityAttachments.cshtml"
                    
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetActivityAttachments_VM>> Html { get; private set; }
    }
}
#pragma warning restore 1591