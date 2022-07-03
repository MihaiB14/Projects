// Bălan Mihai 
var string = `curaj`;
var vowels = `aeiou`;

function addAYontheend(string) {
    string = string + `ay`;
    console.log(string);
}

function moveConsonanttofinal(string) {
    var numberConsonant = 0;
    while (vowels.indexOf(string.substr(numberConsonant, 1)) == -1 ) { // Se numara cate consoane avem de la inceput pana la intalnirea primei vocale, reprezentant si pozitia din stirng a primei vocale.
        numberConsonant ++;
    }
    string = string.substring(numberConsonant) + string.substr(0, numberConsonant); // Se rescrie stringul cu leterele de la pozitia numberConsonant pana la final, apoi se adauga la sfarsit numberConsonant consoane gasite la inceput.
    addAYontheend(string); // Apelam funcita pentur a adauga ay la final, afisand si noul string.
}

if (vowels.indexOf(string.substr(0,1)) != -1) { // Am folosit funtia indexOf pentru a afla daca prima litera este vocala, in detrimentul unui if cu 5 verificari pentru fiecare vocala si cu && intre ele.
    addAYontheend(string);
}
else {
    moveConsonanttofinal(string);
}
