//console.log("Hello ma!");

/*
var truthyOrFalsy;

if(truthyOrFalsy) {
    console.log(truthyOrFalsy + ' is truthy');
}
else {
    console.log(truthyOrFalsy + ' is falsy');
}

if(null == undefined) {
    console.log('A');
}

*/

window.onload = function() {
    //var square = document.getElementById('yellow');
    //console.log(square);
    //square.style.width = "400px";
    //var squares = document.getElementsByClassName('square blue');
    //console.log(squares);

    //var squaresByQuery = document.querySelectorAll('.square.red');
    //console.log(squaresByQuery);
    var submitButton = document.getElementById('submit-button');
    submitButton.addEventListener('click', function(event) {
        //console.log(event);
        var firstName = document.querySelector('input[placeholder = "First Name"]');
        var lastName = document.querySelector('input[placeholder = "Second Name"]');
        console.log(firstName.value + ' ' + lastName.value);
        //console.log(`${firstName.value} ${lastName.value}`);
        
        
    })

    window.addEventListener('keydown', function(event) {
        console.log(event.key);
        if(event.key === "Enter") {
            fullNameCreation();
            submitButton.classList.add('active-button')
        }
    })

    window.addEventListener('keyup', function(event) {
        //console.log(event.key);
        if(event.key === "Enter") {
            submitButton.classList.remove('active-button');
        }
    })

    // var square = document.getElementsByClassName('square blue')[0];
    // console.log(square);
    // square.innerHTML = "<div style = 'font-size: 30px; color: white;'> inner div</div>";
}

function fullNameCreation() {
    var firstName = document.querySelector('input[placeholder = "First Name"]');
    var lastName = document.querySelector('input[placeholder = "Second Name"]');
        //console.log(firstName.value + ' ' + lastName.value);
    console.log(`${firstName.value} ${lastName.value}`);
}
