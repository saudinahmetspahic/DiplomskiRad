#pragma checksum "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\CreateCustomnPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cf41596c95a4cb2ea42dce06c0b184f1f7314fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_CreateCustomnPlan), @"mvc.1.0.view", @"/Views/Program/CreateCustomnPlan.cshtml")]
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
#line 2 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\CreateCustomnPlan.cshtml"
using WebApp.ViewModels.Program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf41596c95a4cb2ea42dce06c0b184f1f7314fb", @"/Views/Program/CreateCustomnPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_CreateCustomnPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateCustomProgram_VM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Model_ProgramName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8cf41596c95a4cb2ea42dce06c0b184f1f7314fb3702", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 6 "C:\Users\saudi\source\repos\WebApp\WebApp\Views\Program\CreateCustomnPlan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.ProgramName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div id=""PlanNameId""><h3 class=""cursor margin-bottom-50"" onclick=""javascript: RenamePlane();"">My plan</h3></div>


    <div id=""DaysId"" class=""div-section-list-item "">
        <div id=""1"" class=""list-item text-align-left margin-bottom-20"">
            <div class=""d-flex row justify-content-between margin-side-10 cursor"">
                <h5 onclick=""javascript: CollapseDiv('DayID_1_Activities');"">Day 1</h5>
                <button onclick=""javascript: ChooseActivity('DayID_1_Activities', 1);"" class=""btn-danger"">+ Activity</button>
            </div>
            <div class=""div-section-list-item overflow-hidden"" id=""DayID_1_Activities"">

                <!--<div class=""div-section-list-item focus-border"">
                <div class=""d-flex justify-content-around"">
                        <div class=""row d-flex flex-column"">
                            <input placeholder=""Search.."" onclick=""javascript: SearchActivites('Day_1_ActivitiesAjax');"" />
                            <div id=""Day_1_A");
            WriteLiteral(@"ctivitiesAjax"" class=""div-section-list-item"">
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
                    <h6>Activity 1</h6>
                    <input type=""time"" value=""12:00"" />
                </div>
                <div class=""d-flex row justify-content-around overflow-hidden padding-0"" id=""DayID_1_Activity_Attachments"">
  ");
            WriteLiteral("                  <p>Description</p>\r\n                    <div class=\"div-section-list-item\">-->\r\n");
            WriteLiteral(@"                <!--<input placeholder=""Search.."" />
                    <div id=""AttachmentIdAjax"" class=""h-50 scroll-allow"">
                        <p>1</p>
                        <p>2</p>
                        <p>3</p>
                    </div>
                </div>
                <div>-->
");
            WriteLiteral(@"                <!--<div class=""div-section-list-item"">
                            <p>Attch 1 10BAM</p>
                            <p>Attch 2 12BAM</p>
                            <p>Attch 3 29BAM</p>
                        </div>
                    </div>
                </div>-->
");
            WriteLiteral(@"            </div>
        </div>

    </div>
    <button onclick=""javascript: AddNewDay();"" class=""btn-success"">+ Day</button>
</div>

<script>

    function AddActivityToDay(e, ActivityId, Description) {
        var counter = e.parentElement.id.substr(4, 1);
        var outputdiv = e.parentElement.parentElement.parentElement.parentElement.id;

        $(""#ChooseActivityBox_"" + counter).remove();
        AddNewActivity(counter, outputdiv, Description);
        //var parentDiv = document.getElementById(""DayID_"" + counter + ""_Activities"");

        //var mainDiv = document.createElement(""div"");
    }

    function CollapseDiv(id) {
        if ($(""#"" + id).css(""maxHeight"") !== ""0px"")
            $(""#"" + id).css(""maxHeight"", ""0px"");
        else
            $(""#"" + id).css(""maxHeight"", ""100%"");
    }

    var showActivityDetailsDiv;

    function SearchActivites(DivId, value, counter) {
        $.get(""/Program/GetActivitiesAjax?Value="" + value, function (result, status) {
         ");
            WriteLiteral(@"   if (status === ""success"") {
                $(""#"" + DivId).html(result);
                showActivityDetailsDiv = ""Day_"" + counter + ""_ActivityDetailsAjax"";
            }
        });
    }

    function ShowActivityDetails(e, ActivityId) {
        // var counter = parseint(e.parentElement.id.substr(3, 1));
        var counter = e.parentElement.id.substr(6, 1);
        $.get(""/Program/GetActivityDetailsAjax?ActivityId="" + ActivityId, function (result, status) {
            if (status === ""success"") {
                $(""#Day_"" + counter + ""_ActivityDetailsAjax"").html(result);
            }
        });
    }

    function ChooseActivity(day, counter) {

        var maindiv = document.createElement(""div"");
        maindiv.id = ""ChooseActivityBox_"" + day.substr(6, 1);
        maindiv.className = ""d-flex justify-content-around"";

        var innerdiv1 = document.createElement(""div"");
        innerdiv1.className = ""row d-flex flex-column"";

        var input = document.createElement(""inp");
            WriteLiteral(@"ut"");
        input.placeholder = ""Search.."";
        input.oninput = function () {
            SearchActivites(""Day_"" + counter + ""_ActivitiesAjax"", input.value, counter);
            sessionStorage.setItem(""counter"", counter.toString());
        };

        var innerdiv1_innerdiv = document.createElement(""div"");
        innerdiv1_innerdiv.id = day + ""Ajax"";
        innerdiv1_innerdiv.className = ""div-section-list-item"";

        innerdiv1.appendChild(input);
        innerdiv1.appendChild(innerdiv1_innerdiv);

        var innerdiv2 = document.createElement(""div"");
        innerdiv2.className = ""row flex-section-column justify-content-between"";

        var innerdiv2_innerdiv = document.createElement(""div"");
        innerdiv2_innerdiv.id = ""Day_"" + counter + ""_ActivityDetailsAjax"";

        //var button = document.createElement(""button"");
        //button.innerHTML = ""Add this acitvity"";

        innerdiv2.appendChild(innerdiv2_innerdiv);
        //innerdiv2.appendChild(button);

   ");
            WriteLiteral(@"     maindiv.appendChild(innerdiv1);
        maindiv.appendChild(innerdiv2);

        document.getElementById(day).appendChild(maindiv);
        SearchActivites(day + ""Ajax"", """");
    }

    function ChangeArrow(arrow) {
        if (arrow.className === ""bi bi-caret-up-fill"")
            arrow.className = ""bi bi-caret-down-fill"";
        else
            arrow.className = ""bi bi-caret-up-fill"";
    }

    function AddNewActivity(day, outputdiv, description) {
        var counter = $(""#"" + day + "" .activity"").length + 1;

        var maindiv = document.createElement(""div"");
        maindiv.className = ""div-section-list-item focus-border activity"";

        var innerdiv_1 = document.createElement(""div"");
        innerdiv_1.className = ""d-flex row justify-content-between margin-side-10 border-bottom cursor"";

        var headerdiv = document.createElement(""div"");
        headerdiv.className = ""flex-section-row"";
        var iele = document.createElement(""i"");
        iele.className = ""bi");
            WriteLiteral(@" bi-caret-up-fill"";

        var h6 = document.createElement(""h6"");
        h6.innerHTML = ""Activity "" + counter;
        h6.onclick = function () {
            CollapseDiv(day + ""_"" + counter + ""_Activity_Attachments"");
            ChangeArrow(iele);
        };
        headerdiv.appendChild(iele);
        headerdiv.appendChild(h6);

        var input = document.createElement(""input"");
        input.type = ""time"";
        input.value = ""12:00"";

        innerdiv_1.appendChild(headerdiv);
        innerdiv_1.appendChild(input);

        var innerdiv_2 = document.createElement(""div"");
        innerdiv_2.className = ""d-flex row justify-content-around overflow-hidden padding-0"";
        innerdiv_2.id = day + ""_"" + counter + ""_Activity_Attachments"";

        var p = document.createElement(""p"");
        p.innerHTML = description;
        var innerdiv1 = document.createElement(""div"");
        innerdiv1.className = ""div-section-list-item"";
        var input = document.createElement(""input"");");
            WriteLiteral(@"
        input.type = ""text"";
        input.placeholder = ""Search.."";
        input.oninput = function () {
            // searching attachments
        };
        var div2 = document.createElement(""div"");
        div2.className = ""h-50 scroll-allow"";
        div2.id = ""AttachmentIdAjax"";
        innerdiv1.appendChild(input);
        innerdiv1.appendChild(div2);

        var innerdiv2 = document.createElement(""div""); // added attachments
        innerdiv2.classList = ""div-section-list-item"";


        innerdiv_2.appendChild(p);
        innerdiv_2.appendChild(innerdiv1);
        innerdiv_2.appendChild(innerdiv2);

        maindiv.appendChild(innerdiv_1);
        maindiv.appendChild(innerdiv_2);

        document.getElementById(outputdiv).append(maindiv);
    }

    function AddNewDay() {
        var counter = document.getElementById(""DaysId"").children.length + 1;

        var maindiv = document.createElement(""div"");
        maindiv.id = counter;
        maindiv.className = ""list-i");
            WriteLiteral(@"tem text-align-left margin-bottom-20"";

        var maindiv_child_1 = document.createElement(""div"");
        maindiv_child_1.className = ""d-flex row justify-content-between margin-side-10 cursor"";

        var h5 = document.createElement(""h5"");
        h5.innerHTML = ""Day "" + counter;
        h5.onclick = function () {
            CollapseDiv(""DayID_"" + counter + ""_Activities"");
        };

        var bttnActivity = document.createElement(""button"");
        bttnActivity.classList = ""btn-danger"";
        bttnActivity.innerHTML = ""+ Activity"";
        bttnActivity.onclick = function () {
            ChooseActivity(""DayID_"" + counter + ""_Activities"", counter);

            //AddNewActivity(""DayID_"" + counter + ""_Activities"");
        };

        maindiv_child_1.appendChild(h5);
        maindiv_child_1.appendChild(bttnActivity);

        var maindiv_child_2 = document.createElement(""div"");
        maindiv_child_2.id = ""DayID_"" + counter + ""_Activities"";
        maindiv_child_2.classList ");
            WriteLiteral(@"= ""div-section-list-item overflow-hidden"";

        maindiv.appendChild(maindiv_child_1);
        maindiv.appendChild(maindiv_child_2);
        document.getElementById(""DaysId"").appendChild(maindiv);


        //var activity_innerdiv_1 = document.createElement(""div"");
        //activity_innerdiv_1.classList = ""d-flex row justify-content-between margin-side-10 border-bottom cursor"";
        //activity_innerdiv_1.onclick = function () {
        //    CollapseDiv(""DayID_"" + counter + ""_Activity_Attachments"");
        //};

        //var activity_innerdiv_2 = document.createElement(""div"");
        //activity_innerdiv_2.classList = ""d-flex row justify-content-around overflow-hidden padding-0"";




        //var h5 = document.createElement(""h5"");
        //h5.innerHTML = ""Day "" + counter;

        //var bttn = document.createElement(""button"");
        //bttn.classList = ""btn-danger cursor"";
        //bttn.innerHTML = ""+ Activity"";
        //bttn.onclick = function () {
        //    AddNew");
            WriteLiteral(@"Activity(counter);
        //}

        //var innerdiv1 = document.createElement(""div"");
        //innerdiv1.classList = ""d-flex row justify-content-between margin-side-10"";
        //innerdiv1.appendChild(h5);
        //innerdiv1.appendChild(bttn);

        //var innerdiv2 = document.createElement(""div"");
        //innerdiv2.classList = ""div-section-list-item"";



        //div.append(innerdiv1);
        //div.append(innerdiv2);

        //var parent = document.getElementById(""DaysId"");
        //parent.appendChild(div);
    }

    function RenamePlane() {
        var div = document.createElement(""div"");
        div.id = ""RenamePlanId"";
        div.className = ""flex-section-row justify-content-center"";
        var input = document.createElement(""input"");
        input.placeholder = ""Enter your plan name"";

        var ok = document.createElement(""span"");
        ok.innerHTML = ""&#x2714;"";
        ok.style.border = ""1px solid gray"";
        ok.style.cursor = ""pointer"";
        o");
            WriteLiteral(@"k.onclick = function (e) {
            var val = input.value;
            if (val == """")
                return;
            var h3 = document.createElement(""h3"");
            h3.onclick = RenamePlane;
            h3.innerHTML = val;
            document.getElementById(""RenamePlanId"").remove();
            document.getElementById(""PlanNameId"").appendChild(h3);
            document.getElementById(""Model_ProgramName"").val(val);
        };


        div.append(input);
        div.append(ok);

        var planNameDiv = document.getElementById(""PlanNameId"");
        planNameDiv.innerHTML = """";
        planNameDiv.appendChild(div);


    }
</script>");
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
