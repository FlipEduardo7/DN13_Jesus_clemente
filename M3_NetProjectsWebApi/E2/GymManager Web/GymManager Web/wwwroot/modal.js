document.getElementById("btnModal").addEventListener("click", function () {
    var modal = document.getElementById("myModal");
    let id = document.getElementById("idMember");
    modal.classList.add("show");
    modal.style.display = "block";

    let fecha = new Date();
    let hora = fecha.getHours();
    let minutos = fecha.getMinutes();
    let segundos = fecha.getSeconds();
    let horaActual = (hora < 10 ? "0" + hora : hora) + ":" + (minutos < 10 ? "0" + minutos : minutos) + ":" + (segundos < 10 ? "0" + segundos : segundos);

    document.getElementById("idText").textContent += id.value + " " + horaActual;

    setTimeout(() => {
        modal.classList.remove("show");
        modal.style.display = "none";

    }, 3000);
});

document.getElementById("idMember").addEventListener("keydown", function (event) {
    if (event.key === "Enter") {
    event.preventDefault();
    document.getElementById("btnModal").click();
}
});

//Funcionamiento para Member Out
