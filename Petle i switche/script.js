// funckaj z uzytym switchem
const sprawdz = () => {
    let liczba = document.getElementById('liczba');
    const informacja = document.getElementById("information");
    switch (parseInt(liczba.value) % 2){
        case 0:
            informacja.innerText = "liczba parzysta";
            break;
        case 1:    
            informacja.innerText = "liczba nieparzysta";
            break;
        default:    
            informacja.innerText = "Nie podales liczby";
    }
    liczba.value = "";
}

// funkcja uzywajaca fora (mozna jeszcze whilem jak i do-whilem)
const wypisywanieLiczbFor = () => {
    let liczby = document.getElementById('liczby');
    let temp = "";
    liczby.innerHTML = "";
    for (let i = 0; i < 10; i++){
        temp += i + "\n";
        liczby.append(i + " ");
    }
    alert(temp);
}

const obliczaniePotegi = () => {
    let podstawa = prompt("Podaj podstawe potegi", "podstawa potegi");
    let podstawa1 = podstawa;
    let potega = prompt("Podaj wykladnik potege", "potega");
    for (let i = 1; i < parseInt(potega); i++){
        let wynik = podstawa1 * podstawa;
        podstawa1 = wynik;
    }
    alert("Wynik to " + podstawa1);

    // TODO moze kiedys dokoncze
}
