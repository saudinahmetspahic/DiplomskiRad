#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcd5f3bd56a6b08a1b559f177753c5eeaadd1bd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd5f3bd56a6b08a1b559f177753c5eeaadd1bd8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/kravice.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Kravice"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Home\Index.cshtml"
  
    Layout = "_LandingPageLayout";
    var msg = (string)TempData["msg"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Home\Index.cshtml"
 if (msg != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"warning-message\">");
#nullable restore
#line 7 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Home\Index.cshtml"
                            Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 8 "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    setTimeout(function () {\r\n        $(\".warning-message\").remove();\r\n    }, 4000);\r\n</script>\r\n\r\n<div>\r\n    <div class=\"position-relative margin-bottom-50\">\r\n        <div id=\"top-image\" class=\"custom-section h-80perc\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fcd5f3bd56a6b08a1b559f177753c5eeaadd1bd84968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div id=""programsPreview"" class=""font-family-ubuntu"">

        </div>
    </div>

    <div>
        <div class=""presentation-section"">
            <img class=""presentation-section-bg"" src=""/Images/pyramid.jpg"" alt=""Alternate Text"" />
            <div class=""presentation-section-image"">
                <img src=""/Images/semir_osmanagic.jpg"" alt=""Alternate Text"" />
            </div>
            <div class=""presentation-section-info"">
                <h4>Pyramids</h4>
                <p>Our friend Dr. Semir Osmanagic is responsible for discovering the pyramids in the city of Visoko. Many people with health problems come to the pyramids because of the negative jonahs, the tunnels that lead to the heart of the pyramid, but also because of the parks on the surface of the pyramid.</p>
            </div>
        </div>
        <div class=""presentation-section"">
            <img class=""presentation-section-bg"" src=""/Images/pyramid.jpg"" alt=""Alternate Text"" />
            <d");
            WriteLiteral(@"iv class=""presentation-section-info"">
                <h4>Pyramids</h4>
                <p>Our friend Dr. Semir Osmanagic is responsible for discovering the pyramids in the city of Visoko. Many people with health problems come to the pyramids because of the negative jonahs, the tunnels that lead to the heart of the pyramid, but also because of the parks on the surface of the pyramid.</p>
            </div>
            <div class=""presentation-section-image"">
                <img src=""/Images/semir_osmanagic.jpg"" alt=""Alternate Text"" />
            </div>
        </div>
    </div>

");
            WriteLiteral("\r\n");
            WriteLiteral("    <div id=\"sponsors\" class=\"sectionMargin\">\r\n\r\n    </div>\r\n\r\n");
            WriteLiteral(@"    <div id=""contact-lists-div"" class=""flex-section-row justify-content-around padding-50 background-gainsboro user-select-none"">
        <div class=""contact-list"">
            <h5 class=""card-title text-center"">&#128222; Contact</h5>
            <ul class=""w-50 div-align-center"">
                <li><i class=""fa fa-envelope""></i> respectzajim@gmail.com</li>
                <li><i class=""fa fa-phone-square""></i> <i class=""fa fa-comment""></i> +387/62-973-830</li>
");
            WriteLiteral(@"                <li><i class=""fa fa-facebook-official""></i> Facebook</li>
            </ul>
        </div>
        <div class=""contact-list"">
            <h5 class=""card-title text-center"">&#127758; Location</h5>
            <ul class=""w-50 div-align-center"">
                <li>We are located in Zenica</li>
                <li>Bosnia and Herzegovina</li>
                <li>Street Branilaca Bosne 14</li>
");
            WriteLiteral(@"            </ul>
        </div>
    </div>




    <footer class=""padding-20 border-top text-muted"">
        <div class=""container"">
            &copy; 2021 - New Respect - Travel Agency
        </div>
    </footer>


    <script>
        $(document).scroll(function () {

            var x = window.innerWidth;
            if (x < 1000)
                return;
            var y = window.scrollY;
            if (y > 50) {
                $(""nav"").addClass(""fixed-nav"");
                $("".moving_logo"").removeClass(""moving_logo_expand"");
            }
            else {
                $(""nav"").removeClass(""fixed-nav"");
                $("".moving_logo"").addClass(""moving_logo_expand"");
            }

        });

        var interval;
        $(document).ready(function () {
            getPrograms([], 3);
            interval = setInterval(function () {
                var ids = [];
                var addedprograms = document.getElementById(""programsPreview"").children;
    ");
            WriteLiteral(@"            for (var i = 0; i < addedprograms.length; i++) {
                    ids.push(addedprograms.item(i).id.split('_')[1]);
                }
                getPrograms(ids, 1);
            }, 7000);

            getSponsors();
        });

        function getPrograms(ids, num) {
            $.ajax({
                url: ""/Program/GetProgramPreviews"",
                method: ""POST"",
                data: {
                    filterIds: ids,
                    numberOfPrograms: num
                },
                success: function (result, status) {
                    if (status === ""success"") {
                        for (var i = 0; i < num; i++) {
                            $(""#programsPreview"").children().first().remove();
                        }
                        $(""#programsPreview"").append(result);
                    }
                },
                error: function (xhr) {
                    if (xhr.status == 406) {
                        // kill");
            WriteLiteral(@"ing interval because there is no need for it as there is no enough programs to show
                        clearInterval(interval);
                    }
                }
            });
        }

        function getSponsors() {
            $.get(""/Sponsor/GetSponsorsInfo"", function (result, status) {
                if (status === ""success"") {
                    $(""#sponsors"").html(result);
                }
            });
        }
    </script>







");
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
