let gender = document.getElementsByName("gender");
let info = document.getElementById("info");

document.getElementById("submit").addEventListener("click", () => {
    for (let i = 0; i < gender.length; i++) {
        if (gender[i].checked) {
            info.textContent = `Wybrales opcje: ${gender[i].value}`;   
        }
    }
});
