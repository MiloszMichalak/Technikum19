// * Kod sprawdzajacy podane imie 
let informacja = document.getElementById("informacja");
// let imie = prompt("Podaj swoje imie", "Imie");
// if (imie === "admin"){
//     informacja.innerText = "Witaj na stronie";
// } else {
//     informacja.innerText = "Nie wiem co tutaj szukasz";
// }

// * Sprawdzanie jednoczesnie loginu i hasła za pomoca operatora logicznego = && czyli and
// let login = prompt("Podaj login", "login");
// let password = prompt("Podaj swoje hasło", "hasło");
// if (login == "admin" && password == "123"){
//     informacja.innerText = "Witaj na stronie";
// } else {
//     alert("Podałeś błędny login lub hasło");
// }

// * Funkcja ktora sprawdza haslo nie podaje wprost ze wynosi ono "8" tylko sprawdza czy jest to 8 za pomoca kodu ASCII
function szyfrowanie(){
    let login = prompt("Podaj swoj login", "login");
    let password = prompt("Podaj swoje hasło", "hasło");
    let haslo = password.charCodeAt(0);
    if (login == "admin" && haslo == 56){
        informacja.innerText = "Udalo ci sie zalogowac";
    } else {
        alert("Podałeś błędny login lub hasło");
    }
}

// * Funkcja ktora zmienia znak na cyfre w kodzie ascii, index 0 oznacza ze zamienia tylko 1 znak na ascii
function szyfrowanieZnaku(){
    let litera = prompt("Podaj znak do zaszyfrowania", "");
    alert("Zaszyfrowany znak: (cyfra w kodzie ascii) - " + litera.charCodeAt(0));
}
