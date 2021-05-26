#pragma checksum "C:\Users\saudi\OneDrive\Radna površina\WebApp\DiplomskiRad\Views\Program\GetSearchPlansOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83416973cf3e5f1b84fab48ce3a12ff128d4c0b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_GetSearchPlansOptions), @"mvc.1.0.view", @"/Views/Program/GetSearchPlansOptions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83416973cf3e5f1b84fab48ce3a12ff128d4c0b1", @"/Views/Program/GetSearchPlansOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b3b305ba8f7e84ffe4999644d8cfa33b7cf93a", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_GetSearchPlansOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>
    <label>Add places, historical architecutre, transportation, food and other tags to search for plans that offer what you need.</label>
    <div class=""flex-section-row h-200 overflow-hidden border-bottom"">
        <div class=""flex-section-row-child-50 flex-section-column padding-20"">
            <input placeholder=""search.."" oninput=""javascript: GetTags();"" id=""TagSearch"" />
            <div class=""div-section-list-item overflow-auto"" id=""TagsAjax"">

            </div>
        </div>
        <div class=""flex-section-row-child-50 flex-section-column padding-20"">
            <p class=""d-flex justify-content-between align-items-center background-light text-color-white padding-5 margin-0"">
                You are searching for..
            </p>
            <ul class=""list-group text-decoration-none border-left-0 overflow-auto"" id=""TagsList"">
            </ul>
        </div>
    </div>
    <br />

    <div id=""PlansList"" class=""list-group"">

    </div>

</div>


");
            WriteLiteral(@"<div class=""modal fade"" id=""infoModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""infoModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""infoModalLabel""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""modalContent"">
                
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>



<script>
    function GetTags() {
        var keyword = $(""#TagSearch"").val();
        $.get(""/Program/GetTags?Keyword="" + keyword, function (result, status) {
            if (status == ""success"") {
        ");
            WriteLiteral(@"        $(""#TagsAjax"").html(result);
            }
        });
    }

    function AddChoosenTag(TagId, TagName) {
        if (document.getElementById(""Tag_"" + TagId) != null)
            return;

        var li = document.createElement(""li"");
        li.id = ""Tag_"" + TagId;
        li.innerText = TagName;
        li.classList = ""d-flex justify-content-between align-items-center padding-5"";

        var span = document.createElement(""span"");
        span.className = ""badge badge-primary badge-pill"";
        span.onclick = () => {
            li.remove();
            UpdatePlansList();
        };

        var x = document.createElement(""a"");
        x.innerHTML = ""X"";
        x.classList = ""cursor"";

        span.appendChild(x);
        li.appendChild(span);
        document.getElementById(""TagsList"").appendChild(li);
        UpdatePlansList();

    }

    function UpdatePlansList() {
        var tags = $(""#TagsList"").children(""li"");
        if (tags.length <= 0) {
          ");
            WriteLiteral(@"  $(""#PlansList"").html("""");
            return;
        }
        var tagList = new Array();
        for (var i = 0; i < tags.length; i++) {
            tagList.push(tags[i].id);
        }
        $.get(""/Program/GetPrograms?TagList="" + tagList, function (result, status) {
            if (status == ""success"") {
                $(""#PlansList"").html(result);
            }
        });
    }

    function GetTagInfo(TagId) {
        $.get(""/Program/GetTagInfo?TagId="" + TagId, function (result, status) {
            if (status == ""success"") {
                var r = JSON.parse(JSON.stringify(result));
                $(""#infoModalLabel"").html(r.name);
                $(""#modalContent"").html(r.description);
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
