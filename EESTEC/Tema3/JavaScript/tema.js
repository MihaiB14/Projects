// Balan Mihai 
//---------------------------------------Datele persoanelor care merg in excursie-----------------------------------------// 
var person1 = {
    numeComplet: 'Balan Mihai',
    varsta: 21,
    sex: 'M',
    serieSiNumarBuletin: 'PX 123876',
    CNP: 5000914564333,
    bugetPersonal: 500,
    numarBeri: 0,
    numarPacheteTigari: 0,
    stareEbrietate: false
}

var person2 = {
    numeComplet: 'Vasile Ana-Maria',
    varsta: 20,
    sex: 'F',
    serieSiNumarBuletin: 'XZ 345678',
    CNP: 611122567345,
    bugetPersonal: 600,
    numarBeri: 0,
    numarPacheteTigari: 0,
    stareEbrietate: false
}

var person3 = {
    numeComplet: 'Dobre Vasile',
    varsta: 19,
    sex: 'M',
    serieSiNumarBuletin: 'PX 987534',
    CNP: 50112453555,
    bugetPersonal: 700,
    numarBeri: 0,
    numarPacheteTigari: 0,
    stareEbrietate: false
}

var person4 = {
    numeComplet: 'Dorel Nicu',
    varsta: 17,
    sex: 'M',
    serieSiNumarBuletin: 'PX 999876',
    CNP: 50423444678,
    bugetPersonal: 550,
    numarBeri: 0,
    numarPacheteTigari: 0,
    stareEbrietate: false
}
//------------------------------------------------Lista cu datele fiecarei persoane--------------------------------------------//
var list = [person1, person2, person3, person4];

//------------------------------------------------Functii destinate unei persoane---------------------------------------------//
function cumparatTigari(person) {
    if(person.varsta > 17 && person.bugetPersonal > 18) {
        person.bugetPersonal -= 19
        person.numarPacheteTigari++
    } 
    else {
        console.log('Baiatul/fata e minora sau nu are bani de ajuns pentru a cumpara un pachet de tigari.')
    }
}

function cumparatBere(person) {
    if(person.bugetPersonal > 6) {
        person.bugetPersonal -= 7
        person.numarBeri ++
    }
    else {
        console.log('Persoana nu are destui bani pentru a cumpara un pet de Timisoreana.')
    }
    
    if(person.numarBeri > 16) {
        person.stareEbrietate = true
    }
}

function cnpSiSerieValide(person) {
    if(!person.CNP || !person.serieSiNumarBuletin) {
        console.log('Persoana nu are CNP valid sau serie buletin valida!')
        person = {...person, bugetPersonal: person.bugetPersonal - 50}
    }
    else {
        console.log('Totul este in ordine.')
    }
}

//----------------------------------------------Functii ce prelucreaza lista-----------------------------------------------------//
function beriSiTigari(list) {
    var numarBeriPrestabilit = 14
    var costBeri = 14*7
    var nuamrTigariPrestabilit = 14
    var costTigari = 14*19
    for(var i = 0; i < list.length; i++) {
         list[i] = {...list[i], numarBeri: numarBeriPrestabilit, numarPacheteTigari: nuamrTigariPrestabilit}
    }
}

function sumaTotala(list) {
    var suma = 0
    for(var i = 0; i < list.length; i++) {
        suma += list[i].bugetPersonal
    }
    console.log('Suma totala ramasa este ' + suma + ' lei.\nMai puteam cumpara ' + Math.floor(suma/19) + ' pachete de tigari sau ' + Math.floor(suma/7) + ' peturi de Timisoreana.')
}

function persoaneInStareDeEbrietate(list) {
    var numar = 0
    for(var i = 0; i < list.length; i++) {
        if(list[i].stareEbrietate == true) {
            numar ++
        }
    }
    console.log(numar + ' persoane in stare de ebrietate.')
}

//-------------------------------------------------------Teste facute-----------------------------------------------------//
/*
cumparatTigari(person1)
console.log(person1)

cumparatBere(person2)
console.log(person2)

cnpSiSerieValide(person3)
cnpSiSerieValide(list[2])

beriSiTigari(list)
console.log(list)

sumaTotala(list)

persoaneInStareDeEbrietate(list)
*/