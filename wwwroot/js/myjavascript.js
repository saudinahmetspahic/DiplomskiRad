/*const { LogLevel } = require("@microsoft/signalr");*/



function CollapseDiv(id) {
    if ($("#" + id).css("maxHeight") !== "0px")
        $("#" + id).css("maxHeight", "0px");
    else
        $("#" + id).css("maxHeight", "100%");
}

$(document).ready(function () {

    $(window).on("resize", function () {
        if (window.innerWidth > 1000) {
            $(".show-mob-menu").removeClass("show-mob-menu");
            $(".show-mob-menu-icon").removeClass("show-mob-menu-icon");
        }

    });

    $("#menu-list-icon").on("click", function () {
        $("#menu-list-ul").toggleClass("show-mob-menu");
        $("#menu-list-icon").toggleClass("show-mob-menu-icon");
    });

    $(".custom-file-input").on("change", function () {
        var filename = $(this).val().split("\\").pop();
        $(this).next(".custom-file-label").html(filename);
    });

})




var connection;

function Message(message) {

    var div = document.createElement("div");
    div.className = "alert alert-info position-fixed fixed-bottom-right margin-5 moving-divs";
    div.role = "alert";
    div.innerHTML = message;

    setTimeout(function () {
        div.remove();

        var alerts = document.getElementsByClassName("moving-divs");
        for (var i = 0; i < alerts.length; i++) {
            alerts[i].style.bottom = (60 * (i % alerts.length)) + "px";
        }

    }, 5000);
    document.body.appendChild(div);


    var alerts = document.getElementsByClassName("moving-divs");
    for (var i = 0; i < alerts.length; i++) {
        alerts[i].style.bottom = (60 * (i % alerts.length)) + "px";
    }
}


function ShowHoverInfo(elem, text) {
    if (document.getElementById("ShowHoverInfoDiv") == null) {
        var e = window.event;
        var posX = e.clientX;
        if (posX + 15 + 250 >= window.innerWidth)
            posX -= 300;
        var posY = e.clientY;

        var div = document.createElement("div");
        div.id = "ShowHoverInfoDiv";
        div.style.padding = "15px 20px";
        div.style.color = "white";
        div.style.backgroundColor = "dodgerblue";
        div.style.border = "1px solid white";
        div.style.borderRadius = "5px";
        div.style.maxWidth = "250px";
        div.innerHTML = "<i class='bi bi-info-square text-color-white'></i><br /><br />";
        div.innerHTML += text;
        div.style.position = "fixed";
        div.style.left = (posX + 15) + "px";
        div.style.top = posY + "px";

        document.body.appendChild(div);

        elem.addEventListener("mouseleave", function () {
            div.remove();
        });
    }
}



// graficki prikaz (klijentska strana)
function LoadProgram(ProgramId, Title, OutPutDiv, Switch, AllowModifications) {
    $.get("/Program/LoadProgramData?ProgramId=" + ProgramId, function (result, status) {
        if (status == "success") {
            if (Switch) {
                $("#CreateProgramDiv").remove();
                $("#BuildProgramDiv").removeClass("hidden");
                $("#AddDayButtonID").removeClass("hidden");
                $("#AddDayButtonID").addClass("d-block");
            }
            $("#" + OutPutDiv).html("");
            $("#BuildProgramDiv").html("");
            //$("#ProgramNameID").val(Title);
            var programname = document.createElement("input");
            programname.id = "ProgramNameID";
            programname.value = Title;
            programname.style.display = "none";

            //<div class="d-flex justify-content-center align-items-center">
            //    <p class="padding-0 margin-5">Check if this program has some feedback. To see it click on button bellow.</p>
            //    <a class="btn btn-secondary padding-5 margin-5" asp-controller="Program" asp-action="GetProgramFeedback" asp-route-ProgramId="">See feedback</a>
            //</div>
            var fbdiv = document.createElement("div");
            fbdiv.className = "d-flex justify-content-center align-items-center margin-20";
            var p = document.createElement("p");
            p.className = "padding-0 margin-5";
            p.textContent = "Check if this program has some feedback. To see it click on button bellow.";
            var a = document.createElement("a");
            a.className = "btn btn-secondary padding-5 margin-5";
            a.textContent = "See feedback";
            a.href = "/Program/AddProgramFeedback?ProgramId=" + ProgramId;
            fbdiv.appendChild(p);
            fbdiv.appendChild(a);

            document.getElementById(OutPutDiv).appendChild(programname);
            document.getElementById(OutPutDiv).appendChild(fbdiv);

            var daysdiv = document.createElement("div");
            daysdiv.id = "DaysDiv";
            document.getElementById(OutPutDiv).appendChild(daysdiv);

            var data = JSON.parse(JSON.stringify(result));
            for (var i = 0; i < data.length; i++) {
                AddToPlan(data[i].day, data[i].activity, data[i].attachment, OutPutDiv, AllowModifications);
            }
        }
    });
    AddAttachment(1, 1, 0);

}

