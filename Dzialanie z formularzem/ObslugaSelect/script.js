let partie = document.getElementById('partie');
let info = document.getElementById('info');

document.getElementById("submit").addEventListener("click", () => {
    info.textContent = "";
    info.append("Wybrales: " + partie.value + ". Zaznaczyles partie numer: " + parseInt(partie.selectedIndex + 1) + ". Masz do wyboru " + partie.length + " partii");
});
