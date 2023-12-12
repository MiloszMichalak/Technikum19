let zmienBtn = document.getElementById("zmien");
let kolorIpt = document.getElementById("kolor");
let div = document.getElementById("div2");

zmienBtn.addEventListener("click", () => {
    div.style.backgroundColor = kolorIpt.value;
});
