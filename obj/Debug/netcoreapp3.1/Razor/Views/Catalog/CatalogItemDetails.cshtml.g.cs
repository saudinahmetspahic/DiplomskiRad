#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Catalog\CatalogItemDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4115f04e7bcfada69afebcdd8f4c0066cfc05b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_CatalogItemDetails), @"mvc.1.0.view", @"/Views/Catalog/CatalogItemDetails.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Catalog\CatalogItemDetails.cshtml"
using WebApp.ViewModels.Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4115f04e7bcfada69afebcdd8f4c0066cfc05b5", @"/Views/Catalog/CatalogItemDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_CatalogItemDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogPreview_VM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n    <div class=\"w-100 max-height-500\">\r\n");
#nullable restore
#line 7 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Catalog\CatalogItemDetails.cshtml"
           var image = string.IsNullOrEmpty(Model.ImageName) ? "default.jpg" : Model.ImageName; 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 222, "\"", 257, 2);
            WriteAttributeValue("", 228, "/Images/Administration/", 228, 23, true);
#nullable restore
#line 8 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Catalog\CatalogItemDetails.cshtml"
WriteAttributeValue("", 251, image, 251, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"object-fit-cover w-100 h-300px\"");
            BeginWriteAttribute("alt", " alt=\"", 297, "\"", 303, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"max-width-700px padding-20 div-align-center\">\r\n        <h5>");
#nullable restore
#line 11 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Catalog\CatalogItemDetails.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p>");
#nullable restore
#line 12 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Catalog\CatalogItemDetails.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogPreview_VM> Html { get; private set; }
    }
}
#pragma warning restore 1591
