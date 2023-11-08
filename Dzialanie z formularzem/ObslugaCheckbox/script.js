let czego = document.getElementsByName("konfederat");
let poglady = document.getElementById("poglady");

document.getElementById("submit").addEventListener("click", () => {
    poglady.textContent = "Nienawidzisz: "
    for (let i = 0; i < czego.length; i++) {
        if (czego[i].checked) {
            poglady.append('\n' + czego[i].value + ", ");
        }
    }
});
