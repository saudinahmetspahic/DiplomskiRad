#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f40d6cfd8a954eb30214313f96f750594cec8830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_PurchaseProgram), @"mvc.1.0.view", @"/Views/Purchase/PurchaseProgram.cshtml")]
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
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
using WebApp.ViewModels.Purchase;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40d6cfd8a954eb30214313f96f750594cec8830", @"/Views/Purchase/PurchaseProgram.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_PurchaseProgram : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAvailablePrograms_VM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
  
    var myprograms = Model.Where(w => w.CreatedByMe == true).ToList();
    var otherprograms = Model.Where(w => w.CreatedByMe == false).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
 if (myprograms.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>You created these programs and you are just one click away from us. Purchase now! (Only allowed programs can be ordered)</p>\r\n    <section class=\"margin-bottom-50 margin-top-5\">\r\n");
#nullable restore
#line 14 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
         foreach (var myprogram in myprograms)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"padding-20 margin-bottom-20 box-shadow-small\">\r\n                <div>\r\n                    <h3 class=\"text-uppercase\">");
#nullable restore
#line 18 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                                          Write(myprogram.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"max-height-300 overflow-auto\">");
#nullable restore
#line 19 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                                                       Write(myprogram.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"d-flex justify-content-around align-items-center border-top border-dark padding-5\">\r\n                    <h5>Number of sells</h5>\r\n                    <h5>");
#nullable restore
#line 23 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                   Write(myprogram.NumberOfSells);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Number of customers involved</h5>\r\n                    <h5>");
#nullable restore
#line 25 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                   Write(myprogram.NumberOfCustomersPurcheses);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Expected price</h5>\r\n                    <h5>");
#nullable restore
#line 27 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                    Write(Math.Round(myprogram.ExpectedPrice / 1.95, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</h5>\r\n                </div>\r\n                <div class=\"d-flex justify-content-center align-items-center\">\r\n                    <button class=\"w-300px btn-info padding-5 margin-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1459, "\"", 1538, 5);
            WriteAttributeValue("", 1469, "location.href", 1469, 13, true);
            WriteAttributeValue(" ", 1482, "=", 1483, 2, true);
            WriteAttributeValue(" ", 1484, "\'/Program/ShowProgramDetails?ProgramId=", 1485, 40, true);
#nullable restore
#line 30 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
WriteAttributeValue("", 1524, myprogram.Id, 1524, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1537, "\'", 1537, 1, true);
            EndWriteAttribute();
            WriteLiteral(">More details</button>\r\n                    <button class=\"w-300px btn-primary padding-5 margin-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1637, "\"", 1711, 5);
            WriteAttributeValue("", 1647, "location.href", 1647, 13, true);
            WriteAttributeValue(" ", 1660, "=", 1661, 2, true);
            WriteAttributeValue(" ", 1662, "\'/Purchase/OrderProgram?ProgramId=", 1663, 35, true);
#nullable restore
#line 31 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
WriteAttributeValue("", 1697, myprogram.Id, 1697, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1710, "\'", 1710, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Order</button>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 1773, "\"", 1809, 2);
            WriteAttributeValue("", 1778, "ProgramPreviewDiv_", 1778, 18, true);
#nullable restore
#line 33 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
WriteAttributeValue("", 1796, myprogram.Id, 1796, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n");
#nullable restore
#line 39 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
 if (otherprograms.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Check these programs as well. Read details and click \'Order\' if you want to experience what it offers you.</p>\r\n    <section>\r\n");
#nullable restore
#line 44 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
         foreach (var otherprogram in otherprograms)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"padding-20 background-lightgray box-shadow-small margin-top-5\">\r\n                <div class=\"w-50\">\r\n                    <h3>");
#nullable restore
#line 48 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                   Write(otherprogram.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 49 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                  Write(otherprogram.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"d-flex justify-content-around align-items-center border-top border-dark padding-5\">\r\n                    <h5>Number of sells</h5>\r\n                    <h5>");
#nullable restore
#line 53 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                   Write(otherprogram.NumberOfSells);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Number of customers involved</h5>\r\n                    <h5>");
#nullable restore
#line 55 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                   Write(otherprogram.NumberOfCustomersPurcheses);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5>Expected price</h5>\r\n                    <h5>");
#nullable restore
#line 57 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
                    Write(Math.Round(otherprogram.ExpectedPrice / 1.95, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</h5>\r\n                </div>\r\n                <div class=\"d-flex justify-content-center align-items-center\">\r\n                    <button class=\"w-300px btn-info padding-5 margin-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3028, "\"", 3110, 5);
            WriteAttributeValue("", 3038, "location.href", 3038, 13, true);
            WriteAttributeValue(" ", 3051, "=", 3052, 2, true);
            WriteAttributeValue(" ", 3053, "\'/Program/ShowProgramDetails?ProgramId=", 3054, 40, true);
#nullable restore
#line 60 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
WriteAttributeValue("", 3093, otherprogram.Id, 3093, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3109, "\'", 3109, 1, true);
            EndWriteAttribute();
            WriteLiteral(">More details</button>\r\n                    <button class=\"w-300px btn-primary padding-5 margin-5\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3209, "\"", 3286, 5);
            WriteAttributeValue("", 3219, "location.href", 3219, 13, true);
            WriteAttributeValue(" ", 3232, "=", 3233, 2, true);
            WriteAttributeValue(" ", 3234, "\'/Purchase/OrderProgram?ProgramId=", 3235, 35, true);
#nullable restore
#line 61 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
WriteAttributeValue("", 3269, otherprogram.Id, 3269, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3285, "\'", 3285, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Order</button>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 3348, "\"", 3387, 2);
            WriteAttributeValue("", 3353, "ProgramPreviewDiv_", 3353, 18, true);
#nullable restore
#line 63 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
WriteAttributeValue("", 3371, otherprogram.Id, 3371, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n");
#nullable restore
#line 69 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
 if (myprograms.Count() == 0 && otherprograms.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"text-center\">No approved programs found.</h2>\r\n    <h4 class=\"text-center\">If you created a program and you want to purchase it, your program has to be approved by administrators first.</h4>\r\n");
#nullable restore
#line 75 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Purchase\PurchaseProgram.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAvailablePrograms_VM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