function AddToPlan(day, activity, attachment, outputdiv, allowmodifications) {
    var day_exist = false, activity_exist = false, attachment_exist = false;
    var current_days = $("#DaysDiv").children("div");
    //alert("Ukupno dana: " + current_days.length);
    for (var i = 1; i <= current_days.length; i++) {
        if (current_days[i - 1].id == "DayID_" + day) { // day already added
            //alert("Dan " + day + " postoji");
            day_exist = true;
            var activities = $("#Day_" + day + "_ActivitiesDiv").children("div");
            //alert("Ukupno aktivnosti: " + activities.length);
            for (var j = 1; j <= activities.length; j++) {
                if (activities[j - 1].id == "ActivityID_" + activity) { // activity already added
                    activity_exist = true;
                    //alert("Aktivnosti " + activity + " postoji");
                    var attachments = $("#Day_" + day + "_Activity_" + activity + "_AttachmentsDiv").children("div");
                    for (var z = 1; z <= attachments.length; z++) {
                        if (attachments[z - 1].id == attachment) { // attachment already added
                            attachment_exist = true;
                            //alert("Attachment " + attachment + " postoji");
                        }
                    }
                    if (!attachment_exist) {
                        AddAttachment(day, activity, attachment, allowmodifications);
                    }

                }
            }
            if (!activity_exist) {
                //alert("Aktivnosti " + activity + " ne postoji, pa ce se napraviti");
                AddActivity(day, activity, allowmodifications);
                AddToPlan(day, activity, attachment, outputdiv, allowmodifications);
            }


        }
    }
    if (!day_exist) {
        //alert("Dan " + day + " ne postoji, pa ce se napraviti");
        AddDay(day, allowmodifications);
        AddToPlan(day, activity, attachment, outputdiv, allowmodifications);
    }
}


function AddDay(day, allowmodifications) {
    if (day == 0) {
        day = $("#DaysDiv").children().length + 1;
    }
    if (document.getElementById("DayID_" + day) != null) {
        AddDay(day + 1, allowmodifications);
        return;
    }

    var maindiv = document.createElement("div");
    maindiv.id = "DayID_" + day;
    maindiv.className = "list-item text-align-left margin-bottom-50 box-shadow-small border-color-custom";

    var innerdiv1 = document.createElement("div");
    innerdiv1.className = "d-flex row justify-content-between margin-side-10 cursor border-bottom border-bottom-dotted border-size-10 padding-vertical-10";

    var titlediv = document.createElement("div");
    titlediv.className = "d-flex align-items-center";

    var changeday = document.createElement("i");
    changeday.className = "bi bi-pencil-square";
    changeday.addEventListener("click", function () {

        var content = document.createElement("div");

        var p = document.createElement("p");
        p.textContent = "Keep in mind that when you change day all activities of that specific day will change to day you choose. (current day: " + day + ")";

        var div = document.createElement("div");
        div.className = "d-flex align-items-center justify-content-center margin-top-20";

        var input = document.createElement("input");
        input.className = "outline-none text-center margin-left-5px";
        input.type = "number";
        input.min = 1;
        input.max = 100;

        div.appendChild(input);

        content.appendChild(p);
        content.appendChild(div);

        MakeCustomModal('Change day', content, true, function () {
            var ProgramName = $("#ProgramNameID").val();
            var value = input.value;
            if (value != day) {
                $.get("/Program/ChangeDay?ProgramName=" + ProgramName + "&OldValue=" + day + "&NewValue=" + value, function (result, status) {
                    if (status == "success") {
                        setTimeout(LoadProgram(result, ProgramName, 'BuildProgramDiv', false, allowmodifications), 3000);
                    }
                });
            }
        });
    });

    var h5 = document.createElement("h5");
    h5.className = "margin-left-5px text-uppercase margin-0";
    h5.innerHTML = "Day " + day;
    h5.onclick = function () {
        CollapseDiv("Day_" + day + "_ActivitiesDiv");
    };
    titlediv.appendChild(changeday);
    titlediv.appendChild(h5);

    var bttnActivity = document.createElement("button");
    bttnActivity.classList = "btn-white-black";
    bttnActivity.innerHTML = "<i class='bi bi-node-plus'></i> Add new activity";
    bttnActivity.onclick = function () {
        AddNewActivity(day);
        //ChooseActivity("DayID_" + counter + "_Activities", counter);
    };

    innerdiv1.appendChild(titlediv);
    if (allowmodifications == true)
        innerdiv1.appendChild(bttnActivity);

    var innerdiv2 = document.createElement("div");
    innerdiv2.id = "Day_" + day + "_ActivitiesDiv";
    innerdiv2.classList = "div-section-list-item overflow-hidden";

    maindiv.appendChild(innerdiv1);
    maindiv.appendChild(innerdiv2);
    document.getElementById("DaysDiv").appendChild(maindiv);
}

