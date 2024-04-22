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

    t.innerHTML += "<tr><td>" + b.getAttribute("name") + "</td><td>" + new Date() + "</td><tr>";
}

let buttons = document.getElementsByTagName("button");

for (let i = 0; buttons.length; i++) {
    buttons[i].addEventListener("click", onButtonClick);
}

//button.addEventListener("click", onButtonClick);