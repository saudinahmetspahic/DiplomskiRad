

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