function AddActivity(day, activity, allowmodifications) {
    var counter = $("#Day_" + day + "_ActivitiesDiv").children().length + 1;

    var maindiv = document.createElement("div");
    maindiv.id = "ActivityID_" + activity;
    maindiv.className = "div-section-list-item activity box-shadow padding-0";

    var innerdiv1 = document.createElement("div");
    innerdiv1.className = "d-flex row justify-content-between margin-side-10 margin-bottom-20 border-bottom activity-header";

    var headerdiv = document.createElement("div");
    headerdiv.className = "flex-section-row align-items-center";

    var iele = document.createElement("i");
    iele.className = "bi bi-caret-up-fill";

    var h6 = document.createElement("h6");
    h6.className = "cursor margin-0 activity-name";
    h6.innerHTML = " Activity " + counter;
    h6.onclick = function () {
        CollapseDiv("Day_" + day + "_Activity_" + activity + "_Collapse");
        ChangeArrow(iele);
    };

    headerdiv.appendChild(iele);
    headerdiv.appendChild(h6);

    var removeactivity = document.createElement("button");
    removeactivity.className = "padding-5 btn-white-black border-0 div-align-center";
    removeactivity.innerHTML = "<i class='bi bi-trash'></i> Remove activity (and attachments)";
    removeactivity.addEventListener("click", function () {
        var ProgramName = $("#ProgramNameID").val();
        $.post("/Program/RemoveActivityFromProgram?ProgramName=" + ProgramName + "&ActivityId=" + activity + "&Day=" + day, function (result, status) {
            if (status == "success") {
                RemoveActivity(maindiv, day); // zavrsiti
            }
        });
    });

    var timediv = document.createElement("div");
    timediv.className = "d-flex flex-column align-items-end w-100";

    var inputdate = document.createElement("input");
    inputdate.className = "input-time w-140px";
    inputdate.type = "date";
    inputdate.valueAsDate = new Date(2000, 1, 1);

    var input = document.createElement("input");
    input.className = "input-time w-95px";
    input.type = "time";
    input.value = "00:00";

    var ProgramName = $("#ProgramNameID").val();
    $.get("/Program/GetCurrentTimeOfActivity?ProgramName=" + ProgramName + "&Activity=" + activity + "&Day=" + day, function (result, status) {
        if (status == "success") {
            var date = new Date(result);
            var datestring = date.getFullYear() + "-" + ("0" + (date.getMonth() + 1)).slice(-2) + "-" + ("0" + date.getDate()).slice(-2);
            var timestring = ("0" + date.getHours()).slice(-2) + ":" + ("0" + date.getMinutes()).slice(-2);

            input.value = timestring;
            inputdate.value = datestring;
        }
    });

    if (allowmodifications == false) {
        input.disabled = true;
        inputdate.disabled = true;
    }
    inputdate.addEventListener("change", function () {
        $.post("/Program/ChangeActivityDate?ProgramName=" + ProgramName + "&Activity=" + activity + "&Day=" + day + "&Date=" + inputdate.value);
    });
    input.addEventListener("blur", function () {
        $.post("/Program/ChangeActivityTime?ProgramName=" + ProgramName + "&Activity=" + activity + "&Day=" + day + "&Time=" + input.value);
    });

    var dedicatedtimediv = document.createElement("div");
    dedicatedtimediv.className = "d-flex align-items-center";
    var pp = document.createElement("p");
    pp.className = "margin-0 padding-5";
    pp.textContent = "Dedicated hours ";
    var inputhours = document.createElement("input");
    inputhours.className = "w-50px border-bottom-only text-center";
    inputhours.type = "number";
    $.get("/Program/GetActivityDuration?ProgramName=" + ProgramName + "&Activity=" + activity + "&Day=" + day, function (result, status) {
        if (status == "success") {
            inputhours.value = result;
        }
    });
    if (allowmodifications == false)
        inputhours.disabled = true;
    inputhours.addEventListener("blur", function () {
        $.post("/Program/ChangeActivityDuration?ProgramName=" + ProgramName + "&Activity=" + activity + "&Day=" + day + "&DedicatedHours=" + inputhours.value);
    });

    dedicatedtimediv.appendChild(pp);
    dedicatedtimediv.appendChild(inputhours);

    timediv.appendChild(inputdate);
    timediv.appendChild(input);
    timediv.appendChild(dedicatedtimediv);

    innerdiv1.appendChild(headerdiv);
    if (allowmodifications == true)
        innerdiv1.appendChild(removeactivity);
    innerdiv1.appendChild(timediv);

    var innerdiv2 = document.createElement("div");
    innerdiv2.className = "d-flex flex-column w-100 overflow-hidden padding-0";
    innerdiv2.id = "Day_" + day + "_Activity_" + activity + "_Collapse";

    var p = document.createElement("div");
    $.get("/Program/GetActivityDescription?ActivityId=" + activity, function (result, status) {
        if (status == "success") {
            //var data = JSON.parse(JSON.stringify(result));
            //p.innerHTML = data.description;
            p.innerHTML = result;
        }
    });

    var button = document.createElement("button"); // add attachment
    //innerdiv3.id = "AddedAttachmentsDiv";
    //innerdiv3.classList = "div-section-list-item";
    button.classList = "btn btn-white-black w-100 padding-5";
    button.innerHTML = "+";//"<i class='bi bi-arrow-down-square'></i> ADD NEW ATTACHMENT";
    button.addEventListener("click", function () {
        SearchAttachments(day, activity);
    });

    var innerdiv3 = document.createElement("div");
    innerdiv3.className = "margin-top-5";
    innerdiv3.id = "Day_" + day + "_Activity_" + activity + "_SearchAttachmentsDiv";

    //var x = document.createElement("button");
    //x.className = "btn-danger padding-5";
    //x.innerHTML = "<i class='bi bi-x-square-fill'></i>";
    //x.style.position = "absolute";
    //x.style.right = "0";
    //x.style.top = "0";
    //x.style.margin = "0";
    //x.style.width = "10px";
    //x.style.height = "10px";
    //x.addEventListener("click", function () {
    //    alert("Remove " + innerdiv4.id);
    //});

    //innerdiv3.appendChild(x);

    var h5 = document.createElement("h5");
    h5.innerHTML = "Added attachments";
    h5.className = "text-center padding-5 margin-bottom-0 cursor attachment-title";
    h5.addEventListener("click", function () {
        CollapseDiv("Day_" + day + "_Activity_" + activity + "_AttachmentsDiv");
    });

    var innerdiv4 = document.createElement("div"); // added attachments
    innerdiv4.id = "Day_" + day + "_Activity_" + activity + "_AttachmentsDiv";
    innerdiv4.className = "w-100 padding-5 d-flex flex-row flex-wrap justify-content-start align-items-start overflow-hidden border-0";

    //innerdiv2.appendChild(innerdiv1);
    innerdiv2.appendChild(p);
    if (allowmodifications == true)
        innerdiv2.appendChild(button);
    innerdiv2.appendChild(innerdiv3);
    innerdiv2.appendChild(h5);
    innerdiv2.appendChild(innerdiv4);



    maindiv.appendChild(innerdiv1);
    maindiv.appendChild(innerdiv2);
    //maindiv.appendChild(innerdiv3);

    document.getElementById("Day_" + day + "_ActivitiesDiv").appendChild(maindiv);

    //$.get("/Program/GetActivityDescription?ActivityId=" + activity, function (result, status) {
    //    if (status == "success") {
    //        var data = JSON.parse(JSON.stringify(result));
    //        alert(data);
    //        alert(data.description);
    //        //innerdiv3.innerHTML = result;
    //    }
    //});

}

