// Informujące okienko
// alert("Nauka javascript");


// Okienko od potwierdzania - Tak/Nie 
// confirm("Czy jesteś pewny?");


// Jesli confim zamkniete w alercie zwraca True/False
// alert(confirm("Czy jesteś pewny?"));


// Wyskakujace okienko do wpisania. Pierwszy nawias to jest tekst odnosnie pytania. 2 nawias to tekst od 
// razu wpisany w okienko do wpisania (taka podpowiedz)
// prompt("Podaj swoje imie", "Imie");


// Kod ktory pokaze i polaczy 2 rzeczy ktore wpiszemy
// let imie = prompt("Podaj swoje imie", "Imie");
// let nazwisko = prompt("Podaj swoje nazwisko", "Nazwisko");
// alert("Witaj " + imie + " " + nazwisko);
 
// Kod ktory pokaze 2 wpisane liczby
let number1 = prompt("Podaj 1 liczbe");
let number2 = prompt("Podaj 2 liczbe");

//alert('Iloczyn 2 liczb wynosi: ' + number1 * number2)
//alert('Roznica 2 liczb wynosi: ' + (number1 - number2 ));

// -+- dziala w js jako dodawanie
alert('Suma 2 liczb wynosi: ' + (number1 -+- number2));
