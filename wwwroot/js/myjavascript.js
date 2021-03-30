function CollapseDiv(id) {
    if ($("#" + id).css("maxHeight") !== "0px")
        $("#" + id).css("maxHeight", "0px");
    else
        $("#" + id).css("maxHeight", "100%");
}


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
        var posY = e.clientY;

        var div = document.createElement("div");
        div.id = "ShowHoverInfoDiv";
        div.style.padding = "15px 20px";
        div.style.color = "white";
        div.style.backgroundColor = "lightgreen";
        div.style.border = "1px solid darkgreen";
        div.style.borderRadius = "10px";
        div.innerHTML = "<i class='bi bi-info-square text-color-white'></i> ";
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
function LoadProgram(ProgramId, Title, Switch) {
    $.get("/Program/LoadProgramData?ProgramId=" + ProgramId, function (result, status) {
        if (status == "success") {
            if (Switch) {
                $("#CreateProgramDiv").remove();
                $("#BuildProgramDiv").removeClass("hidden");
            }
            $("#ProgramNameID").val(Title);

            var data = JSON.parse(JSON.stringify(result));
            for (var i = 0; i < data.length; i++) {
                AddToPlan(data[i].day, data[i].activity, data[i].attachment);
            }
        }
    });
    AddAttachment(1, 1, 0);
}

function AddToPlan(day, activity, attachment) {
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
                        AddAttachment(day, activity, attachment);
                    }

                }
            }
            if (!activity_exist) {
                //alert("Aktivnosti " + activity + " ne postoji, pa ce se napraviti");
                AddActivity(day, activity);
                AddToPlan(day, activity, attachment);
            }


        }
    }
    if (!day_exist) {
        //alert("Dan " + day + " ne postoji, pa ce se napraviti");
        AddDay(day);
        AddToPlan(day, activity, attachment);
    }
}


function AddDay(day) {
    if (day == 0) {
        day = $("#DaysDiv").children().length + 1;
    }
    if (document.getElementById("DayID_" + day) != null) {
        AddDay(day + 1);
        return;
    }

    var maindiv = document.createElement("div");
    maindiv.id = "DayID_" + day;
    maindiv.className = "list-item text-align-left margin-bottom-20";

    var innerdiv1 = document.createElement("div");
    innerdiv1.className = "d-flex row justify-content-between margin-side-10 cursor";

    var h5 = document.createElement("h5");
    h5.innerHTML = "Day " + day;
    h5.onclick = function () {
        CollapseDiv("Day_" + day + "_ActivitiesDiv");
    };

    var bttnActivity = document.createElement("button");
    bttnActivity.classList = "btn-danger";
    bttnActivity.innerHTML = "<i class='bi bi-node-plus'></i> Add new activity";
    bttnActivity.onclick = function () {
        AddNewActivity(day);
        //ChooseActivity("DayID_" + counter + "_Activities", counter);
    };

    innerdiv1.appendChild(h5);
    innerdiv1.appendChild(bttnActivity);

    var innerdiv2 = document.createElement("div");
    innerdiv2.id = "Day_" + day + "_ActivitiesDiv";
    innerdiv2.classList = "div-section-list-item overflow-hidden";

    maindiv.appendChild(innerdiv1);
    maindiv.appendChild(innerdiv2);
    document.getElementById("DaysDiv").appendChild(maindiv);
}