function SearchAttachments(day, activity) {
    var outputdiv = $("#Day_" + day + "_Activity_" + activity + "_SearchAttachmentsDiv");
    $.get("/Program/GetActivityAttachments?ActivityId=" + activity + "&Day=" + day, function (result, status) {
        if (status == "success") {
            outputdiv.html(result);
        }
    });
}

function AddAttachment(day, activity, attachment, allowmodifications) {
    if (attachment == 0)
        return;
    $.get("/Program/GetAttachmentDescription?AttachmentId=" + attachment + "&AllowModifications=" + allowmodifications, function (result, status) {
        if (status == "success") {
            $("#Day_" + day + "_Activity_" + activity + "_AttachmentsDiv").append(result);
        }
    });

}

function RemoveActivity(activity, day) {
    activity.remove();
    if ($("#Day_" + day + "_ActivitiesDiv").children().length <= 0) {
        $("#DayID_" + day).remove();
    }

}

function ClearAttachments(button) {
    var parent = button.parentElement;
    parent.remove();
    //parent.innerHTML = "";
    //parent.style.padding = "0px";
}

//////
// when button '+ Activity' is clicked
function AddNewActivity(day) {
    if (document.getElementById("SearchNewActivities_ForDay_" + day) != null)
        return;

    $("#Day_" + day + "_ActivitiesDiv").css("maxHeight", "0px");

    var maindiv = document.createElement("div");
    maindiv.id = "SearchNewActivities_ForDay_" + day;
    maindiv.className = "border-decor padding-20 margin-top-25 d-flex justify-content-between";

    var innerdiv1 = document.createElement("div");
    innerdiv1.className = "flex-section-row-child-50 d-flex flex-column";

    var input = document.createElement("input");
    input.placeholder = "Search..";
    input.oninput = function () {
        SearchActivities(day, input.value);
    };

    var innerdiv1_innerdiv = document.createElement("div");
    innerdiv1_innerdiv.id = "SearchedActivityList_ForDay_" + day;
    innerdiv1_innerdiv.className = "div-section-list-item";

    innerdiv1.appendChild(input);
    innerdiv1.appendChild(innerdiv1_innerdiv);

    var h6 = document.createElement("h6");
    h6.textContent = "Add activity";
    h6.className = "text-align-left";
    var p = document.createElement("p");
    p.className = "padding-5 text-align-left";
    p.innerHTML = "Search activities and click on them to see details. We suggest you to check out catalogs to learn more about them."

    var innerdiv2 = document.createElement("div");
    innerdiv2.className = "flex-section-row-child-50 d-flex flex-column justify-content-between margin-left-25px";
    innerdiv2.id = "SearchedActivityDetails_ForDay_" + day;
    innerdiv2.appendChild(h6);
    innerdiv2.appendChild(p);

    maindiv.appendChild(innerdiv1);
    maindiv.appendChild(innerdiv2);

    document.getElementById("DayID_" + day).appendChild(maindiv);
}


