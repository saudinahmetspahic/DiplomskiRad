
var messageBuilder = function () {
    var message = null;
    var time = null;
    var msg = null;
    var writer = null;

    return {
        createMessage: function (classList) {
            message = document.createElement("div")
            if (classList === undefined)
                classList = [];

            for (var i = 0; i < classList.length; i++) {
                message.classList.add(classList[i])
            }

            message.classList.add('message')
            return this;
        },
        withTime: function (text) {
            time = document.createElement("p")
            time.className = "message-time"
            time.appendChild(document.createTextNode(text))
            return this;
        },
        withText: function (text) {
            msg = document.createElement("p")
            msg.className = "message-text"
            msg.appendChild(document.createTextNode(text))
            return this;
        },
        withWriter: function (text) {
            writer = document.createElement("p")
            writer.className = "message-writer"
            writer.appendChild(document.createTextNode(text))
            return this;
        },
        build: function () {
            message.appendChild(time);
            message.appendChild(msg);
            message.appendChild(writer);
            return message;
        }
    }
}