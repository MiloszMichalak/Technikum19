let a = document.getElementById("bokA");
let b = document.getElementById("bokB");
let info = document.getElementById("info");

let button = document.getElementById("oblicz155 7");

button.addEventListener("click", () => {
    info.textContent = `Pole wynosi: ${parseInt(a.value) * parseInt(b.value)}`;
    a.value = "";
    b.value = "";
});