function SearchActivities(day, value) {
    $.get("/Program/GetActivitiesAjax?Value=" + value, function (result, status) {
        if (status === "success") {
            $("#SearchedActivityList_ForDay_" + day).html(result);
        }
    });
}

function ShowActivityDetails(e, ActivityId) {
    var parent = e.parentElement;
    var day = parent.id.substr(parent.id.length - 1);
    $.get("/Program/GetActivityDetailsAjax?ActivityId=" + ActivityId, function (result, status) {
        if (status === "success") {
            $("#SearchedActivityDetails_ForDay_" + day).html(result);
        }
    });
}

function AddActivityToDay(e, ActivityId) {
    var parent = e.parentElement;
    var day = parent.id.substr(parent.id.length - 1);
    var ProgramName = $("#ProgramNameID").val();

    $.post("/Program/AddActivityToProgram?ProgramName=" + ProgramName + "&ActivityId=" + ActivityId + "&Day=" + day, function (result, status) {
        if (status == "success") {
            $("#SearchNewActivities_ForDay_" + day).remove();
            AddActivity(day, ActivityId, true);
            CollapseDiv("Day_" + day + "_ActivitiesDiv");
        }
    }).catch(function (statusCode) {
        if (statusCode.status == 400) {
            Message("Activity cannot be added.");
        }
    });
}


function CreateProgram() {
    var program = $("#ProgramName").val();
    $.post("/Program/CreateProgram?ProgramName=" + program, function (result, status) {
        if (status == "success") {
            $("#CreateProgramDiv").remove();
            $("#BuildProgramDiv").removeClass("hidden");
            $("#AddDayButtonID").removeClass("hidden");
            $("#AddDayButtonID").addClass("d-block");

            var programname = document.createElement("input");
            programname.style.display = "none";
            programname.id = "ProgramNameID";
            programname.value = program;

            var daysdiv = document.createElement("div");
            daysdiv.id = "DaysDiv";

            document.getElementById("BuildProgramDiv").appendChild(programname);
            document.getElementById("BuildProgramDiv").appendChild(daysdiv);
        }
    }).fail(function (xhr) {
        if (xhr.status == 400) {
            $("#ProgramNameWarning").removeClass("hidden");
        }
    });
}

//Day_1_Activity_1_XXX
function AddAttachmentToActivity(attachment, activityId, day) {
    var program = $("#ProgramNameID").val();
    $.post("/Program/AddAttachmentToProgramActivity?ProgramName=" + program + "&ActivityId=" + activityId + "&Day=" + day + "&AttachmentId=" + attachment, function (result, status) {
        if (status == "success") {
            AddAttachment(day, activityId, attachment, true);
        }
    });
}


function RemoveAttachmentFromActivity(e, attachment) {
    var day = e.parentElement.parentElement.id.substr(4, 1);
    var id = e.parentElement.parentElement.id;
    var activity = id.substr(15);
    activity = activity.substr(0, activity.indexOf("_"));
    //var activity = e.parentElement.parentElement.id.substr(15, 1);
    var program = $("#ProgramNameID").val();
    $.post("/Program/RemoveAttachmentFromProgramActivity?ProgramName=" + program + "&ActivityId=" + activity + "&Day=" + day + "&AttachmentId=" + attachment, function (result, status) {
        if (status == "success") {
            RemoveAttachment(e.parentElement);
        }
    });
}

function RemoveAttachment(attachment) {
    attachment.remove();
}


function ChangeArrow(arrow) {
    if (arrow.className === "bi bi-caret-up-fill")
        arrow.className = "bi bi-caret-down-fill";
    else
        arrow.className = "bi bi-caret-up-fill";
}

function ChangeState(ProgramId, Title, State) {

    var div = document.createElement("div");

    var p = document.createElement("p");
    p.className = "padding-5 text-align-left";
    p.textContent = "Select state and press 'Save changes' to change state of selected program.";

    var h5 = document.createElement("h5");
    h5.className = "padding-5 text-align-left";
    h5.textContent = "Current status is " + State;

    var select = document.createElement("select");
    select.className = "w-100 padding-5";

    var optionApproved = document.createElement("option");
    optionApproved.textContent = "Approved";
    optionApproved.value = 0;

    var optionRefused = document.createElement("option");
    optionRefused.textContent = "Refused";
    optionRefused.value = 1;

    var optionOnHold = document.createElement("option");
    optionOnHold.textContent = "On-hold";
    optionOnHold.value = 2;

    select.appendChild(optionApproved);
    select.appendChild(optionRefused);
    select.appendChild(optionOnHold);

    div.appendChild(p);
    div.appendChild(h5);
    div.appendChild(select);

    MakeCustomModal(Title, div, true, function () {
        let option = select.value;
        $.post("/Administration/ChangeProgramState?ProgramId=" + ProgramId + "&State=" + option, function (result, status) {
            if (status == "success") {
                $("#ProgramStatusID").text(select.options[select.selectedIndex].text);
            }
        });
    });
}

