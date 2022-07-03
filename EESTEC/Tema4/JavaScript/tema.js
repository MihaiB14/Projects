// Bălan Mihai
const numbers =  [4, 7, 25, 100, 67, 66, 900, 41, 13, 18, 1, 92, 57, 78, 45, 257];

// Filtrare numere pare => stergere multipla, folosim while
var i = 0;
while(i < numbers.length) {
    if(numbers[i] % 2 == 1) {
        numbers.splice(i, 1);
    }
    else {
        i++;
    }
}
console.log("===================================1================================");
console.log("Array-ul filtrat: " + numbers);

// Sortare elemente ramase => sortare prin bule (putina eficinta sa fie zic :D)
var nr = 1, ok;
do {
    ok = 0;
    for(var i = 0; i < numbers.length - nr; i++) {
        if(numbers[i] < numbers[i + 1]) {
            ok++;
            numbers[i] += numbers[i + 1];
            numbers[i + 1] = numbers[i] - numbers[i + 1];
            numbers[i] -= numbers[i + 1];
            // interschimbare fara a folosi variabila auxiliara
        }
    }
    nr++;
}while(ok);
console.log("===================================2================================");
console.log("Array-ul sortat: " + numbers);

// Inversare array => o functie recursiva care interschimba elementele, initial se pleaca din capete si se mrege spre elementul din mijloc.
function interschimbare(number, pozInc, pozFin) {
    
    if(pozFin > pozInc) {
        number[pozFin] += number[pozInc];
        number[pozInc] = number[pozFin] - number[pozInc];
        number[pozFin] -= number[pozInc];
        interschimbare(number, pozInc + 1, pozFin - 1);
    }
}

interschimbare(numbers, 0, numbers.length - 1);
console.log("===================================3================================");
console.log("Array-ul inversat: " + numbers);

// Exemplu 1: Se dau 2 array-uri ce contin cuvinte. Se cere sa se extraga din primul toate vocalele, din al doilea toate consoanele, apoi sa se conceteneze cele 2 siruri fara niciun caractrer de legatura.
const firstword = ["Tema", "asta", "este", "fantastica"];
const secondWord = ["Insa","tema", "de", "la", "html", "a", "fost", "mai", "faina"];
var vocale = "aeiouAEIOU";

var firstWordCopy =  firstword.join("");
var firstwordFinal = [];
for(var i = 0; i < firstWordCopy.length; i++) {
    if(vocale.indexOf(firstWordCopy.charAt(i)) >= 0) {
        firstwordFinal.push(firstWordCopy.charAt(i));
    }
}

var secondWordCopy = secondWord.join("");
var secondWordFinal = [];
for(var i = 0; i < secondWordCopy.length; i++) {
    if(vocale.indexOf(secondWordCopy.charAt(i)) == -1) {
        secondWordFinal.push(secondWordCopy.charAt(i));
    }
}

var final = firstwordFinal.concat(secondWordFinal);
console.log("===================================4================================");
console.log("Sirul final este: " + final.join(""));

// Exemplu 2: Se da un array. Sa se puna in alt array valorile prime, fiind sterse din primul. Apoi sa se afiseze primul element extras, cat si ultimul.
function prim(numar) {
    for(var d = 2; d < numar/2; d++) {
        if(numar % d == 0) {
            return 0;
        }
    }
    return 1;
}

var numbersOne = [11, 2, 24, 23, 12, 67, 88, 45];
var newNumbersOne = [];
var i = 0;
while(i < numbersOne.length) {
    if(prim(numbersOne[i])) {
        newNumbersOne.push(numbersOne[i]);
        numbersOne.splice(i, 1);
    }
    else {
        i++;
    }
}
console.log("===================================5================================");
console.log("Primul element inserat este " + newNumbersOne.slice(0, 1) + ", iar ultimul este " + newNumbersOne.slice(newNumbersOne.length - 1) + ".");

// Exemplu 3: Se da un array, se doreste sa se sterga primele 3 elemente, apoi sa se adauge in locul lor tot acele elemente, insa inversate.
var ceva = [10, 11, 12, 45, 67, 89, 34];

function invers(number) {
    var copy = 0;
    while(number > 0) {
        copy = copy * 10 + number % 10;
        number = Math.floor(number / 10);
    }
    return copy;
}

var backup = [];
for(var i = 0; i < 3; i++) {
   backup.push(invers(ceva.shift()));
}

for(var i = 0; i < 3; i++) {
    ceva.unshift(backup.pop());
}

console.log("===================================6================================");
console.log("Sirul este: " + ceva);
console.log("================================THE END=============================");