function AddActivity(day, activity) {
    var counter = $("#Day_" + day + "_ActivitiesDiv").children().length + 1;

    var maindiv = document.createElement("div");
    maindiv.id = "ActivityID_" + activity;
    maindiv.className = "div-section-list-item focus-border activity box-shadow";

    var innerdiv1 = document.createElement("div");
    innerdiv1.className = "d-flex row justify-content-between margin-side-10 margin-bottom-20 border-bottom";

    var headerdiv = document.createElement("div");
    headerdiv.className = "flex-section-row align-items-center";

    var iele = document.createElement("i");
    iele.className = "bi bi-caret-up-fill";

    var h6 = document.createElement("h6");
    h6.className = "cursor margin-0";
    h6.innerHTML = " Activity " + counter;
    h6.onclick = function () {
        CollapseDiv("Day_" + day + "_Activity_" + activity + "_Collapse");
        ChangeArrow(iele);
    };

    headerdiv.appendChild(iele);
    headerdiv.appendChild(h6);

    var input = document.createElement("input");
    input.type = "time";
    input.value = "12:00";

    innerdiv1.appendChild(headerdiv);
    innerdiv1.appendChild(input);

    var innerdiv2 = document.createElement("div");
    innerdiv2.className = "d-flex flex-column w-100 overflow-hidden padding-0";
    innerdiv2.id = "Day_" + day + "_Activity_" + activity + "_Collapse";

    var p = document.createElement("p");
    $.get("/Program/GetActivityDescription?ActivityId=" + activity, function (result, status) {
        if (status == "success") {
            //var data = JSON.parse(JSON.stringify(result));
            //p.innerHTML = data.description;
            p.innerHTML = result;
        }
    });
    p.style.marginRight = "10px";

    var button = document.createElement("button"); // add attachment
    //innerdiv3.id = "AddedAttachmentsDiv";
    //innerdiv3.classList = "div-section-list-item";
    button.classList = "btn btn-light w-100 padding-5";
    button.innerHTML = "<i class='bi bi-arrow-down-square'></i> ADD NEW ATTACHMENT";
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
    h5.className = "text-center padding-5 background-dodgerblue text-color-white margin-bottom-0";

    var innerdiv4 = document.createElement("div"); // added attachments
    innerdiv4.id = "Day_" + day + "_Activity_" + activity + "_AttachmentsDiv";
    innerdiv4.className = "w-100 padding-5 d-flex flex-row flex-wrap justify-content-center border-dodgerblue border-size-3";

    //innerdiv2.appendChild(innerdiv1);
    innerdiv2.appendChild(p);
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
    $.get("/Program/GetActivityAttachments?ActivityId=" + activity, function (result, status) {
        if (status == "success") {
            outputdiv.html(result);
        }
    });
}

function AddAttachment(day, activity, attachment) {
    if (attachment == 0)
        return;
    $.get("/Program/GetAttachmentDescription?AttachmentId=" + attachment, function (result, status) {
        if (status == "success") {
            $("#Day_" + day + "_Activity_" + activity + "_AttachmentsDiv").append(result);
        }
    });

}

function ClearAttachments(button) {
    var parent = button.parentElement;
    parent.innerHTML = "";
}

//////
// when button '+ Activity' is clicked
function AddNewActivity(day) {
    if (document.getElementById("SearchNewActivities_ForDay_" + day) != null)
        return;

    $("#Day_" + day + "_ActivitiesDiv").css("maxHeight", "0px");

    var maindiv = document.createElement("div");
    maindiv.id = "SearchNewActivities_ForDay_" + day;
    maindiv.className = "padding-20 margin-top-25 d-flex justify-content-between border-size-3";

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

    var p = document.createElement("p");
    p.className = "padding-5 text-align-left";
    p.innerHTML = "Search activities and click on them to see details. We suggest you to check out catalogs to learn more about them."

    var innerdiv2 = document.createElement("div");
    innerdiv2.className = "flex-section-row-child-50 d-flex flex-column justify-content-between margin-left-25px";
    innerdiv2.id = "SearchedActivityDetails_ForDay_" + day;
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

function AddActivityToDay(e, ActivityId, Description) {
    var parent = e.parentElement;
    var day = parent.id.substr(parent.id.length - 1);
    var ProgramName = $("#ProgramNameID").val();

    $.post("/Program/AddActivityToProgram?ProgramName=" + ProgramName + "&ActivityId=" + ActivityId + "&Day=" + day, function (result, status) {
        if (status == "success") {
            $("#SearchNewActivities_ForDay_" + day).remove();
            AddActivity(day, ActivityId);
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
            $("#ProgramNameID").val(program);
        }
    }).fail(function (xhr) {
        if (xhr.status == 400) {
            $("#ProgramNameWarning").removeClass("hidden");
        }
    });
}

//Day_1_Activity_1_XXX
function AddAttachmentToActivity(e, attachment) {
    var day = e.parentElement.parentElement.id.substr(4, 1);
    var activity = e.parentElement.parentElement.id.substr(15, 1);
    var program = $("#ProgramNameID").val();
    $.post("/Program/AddAttachmentToProgramActivity?ProgramName=" + program + "&ActivityId=" + activity + "&Day=" + day + "&AttachmentId=" + attachment, function (result, status) {
        if (status == "success") {
            AddAttachment(day, activity, attachment);
        }
    });
}

function ChangeArrow(arrow) {
    if (arrow.className === "bi bi-caret-up-fill")
        arrow.className = "bi bi-caret-down-fill";
    else
        arrow.className = "bi bi-caret-up-fill";
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

function RenamePlane() {
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
        h3.onclick = RenamePlane;
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