function ChangeAccess(ProgramId, Title, Access) {

    var div = document.createElement("div");

    var p = document.createElement("p");
    p.className = "padding-5 text-align-left";
    p.textContent = "Select state and press 'Save changes' to change state of selected program.";

    var h5 = document.createElement("h5");
    h5.className = "padding-5 text-align-left";
    h5.textContent = "Currently this program is " + Access;

    var select = document.createElement("select");
    select.className = "w-100 padding-5";

    var optionPrivate = document.createElement("option");
    optionPrivate.textContent = "Private";
    optionPrivate.value = 0;

    var optionPublic = document.createElement("option");
    optionPublic.textContent = "Public";
    optionPublic.value = 1;

    select.appendChild(optionPrivate);
    select.appendChild(optionPublic);

    div.appendChild(p);
    div.appendChild(h5);
    div.appendChild(select);

    MakeCustomModal(Title, div, true, function () {
        let option = select.value;
        $.post("/Administration/ChangeProgramAccess?ProgramId=" + ProgramId + "&Access=" + option, function (result, status) {
            if (status == "success") {
                $("#ProgramAccessID").text(select.options[select.selectedIndex].text);
            }
        }).catch(function (statusCode) {
            if (statusCode.status == 412) {
                var main = document.createElement("div");

                var h4 = document.createElement("h4");
                h4.textContent = "ERROR";

                var p = document.createElement("p");
                p.className = "padding-5 text-align-justify";
                p.textContent = "Program description is not provided. To make program public, enter description down bellow and then try again.";

                var textarea = document.createElement("textarea");
                textarea.className = "w-100 padding-5";

                main.appendChild(h4);
                main.appendChild(p);
                main.appendChild(textarea);

                MakeCustomModal(Title, main, true, function () {
                    $.post("/Administration/AddProgramDescription?ProgramId=" + ProgramId + "&Description=" + textarea.value, function (result, status) {
                        if (status == "success") {
                            Message("Program description added successfully. You can change program access now.");
                        }
                    });
                });
            }
        });
    });
}
function CloseModal() {
    $("#modal_ovarlay").remove();
}

function MakeCustomModal(Title, HtmlContent, EnableSaveButton, SaveChangesFunction) {
    var overlaydiv = document.createElement("div");
    overlaydiv.id = "modal_ovarlay";
    overlaydiv.className = "d-flex justify-content-center align-items-center";
    overlaydiv.style.position = "fixed";
    overlaydiv.style.width = "100vw";
    overlaydiv.style.height = "100vh";
    overlaydiv.style.top = "0px";
    overlaydiv.style.left = "0px";
    overlaydiv.style.backgroundColor = "rgba(255, 255, 255, 0.2)";
    overlaydiv.style.zIndex = "10";

    var modaldiv = document.createElement("div");
    modaldiv.className = "d-flex flex-column justify-content-between padding-20";
    modaldiv.style.width = "60vh";
    modaldiv.style.height = "70vh";
    modaldiv.style.backgroundColor = "white";
    modaldiv.style.border = "1px solid black";
    modaldiv.style.borderRadius = "20px";
    modaldiv.style.overflow = "auto";

    var titleheader = document.createElement("h3");
    titleheader.className = "padding-20 text-align-left border-bottom border-dodgerblue";
    titleheader.textContent = Title;

    var contentparagraph = document.createElement("p");
    contentparagraph.className = "padding-5 text-align-left";
    contentparagraph.appendChild(HtmlContent);

    var buttondiv = document.createElement("div");
    buttondiv.className = "d-flex justify-content-end padding-5";

    var buttonClose = document.createElement("button");
    buttonClose.textContent = "Close";
    buttonClose.className = "w-50 btn-secondary padding-5 text-uppercase border-0";
    buttonClose.addEventListener("click", function () {
        overlaydiv.remove();
    });

    var buttonSave = document.createElement("button");
    buttonSave.textContent = "Save changes";
    buttonSave.className = "w-50 btn-primary padding-5 text-uppercase border-0";
    buttonSave.addEventListener("click", function () {
        overlaydiv.remove();
        SaveChangesFunction();
    });

    buttondiv.appendChild(buttonClose);
    if (EnableSaveButton) {
        buttondiv.appendChild(buttonSave);
    }

    modaldiv.appendChild(titleheader);
    modaldiv.appendChild(contentparagraph);
    modaldiv.appendChild(buttondiv);

    overlaydiv.appendChild(modaldiv);
    document.body.appendChild(overlaydiv);
}


