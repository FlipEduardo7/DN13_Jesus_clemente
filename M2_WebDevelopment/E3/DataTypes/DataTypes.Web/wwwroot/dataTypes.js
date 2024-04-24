
(function () {

    document.getElementById("button1").addEventListener("click", function () {

        let options = {
            style: {
                main: {
                    background: "#364685",
                    color: "#FFF",
                },
            },
        }
        iqwerty.toast.toast("Hello World!", options);
    });
}());
function onButtonClick(evt) {
    let b = evt.currentTarget;

    let classes = b.classList;

    let isGreen = false;

    for (let i = 0; i < classes.length; i++) {

        let c = classes[i];

        if (c == "greenButton") {
            isGreen = true;
            break;  
        }
    }

    if (isGreen) {
        b.className = "btn redButton";
    }
    else {
        b.className = "btn greenButton";
    }

    let t = document.getElementById("sampleTable");
    let currentHtml = t.innerHTML;

    t.innerHTML += "<tr><td>" + b.getAttribute("name") + "</td><td>" + moment(new Date()).format("DD-MM-YYYY HH:mm:ss") + "</td><tr>";
}

let buttons = document.getElementsByTagName("button");

for (let i = 0; buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);
}

//button.addEventListener("click", onButtonClick);