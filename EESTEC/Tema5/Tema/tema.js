// Bălan Mihai

window.onload = function() {
    let eroare = document.querySelector('p[class = "eroare"]');
    let fileds = document.querySelectorAll('input[id = "text-box"]');
    let textarea = document.querySelector('textarea');
    let checkBox = document.querySelector('input[class = "box"]');
    let button = document.querySelector('input[type = button]');
    let isOk = true;
    
    document.addEventListener('click', function() {
        cehckFunction(fileds, eroare, textarea, checkBox, isOk);
        isOk = true;
        button.addEventListener('click', function() {
            if(checkFields(fileds, textarea, checkBox)) {
                isOk = false;
                submitAndResetFunction(fileds, textarea, checkBox);
            }
        });

        window.addEventListener('keydown', function(event) {
            if(event.key === 'Enter') {
                if(checkFields(fileds, textarea, checkBox)) {
                    button.classList.add('active-button');
                    isOk = false;
                    submitAndResetFunction(fileds, textarea, checkBox);
                }
            }
        });

        window.addEventListener('keyup', function(event) {
            if(event.key === 'Enter') {
                button.classList.remove('active-button');
            }
        })
    });
   
}

//  -> Functie ce verifica daca cumva exista vreun camp liber sau casuta nebifata.
//  -> Adauga borduri roisii si mesaje de eroare doar daca dupa ce am apasat butonul de "Deus vult!"  mai apasam inca un clic oriunde.
// fields -> campurile
// eroare -> mesajul de eroare ce va fii afisat
// textarea -> campul mare de jos
// checkBox -> casuta de bifat
// isOk -> variabila ce indica daca a fost sau nu apasat butonul
function cehckFunction(fileds, eroare, textarea, checkBox, isOk) {
    if(isOk) {
        let ok = true;
        for(let i = 0; i < fileds.length; i++) {
            if(fileds[i].value == '' || fileds[i].value == null) {
                fileds[i].classList.add('red-border');
                eroare.innerHTML = "Please fill in all the fields";
                ok = false;
            }
            else {
                fileds[i].classList.remove('red-border');
            }
        }
        if(textarea.value == '' || textarea.value == null) {
            textarea.classList.add('red-border');
            eroare.innerHTML = "Please fill in all the fields";
            ok = false;
        }
        else {
            textarea.classList.remove('red-border');
        }
        if(ok) {
            eroare.innerHTML = '';
            if(checkBox.checked == false) {
                eroare.innerHTML = 'Please verifiy that you are not a robot';
            }
            else {
                eroare.innerHTML = '';
            }
        }
    }
}   

// -> Functia verifica daca campurile obligatorii sunt sau nu completate
// -> returneaza false daca cel putin unul din campuri sau casuta nu respecta conditia, si true in sens contrar
// fields -> campurile
// textarea -> campul mare de jos
// checkBox -> casuta de bifat
function checkFields(fileds, textarea, checkBox) {
    for(let i = 0; i < fileds.length; i++) {
        if(fileds[i].value == '' || fileds[i].value == null) {
            return false;
        }
    }
    if(textarea.value == '' || textarea.value == null) {
        return false;
    }
    else {
        if(checkBox.checked == false) {
            return false;
        }
    }
    return true;
}

// -> Functia ce creaza un obiect cu valorile din campurile respective
// -> Reseteaza toate campurile
// fields -> campurile
// textarea -> campul mare de jos
// checkBox -> casuta de bifat
function submitAndResetFunction(fileds, textarea, checkBox) {
    let obj = {
        firstName: fileds[0].value,
        latinName: fileds[1].value,
        lastName: fileds[2].value,
        creed: fileds[3].value,
        deusVult: textarea.value
    }

    console.log(obj);
    for(let i = 0; i < fileds.length; i++) {
        fileds[i].value = '';
    }
    textarea.value = '';
    checkBox.checked = false;
}