//function AddActivityToDay(e, ActivityId, Description) {
//    var counter = e.parentElement.id.substr(4, 1);
//    var outputdiv = e.parentElement.parentElement.parentElement.parentElement.id;

//    var ProgramName = $("#ProgramName").val();

//    $.post("/Program/AddActivityToDay?ProgramName=" + ProgramName + "&DayId=" + outputdiv + "&ActivityId=" + ActivityId, function (result, status) {
//        if (status == "success") {
//            $("#ChooseActivityBox_" + counter).remove();
//            AddNewActivity(counter, outputdiv, ActivityId, Description);
//        }
//    });
//}


//var showActivityDetailsDiv;

//function SearchActivites(DivId, value, counter) {
//    $.get("/Program/GetActivitiesAjax?Value=" + value, function (result, status) {
//        if (status === "success") {
//            $("#" + DivId).html(result);
//            showActivityDetailsDiv = "Day_" + counter + "_ActivityDetailsAjax";
//        }
//    });
//}

//function ShowActivityDetails(e, ActivityId) {
//    // var counter = parseint(e.parentElement.id.substr(3, 1));
//    var counter = e.parentElement.id.substr(6, 1);
//    $.get("/Program/GetActivityDetailsAjax?ActivityId=" + ActivityId, function (result, status) {
//        if (status === "success") {
//            $("#Day_" + counter + "_ActivityDetailsAjax").html(result);
//        }
//    });
//}

//function ChooseActivity(day, counter) {

//    var maindiv = document.createElement("div");
//    maindiv.id = "ChooseActivityBox_" + day.substr(6, 1);
//    maindiv.className = "d-flex justify-content-between";

//    var innerdiv1 = document.createElement("div");
//    innerdiv1.className = "flex-section-row-child-50 d-flex flex-column";

//    var input = document.createElement("input");
//    input.placeholder = "Search..";
//    input.oninput = function () {
//        SearchActivites("Day_" + counter + "_ActivitiesAjax", input.value, counter);
//        sessionStorage.setItem("counter", counter.toString());
//    };

//    var innerdiv1_innerdiv = document.createElement("div");
//    innerdiv1_innerdiv.id = day + "Ajax";
//    innerdiv1_innerdiv.className = "div-section-list-item";

//    innerdiv1.appendChild(input);
//    innerdiv1.appendChild(innerdiv1_innerdiv);

//    var innerdiv2 = document.createElement("div");
//    innerdiv2.className = "flex-section-row-child-50 d-flex flex-column justify-content-between margin-left-25px";

//    innerdiv2.id = "Day_" + counter + "_ActivityDetailsAjax";
//    //var innerdiv2_innerdiv = document.createElement("div");
//    //innerdiv2_innerdiv.className = "d-flex flex-column justify-content-between";
//    //innerdiv2_innerdiv.id = "Day_" + counter + "_ActivityDetailsAjax";

//    //var button = document.createElement("button");
//    //button.innerHTML = "Add this acitvity";

//    //innerdiv2.appendChild(innerdiv2_innerdiv);
//    //innerdiv2.appendChild(button);

//    maindiv.appendChild(innerdiv1);
//    maindiv.appendChild(innerdiv2);

//    document.getElementById(day).appendChild(maindiv);
//    SearchActivites(day + "Ajax", "");
//}


//function AddNewActivity(day, outputdiv, ActivityId, description) {
//    var counter = $("#" + day + " .activity").length + 1;

//    var maindiv = document.createElement("div");
//    maindiv.id = "ActivityID_" + ActivityId;
//    maindiv.className = "div-section-list-item focus-border activity";

//    var innerdiv_1 = document.createElement("div");
//    innerdiv_1.className = "d-flex row justify-content-between margin-side-10 border-bottom";

//    var headerdiv = document.createElement("div");
//    headerdiv.className = "flex-section-row";

//    var iele = document.createElement("i");
//    iele.className = "bi bi-caret-up-fill";

//    var h6 = document.createElement("h6");
//    h6.className = "cursor";
//    h6.innerHTML = " Activity " + counter;
//    h6.onclick = function () {
//        CollapseDiv(day + "_" + counter + "_Activity_Attachments");
//        ChangeArrow(iele);
//    };

//    headerdiv.appendChild(iele);
//    headerdiv.appendChild(h6);

//    var input = document.createElement("input");
//    input.type = "time";
//    input.value = "12:00";

//    innerdiv_1.appendChild(headerdiv);
//    innerdiv_1.appendChild(input);

//    var innerdiv_2 = document.createElement("div");
//    innerdiv_2.className = "d-flex row w-100 overflow-hidden padding-0";
//    innerdiv_2.id = day + "_" + counter + "_Activity_Attachments";

//    var p = document.createElement("p");
//    p.innerHTML = description;
//    p.style.marginRight = "10px";
//    //var innerdiv1 = document.createElement("div");
//    //innerdiv1.className = "div-section-list-item";

//    //var input = document.createElement("input");
//    //input.type = "text";
//    //input.placeholder = "Search..";
//    //input.oninput = function () {
//    //    // searching attachments
//    //};

