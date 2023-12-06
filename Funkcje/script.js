function test(){
    alert("Cześć");
}

// Zamienia w strone w to co jest wpisane w ""
function test1(){
    document.write("Witaj")
}

// Funkcja pyta o 2 liczby nastepnie metoda isNaN sprawdza czy suma tych liczb jest liczba i jesli jest to wypisuje ich sume
function dodawanie(){
    let l1 = prompt("Podaj pierwszą liczbę", "Wpisz tutaj...")
    let l2 = prompt("Podaj drugą liczbę", "Wpisz tutaj...")
    let metoda = (isNaN((l1 -+- l2)))? "Wprowadź tylko liczby!": l1 + " + " + l2 + " = " + (l1 -+- l2);
    alert(metoda)
}
