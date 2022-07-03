// Bălan Mihai
window.onload = function() {
    let celes = document.querySelectorAll('div[id = "tile"]');
    let winner = document.querySelector('p[id = "winner"]');
    let turn = document.querySelector('p[id = "turn"]');
    let Matrix = [];
    let moves = 0;
    let ok = false;

        initializareMatrice(Matrix, winner, turn);

        for(let i = 0; i < celes.length; i++) {
            // se prcurge fiecare celula
            celes[i].addEventListener('click', function() {
                if(Matrix[Math.floor(i / 3)][i % 3] == null && !ok) {
                    if(moves % 2 == 0) {
                        // daca valoarea lui moves e un numar par, stim sa punem O in patrat, repetiv 0 in matrice
                        // se schimba si titlul
                        celes[i].innerHTML = "O";
                        turn.innerHTML = "X's turn";
                        Matrix[Math.floor(i / 3)][i % 3] = 0;
                        if(endGame(celes, Matrix)) {
                            // daca am gasit o linie/coloana/diagonala atunci desemnam castigatorul, iar moves = -1 pentru ca la finalul if-ului avem moves++, astfel moves va avea la urmatorul eveniment valoarea 0, adica tot timpul va incepe O.
                            isWinner(winner, moves, turn);
                            moves = -1;
                            ok = true;
                        }
                        else if(moves == 8) {
                            moves = -1;
                            // ok ne spune daca jocul s-a terminat
                            ok = true;
                            isDraw(winner, turn);
                        }

                    }
                    else {
                        // moves are valoare impara => X in casuta si 1 in matrice
                        // respectiv se schimba titlul 
                        celes[i].innerHTML = "X";
                        turn.innerHTML = "O's turn";
                        Matrix[Math.floor(i / 3)][i % 3] = 1;
                        if(endGame(celes, Matrix)) {
                            isWinner(winner, moves, turn);
                            moves = -1;
                            ok = true;
                        }
                        else if(moves == 8) {
                            // daca cumva numarul de miscari este 8 nu a fost castigat meciul de X sau O, atunci inseamana ca este remiza
                            moves = -1;
                            ok = true;
                            isDraw(winner, turn);
                        }
                    } 
                    moves++;
                }
                else if(ok) {
                    // daca ok este true, inseamana ca meciul s a temrinat si este timpul sa resetam toate casutele, titlurile, cat si matricea
                    ok = false;
                    initializareMatrice(Matrix, winner, turn);
                    for(let i = 0; i < celes.length; i++) {
                        celes[i].innerHTML = "";
                        celes[i].style.backgroundColor = "gainsboro";
                    }
                }

            });
        }
}

// -> Functie ce verifica daca este remiza, afisand mesajele corespunzataore
// winner -> mesajul ce apare in partea de jos a jocului
// turn -> mesasjul din partea de sus a jocului
function isDraw(winner, turn) {
    winner.innerHTML = "Draw";
    turn.innerHTML = "Click a tile to reset.";
}

// -> Functie ce initializeaza matricea ce retine valorile pentru fiecare "patrat": null -> gol; 1 -> X; 0 -> O
// Marix -> matricea corespunzatoare valorilor fiecarui "patrat"
// winner -> mesajul ce apare in partea de jos a jocului
// turn -> mesasjul din partea de sus a jocului
function initializareMatrice(Matrix, winner, turn) {
    for(let i = 0; i < 3; i++) {
        Matrix[i] = [];
        for(let j = 0; j < 3; j++) {
            Matrix[i][j] = null;
        }
    }
    turn.innerHTML = "O's turn";
    winner.innerHTML = "";
}

// Functie ce returneaza true daca jocul s a incheiat
// Marix -> matricea corespunzatoare valorilor fiecarui "patrat"
// celes -> "patratele"
function endGame(celes, Matrix) {
    
    for(let i = 0; i < 3; i++) {
        switch(i) {
            case 0: {
                if(checkRows(Matrix, celes)) {
                    return true;
                }
                break;
            }
            case 1: {
                if(checkColumns(Matrix, celes)) {
                    return true;
                }
                break;
            }
            case 2: {
                if(checkDiagonals(Matrix, celes)) {
                    return true;
                }
                break;
            }
        }
    }
}

// Functia ce verifica daca cumva exista o linie ce contine numai "1" sau numai "0"
// Daca se intampla asta, se va apelea funtia colorCeles
// Marix -> matricea corespunzatoare valorilor fiecarui "patrat"
// celes -> "patratele"
function checkRows(Matrix, celes) {
    for(let i = 0; i < 3; i++) {
        let ok = true;
        for(let j = 0; j < 3; j++) {
            if(Matrix[i][j] != 0) {
                ok = false;
                break;
            }
        }
        if(ok) {
            colorCeles(0, celes, i);
            return true;
        }

        ok = true;
        for(let j = 0; j < 3; j++) {
            if(Matrix[i][j] != 1) {
                ok = false;
                break;
            }
        }
        if(ok) {
            colorCeles(0, celes, i);
            return true;
        }
            
    }
}