//    //var div2 = document.createElement("div");
//    //div2.className = "h-50 overflow-auto";
//    //div2.id = "ActivityAttachmentListAjax";
//    //innerdiv1.appendChild(input);
//    //innerdiv1.appendChild(div2);

//    var innerdiv1 = document.createElement("div"); // added attachments
//    innerdiv1.id = "AddedAttachmentsDiv";
//    innerdiv1.classList = "div-section-list-item";


//    innerdiv_2.appendChild(p);
//    innerdiv_2.appendChild(innerdiv1);
//    //innerdiv_2.appendChild(innerdiv2);

//    var innerdiv_3 = document.createElement("div");
//    //innerdiv_3.id = "ShowActivityAttachmentsAjax_ForDay_" + day;
//    innerdiv_3.className = "w-100 padding-5";

//    maindiv.appendChild(innerdiv_1);
//    maindiv.appendChild(innerdiv_2);
//    maindiv.appendChild(innerdiv_3);

//    document.getElementById(outputdiv).append(maindiv);

//    $.get("/Program/GetActivityAttachments?ActivityId=" + ActivityId, function (result, status) {
//        if (status == "success") {
//            innerdiv_3.innerHTML = result;
//        }
//    });
//}



//function AddNewDay() {
//    var counter = document.getElementById("DaysId").children.length + 1;

//    var maindiv = document.createElement("div");
//    maindiv.id = "DayID_" + counter;
//    maindiv.className = "list-item text-align-left margin-bottom-20";

//    var maindiv_child_1 = document.createElement("div");
//    maindiv_child_1.className = "d-flex row justify-content-between margin-side-10 cursor";

//    var h5 = document.createElement("h5");
//    h5.innerHTML = "Day " + counter;
//    h5.onclick = function () {
//        CollapseDiv("DayID_" + counter + "_Activities");
//    };

//    var bttnActivity = document.createElement("button");
//    bttnActivity.classList = "btn-danger";
//    bttnActivity.innerHTML = "+ Activity";
//    bttnActivity.onclick = function () {
//        ChooseActivity("DayID_" + counter + "_Activities", counter);

//        //AddNewActivity("DayID_" + counter + "_Activities");
//    };

//    maindiv_child_1.appendChild(h5);
//    maindiv_child_1.appendChild(bttnActivity);

//    var maindiv_child_2 = document.createElement("div");
//    maindiv_child_2.id = "DayID_" + counter + "_Activities";
//    maindiv_child_2.classList = "div-section-list-item overflow-hidden";

//    maindiv.appendChild(maindiv_child_1);
//    maindiv.appendChild(maindiv_child_2);
//    document.getElementById("DaysId").appendChild(maindiv);


//    //var activity_innerdiv_1 = document.createElement("div");
//    //activity_innerdiv_1.classList = "d-flex row justify-content-between margin-side-10 border-bottom cursor";
//    //activity_innerdiv_1.onclick = function () {
//    //    CollapseDiv("DayID_" + counter + "_Activity_Attachments");
//    //};

//    //var activity_innerdiv_2 = document.createElement("div");
//    //activity_innerdiv_2.classList = "d-flex row justify-content-around overflow-hidden padding-0";




//    //var h5 = document.createElement("h5");
//    //h5.innerHTML = "Day " + counter;

//    //var bttn = document.createElement("button");
//    //bttn.classList = "btn-danger cursor";
//    //bttn.innerHTML = "+ Activity";
//    //bttn.onclick = function () {
//    //    AddNewActivity(counter);
//    //}

//    //var innerdiv1 = document.createElement("div");
//    //innerdiv1.classList = "d-flex row justify-content-between margin-side-10";
//    //innerdiv1.appendChild(h5);
//    //innerdiv1.appendChild(bttn);

//    //var innerdiv2 = document.createElement("div");
//    //innerdiv2.classList = "div-section-list-item";



//    //div.append(innerdiv1);
//    //div.append(innerdiv2);

//    //var parent = document.getElementById("DaysId");
//    //parent.appendChild(div);
//}

function RenameProgram() {
    var div = document.createElement("div");
    div.id = "RenamePlanId";
    div.className = "flex-section-row justify-content-center";
    var input = document.createElement("input");
    input.placeholder = "Enter your plan name";

    var ok = document.createElement("span");
    ok.innerHTML = "&#x2714;";
    ok.style.border = "1px solid gray";
    ok.style.cursor = "pointer";
    ok.onclick = function (e) {
        var val = input.value;
        if (val == "")
            return;
        var h3 = document.createElement("h3");
        h3.onclick = RenameProgram;
        h3.innerHTML = val;
        document.getElementById("RenamePlanId").remove();
        document.getElementById("PlanNameId").appendChild(h3);
        document.getElementById("Model_ProgramName").val(val);
    };


    div.append(input);
    div.append(ok);

    var planNameDiv = document.getElementById("PlanNameId");
    planNameDiv.innerHTML = "";
    planNameDiv.appendChild(div);


}

