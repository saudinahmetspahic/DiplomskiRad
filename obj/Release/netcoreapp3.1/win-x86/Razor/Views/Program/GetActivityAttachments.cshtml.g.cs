#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34720917483d130002cbf3b5dc41cadf8ee3c77"
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
using WebApp.ViewModels.Program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34720917483d130002cbf3b5dc41cadf8ee3c77", @"/Views/Program/GetActivityAttachments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_GetActivityAttachments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetActivityAttachments_VM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("attachment-image object-fit-contain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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



<div class=""position-relative d-flex flex-wrap justify-content-start w-100 border-custom-light padding-5 max-height-300 overflow-auto margin-5"">
    <button onclick=""javascript: ClearAttachments(this);"" class=""padding-5 zIndexUp close-button""><i class=""bi bi-x""></i></button>

");
#nullable restore
#line 10 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
     foreach (var attachment in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex w-100 margin-bottom-20\">\r\n");
#nullable restore
#line 13 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
               var image = string.IsNullOrEmpty(attachment.ImageName) ? "default.jpg" : attachment.ImageName; 

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c34720917483d130002cbf3b5dc41cadf8ee3c775099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 648, "~/Images/Administration/", 648, 24, true);
#nullable restore
#line 14 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
AddHtmlAttributeValue("", 672, image, 672, 6, false);

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
            WriteLiteral("\r\n            <div class=\"w-100 d-flex\">\r\n                <div class=\"d-flex flex-column flex-1 align-items-center\">\r\n                    <h6 class=\"attachment-type align-self-start\">");
#nullable restore
#line 17 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
                                                            Write(attachment.TypeOfAttachment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h3 class=\"attachment-title flex-1\">");
#nullable restore
#line 18 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
                                                   Write(attachment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\" zIndexUp\"");
            BeginWriteAttribute("onmouseover", " onmouseover=\"", 996, "\"", 1057, 4);
            WriteAttributeValue("", 1010, "ShowHoverInfo(this,", 1010, 19, true);
            WriteAttributeValue(" ", 1029, "\'", 1030, 2, true);
#nullable restore
#line 18 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1031, attachment.Description, 1031, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1054, "\');", 1054, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-info-circle-fill font-size-13px\"></i></span></h3>\r\n                    <h6 class=\"attachment-price min-w-130\">Price: <strong>");
#nullable restore
#line 19 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
                                                                     Write(Math.Round(attachment.PriceToVisit, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" BAM (");
#nullable restore
#line 19 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
                                                                                                                   Write(Math.Round(attachment.PriceToVisit / 1.95, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €)</strong></h6>\r\n                </div>\r\n                <button class=\"margin-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1376, "\"", 1485, 10);
            WriteAttributeValue("", 1386, "javascript:", 1386, 11, true);
            WriteAttributeValue(" ", 1397, "AddAttachmentToActivity(\'", 1398, 26, true);
#nullable restore
#line 21 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1423, attachment.Id, 1423, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1437, "\',", 1437, 2, true);
            WriteAttributeValue(" ", 1439, "\'", 1440, 2, true);
#nullable restore
#line 21 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1441, attachment.ActivityId, 1441, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1463, "\',", 1463, 2, true);
            WriteAttributeValue(" ", 1465, "\'", 1466, 2, true);
#nullable restore
#line 21 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
WriteAttributeValue("", 1467, attachment.Day, 1467, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1482, "\');", 1482, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-plus font-size-20px\"></i></button>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetActivityAttachments.cshtml"
                    

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