// Functia ce verifica daca cumva exista o coloana ce contine numai "1" sau numai "0"
// Daca se intampla asta, se va apelea funtia colorCeles
// Marix -> matricea corespunzatoare valorilor fiecarui "patrat"
// celes -> "patratele"
function checkColumns(Matrix, celes) {
    for(let j = 0; j < 3; j++) {
        let ok = true;
        for(let i = 0; i < 3; i++) {
            if(Matrix[i][j] != 0) {
                ok = false;
                break;
            }
        }
        if(ok) {
            colorCeles(1, celes, j);
            return true;
        }

        ok = true;
        for(let i = 0; i < 3; i++) {
            if(Matrix[i][j] != 1) {
                ok = false;
                break;
            }
        }
        if(ok) {
            colorCeles(1, celes, j);
            return true;
        }
    }
}

// Functia ce verifica daca pe diagonala principala sau secundara se afla numai "1" sau "0"
// Daca se intampla asta, se va apelea funtia colorCeles
// Marix -> matricea corespunzatoare valorilor fiecarui "patrat"
// celes -> "patratele"
function checkDiagonals(Matrix, celes) {
    let ok = true;
    for(let i = 0; i < 3; i++) {
        if(Matrix[i][i] != 0) {
            ok = false;
            break;
        }
    }
    if(ok) {
        colorCeles(2, celes, 0);
        return true;
    }

    ok = true;
    for(let i = 0; i < 3; i++) {
        if(Matrix[i][i] != 1) {
            ok = false;
            break;
        }
    }
    if(ok) {
        colorCeles(2, celes, 0);
        return true;
    }

    ok = true;
    for(let i = 0; i < 3; i++) {
        if(Matrix[i][3 - i - 1] != 0) {
            ok = false;
            break;
        }
    }
    if(ok) {
        colorCeles(2, celes, 1);
        return true;
    }

    ok = true;
    for(let i = 0; i < 3; i++) {
        if(Matrix[i][3 - i - 1] != 1) {
            ok = false;
            break;
        }
    }
    if(ok) {
        colorCeles(2, celes, 1);
        return true;
    }
}

// In functie de parametrii, se modifica backgroundColor pentru 3 celule in culoarea rosie
// type -> coloreaza 0 -> o linie, 1-> o coloana, 2 -> o diagonala
// celes -> "patratele"
// poz -> pentru type = 0 sau 1, numarul liniei, respectiv coloanei, iar pentru type = 2, 0 -> diagonala principala, 1 -> diagonala secundara.
function colorCeles(type, celes, poz) {
        switch(type) {
            case 0: {
                // coloram o linie
                switch(poz) {
                    case 0: {
                        //prima linie
                        celes[0].style.backgroundColor = "red";
                        celes[1].style.backgroundColor = "red";
                        celes[2].style.backgroundColor = "red";
                        break;
                    }
                    case 1: {
                        // a doua linie
                        celes[3].style.backgroundColor = "red";
                        celes[4].style.backgroundColor = "red";
                        celes[5].style.backgroundColor = "red";
                        break;
                    }
                    case 2: {
                        // a treia linie
                        celes[6].style.backgroundColor = "red";
                        celes[7].style.backgroundColor = "red";
                        celes[8].style.backgroundColor = "red";
                        break;
                    }
                }
                break
            }

            case 1: {
                // coloram o coloana
                switch(poz) {
                    case 0: {
                        // prima coloana
                        celes[0].style.backgroundColor = "red";
                        celes[3].style.backgroundColor = "red";
                        celes[6].style.backgroundColor = "red";
                        break;
                    }
                    case 1: {
                        // a doua coloana
                        celes[1].style.backgroundColor = "red";
                        celes[4].style.backgroundColor = "red";
                        celes[7].style.backgroundColor = "red";
                        break;
                    }
                    case 2: {
                        // a treia coloana
                        celes[2].style.backgroundColor = "red";
                        celes[5].style.backgroundColor = "red";
                        celes[8].style.backgroundColor = "red";
                        break;
                    }
                }
                break
            }

            case 2: {
                // coloram o diagonala
                switch(poz) {
                    case 0: {
                        // diagonala principala
                        celes[0].style.backgroundColor = "red";
                        celes[4].style.backgroundColor = "red";
                        celes[8].style.backgroundColor = "red";
                        break;
                    }
                    case 1: {
                        // diagoanala secundara
                        celes[2].style.backgroundColor = "red";
                        celes[4].style.backgroundColor = "red";
                        celes[6].style.backgroundColor = "red";
                        break;
                    }
                }
                break;
            }
        }
            
}

// Functie ce seteaza titlul si cione este catigatorul in functie de ultima miscare
// winner -> mesajul ce apare in partea de jos a jocului
// moves -> variabila ce se incrementeaza in program si care in functie de paritate decide cine e castigatorul.
// turn -> mesasjul din partea de sus a jocului
function isWinner(winner, moves, turn) {
    if(moves % 2 == 0) {
        winner.innerHTML = "O is the winner";
    }
    else {
        winner.innerHTML = "X is the winner";
    }
    turn.innerHTML = "Click a tile to reset.";
}