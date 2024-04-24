let element = document.getElementById("example");
let textExample = "this is a text";
let aNumber = 10.333;

let complexObject = {
    name: "Israel",
    lastName: "Perez",
    age: 35
}

let text1 = "text";
let text2 = "text";
let ul = "<ul>";

for (let i = 0; i < textExample.length; i++) {
   ul += ("<li>" + textExample[i] + "</li>");
}

ul += "</ul>";

let data = "133333";



element.innerHTML = typeof (parseInt(data));