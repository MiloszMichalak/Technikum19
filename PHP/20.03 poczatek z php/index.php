<?php
// wypisanie wszystkich informacji z serwera
//phpinfo();

$imie = "Janusz";
$nazwisko = "Nowak";
print("Nazwywam sie: ".$imie." ".$nazwisko);

print('<br>');

$bokA = 5;
$bokB = 7;
print("Boki prostokata wynosza: ".$bokA." i ".$bokB." a <p style='font-size:20px;'>pole bedzie wynosic: ".$bokA*$bokB." a obwod wynosi: ".(2*$bokA + 2*$bokB)."</p>");

define ("Kwota_do_odjecia", 436.20);
define ("Stawka_podatkowa", 0.19);
print("Podatek od dochotu 5000PLN w 2024 roku wynosi: ");
printf("%0.2f", (5000 * Stawka_podatkowa - Kwota_do_odjecia));

print("<br>");

// .= dziala ja concatynacja, jest to skrotowiec
$tekst = "Jan";
$tekst .= "Nowak";
$tekst .= "<br>";
$tekst .= "Ulica. TAK";
print($tekst);
?>
