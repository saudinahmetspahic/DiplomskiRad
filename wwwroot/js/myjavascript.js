

function Message(message) {

    var div = document.createElement("div");
    div.className = "alert alert-info position-absolute position-right position-bottom margin-5 moving-divs";
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

function sendprivatemessage(Message) {
    var div = document.createElement("div");
    div.className = "d-block";

    var div2 = document.createElement("div");
    div2.className = "background-dark margin-left-25 div-align-right text-align-right border-radius-right w-75 d-inline-block margin-5 padding-20 text-color-white";

    var p = document.createElement("p");
    p.className = "small-text text-color-darkgray";
    var time = new Date();
    var day = today.getDay();
    var daylist = ["Sunday", "Monday", "Tuesday", "Wednesday ", "Thursday", "Friday", "Saturday"];
    p.innerHTML = time.getDay() + "/" + time.getMonth() + "/" + time.getFullYear() + " " + time.getHours + ":" + time.getMinutes() + " " + daylist[day];

    var p2 = document.createElement("p");
    p2.innerHTML = Message;

    div2.appendChild(p);
    div2.appendChild(p2);

    div.appendChild(div2);
    document.getElementById("messagesDiv").appendChild(div); //ChatAjaxDiv
}
